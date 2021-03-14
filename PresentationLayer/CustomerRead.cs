using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataLayer;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace PresentationLayer
{
    public partial class CustomerRead : Form
    {
        CustomerDataContext ctx = new CustomerDataContext();


        public CustomerRead()
        {
            InitializeComponent();

        }
        private void CustomerRead_Load(object sender, EventArgs e)
        {
            getData();
        }
        public void getData()
        {

            var c = (from Customer in ctx.Customers
                     join Address in ctx.Addresses on Customer.CustomerId equals Address.CustomerId
                     select new
                     {
                         CustomerID = Customer.CustomerId,
                         Firstname = Customer.Firstname,
                         Lastname = Customer.Lastname,
                         AddressID = Address.AddressId,
                         Street = Address.Street,
                         City = Address.City,
                         State = Address.State,
                         Zip = Address.Zip
                     })
                     .ToList();
            //long select to put into grid from both tables at once
            customergrid.DataSource = c;


        }

        private void customergrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow drow = customergrid.CurrentRow;
            try
            {
                string cell = customergrid.CurrentCell.OwningColumn.Name;
                if (drow == null)
                {
                    //skip
                }
                else if (cell == "Lastname" || cell == "Firstname")
                {
                    //open customer name edit form
                    //use stored proc
                    var customerform = new CustomerEdit(drow, ctx);
                    customerform.Show();
                }
                else
                {
                    //open address edit form
                    //use built in EF functions                    
                    var addressform = new AddressEdit(drow, ctx);
                    addressform.Show();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

    }
}

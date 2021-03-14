using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataLayer;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace PresentationLayer
{
    public partial class CustomerEdit : Form
    {
        CustomerDataContext ctx;
        DataGridViewRow drow;
        public CustomerEdit(DataGridViewRow row, CustomerDataContext context)
        {
            InitializeComponent();
            ctx = context;
            drow = row;
        }

        private void CustomerEdit_Load(object sender, EventArgs e)
        {
            firstnametxt.Text = drow.Cells["Firstname"].Value.ToString().Trim();
            lastnametxt.Text = drow.Cells["Lastname"].Value.ToString().Trim();
            streettxt.Text = drow.Cells["Street"].Value.ToString().Trim();
            citytxt.Text = drow.Cells["City"].Value.ToString().Trim();
            statetxt.Text = drow.Cells["State"].Value.ToString().Trim();
            ziptxt.Text = drow.Cells["Zip"].Value.ToString().Trim();
            
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlParameter name = new SqlParameter("Firstname", firstnametxt.Text);
                SqlParameter id = new SqlParameter("CustomerID", Convert.ToInt32(drow.Cells["CustomerID"].Value));

                ctx.Database.ExecuteSqlRaw("EXECUTE updateCustomers @Firstname, @CustomerID", name, id);
                //execute stored proc
                ctx.SaveChanges();
                System.Windows.Forms.Application.OpenForms.OfType<CustomerRead>().FirstOrDefault().getData();
                //refreshes main form
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
}
    }
}

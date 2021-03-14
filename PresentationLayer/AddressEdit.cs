using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataLayer;
using System.Linq;

namespace PresentationLayer
{
    public partial class AddressEdit : Form
    {
        CustomerDataContext ctx;
        DataGridViewRow drow;
        public AddressEdit(DataGridViewRow row, CustomerDataContext context)
        {
            InitializeComponent();
            ctx = context;
            drow = row;           
        }

        private void AddressEdit_Load(object sender, EventArgs e)
        {
            firstnametxt.Text = drow.Cells["Firstname"].Value.ToString().Trim();
            lastnametxt.Text = drow.Cells["Lastname"].Value.ToString().Trim();
            streettxt.Text = drow.Cells["Street"].Value.ToString().Trim();
            citytxt.Text = drow.Cells["City"].Value.ToString().Trim();
            statetxt.Text = drow.Cells["State"].Value.ToString().Trim();
            ziptxt.Text = drow.Cells["Zip"].Value.ToString().Trim();
            //fill with selected row's values

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                var update = ctx.Addresses.Find(drow.Cells["AddressID"].Value);
                update.Street = streettxt.Text;
                update.City = citytxt.Text;
                update.State = statetxt.Text;
                update.Zip = ziptxt.Text;
                ctx.Entry(update).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                //update any changes made
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

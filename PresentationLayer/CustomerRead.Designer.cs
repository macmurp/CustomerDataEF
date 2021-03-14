
namespace PresentationLayer
{
    partial class CustomerRead
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customergrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customergrid)).BeginInit();
            this.SuspendLayout();
            // 
            // customergrid
            // 
            this.customergrid.AllowUserToAddRows = false;
            this.customergrid.AllowUserToDeleteRows = false;
            this.customergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customergrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.Firstname,
            this.Lastname,
            this.AddressID,
            this.Street,
            this.City,
            this.State,
            this.Zip});
            this.customergrid.Location = new System.Drawing.Point(12, 12);
            this.customergrid.Name = "customergrid";
            this.customergrid.ReadOnly = true;
            this.customergrid.RowHeadersWidth = 82;
            this.customergrid.RowTemplate.Height = 41;
            this.customergrid.Size = new System.Drawing.Size(1458, 808);
            this.customergrid.TabIndex = 0;
            this.customergrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customergrid_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 855);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(720, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Double click a cell to edit either the Customer or Address portions";
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.MinimumWidth = 10;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Visible = false;
            this.CustomerID.Width = 200;
            // 
            // Firstname
            // 
            this.Firstname.DataPropertyName = "Firstname";
            this.Firstname.HeaderText = "First Name";
            this.Firstname.MinimumWidth = 10;
            this.Firstname.Name = "Firstname";
            this.Firstname.ReadOnly = true;
            this.Firstname.Width = 200;
            // 
            // Lastname
            // 
            this.Lastname.DataPropertyName = "Lastname";
            this.Lastname.HeaderText = "Last Name";
            this.Lastname.MinimumWidth = 10;
            this.Lastname.Name = "Lastname";
            this.Lastname.ReadOnly = true;
            this.Lastname.Width = 200;
            // 
            // AddressID
            // 
            this.AddressID.DataPropertyName = "AddressID";
            this.AddressID.HeaderText = "AddressID";
            this.AddressID.MinimumWidth = 10;
            this.AddressID.Name = "AddressID";
            this.AddressID.ReadOnly = true;
            this.AddressID.Visible = false;
            this.AddressID.Width = 200;
            // 
            // Street
            // 
            this.Street.DataPropertyName = "Street";
            this.Street.HeaderText = "Street";
            this.Street.MinimumWidth = 10;
            this.Street.Name = "Street";
            this.Street.ReadOnly = true;
            this.Street.Width = 200;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.MinimumWidth = 10;
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Width = 200;
            // 
            // State
            // 
            this.State.DataPropertyName = "State";
            this.State.HeaderText = "State";
            this.State.MinimumWidth = 10;
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Width = 200;
            // 
            // Zip
            // 
            this.Zip.DataPropertyName = "Zip";
            this.Zip.HeaderText = "Zip";
            this.Zip.MinimumWidth = 10;
            this.Zip.Name = "Zip";
            this.Zip.ReadOnly = true;
            this.Zip.Width = 200;
            // 
            // CustomerRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 924);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customergrid);
            this.Name = "CustomerRead";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CustomerRead_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customergrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customergrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Street;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zip;
    }
}


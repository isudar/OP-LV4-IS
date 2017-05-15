namespace OP_LV4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DGWTablica = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCustomers = new System.Windows.Forms.ComboBox();
            this.cbEmployees = new System.Windows.Forms.ComboBox();
            this.cbShippers = new System.Windows.Forms.ComboBox();
            this.northwindDataSet = new OP_LV4.NorthwindDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new OP_LV4.NorthwindDataSetTableAdapters.CustomersTableAdapter();
            this.shippersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shippersTableAdapter = new OP_LV4.NorthwindDataSetTableAdapters.ShippersTableAdapter();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new OP_LV4.NorthwindDataSetTableAdapters.EmployeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DGWTablica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DGWTablica
            // 
            this.DGWTablica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGWTablica.Location = new System.Drawing.Point(41, 15);
            this.DGWTablica.Name = "DGWTablica";
            this.DGWTablica.Size = new System.Drawing.Size(959, 311);
            this.DGWTablica.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Employees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Shippers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Customers";
            // 
            // cbCustomers
            // 
            this.cbCustomers.DataSource = this.customersBindingSource;
            this.cbCustomers.DisplayMember = "CompanyName";
            this.cbCustomers.FormattingEnabled = true;
            this.cbCustomers.Location = new System.Drawing.Point(306, 345);
            this.cbCustomers.Name = "cbCustomers";
            this.cbCustomers.Size = new System.Drawing.Size(121, 21);
            this.cbCustomers.TabIndex = 9;
            this.cbCustomers.ValueMember = "CustomerID";
            this.cbCustomers.SelectedIndexChanged += new System.EventHandler(this.cbCustomers_SelectedIndexChanged);
            // 
            // cbEmployees
            // 
            this.cbEmployees.DataSource = this.employeesBindingSource;
            this.cbEmployees.DisplayMember = "LastName";
            this.cbEmployees.FormattingEnabled = true;
            this.cbEmployees.Location = new System.Drawing.Point(306, 425);
            this.cbEmployees.Name = "cbEmployees";
            this.cbEmployees.Size = new System.Drawing.Size(121, 21);
            this.cbEmployees.TabIndex = 8;
            this.cbEmployees.ValueMember = "EmployeeID";
            this.cbEmployees.SelectedIndexChanged += new System.EventHandler(this.cbEmployees_SelectedIndexChanged);
            // 
            // cbShippers
            // 
            this.cbShippers.DataSource = this.shippersBindingSource;
            this.cbShippers.DisplayMember = "CompanyName";
            this.cbShippers.FormattingEnabled = true;
            this.cbShippers.Location = new System.Drawing.Point(306, 385);
            this.cbShippers.Name = "cbShippers";
            this.cbShippers.Size = new System.Drawing.Size(121, 21);
            this.cbShippers.TabIndex = 7;
            this.cbShippers.ValueMember = "ShipperID";
            this.cbShippers.SelectedIndexChanged += new System.EventHandler(this.cbShippers_SelectedIndexChanged);
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.northwindDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // shippersBindingSource
            // 
            this.shippersBindingSource.DataMember = "Shippers";
            this.shippersBindingSource.DataSource = this.northwindDataSet;
            // 
            // shippersTableAdapter
            // 
            this.shippersTableAdapter.ClearBeforeFill = true;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.northwindDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 466);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCustomers);
            this.Controls.Add(this.cbEmployees);
            this.Controls.Add(this.cbShippers);
            this.Controls.Add(this.DGWTablica);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGWTablica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGWTablica;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCustomers;
        private System.Windows.Forms.ComboBox cbEmployees;
        private System.Windows.Forms.ComboBox cbShippers;
        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource shippersBindingSource;
        private NorthwindDataSetTableAdapters.ShippersTableAdapter shippersTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private NorthwindDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
    }
}


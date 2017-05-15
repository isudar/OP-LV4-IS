using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OP_LV4
{
    public partial class Form1 : Form
    {
        OleDbConnection myConnection;
        OleDbDataAdapter myOleDbDataAdapter;

        String customerIndex;
        int shipperIndex, employeesIndex;

        BindingSource bsOrders = new BindingSource();

        private const string myConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Sudo\Downloads\Northwind.MDB";
        public Form1()
        {
            InitializeComponent();
        }

        private void cbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            customerIndex = cbCustomers.SelectedValue.ToString();
            Refresh();
        }

        private void cbShippers_SelectedIndexChanged(object sender, EventArgs e)
        {
            shipperIndex = cbShippers.SelectedIndex + 1;
            Refresh();
        }

        private void cbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            employeesIndex = cbEmployees.SelectedIndex + 1;
            Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.northwindDataSet.Employees);
            // TODO: This line of code loads data into the 'northwindDataSet.Shippers' table. You can move, or remove it, as needed.
            this.shippersTableAdapter.Fill(this.northwindDataSet.Shippers);
            // TODO: This line of code loads data into the 'northwindDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);

            DGWTablica.DataSource = bsOrders;
            customerIndex = cbCustomers.SelectedValue.ToString();
            shipperIndex = cbShippers.SelectedIndex + 1;
            employeesIndex = cbEmployees.SelectedIndex + 1;
        }

        private void Refresh()
        {
            using (myConnection = new OleDbConnection(myConnectionString))
            {
                myConnection.Open();

                using (myOleDbDataAdapter = new OleDbDataAdapter())
                {
                    DataSet dataSet = new DataSet();

                    myOleDbDataAdapter.SelectCommand = new OleDbCommand("SELECT * FROM Orders WHERE CustomerID='" + customerIndex + "' AND EmployeeID=" + employeesIndex + " AND ShipVia=" + shipperIndex, myConnection);
                    myOleDbDataAdapter.Fill(dataSet, "Orders");
                    bsOrders.DataSource = dataSet;
                    bsOrders.DataMember = "Orders";


                    myConnection.Close();

                }

            }
        }
    }
}

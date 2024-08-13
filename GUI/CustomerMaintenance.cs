using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Hi_TechDistributionInc.BLL;
using Hi_TechDistributionInc.DAL;
using Hi_TechDistributionInc.Validation;
namespace Hi_TechDistributionInc.GUI
{
    public partial class CustomerMaintenance : Form
    {
        SqlDataAdapter da;
        DataSet dsHiTechDB;
        DataTable dtCustomers;
        SqlCommandBuilder sqlBuilder;
        public CustomerMaintenance()
        {
            InitializeComponent();
        }

        private void CustomerMaintenance_Load(object sender, EventArgs e)
        {
            dsHiTechDB = new DataSet();
            dtCustomers = new DataTable("Customers");
            dtCustomers.Columns.Add("CustomerID", typeof(Int32));
            dtCustomers.PrimaryKey = new DataColumn[] { dtCustomers.Columns["CustomerID"] };
            dtCustomers.Columns["CustomerID"].AutoIncrement = true;
            dtCustomers.Columns["CustomerID"].AutoIncrementSeed = 1111111;
            dtCustomers.Columns["CustomerID"].AutoIncrementStep = 1;
            dtCustomers.Columns.Add("CustomerName", typeof(string));
            dtCustomers.Columns.Add("StreetAddress", typeof(string));
            dtCustomers.Columns.Add("City", typeof(string));
            dtCustomers.Columns.Add("PostalCode", typeof(string));
            dtCustomers.Columns.Add("PhoneNumber", typeof(string));
            dtCustomers.Columns.Add("FaxNumber", typeof(string));
            dtCustomers.Columns.Add("CreditLimit", typeof(string));
            dtCustomers.Columns.Add("Email", typeof(string));
            dsHiTechDB.Tables.Add(dtCustomers);

            da = new SqlDataAdapter("SELECT * FROM Customers", UtilityDB.ConnectDB());
            sqlBuilder = new SqlCommandBuilder(da);
        }

        private void buttonSaveEmployee_Click(object sender, EventArgs e)
        {
            DataRow dr = dtCustomers.NewRow();
            string input = textBoxCustomerId.Text.Trim();
            
            //Check name
            input = "";
            input = textBoxCustomerName.Text.Trim();
            if (!Validator.IsValidName(input))
            {
                MessageBox.Show("Firstname contains only letters and space" +
                    " to separate first name components.",
                                "Invalid FirstName",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCustomerName.Clear();
                textBoxCustomerName.Focus();
                return;
            }

            dr["CustomerName"] = textBoxCustomerName.Text.Trim();
            dr["StreetAddress"] = textBoxStreetAddress.Text.Trim();
            dr["City"] = textBoxCity.Text.Trim();
            dr["PostalCode"] = maskedTextBoxPostalCode.Text.Trim();
            dr["PhoneNumber"] = maskedTextBoxPhoneNumber.Text.Trim();
            dr["FaxNumber"] = maskedTextBoxFaxNumber.Text.Trim();
            dr["CreditLimit"] = textBoxCreditLimit.Text.Trim();
            dr["Email"] = textBoxEmail.Text.Trim();

            //add the row to the datatable
            dtCustomers.Rows.Add(dr);
            MessageBox.Show(dr.RowState.ToString());
        }

        private void buttonUpdateDatabase_Click(object sender, EventArgs e)
        {
            da.Update(dsHiTechDB.Tables["Customers"]);
            MessageBox.Show("Database Updated", "Database Updated");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int searchId = Convert.ToInt32(textBoxCustomerId.Text);
            DialogResult ans = MessageBox.Show("Are you sure you want to delete this Student?", "Confirm",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ans == DialogResult.Yes)
            {
                if (textBoxCustomerId != null)
                {
                    DataRow dr = dtCustomers.Rows.Find(searchId);
                    dr.Delete();
                }
                else
                {
                    MessageBox.Show("Student Id is empty!\nPlease enter Student Id.", "No Student Id",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int searchId = Convert.ToInt32(textBoxCustomerId.Text);

            DataRow dr = dtCustomers.Rows.Find(searchId);
            dr["CustomerName"] = textBoxCustomerName.Text.Trim();
            dr["StreetAddress"] = textBoxStreetAddress.Text.Trim();
            dr["City"] = textBoxCity.Text.Trim();
            dr["PostalCode"] = maskedTextBoxPostalCode.Text.Trim();
            dr["PhoneNumber"] = maskedTextBoxPhoneNumber.Text.Trim();
            dr["FaxNumber"] = maskedTextBoxFaxNumber.Text.Trim();
            dr["CreditLimit"] = textBoxCreditLimit.Text.Trim();
            dr["Email"] = textBoxEmail.Text.Trim();
            MessageBox.Show(dr.RowState.ToString());
        }

        private void buttonListCustomerFromDataSet_Click(object sender, EventArgs e)
        {
            da.Fill(dsHiTechDB.Tables["Customers"]);
            dataGridViewListCustomerFromDS.DataSource = dsHiTechDB.Tables["Customers"];
        }

        private void buttonListCustomerFromDB_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            dataGridViewCustomerFromDB.DataSource = c.GetCustomerList();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Do you want to log out?", "Confirmation",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ans == DialogResult.Yes)
            {
                this.Hide();
                new LoginForm().Show();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int searchId = Convert.ToInt32(textBoxSearchID.Text);

            DataRow dr = dtCustomers.Rows.Find(searchId);
            if (Convert.ToInt32(dr["CustomerID"]) == searchId)
            {
                textBoxCustomerId.Text = dr["CustomerID"].ToString();
                textBoxCustomerName.Text = dr["CustomerName"].ToString();
                textBoxStreetAddress.Text = dr["StreetAddress"].ToString();
                textBoxCity.Text = dr["City"].ToString();
                maskedTextBoxPostalCode.Text = dr["PostalCode"].ToString();
                maskedTextBoxPhoneNumber.Text = dr["PhoneNumber"].ToString();
                textBoxCreditLimit.Text = dr["CreditLimit"].ToString();
                maskedTextBoxFaxNumber.Text = dr["FaxNumber"].ToString();
                textBoxEmail.Text = dr["Email"].ToString();
            }
            else
            {
                MessageBox.Show("Student not found!", "Invalid Student Id");
            }
        }

        private void dataGridViewCustomerFromDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxCustomerId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

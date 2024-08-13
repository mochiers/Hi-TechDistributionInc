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
using Hi_TechDistributionInc.EF;

namespace Hi_TechDistributionInc.GUI
{
    public partial class LoginForm : Form
    {
        HiTechDBEntities db = new HiTechDBEntities();
        public static int user_Id;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(textBoxUserId.Text);
            user_Id = userId;
            string pwd = textBoxPassword.Text.Trim();
            //VALIDATING PASSWORD
            var user = (from u in db.UsersAccounts
                        where u.UserID == userId
                        && u.Password == pwd
                        select u).FirstOrDefault();
            if (user != null)
            {
                //SELECTING JOB TITLE FROM JOBPOSITIONS EMPLOYEE TABLE RELATION THROUGH EMPLOYEE ID
                var jobPosition = (from jp in db.JobPositions
                                   join emp in db.Employees
                                   on jp.JobID equals emp.JobID
                                   where emp.EmployeeID == user_Id
                                   select jp.JobTitle).Single();

                if (jobPosition == "MIS Manager")
                {
                    this.Hide();
                    EmployeeMaintenance frm = new EmployeeMaintenance();
                    frm.ShowDialog();
                }
                else if(jobPosition == "Sales Manager")
                {
                    this.Hide();
                    CustomerMaintenance frm = new CustomerMaintenance();
                    frm.ShowDialog();
                }
                else if (jobPosition == "Inventory Controller")
                {
                    this.Hide();
                    InventoryMaintenance frm = new InventoryMaintenance();
                    frm.ShowDialog();
                }
                else if (jobPosition == "Order Clerk")
                {
                    this.Hide();
                    OrderForm frm = new OrderForm();
                    frm.ShowDialog();
                }
                
            }
            else
            {
                MessageBox.Show("Invalid UserId or Password!", "Invalid User");
            }
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Do you want to exit the application?", "Confirmation",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ans == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPassword.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
        }
    }
}

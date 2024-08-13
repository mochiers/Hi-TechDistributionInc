using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hi_TechDistributionInc.DAL;
using Hi_TechDistributionInc.BLL;
using Hi_TechDistributionInc.Validation; //validation
using System.Data.SqlClient; //DB connection

namespace Hi_TechDistributionInc.GUI
{
    public partial class EmployeeMaintenance : Form
    {
        //Global variable
        public static int selectedIndexJob;
        public static int selectedIndexStatus;
        
        public EmployeeMaintenance()
        {
            InitializeComponent();
        }

        //private void buttonConnect_Click(object sender, EventArgs e)
        //{
        // MessageBox.Show("Database Connection is " + UtilityDB.ConnectDB().State.ToString());
        //}

        private void buttonSaveEmployee_Click_1(object sender, EventArgs e)
        {

            //perform input data validation first
            //Check Employee ID (5 digits)
            string input = textBoxEmployeeId.Text.Trim();
            string error = "";
            if (!(Validator.IsValidId(input, 5, ref error)))
            {
                MessageBox.Show(error, "Invalid Employee ID",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmployeeId.Clear();
                textBoxEmployeeId.Focus();
                return;
            }

            Employee emp = new Employee();
            if (emp.IsDuplicateEmpId(Convert.ToInt32(input)))
            {
                MessageBox.Show("This Employee Id already exists!", "Duplicate Employee ID",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmployeeId.Clear();
                textBoxEmployeeId.Focus();
                return;

            }

            //Check first name
            input = "";
            input = textBoxFirstName.Text.Trim();
            if (!Validator.IsValidName(input))
            {
                MessageBox.Show("Firstname contains only letters and space" +
                    " to separate first name components.",
                                "Invalid FirstName",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFirstName.Clear();
                textBoxFirstName.Focus();
                return;
            }
            //Check last name
            input = "";
            input = textBoxLastName.Text.Trim();
            if (!Validator.IsValidName(input))
            {
                MessageBox.Show("Lastname contains only letters and space" +
                    " to separate last name components.",
                                "Invalid LastName",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxLastName.Clear();
                textBoxLastName.Focus();
                return;
            }

            //valid input data
            emp.EmployeeID = Convert.ToInt32(textBoxEmployeeId.Text.Trim());
            emp.FirstName = textBoxFirstName.Text.Trim();
            emp.LastName = textBoxLastName.Text.Trim();
            emp.PhoneNumber = maskedTextBoxPhoneNumber.Text.Trim();
            emp.Email = textBoxEmail.Text.Trim();
            //For combobox saving of JobID 
            int indexSelected = comboBoxJobTitle.SelectedIndex;
            switch (indexSelected)
            {
                case 0:
                    emp.JobID = 11;
                    break;
                case 1:
                    emp.JobID = 12;
                    break;
                case 2:
                    emp.JobID = 13;
                    break;
                case 3:
                    emp.JobID = 14;
                    break;
                case 4:
                    emp.JobID = 15;
                    break;

                default:
                    break;
            }
            //For saving 
            int indexSelected2 = comboBoxStatus.SelectedIndex;
            switch (indexSelected2)
            {
                case 0:
                    emp.StatusID = 1;
                    break;
                case 1:
                    emp.StatusID = 2;
                    break;
                default:
                    break;
            }
            emp.SaveEmployee(emp);
            MessageBox.Show("Employee saved", "Confirmation");
            textBoxEmployeeId.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxEmail.Clear();
            maskedTextBoxPhoneNumber.Clear();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonListAll_Click_1(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            List<Employee> listEmp = emp.GetAllEmployees();
            listViewEmployee.Items.Clear();
            if (listEmp.Count != 0)
            {
                foreach (Employee e_item in listEmp)
                {
                    ListViewItem item = new ListViewItem(e_item.EmployeeID.ToString());
                    item.SubItems.Add(e_item.FirstName);
                    item.SubItems.Add(e_item.LastName);
                    item.SubItems.Add(e_item.PhoneNumber);
                    item.SubItems.Add(e_item.Email);
                    item.SubItems.Add(e_item.JobID.ToString());
                    item.SubItems.Add(e_item.StatusID.ToString());
                    listViewEmployee.Items.Add(item);

                }

            }
            else
            {
                MessageBox.Show("Employee list is empty!\nPlease enter employee data.", "No Employee data",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
        }

        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            
        }

        private void buttonLogout_Click_1(object sender, EventArgs e)
        {
        
        }

        private void comboBoxOption_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int indexSelected = comboBoxOption.SelectedIndex;
            //MessageBox.Show(indexSelected.ToString());
            switch (indexSelected)
            {
                case 0:
                    labelDisplay.Text = "Please enter Employee Id : ";
                    textBoxInput.Clear();
                    textBoxInput.Focus();
                    break;
                case 1:
                    labelDisplay.Text = "Please enter First Name : ";
                    textBoxInput.Clear();
                    textBoxInput.Focus();
                    break;
                case 2:
                    labelDisplay.Text = "Please enter Last Name : ";
                    textBoxInput.Clear();
                    textBoxInput.Focus();
                    break;
                case 3:
                    labelDisplay.Text = "Please enter Job ID : ";
                    textBoxInput.Clear();
                    textBoxInput.Focus();
                    break;
                case 4:
                    labelDisplay.Text = "Please enter Status ID : ";
                    textBoxInput.Clear();
                    textBoxInput.Focus();
                    break;

                default:
                    break;
            }
        }

        private void buttonSearch_Click_1(object sender, EventArgs e)
        {

        }

        private void labelDisplay_Click(object sender, EventArgs e)
        {

        }

        private void buttonListAllEmployee2_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            List<Employee> listEmp = emp.GetAllEmployees();
            listViewEmployee2.Items.Clear();
            if (listEmp.Count != 0)
            {
                foreach (Employee e_item in listEmp)
                {
                    ListViewItem item = new ListViewItem(e_item.EmployeeID.ToString());
                    item.SubItems.Add(e_item.FirstName);
                    item.SubItems.Add(e_item.LastName);
                    item.SubItems.Add(e_item.PhoneNumber);
                    item.SubItems.Add(e_item.Email);
                    item.SubItems.Add(e_item.JobID.ToString());
                    item.SubItems.Add(e_item.StatusID.ToString());
                    listViewEmployee2.Items.Add(item);

                }

            }
            else
            {
                MessageBox.Show("Employee list is empty!\nPlease enter employee data.", "No Employee data",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int option = comboBoxOption.SelectedIndex;
            int searchIndex = comboBoxOption.SelectedIndex;
            switch (searchIndex)
            {
                case 0: //EMPLOYEE ID
                    //perform input data validation first
                    //Check Employee ID (4 digits)
                    string input = textBoxInput.Text.Trim();
                    string error = "";
                    textBoxEmployeeId.Clear();
                    textBoxFirstName.Clear();
                    textBoxLastName.Clear();
                    maskedTextBoxPhoneNumber.Clear();
                    textBoxEmail.Clear();
                    if (!(Validator.IsValidId(input, 5, ref error)))
                    {
                        MessageBox.Show(error, "Invalid Employee ID",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxInput.Clear();
                        textBoxInput.Focus();
                        return;
                    }

                    Employee emp = new Employee();
                    emp = emp.SearchEmployee(Convert.ToInt32(input));
                    if (emp != null)
                    {
                        textBoxEmployeeId.Text = emp.EmployeeID.ToString();
                        textBoxFirstName.Text = emp.FirstName;
                        textBoxLastName.Text = emp.LastName;
                        maskedTextBoxPhoneNumber.Text = emp.PhoneNumber;
                        textBoxEmail.Text = emp.Email;
                        switch (emp.JobID)
                        {
                            case 11:
                                comboBoxJobTitle.SelectedIndex = 0;
                                break;
                            case 12:
                                comboBoxJobTitle.SelectedIndex = 1;
                                break;
                            case 13:
                                comboBoxJobTitle.SelectedIndex = 2;
                                break;
                            case 14:
                                comboBoxJobTitle.SelectedIndex = 3;
                                break;
                            case 15:
                                comboBoxJobTitle.SelectedIndex = 4;
                                break;

                            default:
                                break;
                        }
                        switch (emp.StatusID)
                        {
                            case 1:
                                comboBoxStatus.SelectedIndex = 0;
                                break;
                            case 2:
                                comboBoxStatus.SelectedIndex = 1;
                                break;
                            default:
                                break;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Employee not found!", "Invalid Employee ID",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxInput.Clear();
                        textBoxInput.Focus();
                    }

                    break;

                case 1: //FIRST NAME

                    textBoxEmployeeId.Clear();
                    textBoxFirstName.Clear();
                    textBoxLastName.Clear();
                    maskedTextBoxPhoneNumber.Clear();
                    textBoxEmail.Clear();
                    Employee emp1 = new Employee();
                    List<Employee> listE = emp1.SearchEmployee(textBoxInput.Text.Trim(), searchIndex);
                    if (listE != null)
                    {
                        listViewEmployee.Items.Clear();
                        foreach (Employee empTemp in listE)
                        {
                            ListViewItem item = new ListViewItem(empTemp.EmployeeID.ToString());
                            item.SubItems.Add(empTemp.FirstName);
                            item.SubItems.Add(empTemp.LastName);
                            item.SubItems.Add(empTemp.PhoneNumber);
                            item.SubItems.Add(empTemp.Email);
                            item.SubItems.Add(empTemp.JobID.ToString());
                            item.SubItems.Add(empTemp.StatusID.ToString());
                            listViewEmployee.Items.Add(item);
                        }
                    }

                    break;

                case 2: //LAST NAME

                    textBoxEmployeeId.Clear();
                    textBoxFirstName.Clear();
                    textBoxLastName.Clear();
                    maskedTextBoxPhoneNumber.Clear();
                    textBoxEmail.Clear();
                    Employee emp2 = new Employee();
                    List<Employee> listE2 = emp2.SearchEmployee(textBoxInput.Text.Trim(), searchIndex);
                    if (listE2 != null)
                    {
                        listViewEmployee.Items.Clear();
                        foreach (Employee empTemp in listE2)
                        {
                            ListViewItem item = new ListViewItem(empTemp.EmployeeID.ToString());
                            item.SubItems.Add(empTemp.FirstName);
                            item.SubItems.Add(empTemp.LastName);
                            item.SubItems.Add(empTemp.PhoneNumber);
                            item.SubItems.Add(empTemp.Email);
                            item.SubItems.Add(empTemp.JobID.ToString());
                            item.SubItems.Add(empTemp.StatusID.ToString());
                            listViewEmployee.Items.Add(item);
                        }
                    }

                    break;

                case 3: //JOB ID

                    textBoxEmployeeId.Clear();
                    textBoxFirstName.Clear();
                    textBoxLastName.Clear();
                    maskedTextBoxPhoneNumber.Clear();
                    textBoxEmail.Clear();
                    Employee emp3 = new Employee();
                    List<Employee> listE3 = emp3.SearchEmployee(textBoxInput.Text.Trim(), searchIndex);
                    if (listE3 != null)
                    {
                        listViewEmployee.Items.Clear();
                        foreach (Employee empTemp in listE3)
                        {
                            ListViewItem item = new ListViewItem(empTemp.EmployeeID.ToString());
                            item.SubItems.Add(empTemp.FirstName);
                            item.SubItems.Add(empTemp.LastName);
                            item.SubItems.Add(empTemp.PhoneNumber);
                            item.SubItems.Add(empTemp.Email);
                            item.SubItems.Add(empTemp.JobID.ToString());
                            item.SubItems.Add(empTemp.StatusID.ToString());
                            listViewEmployee.Items.Add(item);
                        }
                    }


                    break;

                case 4: //Status ID

                    textBoxEmployeeId.Clear();
                    textBoxFirstName.Clear();
                    textBoxLastName.Clear();
                    maskedTextBoxPhoneNumber.Clear();
                    textBoxEmail.Clear();
                    //textBoxJobId.Clear();
                    //textBoxStatusId.Clear();
                    Employee emp4 = new Employee();
                    List<Employee> listE4 = emp4.SearchEmployee(textBoxInput.Text.Trim(), searchIndex);
                    if (listE4 != null)
                    {
                        listViewEmployee.Items.Clear();
                        foreach (Employee empTemp in listE4)
                        {
                            ListViewItem item = new ListViewItem(empTemp.EmployeeID.ToString());
                            item.SubItems.Add(empTemp.FirstName);
                            item.SubItems.Add(empTemp.LastName);
                            item.SubItems.Add(empTemp.PhoneNumber);
                            item.SubItems.Add(empTemp.Email);
                            item.SubItems.Add(empTemp.JobID.ToString());
                            item.SubItems.Add(empTemp.StatusID.ToString());
                            listViewEmployee.Items.Add(item);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Employee not found!", "Invalid Employee ID",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxInput.Clear();
                        textBoxInput.Focus();
                    }

                    break;
            }

            //private void buttonListAll_Click(object sender, EventArgs e)
            //{
                
            //}

            //private void buttonSaveEmployee_Click_1(object sender, EventArgs e)
            //{

            //}
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            DialogResult ans = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ans == DialogResult.Yes)
            {
                if (textBoxEmployeeId != null)
                {
                    SqlConnection conn = UtilityDB.ConnectDB();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Employees WHERE EmployeeId ='" + textBoxEmployeeId.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee record has been deleted successfully.", "Confirmation");
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("EmployeeId is empty!\nPlease enter EmployeeId.", "No EmployeeId",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //INSERTING CORRECT INFO FOR SELECTED INDEX OF JOB ID
            int indexSelected = comboBoxJobTitle.SelectedIndex;
            switch (indexSelected)
            {
                case 0:
                    selectedIndexJob = 11;
                    break;
                case 1:
                    selectedIndexJob = 12;
                    break;
                case 2:
                    selectedIndexJob = 13;
                    break;
                case 3:
                    selectedIndexJob = 14;
                    break;
                case 4:
                    selectedIndexJob = 15;
                    break;

                default:
                    break;
            }
            //INSERTING CORRECT INFO FOR SELECTED INDEX OF STATUS ID
            int indexSelected2 = comboBoxStatus.SelectedIndex;
            switch (indexSelected2)
            {
                case 0:
                    selectedIndexStatus = 1;
                    break;
                case 1:
                    selectedIndexStatus = 2;
                    break;
                default:
                    break;
            }
            DialogResult ans = MessageBox.Show("Are you sure you want to update this employee?", "Confirm",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ans == DialogResult.Yes)
            {
                if (textBoxEmployeeId.Text != "" && textBoxFirstName.Text != "" && textBoxLastName.Text != "" && maskedTextBoxPhoneNumber.Text != "" && textBoxEmail.Text != "" && comboBoxJobTitle.Text != "" && comboBoxStatus.Text != "")
                {
                    string input = textBoxEmployeeId.Text.Trim();
                    input = "";
                    input = textBoxFirstName.Text.Trim();
                    if (!Validator.IsValidName(input))
                    {
                        MessageBox.Show("Firstname contains only letters and space" +
                            " to separate first name components.",
                                        "Invalid FirstName",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxFirstName.Clear();
                        textBoxFirstName.Focus();
                        return;
                    }
                    //Check last name
                    input = "";
                    input = textBoxLastName.Text.Trim();
                    if (!Validator.IsValidName(input))
                    {
                        MessageBox.Show("Lastname contains only letters and space" +
                            " to separate last name components.",
                                        "Invalid LastName",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxLastName.Clear();
                        textBoxLastName.Focus();
                        return;
                    }
                    SqlConnection conn = UtilityDB.ConnectDB();
                    SqlCommand cmd = new SqlCommand("UPDATE Employees SET FirstName = @FirstName," +
                        "LastName = @LastName, PhoneNumber = @PhoneNumber, Email = @Email, JobId = @JobID, StatusID = @StatusID WHERE EmployeeId =@EmployeeId", conn);
                    cmd.Parameters.AddWithValue("@EmployeeId", textBoxEmployeeId.Text);
                    cmd.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", textBoxLastName.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", maskedTextBoxPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                    cmd.Parameters.AddWithValue("@JobID", selectedIndexJob);
                    cmd.Parameters.AddWithValue("@StatusID", selectedIndexStatus);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee record has been updated successfully.", "Confirmation");
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Please enter Employee to update.", "Invalid Input",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void comboBoxOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexSelected = comboBoxOption.SelectedIndex;
            //CHANGES LABEL DEPENDING ON SELECTED INDEX OF COMBOBOX (for the search button)
            switch (indexSelected)
            {
                case 0:
                    labelDisplay.Text = "Please enter Employee Id : ";
                    textBoxInput.Clear();
                    textBoxInput.Focus();
                    break;
                case 1:
                    labelDisplay.Text = "Please enter First Name : ";
                    textBoxInput.Clear();
                    textBoxInput.Focus();
                    break;
                case 2:
                    labelDisplay.Text = "Please enter Last Name : ";
                    textBoxInput.Clear();
                    textBoxInput.Focus();
                    break;
                case 3:
                    labelDisplay.Text = "Please enter Job ID : ";
                    textBoxInput.Clear();
                    textBoxInput.Focus();
                    break;
                case 4:
                    labelDisplay.Text = "Please enter Status ID : ";
                    textBoxInput.Clear();
                    textBoxInput.Focus();
                    break;

                default:
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonListAllUser_Click(object sender, EventArgs e)
        {
            UserAccount ua = new UserAccount();
            List<UserAccount> listUac = ua.GetAllEmployees();
            listViewUserAccount.Items.Clear();
            if (listUac.Count != 0)
            {
                foreach (UserAccount u_item in listUac)
                {
                    ListViewItem item = new ListViewItem(u_item.UserID.ToString());
                    item.SubItems.Add(u_item.Password);
                    item.SubItems.Add(u_item.EmployeeID.ToString());
                    listViewUserAccount.Items.Add(item);

                }

            }
            else
            {
                MessageBox.Show("User Account list is empty!\nPlease enter user data.", "No User data",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAssign_Click(object sender, EventArgs e)
        {
            //perform input data validation first
            //Check User ID (4 digits)
            string input = textBoxUserID.Text.Trim();
            string error = "";
            if (!(Validator.IsValidId(input, 4, ref error)))
            {
                MessageBox.Show(error, "Invalid User ID",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUserID.Clear();
                textBoxUserID.Focus();
                return;
            }

            Employee emp = new Employee();
            if (emp.IsDuplicateEmpId(Convert.ToInt32(input)))
            {
                MessageBox.Show("This Employee Id already exists!", "Duplicate Employee ID",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmployeeId.Clear();
                textBoxEmployeeId.Focus();
                return;

            }
            UserAccount ua = new UserAccount();
            //valid input data
            ua.UserID = Convert.ToInt32(textBoxUserID.Text.Trim());
            ua.Password = textBoxPassword.Text.Trim();
            ua.EmployeeID = Convert.ToInt32(textBoxEmpID.Text.Trim());
           
            ua.SaveUser(ua);
            MessageBox.Show("User saved", "Confirmation");
            textBoxUserID.Clear();
            textBoxPassword.Clear();
            textBoxEmpID.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Are you sure you want to delete this User?", "Confirm",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ans == DialogResult.Yes)
            {
                if (textBoxUserID != null)
                {
                    SqlConnection conn = UtilityDB.ConnectDB();
                    SqlCommand cmd = new SqlCommand("DELETE FROM UsersAccount WHERE UserID ='" + textBoxUserID.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User record has been deleted successfully.", "Confirmation");
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("User ID is empty!\nPlease enter User ID.", "No User ID",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}


namespace Hi_TechDistributionInc.GUI
{
    partial class CustomerMaintenance
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxStreetAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.textBoxCustomerId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxPostalCode = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedTextBoxFaxNumber = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxCreditLimit = new System.Windows.Forms.TextBox();
            this.buttonUpdateDatabase = new System.Windows.Forms.Button();
            this.dataGridViewListCustomerFromDS = new System.Windows.Forms.DataGridView();
            this.dataGridViewCustomerFromDB = new System.Windows.Forms.DataGridView();
            this.buttonListCustomerFromDataSet = new System.Windows.Forms.Button();
            this.buttonListCustomerFromDB = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearchID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListCustomerFromDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerFromDB)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(497, 165);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(144, 54);
            this.buttonDelete.TabIndex = 51;
            this.buttonDelete.Text = "&Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(497, 238);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(144, 54);
            this.buttonUpdate.TabIndex = 50;
            this.buttonUpdate.Text = "&Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(497, 92);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(144, 54);
            this.buttonAdd.TabIndex = 49;
            this.buttonAdd.Text = "&Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonSaveEmployee_Click);
            // 
            // textBoxStreetAddress
            // 
            this.textBoxStreetAddress.Location = new System.Drawing.Point(191, 386);
            this.textBoxStreetAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxStreetAddress.Name = "textBoxStreetAddress";
            this.textBoxStreetAddress.Size = new System.Drawing.Size(280, 26);
            this.textBoxStreetAddress.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 389);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "Street Adress";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(191, 218);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(160, 26);
            this.textBoxCity.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 221);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "City";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(191, 428);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(280, 26);
            this.textBoxEmail.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 431);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Email";
            // 
            // maskedTextBoxPhoneNumber
            // 
            this.maskedTextBoxPhoneNumber.Location = new System.Drawing.Point(191, 302);
            this.maskedTextBoxPhoneNumber.Mask = "(999) 000-0000";
            this.maskedTextBoxPhoneNumber.Name = "maskedTextBoxPhoneNumber";
            this.maskedTextBoxPhoneNumber.Size = new System.Drawing.Size(160, 26);
            this.maskedTextBoxPhoneNumber.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 305);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Customer Name";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(191, 131);
            this.textBoxCustomerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(160, 26);
            this.textBoxCustomerName.TabIndex = 37;
            // 
            // textBoxCustomerId
            // 
            this.textBoxCustomerId.Enabled = false;
            this.textBoxCustomerId.Location = new System.Drawing.Point(191, 89);
            this.textBoxCustomerId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCustomerId.Name = "textBoxCustomerId";
            this.textBoxCustomerId.ReadOnly = true;
            this.textBoxCustomerId.Size = new System.Drawing.Size(124, 26);
            this.textBoxCustomerId.TabIndex = 36;
            this.textBoxCustomerId.TextChanged += new System.EventHandler(this.textBoxCustomerId_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Customer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(478, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 37);
            this.label1.TabIndex = 52;
            this.label1.Text = "Customer Maintenance";
            // 
            // maskedTextBoxPostalCode
            // 
            this.maskedTextBoxPostalCode.Location = new System.Drawing.Point(191, 260);
            this.maskedTextBoxPostalCode.Mask = "A0A 9A9";
            this.maskedTextBoxPostalCode.Name = "maskedTextBoxPostalCode";
            this.maskedTextBoxPostalCode.Size = new System.Drawing.Size(160, 26);
            this.maskedTextBoxPostalCode.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 263);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 53;
            this.label9.Text = "Postal Code";
            // 
            // maskedTextBoxFaxNumber
            // 
            this.maskedTextBoxFaxNumber.Location = new System.Drawing.Point(191, 344);
            this.maskedTextBoxFaxNumber.Mask = "+1 (999) 000-0000";
            this.maskedTextBoxFaxNumber.Name = "maskedTextBoxFaxNumber";
            this.maskedTextBoxFaxNumber.Size = new System.Drawing.Size(160, 26);
            this.maskedTextBoxFaxNumber.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 347);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 20);
            this.label10.TabIndex = 55;
            this.label10.Text = "Fax Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 179);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 20);
            this.label11.TabIndex = 58;
            this.label11.Text = "Credit Limit";
            // 
            // textBoxCreditLimit
            // 
            this.textBoxCreditLimit.Location = new System.Drawing.Point(191, 176);
            this.textBoxCreditLimit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCreditLimit.Name = "textBoxCreditLimit";
            this.textBoxCreditLimit.Size = new System.Drawing.Size(160, 26);
            this.textBoxCreditLimit.TabIndex = 57;
            // 
            // buttonUpdateDatabase
            // 
            this.buttonUpdateDatabase.Location = new System.Drawing.Point(691, 92);
            this.buttonUpdateDatabase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUpdateDatabase.Name = "buttonUpdateDatabase";
            this.buttonUpdateDatabase.Size = new System.Drawing.Size(144, 54);
            this.buttonUpdateDatabase.TabIndex = 59;
            this.buttonUpdateDatabase.Text = "&Update Database";
            this.buttonUpdateDatabase.UseVisualStyleBackColor = true;
            this.buttonUpdateDatabase.Click += new System.EventHandler(this.buttonUpdateDatabase_Click);
            // 
            // dataGridViewListCustomerFromDS
            // 
            this.dataGridViewListCustomerFromDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListCustomerFromDS.Location = new System.Drawing.Point(875, 130);
            this.dataGridViewListCustomerFromDS.Name = "dataGridViewListCustomerFromDS";
            this.dataGridViewListCustomerFromDS.RowHeadersWidth = 62;
            this.dataGridViewListCustomerFromDS.RowTemplate.Height = 28;
            this.dataGridViewListCustomerFromDS.Size = new System.Drawing.Size(424, 150);
            this.dataGridViewListCustomerFromDS.TabIndex = 60;
            // 
            // dataGridViewCustomerFromDB
            // 
            this.dataGridViewCustomerFromDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomerFromDB.Location = new System.Drawing.Point(875, 354);
            this.dataGridViewCustomerFromDB.Name = "dataGridViewCustomerFromDB";
            this.dataGridViewCustomerFromDB.RowHeadersWidth = 62;
            this.dataGridViewCustomerFromDB.RowTemplate.Height = 28;
            this.dataGridViewCustomerFromDB.Size = new System.Drawing.Size(424, 150);
            this.dataGridViewCustomerFromDB.TabIndex = 61;
            this.dataGridViewCustomerFromDB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomerFromDB_CellContentClick);
            // 
            // buttonListCustomerFromDataSet
            // 
            this.buttonListCustomerFromDataSet.Location = new System.Drawing.Point(691, 162);
            this.buttonListCustomerFromDataSet.Name = "buttonListCustomerFromDataSet";
            this.buttonListCustomerFromDataSet.Size = new System.Drawing.Size(144, 54);
            this.buttonListCustomerFromDataSet.TabIndex = 62;
            this.buttonListCustomerFromDataSet.Text = "&List Customer from DS";
            this.buttonListCustomerFromDataSet.UseVisualStyleBackColor = true;
            this.buttonListCustomerFromDataSet.Click += new System.EventHandler(this.buttonListCustomerFromDataSet_Click);
            // 
            // buttonListCustomerFromDB
            // 
            this.buttonListCustomerFromDB.Location = new System.Drawing.Point(691, 233);
            this.buttonListCustomerFromDB.Name = "buttonListCustomerFromDB";
            this.buttonListCustomerFromDB.Size = new System.Drawing.Size(144, 54);
            this.buttonListCustomerFromDB.TabIndex = 63;
            this.buttonListCustomerFromDB.Text = "&List Customer from DB";
            this.buttonListCustomerFromDB.UseVisualStyleBackColor = true;
            this.buttonListCustomerFromDB.Click += new System.EventHandler(this.buttonListCustomerFromDB_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(1162, 534);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(137, 48);
            this.buttonLogout.TabIndex = 64;
            this.buttonLogout.Text = "&Log Out";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(875, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(204, 29);
            this.label12.TabIndex = 65;
            this.label12.Text = "List From DataSet";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(875, 312);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(221, 29);
            this.label13.TabIndex = 66;
            this.label13.Text = "List From Database";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(497, 311);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(144, 54);
            this.buttonSearch.TabIndex = 67;
            this.buttonSearch.Text = "&Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearchID
            // 
            this.textBoxSearchID.Location = new System.Drawing.Point(691, 328);
            this.textBoxSearchID.Name = "textBoxSearchID";
            this.textBoxSearchID.Size = new System.Drawing.Size(131, 26);
            this.textBoxSearchID.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(687, 305);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "Enter Customer ID";
            // 
            // CustomerMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 594);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSearchID);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonListCustomerFromDB);
            this.Controls.Add(this.buttonListCustomerFromDataSet);
            this.Controls.Add(this.dataGridViewCustomerFromDB);
            this.Controls.Add(this.dataGridViewListCustomerFromDS);
            this.Controls.Add(this.buttonUpdateDatabase);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxCreditLimit);
            this.Controls.Add(this.maskedTextBoxFaxNumber);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.maskedTextBoxPostalCode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxStreetAddress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maskedTextBoxPhoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCustomerName);
            this.Controls.Add(this.textBoxCustomerId);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerMaintenance";
            this.Text = "Customer Maintenance";
            this.Load += new System.EventHandler(this.CustomerMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListCustomerFromDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerFromDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxStreetAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.TextBox textBoxCustomerId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPostalCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFaxNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxCreditLimit;
        private System.Windows.Forms.Button buttonUpdateDatabase;
        private System.Windows.Forms.DataGridView dataGridViewListCustomerFromDS;
        private System.Windows.Forms.DataGridView dataGridViewCustomerFromDB;
        private System.Windows.Forms.Button buttonListCustomerFromDataSet;
        private System.Windows.Forms.Button buttonListCustomerFromDB;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearchID;
        private System.Windows.Forms.Label label3;
    }
}
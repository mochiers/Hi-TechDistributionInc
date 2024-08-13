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
using Hi_TechDistributionInc.DAL;
using Hi_TechDistributionInc.EF;
using Hi_TechDistributionInc.Validation;

namespace Hi_TechDistributionInc.GUI
{
    public partial class InventoryMaintenance : Form
    {

        //SqlDataAdapter da;
        //DataSet dsHiTechDB;
        //DataTable dtBooks;
        //SqlCommandBuilder sqlBuilder;

        public InventoryMaintenance()
        {
            InitializeComponent();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void InventoryMaintenance_Load(object sender, EventArgs e)
        {
        }

        private void comboBoxCharacter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonListCharacter_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click_1(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Do you want to log out?", "Confirmation",
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ans == DialogResult.Yes)
            {
                this.Hide();
                new LoginForm().Show();
            }
        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            using (var db = new HiTechDBEntities())
            {

                Book book1 = new Book();

                string isbnTemp = maskedTextBoxIsbn.Text;
                var bookLook = from aBook in db.Books
                               where aBook.ISBN == isbnTemp
                               select aBook;

                // Check if Exists
                foreach (var book in bookLook)
                {
                    db.Books.Find(isbnTemp);
                    book1.ISBN = book.ISBN;
                }
                // if exists, notify user
                if (book1.ISBN != null)
                {
                    MessageBox.Show("ID already exists. Please select a different ID.", "Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    maskedTextBoxIsbn.Clear();
                    maskedTextBoxIsbn.Focus();
                }
                else
                {
                    // If != null (doesn't exist), save book
                    book1.ISBN = maskedTextBoxIsbn.Text;
                    book1.Title = textBoxTitle.Text;
                    book1.UnitPrice = maskedTextBoxUnitPrice.Text;
                    book1.QOH = textBoxQuantityOnHand.Text;
                    book1.YearPublished = Convert.ToInt32(maskedTextBoxYearPublished.Text);
                    book1.CategoryID = Convert.ToInt32(textBoxCatID.Text);
                    book1.PublisherID = Convert.ToInt32(textBoxPubID.Text);
                    db.Books.Add(book1);

                    db.SaveChanges();
                    MessageBox.Show("Book has been saved successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    maskedTextBoxIsbn.Clear();
                    textBoxTitle.Clear();
                    maskedTextBoxUnitPrice.Clear();
                    maskedTextBoxYearPublished.Clear();
                    textBoxQuantityOnHand.Clear();
                    textBoxCatID.Clear();
                    textBoxPubID.Clear();
                }
            }
        }

        private void comboBoxCharacter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        
        }

        private void buttonList_Click_1(object sender, EventArgs e)
        {
            listViewBooks.Items.Clear();
            using (var db = new HiTechDBEntities())
            {
                // Fetch data of all BOOKS
                var listBooks = from book in db.Books
                                    orderby book.ISBN
                                    select book;

                // Add data in proper columns of the List View
                foreach (var books in listBooks)
                {
                    ListViewItem item = new ListViewItem(books.ISBN.ToString());
                    item.SubItems.Add(books.Title);
                    item.SubItems.Add(books.UnitPrice);
                    item.SubItems.Add(books.YearPublished.ToString());
                    item.SubItems.Add(books.QOH);
                    item.SubItems.Add(books.CategoryID.ToString());
                    item.SubItems.Add(books.PublisherID.ToString());
                    listViewBooks.Items.Add(item);
                }
            }
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            using (var db = new HiTechDBEntities())
            {
                string empIdTemp = maskedTextBoxIsbn.Text;

                // Query the database for the rows to be deleted.
                var deleteBook = from book in db.Books
                                     where book.ISBN == empIdTemp
                                     select book;

                // Find row and delete from database
                foreach (var book in deleteBook)
                {
                    db.Books.Remove(book);
                }
                try
                {
                    
                    DialogResult ans = MessageBox.Show("Are you sure you want to delete this Book?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (ans == DialogResult.Yes)
                    {
                        if (maskedTextBoxIsbn == null)
                        {
                            MessageBox.Show("ISBN is empty! Please enter ISBN to delete", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            db.SaveChanges();
                            MessageBox.Show("Book has been deleted.");
                        }
                        // Clear Textboxes Information and Update ListView
                        maskedTextBoxIsbn.Clear();
                    }
                    

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    // Provide for exceptions.
                }
            }
        }

        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            using (var db = new HiTechDBEntities())
            {

                // Update Employee
                Book book = new Book();
                string isbn = maskedTextBoxIsbn.Text;
                book = (db.Books.Where(x => x.ISBN == isbn)).FirstOrDefault();
                book.Title = textBoxTitle.Text;
                book.UnitPrice = maskedTextBoxUnitPrice.Text;
                book.YearPublished = Convert.ToInt32(maskedTextBoxYearPublished.Text);
                book.QOH = textBoxQuantityOnHand.Text;
                book.CategoryID = Convert.ToInt32(textBoxCatID.Text);
                book.PublisherID = Convert.ToInt32(textBoxPubID.Text);
                db.SaveChanges();

                // Notify user Update Successful
                MessageBox.Show("Book has been updated. List will update after this message.");

                // Clear Textboxes Book Information 
                maskedTextBoxIsbn.Clear();
                textBoxTitle.Clear();
                maskedTextBoxUnitPrice.Clear();
                maskedTextBoxYearPublished.Clear();
                textBoxQuantityOnHand.Clear();
                textBoxCatID.Clear();
                textBoxPubID.Clear();

            }
        }

        private void buttonListCharacter_Click_1(object sender, EventArgs e)
        {
            
        }

        private void buttonSaveCat_Click(object sender, EventArgs e)
        {
            using (var db = new HiTechDBEntities())
            {

                Category cat1 = new Category();

                int catTemp = Convert.ToInt32(textBoxCategoryID.Text);
                var catLook = from aCat in db.Categories
                               where aCat.CategoryID == catTemp
                               select aCat;

                // Check if Exists
                foreach (var cat in catLook)
                {
                    db.Categories.Find(catTemp);
                    cat1.CategoryID = cat.CategoryID;
                }
                // if exists, notify user
                if (cat1.CategoryID != 0)
                {
                    MessageBox.Show("ID already exists. Please select a different ID.", "Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    maskedTextBoxIsbn.Clear();
                    maskedTextBoxIsbn.Focus();
                }
                else
                {
                    // If != null (doesn't exist), save book
                    cat1.CategoryID = Convert.ToInt32(textBoxCategoryID.Text);
                    cat1.CategoryName = textBoxCategoryName.Text;
                    db.Categories.Add(cat1);

                    db.SaveChanges();
                    MessageBox.Show("Category has been saved successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBoxCategoryID.Clear();
                    textBoxCategoryName.Clear();
                    
                }
            }
        }

        private void buttonListAllCat_Click(object sender, EventArgs e)
        {
            listViewCategories.Items.Clear();
            using (var db = new HiTechDBEntities())
            {
                // Fetch data of all Categories
                var listCats = from cat in db.Categories
                                orderby cat.CategoryID
                                select cat;

                // Add data in proper columns of the List View
                foreach (var cat in listCats)
                {
                    ListViewItem item = new ListViewItem(cat.CategoryID.ToString());
                    item.SubItems.Add(cat.CategoryName);
                    listViewCategories.Items.Add(item);
                }
            }
        }

        private void buttonDeleteCat_Click(object sender, EventArgs e)
        {
            using (var db = new HiTechDBEntities())
            {
                int catIdTemp = Convert.ToInt32(textBoxCategoryID.Text);

                // Query the database for the rows to be deleted.
                var deleteCat = from cat in db.Categories
                                 where cat.CategoryID == catIdTemp
                                 select cat;

                // Find row and delete from database
                foreach (var cat in deleteCat)
                {
                    db.Categories.Remove(cat);
                }
                try
                {

                    DialogResult ans = MessageBox.Show("Are you sure you want to delete this Category?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (ans == DialogResult.Yes)
                    {
                        if (textBoxCategoryID == null)
                        {
                            MessageBox.Show("Category ID is empty! Please enter Category ID to delete", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            db.SaveChanges();
                            MessageBox.Show("Category has been deleted.");
                        }
                        // Clear Textboxes Information and Update ListView
                        textBoxCategoryID.Clear();
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    // Provide for exceptions.
                }
            }
        }

        private void buttonUpdateCat_Click(object sender, EventArgs e)
        {
            using (var db = new HiTechDBEntities())
            {

                // Update Employee
                Category cat = new Category();
                int categoryid = Convert.ToInt32(textBoxCategoryID.Text);
                cat = (db.Categories.Where(x => x.CategoryID == categoryid)).FirstOrDefault();
                cat.CategoryName = textBoxCategoryName.Text;
                db.SaveChanges();

                // Notify user Update Successful
                MessageBox.Show("Category has been updated. List will update after this message.");

                // Clear Textboxes Category Information 
                textBoxCategoryID.Clear();
                textBoxCategoryName.Clear();
                

            }
        }

        private void buttonSearchEmployee_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBoxSearchByBook.SelectedIndex;
            
            switch (selectedIndex)
            {
                case 0:
                    // Validate Input
                    
                        string isbn = textBoxInputBook.Text;

                        using (var db = new HiTechDBEntities())
                        {
                            // Fetch data of ALL Employees by Employee ID
                            var anBook = from book in db.Books
                                             where book.ISBN == isbn
                                             select book;

                            // If sequences exist...
                            if (anBook.Count() != 0)
                            {
                                // Clear List
                                listViewBooks.Items.Clear();
                                // Fill List with Data Found
                                foreach (var book in anBook)
                                {
                                    ListViewItem item = new ListViewItem(book.ISBN.ToString());
                                    item.SubItems.Add(book.Title);
                                    item.SubItems.Add(book.UnitPrice);
                                    item.SubItems.Add(book.YearPublished.ToString());
                                    item.SubItems.Add(book.QOH);
                                    item.SubItems.Add(book.CategoryID.ToString());
                                    item.SubItems.Add(book.PublisherID.ToString());
                                    listViewBooks.Items.Add(item);
                                }
                            }
                            // Otherwise, Notify user
                            else
                            {
                                MessageBox.Show("Sorry, a Book with this ID does not exists.", "Sorry");
                                textBoxInputBook.Clear();
                                return;
                            }
                        
                    }
                    break;
                case 1:
                    using (var db = new HiTechDBEntities())
                    {// Fetch data of ALL Employees by First Name
                        var anBook = from book in db.Books
                                     where book.CategoryID == Convert.ToInt32(textBoxInputBook.Text)
                                            select book;

                        // If there were no sequences found...
                        if (anBook.Count() != 0)
                        {
                            listViewBooks.Items.Clear();

                            // Add data in proper columns of the List View
                            foreach (var book in anBook)
                            {
                                ListViewItem item = new ListViewItem(book.ISBN.ToString());
                                item.SubItems.Add(book.Title);
                                item.SubItems.Add(book.UnitPrice);
                                item.SubItems.Add(book.YearPublished.ToString());
                                item.SubItems.Add(book.QOH);
                                item.SubItems.Add(book.CategoryID.ToString());
                                item.SubItems.Add(book.PublisherID.ToString());
                                listViewBooks.Items.Add(item);
                            }
                        }
                        else
                        {
                            // else, notify user
                            MessageBox.Show($"We couln't find '{textBoxInputBook.Text}' in the system.");
                            textBoxInputBook.Clear();
                            return;
                        }

                        
                    }

                    break;
                case 2:
                    
                        using (var db = new HiTechDBEntities())
                        {
                        // Fetch data of ALL Employees
                        var anBook = from book in db.Books
                                     where book.PublisherID == Convert.ToInt32(textBoxInputBook.Text)
                                     select book;


                        // If there were no sequences found...
                        if (anBook.Count() != 0)
                            {
                                listViewBooks.Items.Clear();

                            // Add data in proper columns of the List View
                            foreach (var book in anBook)
                            {
                                ListViewItem item = new ListViewItem(book.ISBN.ToString());
                                item.SubItems.Add(book.Title);
                                item.SubItems.Add(book.UnitPrice);
                                item.SubItems.Add(book.YearPublished.ToString());
                                item.SubItems.Add(book.QOH);
                                item.SubItems.Add(book.CategoryID.ToString());
                                item.SubItems.Add(book.PublisherID.ToString());
                                listViewBooks.Items.Add(item);
                            }
                        }
                            else
                            {
                                // else, notify user
                                MessageBox.Show($"We couln't find '{textBoxInputBook.Text}' in the system.");
                                textBoxInputBook.Clear();
                                return;
                            }
                        
                        }

                    break;
                default:
                    break;
            }
        }

        private void comboBoxSearchByEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}

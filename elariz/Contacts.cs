using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace myContact
{
    public partial class Contacts : Form
    {
        private readonly func Con;
        private DataTable originalDataTable;
        private ErrorProvider errorProvider = new ErrorProvider();
        private bool searchButtonClicked = false;



        public Contacts()
        {
            InitializeComponent();
            Con = new func();
            ShowContacts();

            originalDataTable = (DataTable)ContactList.DataSource;

            tb_search.TextChanged += tb_search_TextChanged;
        }
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^\d+$");
        }

        private bool IsValidEmail(string email)
        {
            return string.IsNullOrEmpty(email) || System.Text.RegularExpressions.Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
        }

        private void ShowContacts()
        {
            string query = "SELECT ContactName, ContactSurname, ContactPhoneNumber, ContactEmail FROM ContactTbl";
            ContactList.DataSource = Con.GetData(query);

            if (ContactList.Columns.Count > 0)
            {
                ContactList.Columns[0].HeaderText = "Name";
                ContactList.Columns[1].HeaderText = "Surname";
                ContactList.Columns[2].HeaderText = "Number";
                ContactList.Columns[3].HeaderText = "Email";
            }
        }


        private void AddOrUpdateContact(string name, string phoneNumber, string surname, string email, string action)
        {
            try
            {
                errorProvider.Clear();

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phoneNumber) || !IsValidPhoneNumber(phoneNumber) || !IsValidEmail(email))
                {
                    if (string.IsNullOrEmpty(name))
                        errorProvider.SetError(ContactName, "Name is required");

                    if (string.IsNullOrEmpty(phoneNumber) || !IsValidPhoneNumber(phoneNumber))
                        errorProvider.SetError(ContactPhoneNumber, "Valid Phone Number is required");

                    if (!IsValidEmail(email) && !string.IsNullOrEmpty(email))
                        errorProvider.SetError(ContactEmail, "Valid Email is required");
                }
                else
                {
                    string query = $"INSERT INTO ContactTbl (ContactName, ContactPhoneNumber, ContactSurname, ContactEmail) VALUES (@ContactName, @ContactPhoneNumber, @ContactSurname, @ContactEmail)";

                    if (action == "Update")
                    {
                        query = $"UPDATE ContactTbl SET ContactPhoneNumber = @ContactPhoneNumber, ContactSurname = @ContactSurname, ContactEmail = @ContactEmail WHERE ContactName = @ContactName";
                    }

                    List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@ContactName", SqlDbType.NVarChar, 50) { Value = name },
                new SqlParameter("@ContactPhoneNumber", SqlDbType.NVarChar, 50) { Value = phoneNumber },
                new SqlParameter("@ContactSurname", SqlDbType.NVarChar, 50) { Value = surname },
                new SqlParameter("@ContactEmail", SqlDbType.NVarChar, 50) { Value = email }
            };

                    Con.SetData(query, parameters);
                    ShowContacts();

                    MessageBox.Show($"{action} Contact Successfully!");
                    ClearContactFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddOrUpdateContact(ContactName.Text, ContactPhoneNumber.Text, ContactSurname.Text, ContactEmail.Text, "Add");
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            AddOrUpdateContact(ContactName.Text, ContactPhoneNumber.Text, ContactSurname.Text, ContactEmail.Text, "Update");
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(ContactName.Text))
                {
                    MessageBox.Show("Enter Contact Name!");
                }
                else
                {
                    string contactNameToDelete = ContactName.Text;

                    string query = "DELETE FROM ContactTbl WHERE ContactName = @ContactName";
                    SqlParameter parameter = new SqlParameter("@ContactName", SqlDbType.NVarChar, 50) { Value = contactNameToDelete };

                    List<SqlParameter> parameters = new List<SqlParameter> { parameter };

                    int rowsAffected = Con.SetData(query, parameters);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Contact deleted successfully!");
                        ShowContacts();
                    }
                    else
                    {
                        MessageBox.Show("Contact not found or deletion failed.");
                    }

                    ClearContactFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearContactFields()
        {
            ContactName.Text = "";
            ContactEmail.Text = "";
            ContactSurname.Text = "";
            ContactPhoneNumber.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();

            loginForm.Show();

            this.Hide();

        }

        private void ContactList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            if (!searchButtonClicked)
            {
                return;
            }

            string searchQuery = tb_search.Text;

            PerformSearch(searchQuery);
        }


        private void PerformSearch(string searchQuery)
        {
            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                ContactList.DataSource = originalDataTable;
            }
            else
            {
                originalDataTable.DefaultView.RowFilter = $"ContactName LIKE '%{searchQuery}%'";
                ContactList.DataSource = originalDataTable.DefaultView.ToTable();
            }
        }


        private void ClearSearch()
        {
            ContactList.DataSource = originalDataTable;
        }

        private void search_button_Click_1(object sender, EventArgs e)
        {
            searchButtonClicked = true;

            string searchQuery = tb_search.Text;

            PerformSearch(searchQuery);

            searchButtonClicked = false;
        }
    }

}

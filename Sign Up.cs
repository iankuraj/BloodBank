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
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel.Design;
using System.Xml.Linq;
using System.Collections;


namespace Blood_Bank_Management
{
    public partial class Sign_Up : Form
    {
        SqlConnection Connection = new SqlConnection("Data Source=SHAILENDRAYADAV\\MSSQLSERVER2022;Initial Catalog=Bloodbank;Integrated Security=True;Encrypt=True;Trusted_Connection=True;TrustServerCertificate=True;");
        public Sign_Up()
        {
            InitializeComponent();
        }
        //SqlConnection Connection = new SqlConnection("Data Source=SHAILENDRAYADAV\\MSSQLSERVER2022;Initial Catalog=Bloodbank;Integrated Security=True;Encrypt=True;Trusted_Connection=True;TrustServerCertificate=True;");
        private void button1_Click(object sender, EventArgs e)
        {






            try
            {
                if (IsFormValid())
                {
                    if (txtPassword.Text == txtComformPassword.Text)
                    {
                        if (!IsUsernameTaken(txtUsername.Text))
                        {
                            Connection.Open();
                            SqlCommand command = new SqlCommand(
                                "INSERT INTO Registration (FirstName, LastName, B_date, Gender, Address, Username, Password) " +
                                "VALUES (@FirstName, @LastName, @B_date, @Gender, @Address, @Username, @Password)", Connection);

                            command.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                            command.Parameters.AddWithValue("@LastName", txtLastName.Text);
                            command.Parameters.AddWithValue("@B_date", Convert.ToDateTime(txtDate.Text));
                            command.Parameters.AddWithValue("@Gender", txtGender.Text);
                            command.Parameters.AddWithValue("@Address", txtAddress.Text);
                            command.Parameters.AddWithValue("@Username", txtUsername.Text);
                            command.Parameters.AddWithValue("@Password", txtPassword.Text);

                            command.ExecuteNonQuery();
                            Connection.Close();

                            MessageBox.Show("Registration Successful!");

                            // Clear the form
                            ClearForm();

                            // Return to login form
                            Login login = new Login();
                            login.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Username already taken.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not match.");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all fields.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool IsFormValid()
        {
            return !string.IsNullOrEmpty(txtFirstName.Text) &&
                   !string.IsNullOrEmpty(txtLastName.Text) &&
                   !string.IsNullOrEmpty(txtDate.Text) &&
                   !string.IsNullOrEmpty(txtGender.Text) &&
                   !string.IsNullOrEmpty(txtAddress.Text) &&
                   !string.IsNullOrEmpty(txtUsername.Text) &&
                   !string.IsNullOrEmpty(txtPassword.Text) &&
                   !string.IsNullOrEmpty(txtComformPassword.Text);
        }

        private bool IsUsernameTaken(string username)
        {
            int result = 0;
            Connection.Open();
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Registration WHERE Username=@Username", Connection);
            command.Parameters.AddWithValue("@Username", username);
            result = (int)command.ExecuteScalar();
            Connection.Close();
            return result > 0;
        }

        private void ClearForm()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtDate.Text = "";
            txtGender.Text = "";
            txtAddress.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtComformPassword.Text = "";
        }

        //    try
        //    {
        //        if (txtFirstName.Text != "" && txtLastName.Text != "" && txtDate.Text != "" && txtGender.Text != "" && txtUsername.Text != "" && txtAddress.Text != "" && txtPassword.Text != "" && txtComformPassword.Text != "")
        //        {
        //            if (txtPassword.Text == txtComformPassword.Text)
        //            {
        //                int v = check(txtUsername.Text);

        //                if (v != 1)
        //                {   using (SqlConnection Connection = new SqlConnection("Data Source=SHAILENDRAYADAV\\MSSQLSERVER2022;Initial Catalog=Bloodbank;Integrated Security=True;Encrypt=True;Trusted_Connection=True;TrustServerCertificate=True;")) ;
        //                    {
        //                        Connection.Open();
        //                        SqlCommand command = new SqlCommand(
        //                                                    "INSERT INTO Registration (FirstName, LastName, B_date, Gender, Address, Username, Password) " +
        //                                                    "VALUES (@FirstName, @LastName, @B_date, @Gender, @Address, @Username, @Password)", Connection);
        //                        command.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
        //                        command.Parameters.AddWithValue("@LastName", txtLastName.Text);
        //                        command.Parameters.AddWithValue("@B_date", Convert.ToDateTime(txtDate.Text));
        //                        command.Parameters.AddWithValue("@Gender", txtGender.Text);
        //                        command.Parameters.AddWithValue("@Address", txtAddress.Text);
        //                        command.Parameters.AddWithValue("@Username", txtUsername.Text);
        //                        command.Parameters.AddWithValue("@Password", txtPassword.Text);
        //                        command.ExecuteNonQuery();
        //                        Connection.Close();

        //                        MessageBox.Show("Registration Successfully");
        //                    }
        //                    txtFirstName.Text = "";
        //                    txtLastName.Text = "";
        //                    txtGender.Text = "";
        //                    txtAddress.Text = "";
        //                    txtUsername.Text = "";
        //                    txtPassword.Text = "";
        //                    txtComformPassword.Text = "";

        //                }
        //                else
        //                {
        //                    MessageBox.Show(" you are already registered");

        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show("Password does not match.");

        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Fill in the blanks");

        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);

        //    }


        //}
        //int check(string Username)
        //{
        //    int v = 0;
        //    using (SqlConnection Connection = new SqlConnection("Data Source=SHAILENDRAYADAV\\MSSQLSERVER2022;Initial Catalog=Bloodbank;Integrated Security=True;Encrypt=True;Trusted_Connection=True;TrustServerCertificate=True;"))
        //    {
        //        Connection.Open();
        //        string query = "select count(*) from Registration where Username=@Username";
        //        SqlCommand command = new SqlCommand(query, Connection);
        //        command.Parameters.AddWithValue("@Username", Username);
        //        v = (int)command.ExecuteScalar();
        //    }
        //    return v;
        //}

        private void txtDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtComformPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtComformPassword.UseSystemPasswordChar = true;

            }
        }

        private void Sign_Up_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUsername.Text))
                {
                    MessageBox.Show("Please enter your username to delete your account.");
                    return;
                }

                // Check if the username exists before attempting to delete
                if (IsUsernameTaken(txtUsername.Text))
                {
                    Connection.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM Registration WHERE Username=@Username", Connection);
                    command.Parameters.AddWithValue("@Username", txtUsername.Text);

                    command.ExecuteNonQuery();
                    Connection.Close();

                    MessageBox.Show(" Deleted successfully.");

                    // Clear the form after deletion
                    ClearForm();

                    // Optionally, navigate to login page
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username does not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtDate.Text = "";
                txtGender.Text = "";
                txtAddress.Text = "";
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtComformPassword.Text = "";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                string query = "SELECT * FROM Registration WHERE ID = @ID"; // Ensure the column name matches your database schema
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, Connection);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@ID", txtID.Text);

                DataTable dataTable = new DataTable();
                try
                {
                    Connection.Open();
                    dataAdapter.Fill(dataTable);
                    Connection.Close();

                    if (dataTable.Rows.Count > 0)
                    {
                        // Assuming the column order in the DataTable matches the order of the columns in the Registration table
                        txtFirstName.Text = dataTable.Rows[0]["FirstName"].ToString();
                        txtLastName.Text = dataTable.Rows[0]["LastName"].ToString();
                        txtDate.Text = Convert.ToDateTime(dataTable.Rows[0]["B_date"]).ToString("yyyy-MM-dd"); // Format date as needed
                        txtGender.Text = dataTable.Rows[0]["Gender"].ToString();
                        txtAddress.Text = dataTable.Rows[0]["Address"].ToString();
                        txtUsername.Text = dataTable.Rows[0]["Username"].ToString();
                        txtPassword.Text = dataTable.Rows[0]["Password"].ToString();
                        txtComformPassword.Text = txtPassword.Text; // Assuming confirmation should match the password
                    }
                    else
                    {
                        MessageBox.Show("No Record Exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearForm(); // Clear form if no record is found
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter an ID to search.");
            }

        }
    }
 }



using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Blood_Bank_Management
{
    public partial class Login : Form
    {
        SqlConnection Connection = new SqlConnection("Data Source=SHAILENDRAYADAV\\MSSQLSERVER2022;Initial Catalog=Bloodbank;Integrated Security=True;Encrypt=True;Trusted_Connection=True;TrustServerCertificate=True;");
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Add any logic needed here
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Add any logic needed here
        }

        private void btnHideShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (btnHideShow.Text == "Show")
            {
                btnHideShow.Text = "Hide";
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                btnHideShow.Text = "Show";
                txtPassword.PasswordChar = '*';
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {   if(checkBox.Checked == true)
            {
                btnLogin.Enabled = true;
            }
           else
            {
                btnLogin.Enabled = false;
            }

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();
                SqlCommand command = new SqlCommand(
                    "SELECT COUNT(*) FROM Registration WHERE Username=@Username AND Password=@Password", Connection);
                command.Parameters.AddWithValue("@Username", txtUsername.Text);
                command.Parameters.AddWithValue("@Password", txtPassword.Text);

                int result = (int)command.ExecuteScalar();

                if (result > 0)
                {
                    MessageBox.Show("Login successful!");
                    Dashboard dashboard = new Dashboard(); // Assuming a Dashboard form exists
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //    if (txtUsername.Text  =="Admin" && txtPassword.Text == "admin")
        //    {
        //        // Add your login logic here, e.g., validate username and password from a database

        //        Dashboard db = new Dashboard();
        //        db.Show();
        //        this.Hide();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Enter valid Username OR Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Sign_Up db = new Sign_Up();
            //db.Show();
            //this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Sign_Up db = new Sign_Up();
            db.Show();
            this.Hide();
        }
    }
}

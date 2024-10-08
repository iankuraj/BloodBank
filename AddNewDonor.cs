﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank_Management
{
    public partial class AddNewDonor : Form
    {
        function fn = new function();
        //private object labelNewID;

        public AddNewDonor()
        {
            InitializeComponent();
        }

        private void AddNewDonor_Load(object sender, EventArgs e)
        {
            String query = "select max(did) from newDonor";
            DataSet ds = fn.getData(query);
            int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            labelNewID.Text = (count + 1).ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtFather.Text != "" && txtMother.Text != "" && txtDOB.Text != "" && txtMobile.Text != "" && txtGender.Text != "" && txtCity.Text != "" && txtAddress.Text != "")
            {
                String dname = txtName.Text;
                String fname = txtFather.Text;
                String mname = txtMother.Text;
                String dob = txtDOB.Text;
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String gender = txtGender.Text;
                String email = txtEmail.Text;
                String bgroup = txtBloodGroup.Text;
                String city = txtCity.Text;
                String address = txtAddress.Text;


                String Query = "insert into newDonor(dname,fname,mname,dob,mobile,gender, email,bloodgroup,city,daddress) values('" + dname + "','" + fname + "','" + mname + "','" + dob + "','" + mobile + "','" + gender + "','" + email + "','" + bgroup + "','" + city + "','" + address + "')";
                fn.setDate(Query);



            }
            else
            {
                MessageBox.Show("Fill all Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtFather.Clear();
            txtMother.Clear();
            txtDOB.ResetText();
            txtMobile.Clear();
            txtGender.ResetText();
            txtEmail.Clear();
            txtBloodGroup.ResetText();
            txtCity.Clear();
            txtAddress.Clear();
        }
    }
}

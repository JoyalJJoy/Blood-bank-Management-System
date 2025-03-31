using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoodBank
{
    public partial class AddNewDonor : Form
    {
        function fn = new function();
        public AddNewDonor()
        {
            InitializeComponent();
        }

        private void AddNewDonor_Load(object sender, EventArgs e)
        {
            string query = "select isnull(max(did),0) from newDonorjoy";
            DataSet ds = fn.getData(query);
            int count = 0;
            if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
            {
                count= Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            }
            labelNewID.Text = (count+1).ToString();

            /* int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            labelNewID.Text = (count+1).ToString(); */

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtFather.Clear();
            txtMother.Clear();
            txtDOB.ResetText();
            txtMobile.Clear();
            txtGender.SelectedIndex = -1;
            txtEmail.Clear();
            txtBloodGroup.SelectedIndex = -1;
            txtCity.Clear();
            txtAddress.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtName.Text !="" && txtFather.Text!= "" && txtMother.Text != "" && txtDOB.Text!="" && txtMobile.Text!="" && txtGender.Text!="" && txtEmail.Text!="" && txtBloodGroup.Text!="" && txtCity.Text!="" && txtAddress.Text!="")
            {
                string dname = txtName.Text;
                string fname = txtFather.Text;
                string mname = txtMother.Text;
                string dob = txtDOB.Text;
                Int64 mobile = Int64.Parse(txtMobile.Text);
                string gender = txtGender.Text;
                string email = txtEmail.Text;
                string bgroup = txtBloodGroup.Text;
                string city = txtCity.Text;
                string address = txtAddress.Text;

                string query = "insert into newDonorjoy(dname,fname,mname,dob,mobile,gender,email,bloodgroup,city,daddress) values ('" +dname+ "','" +fname+ "','" +mname+ "','" +dob+ "'," +mobile+ ",'" +gender+"','"+email+"','"+bgroup+"','"+city+"','"+address+"')";
                fn.setData(query);


            }
            else
            {
                MessageBox.Show("Fill All Fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

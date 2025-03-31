using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoodBank
{
    public partial class patient : Form
    {
        function fn = new function();
        public patient()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void patient_Load(object sender, EventArgs e)
        {
           string query = "select isnull(max(pid),0) from patients";
            DataSet ds = fn.getData(query);
            int count = 0;
            if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
            {
                count = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            }
            labelNewpID.Text = (count + 1).ToString(); 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             if (txtName.Text != "" && txtFather.Text != "" && txtMother.Text != "" && txtDOB.Text != "" && txtMobile.Text != "" && txtGender.Text != "" && txtEmail.Text != "" && txtBloodGroup.Text != "" && txtCity.Text != "" && txtAddress.Text != "")
            {
                string pname = txtName.Text;
                string fname = txtFather.Text;
                string mname = txtMother.Text;
                string dob = txtDOB.Text;
                Int64 mobile = Int64.Parse(txtMobile.Text);
                string gender = txtGender.Text;
                string email = txtEmail.Text;
                string bgroup = txtBloodGroup.Text;
                string city = txtCity.Text;
                string paddress = txtAddress.Text;

                string query = "insert into patients(pname,fname,mname,dob,mobile,gender,email,bloodgroup,city,paddress) values ('" + pname + "','" + fname + "','" + mname + "','" + dob + "'," + mobile + ",'" + gender + "','" + email + "','" + bgroup + "','" + city + "','" + paddress + "')";
                fn.setData(query);


            }
            else
            {
                MessageBox.Show("Fill All Fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
         
            } 
        }  

        private void btnReset_Click(object sender, EventArgs e)
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
    }
}

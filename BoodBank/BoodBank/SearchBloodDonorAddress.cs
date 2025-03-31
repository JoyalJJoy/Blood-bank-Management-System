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
    public partial class SearchBloodDonorAddress : Form
    {
        function fn = new function();
        public SearchBloodDonorAddress()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchBloodDonorAddress_Load(object sender, EventArgs e)
        {
            string query = "select * from newDonorjoy";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];


        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if(txtAddress.Text != "")
            {
                string query = "select * from newDonorjoy where city like '" + txtAddress.Text + "%' or daddress Like '"+txtAddress.Text+"%' ";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                string query = "select * from newDonorjoy";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}

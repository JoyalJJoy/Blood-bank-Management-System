using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoodBank
{
    public partial class BloodTransferForm : Form
    {
        function fn = new function();
        public BloodTransferForm()
        {
            InitializeComponent();
        }

        private void BloodTransferForm_Load(object sender, EventArgs e)
        { }
        private void TransferBlood(int patientId, string bloodGroup, int quantity)
        {
            try
            {
                // Check if enough blood stock is available
                string checkStockQuery = $"SELECT Quantity FROM Stock WHERE blood_group = '{bloodGroup}'";
                DataSet ds = getData(checkStockQuery);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    int currentStock = Convert.ToInt32(ds.Tables[0].Rows[0]["Quantity"]);

                    if (currentStock >= quantity) // Ensure sufficient stock
                    {
                        // Insert record into Blood_Transfer table
                        string insertTransferQuery = $"INSERT INTO Blood_Transfer (pid, blood_group, quantity, transfer_date) " +
                                                     $"VALUES ({patientId}, '{bloodGroup}', {quantity}, GETDATE())";
                        setData(insertTransferQuery);

                        // Reduce blood stock
                        string updateStockQuery = $"UPDATE Stock SET Quantity = Quantity - {quantity} WHERE blood_group = '{bloodGroup}'";
                        setData(updateStockQuery);

                        MessageBox.Show("Blood Transferred Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Insufficient Blood Stock!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Blood Group Not Found in Stock!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        public DataSet getData(String query) // get data from database
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=LAPTOP-G59HHVK1; database=Bloodbankjoy; integrated security=True";
            return con;
        }

        public void setData(String query) // inseration deletion updation
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Processed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnTransfer_Click(object sender, EventArgs e)
        {
            int patientId = Convert.ToInt32(txtPatientID.Text); // Get Patient ID from textbox
            string bloodGroup = cmbBloodGroup.SelectedItem.ToString(); // Get Blood Group from dropdown
            int quantity = Convert.ToInt32(txtQuantity.Text); // Get Quantity from textbox

            TransferBlood(patientId, bloodGroup, quantity);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    

    }
}
    


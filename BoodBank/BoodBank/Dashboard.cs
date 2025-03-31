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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewDonor and = new AddNewDonor();
            and.Show();
        }

        private void updateDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDonorDetails udd = new UpdateDonorDetails();
            udd.Show();
        }

        private void allDonorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllDonorDetails add = new AllDonorDetails();
            add.Show();
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBloodDonorAddress sba = new SearchBloodDonorAddress();
            sba.Show();
        }

        private void bloodGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchDonorByBlood sdb = new SearchDonorByBlood();
            sdb.Show();

        }

        private void increaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockIncrease si = new StockIncrease();
            si.Show();
        }

        private void decreaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockDecrease sd = new StockDecrease();
            sd.Show();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Stock s = new Stock();
            s.Show();
        }

        private void deleteDonorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeleteDonor dd = new DeleteDonor();
            dd.Show();
        }

        private void addNewPatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patient p = new patient();
            p.Show();
        }

        private void updatePatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePatientDetails up = new UpdatePatientDetails();
            up.Show();
        }

        private void allPatientsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllPatientsDetails pd = new AllPatientsDetails();
            pd.Show();
        }

        private void deletePateintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeletePatients dp = new DeletePatients();
            dp.Show();
        }

        private void bloodTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BloodTransferForm btf = new BloodTransferForm();
            btf.Show();
        }
    }
}

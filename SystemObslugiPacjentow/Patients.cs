using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SystemObslugiPacjentow
{
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
            DisplayPatients();
            if (Login.Role == "Receptionist")
            {
                RecepLink.Enabled = false;
                DocLink.Enabled = false;
                LabLink.Enabled = false;
                HomeLink.Enabled = true;
                LogoutLink.Enabled = true;
            }
            if (Login.Role == "Administrator")
            {
                RecepLink.Enabled = true;
                DocLink.Enabled = true;
                LabLink.Enabled = true;
                HomeLink.Enabled = false;
                LogoutLink.Enabled = true;
            }
            if (Login.Role == "Doctor")
            {
                RecepLink.Enabled = false;
                DocLink.Enabled = false;
                LabLink.Enabled = false;
                HomeLink.Enabled = false;
                LogoutLink.Enabled = true;
            }
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\janbo\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30;");

        private void DisplayPatients()
        {
            Con.Open();
            string query = "Select * from PatientTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PatientsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Clear()
        {
            PatNameDb.Text = "";
            PatPhoneDb.Text = "";
            PatAllDb.Text = "";
            PatAddDb.Text = "";
            PatGenDb.SelectedItem = null;
            PatCovDb.SelectedItem = null;
            Key = 0;
        }

        int Key = 0;

        private void PatDelBtn_Click_1(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select the Patient");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM PatientTbl WHERE PatId=@PKey", Con);
                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Deleted Successfully");
                    Con.Close();
                    DisplayPatients();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void PatAddBtn_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PatNameDb.Text) ||
                PatGenDb.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(PatAllDb.Text) ||
                string.IsNullOrWhiteSpace(PatAddDb.Text) ||
                string.IsNullOrWhiteSpace(PatPhoneDb.Text) ||
                PatCovDb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into PatientTbl(PatName, PatGen, PatDOB, PatCovid, PatPhone, PatAll, PatAdd)values(@PN, @PG, @PD, @PC, @PP, @PA, @PAD)", Con);
                    cmd.Parameters.AddWithValue("@PN", PatNameDb.Text);
                    cmd.Parameters.AddWithValue("@PG", PatGenDb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PD", PatDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@PC", PatCovDb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PP", PatPhoneDb.Text);
                    cmd.Parameters.AddWithValue("@PA", PatAllDb.Text);
                    cmd.Parameters.AddWithValue("@PAD", PatAddDb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient added");
                    Con.Close();
                    DisplayPatients();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void ExitPat_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void PatientsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure we have a valid row index
            if (e.RowIndex != -1)
            {
                PatNameDb.Text = PatientsDGV.Rows[e.RowIndex].Cells["PatName"].Value.ToString();
                PatGenDb.SelectedItem = PatientsDGV.Rows[e.RowIndex].Cells["PatGen"].Value.ToString();
                PatDOB.Value = Convert.ToDateTime(PatientsDGV.Rows[e.RowIndex].Cells["PatDOB"].Value);
                PatCovDb.SelectedItem = PatientsDGV.Rows[e.RowIndex].Cells["PatCovid"].Value.ToString();
                PatPhoneDb.Text = PatientsDGV.Rows[e.RowIndex].Cells["PatPhone"].Value.ToString();
                PatAllDb.Text = PatientsDGV.Rows[e.RowIndex].Cells["PatAll"].Value.ToString();
                PatAddDb.Text = PatientsDGV.Rows[e.RowIndex].Cells["PatAdd"].Value.ToString();

                if (int.TryParse(PatientsDGV.Rows[e.RowIndex].Cells["PatId"].Value.ToString(), out int keyValue))
                {
                    Key = keyValue;
                }
                else
                {
                    MessageBox.Show("Invalid data in the ID column");
                    Key = 0;
                }
            }
        }

        private void HomeLink_Click(object sender, EventArgs e)
        {
            Homes Obj = new Homes();
            Obj.Show();
            this.Hide();
        }

        private void LogoutLink_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void DocLink_Click(object sender, EventArgs e)
        {
            Doctors Obj = new Doctors();
            Obj.Show();
            this.Hide();
        }

        private void LabLink_Click(object sender, EventArgs e)
        {
            LabTests Obj = new LabTests();
            Obj.Show();
            this.Hide();
        }

        private void RecepLink_Click(object sender, EventArgs e)
        {
            Receptionists Obj = new Receptionists();
            Obj.Show();
            this.Hide();
        }
    }
}



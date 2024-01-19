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

namespace SystemObslugiPacjentow
{
    public partial class Prescriptions : Form
    {
        public Prescriptions()
        {
            InitializeComponent();
            DisplayPrescriptions();
            GetDocId();
            GetPatId();
            GetTestId();
            if (Login.Role == "Receptionist")
            {
                RecepLink.Enabled = false;
                DoctorLink.Enabled = false;
                LabLink.Enabled = false;
                PatientLink.Enabled = true;
                LogoutLink.Enabled = true;
                HomeLink.Enabled = false;
            }
            if (Login.Role == "Administrator")
            {
                RecepLink.Enabled = true;
                DoctorLink.Enabled = true;
                LabLink.Enabled = true;
                PatientLink.Enabled = false;
                LogoutLink.Enabled = true;
                HomeLink.Enabled = false;
            }
            if (Login.Role == "Doctor")
            {
                RecepLink.Enabled = false;
                DoctorLink.Enabled = false;
                LabLink.Enabled = false;
                PatientLink.Enabled = false;
                LogoutLink.Enabled = true;
                HomeLink.Enabled = true;
            }
        }

        private void DisplayPrescriptions()
        {
            try
            {
                Con.Open();
                string query = "SELECT * FROM PrescriptionTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                PresDGV.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\janbo\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30;");
        int Key = 0;

        private void Clear()
        {
            DocNameDb.Text = "";
            PatNameDb.Text = "";
            TestNameDb.Text = "";
            PresPriceDb.Text = "";
            PresMedDb.Text = "";
            PatIdDb.SelectedIndex = 0;
            DocIdDb.SelectedIndex = 0;
            TestIdDb.SelectedIndex = 0;
            Key = 0;
        }


        private void GetDocId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select DocId from DoctorTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("DocId", typeof(int));
            dt.Load(rdr);
            DocIdDb.ValueMember = "DocId";
            DocIdDb.DataSource = dt;
            Con.Close();
        }

        private void GetDocName()
        {
            Con.Open();
            string query = "SELECT * FROM DoctorTbl WHERE DocId=" + DocIdDb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                DocNameDb.Text = dr["DocName"].ToString();
            }
            Con.Close();
        }

        private void GetPatId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select PatId from PatientTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PatId", typeof(int));
            dt.Load(rdr);
            PatIdDb.ValueMember = "PatId";
            PatIdDb.DataSource = dt;
            Con.Close();
        }

        private void GetPatName()
        {
            Con.Open();
            string query = "SELECT * FROM PatientTbl WHERE PatId=" + PatIdDb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PatNameDb.Text = dr["PatName"].ToString();
            }
            Con.Close();
        }

        private void GetTestId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select TestNum from TestTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TestNum", typeof(int));
            dt.Load(rdr);
            TestIdDb.ValueMember = "TestNum";
            TestIdDb.DataSource = dt;
            Con.Close();
        }
        private void GetTest()
        {
            Con.Open();
            string query = "SELECT * FROM TestTbl WHERE TestNum=" + TestIdDb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                TestNameDb.Text = dr["TestName"].ToString();
                PresPriceDb.Text = dr["TestPrice"].ToString();
            }
            Con.Close();
        }

        private void PresAddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DocNameDb.Text) ||
            string.IsNullOrWhiteSpace(PatNameDb.Text) ||
            string.IsNullOrWhiteSpace(TestNameDb.Text) ||
            PatIdDb.SelectedIndex == -1 ||
            DocIdDb.SelectedIndex == -1 ||
            TestIdDb.SelectedIndex == -1 ||
            string.IsNullOrWhiteSpace(SummaryDb.Text) ||
            string.IsNullOrWhiteSpace(PresPriceDb.Text) ||
            string.IsNullOrWhiteSpace(PresMedDb.Text))
            {
                MessageBox.Show("Missing Data");
                return;
            }

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO PrescriptionTbl (DocId, DocName, PatId, PatName, TestNum, LabTestName, Medicines, Price) VALUES (@DI, @DN, @PI, @PN, @TN, @LTN, @MCN, @PCE)", Con);
                cmd.Parameters.AddWithValue("@DI", DocIdDb.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@DN", DocNameDb.Text);
                cmd.Parameters.AddWithValue("@PI", PatIdDb.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@PN", PatNameDb.Text);
                cmd.Parameters.AddWithValue("@TN", TestIdDb.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@LTN", TestNameDb.Text);
                cmd.Parameters.AddWithValue("@MCN", PresMedDb.Text);
                cmd.Parameters.AddWithValue("@PCE", PresPriceDb.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Prescription Added Successfully");
                Con.Close();
                DisplayPrescriptions();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void PresDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                // Use e.RowIndex to get the actual clicked row instead of CurrentRow
                DataGridViewRow clickedRow = PresDGV.Rows[e.RowIndex];

                SummaryDb.Text = "         Patient Management System\n\n" +
                                 "                  PRESCRIPTION                 \n\n" +
                                 "***************************************\n\n" +
                                 DateTime.Today.ToString("dd.MM.yyyy") + "\n\n" +
                                 "Doctor: " + clickedRow.Cells[2].Value.ToString() + "\n" +
                                 "Patient: " + clickedRow.Cells[4].Value.ToString() + "\n" +
                                 "Test: " + clickedRow.Cells[6].Value.ToString() + "\n" +
                                 "Medicines: " + clickedRow.Cells[7].Value.ToString() + "\n" +
                                 "Price: " + clickedRow.Cells[8].Value.ToString() + "\n" +
                                 "Patient Management System";
            }
        }



        private void PresExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


        private void PatIdDb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetPatName();
        }

        private void DocIdDb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetDocName();
        }

        private void TestIdDb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTest();
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            // Configure the print dialog to show the print preview first
            printPreviewDialog1.Document = printDocument1;

            // Show the print preview dialog
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Your code to print goes here
            e.Graphics.DrawString(SummaryDb.Text, new Font("Averia", 18, FontStyle.Regular), Brushes.Black, new Point(95, 80));
            e.Graphics.DrawString("\n\t" + "Thank you", new Font("Averia", 18, FontStyle.Regular), Brushes.Black, new Point(200, 300));
        }

        private void LogoutLink_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void RecepLink_Click(object sender, EventArgs e)
        {
            Receptionists Obj = new Receptionists();
            Obj.Show();
            this.Hide();
        }

        private void LabLink_Click(object sender, EventArgs e)
        {
            LabTests Obj = new LabTests();
            Obj.Show();
            this.Hide();
        }

        private void DoctorLink_Click(object sender, EventArgs e)
        {
            Doctors Obj = new Doctors();
            Obj.Show();
            this.Hide();
        }

        private void PatientLink_Click(object sender, EventArgs e)
        {
            Patients Obj = new Patients();
            Obj.Show();
            this.Hide();
        }

        private void HomeLink_Click(object sender, EventArgs e)
        {
            Homes Obj = new Homes();
            Obj.Show();
            this.Hide();
        }
    }
}

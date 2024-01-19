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
    public partial class Homes : Form
    {
        public Homes()
        {
            InitializeComponent();
            if (Login.Role == "Receptionist")
            {
                RecepLink.Enabled = false;
                DoctorLink.Enabled = false;
                LabLink.Enabled = false;
                PatientLink.Enabled = true;
                LogoutLink.Enabled = true;
                ReceiptLink.Enabled = false;
            }
            if (Login.Role == "Administrator")
            {
                RecepLink.Enabled = true;
                DoctorLink.Enabled = true;
                LabLink.Enabled = true;
                PatientLink.Enabled = false;
                LogoutLink.Enabled = true;
                ReceiptLink.Enabled = false;
            }
            if (Login.Role == "Doctor")
            {
                RecepLink.Enabled = false;
                DoctorLink.Enabled = false;
                LabLink.Enabled = false;
                PatientLink.Enabled = false;
                LogoutLink.Enabled = true;
                ReceiptLink.Enabled = true;
            }
            CountPatients();
            CountDoctors();
            CountTests();
            CountCovid();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\janbo\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30;");

        private void CountPatients()
        {
            Con.Open();
            string query = "SELECT COUNT(*) from PatientTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            PatientLabel.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void CountCovid()
        {
            String positive = "Positive";
            Con.Open();
            string query = "SELECT COUNT(*) FROM PatientTbl WHERE PatCovid='" + positive + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CovidLabel.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void CountDoctors()
        {
            Con.Open();
            string query = "SELECT COUNT(*) from DoctorTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DoctorLabel.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void CountTests()
        {
            Con.Open();
            string query = "SELECT COUNT(*) from TestTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LabLabel.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void PatientLink_Click(object sender, EventArgs e)
        {
            Patients Obj = new Patients();
            Obj.Show();
            this.Hide();
        }

        private void DoctorLink_Click(object sender, EventArgs e)
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

        private void LogoutLink_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void ExitLink_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ReceiptLink_Click(object sender, EventArgs e)
        {
            Prescriptions Obj = new Prescriptions();
            Obj.Show();
            this.Hide();
        }
    }
}

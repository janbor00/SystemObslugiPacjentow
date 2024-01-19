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
using static System.Net.Mime.MediaTypeNames;

namespace SystemObslugiPacjentow
{
    public partial class Doctors : Form
    {
        public Doctors()
        {
            InitializeComponent();
            DisplayDoc();
            if (Login.Role == "Receptionist")
            {
                label3.Enabled = false;
                DoctorsLink.Enabled = false;
                LabLink.Enabled = false;
                PatientLink.Enabled = true;
                LogoutLink.Enabled = true;
            }
            if (Login.Role == "Administrator")
            {
                label3.Enabled = true;
                DoctorsLink.Enabled = true;
                LabLink.Enabled = true;
                PatientLink.Enabled = false;
                LogoutLink.Enabled = true;
            }
            if (Login.Role == "Doctor")
            {
                label3.Enabled = false;
                DoctorsLink.Enabled = false;
                LabLink.Enabled = false;
                PatientLink.Enabled = false;
                LogoutLink.Enabled = true;
            }
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\janbo\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30;");

        private void DisplayDoc()
        {
            Con.Open();
            string query = "Select * from DoctorTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DoctorsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Clear()
        {
            DocNameTb.Text = "";
            DocPhoneTb.Text = "";
            DocExpTb.Text = "";
            DocAddTb.Text = "";
            DocPassTb.Text = "";
            DocSpecTb.SelectedItem = 0;
            DocGenTb.SelectedItem = 0;
            Key = 0;
        }
        private void DocAddBtn_Click(object sender, EventArgs e)
        {
            if (DocNameTb.Text == "" || DocPassTb.Text == "" || DocPhoneTb.Text == "" || DocAddTb.Text == "" || DocGenTb.SelectedIndex == -1 || DocSpecTb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into DoctorTbl(DocName, DocGen, DocDOB, DocSpec, DocPhone, DocExp, DocAdd, DocPass)values(@DN, @DG, @DD,@DS, @DP, @DE, @DA,@DPA)", Con);
                    cmd.Parameters.AddWithValue("@DN", DocNameTb.Text);
                    cmd.Parameters.AddWithValue("@DG", DocGenTb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DD", DocDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@DS", DocSpecTb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DP", DocPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@DE", DocExpTb.Text);
                    cmd.Parameters.AddWithValue("@DA", DocAddTb.Text);
                    cmd.Parameters.AddWithValue("@DPA", DocPassTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor added");
                    Con.Close();
                    DisplayDoc();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        int Key = 0;
        private void DoctorsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure we have a valid row index
            if (e.RowIndex != -1)
            {
                DocNameTb.Text = DoctorsDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                DocGenTb.Text = DoctorsDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                DocDOB.Text = DoctorsDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                DocSpecTb.Text = DoctorsDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
                DocPhoneTb.Text = DoctorsDGV.Rows[e.RowIndex].Cells[5].Value.ToString();
                DocExpTb.Text = DoctorsDGV.Rows[e.RowIndex].Cells[6].Value.ToString();
                DocAddTb.Text = DoctorsDGV.Rows[e.RowIndex].Cells[7].Value.ToString();
                DocPassTb.Text = DoctorsDGV.Rows[e.RowIndex].Cells[8].Value.ToString();

                // Safely try to get the key value
                if (int.TryParse(DoctorsDGV.Rows[e.RowIndex].Cells[0].Value.ToString(), out int keyValue))
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

        private void DocEditBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DocNameTb.Text) ||
                DocGenTb.SelectedIndex == -1 ||
                DocDOB.Value.Date == default(DateTime) ||
                DocSpecTb.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(DocPhoneTb.Text) ||
                string.IsNullOrWhiteSpace(DocExpTb.Text) ||
                string.IsNullOrWhiteSpace(DocAddTb.Text) ||
                string.IsNullOrWhiteSpace(DocPassTb.Text))
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE DoctorTbl SET DocName=@DN, DocGen=@DG, DocDOB=@DD, DocSpec=@DS, DocPhone=@DP, DocExp=@DE, DocAdd=@DA, DocPass=@DPA WHERE DocId=@DKey", Con);
                    cmd.Parameters.AddWithValue("@DN", DocNameTb.Text);
                    cmd.Parameters.AddWithValue("@DG", DocGenTb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DD", DocDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@DS", DocSpecTb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DP", DocPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@DE", DocExpTb.Text);
                    cmd.Parameters.AddWithValue("@DA", DocAddTb.Text);
                    cmd.Parameters.AddWithValue("@DPA", DocPassTb.Text);
                    cmd.Parameters.AddWithValue("@DKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor Updated Successfully");
                    Con.Close();
                    DisplayDoc();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DocDelBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select the Doctor");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM  DoctorTbl WHERE DocId=@DKey", Con);

                    cmd.Parameters.AddWithValue("@DKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor deleted");
                    Con.Close();
                    DisplayDoc();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void ExitDoc_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void DoctorsLink_Click(object sender, EventArgs e)
        {
            Homes Obj = new Homes();
            Obj.Show();
            this.Hide();
        }

        private void LabLink_Click(object sender, EventArgs e)
        {
            LabTests Obj = new LabTests();
            Obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
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

        private void PatientLink_Click(object sender, EventArgs e)
        {
            Patients Obj = new Patients();
            Obj.Show();
            this.Hide();
        }
    }
}

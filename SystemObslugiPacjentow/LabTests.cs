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
using System.Windows.Forms;

namespace SystemObslugiPacjentow
{
    public partial class LabTests : Form
    {
        public LabTests()
        {
            InitializeComponent();
            if (Login.Role == "Receptionist")
            {
                RecepLink.Enabled = false;
                DoctorLink.Enabled = false;
                LabLink.Enabled = false;
                PatientLink.Enabled = true;
                LogoutLink.Enabled = true;
            }
            if (Login.Role == "Administrator")
            {
                RecepLink.Enabled = true;
                DoctorLink.Enabled = true;
                LabLink.Enabled = true;
                PatientLink.Enabled = false;
                LogoutLink.Enabled = true;
            }
            if (Login.Role == "Doctor")
            {
                RecepLink.Enabled = false;
                DoctorLink.Enabled = false;
                LabLink.Enabled = false;
                PatientLink.Enabled = false;
                LogoutLink.Enabled = true;
            }
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\janbo\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30;");
        private void LabDelBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select the Test");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM TestTbl WHERE TestNum=@TKey", Con);
                    cmd.Parameters.AddWithValue("@TKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Test Deleted Successfully");
                    Con.Close();
                    DisplayTests();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void LabAddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TestNameDb.Text) ||
        string.IsNullOrWhiteSpace(TestPriceDb.Text))
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO TestTbl (TestName, TestPrice) VALUES (@TN, @TP)", Con);
                    cmd.Parameters.AddWithValue("@TN", TestNameDb.Text);
                    cmd.Parameters.AddWithValue("@TP", int.Parse(TestPriceDb.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Test Added Successfully");
                    Con.Close();
                    DisplayTests();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void LabEditBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TestNameDb.Text) ||
        string.IsNullOrWhiteSpace(TestPriceDb.Text))
            {
                MessageBox.Show("Missing Data");
            }
            else if (!int.TryParse(TestPriceDb.Text, out int testPrice))
            {
                MessageBox.Show("Please enter a valid price");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE TestTbl SET TestName=@TN, TestPrice=@TP WHERE TestNum=@TKey", Con);
                    cmd.Parameters.AddWithValue("@TN", TestNameDb.Text);
                    cmd.Parameters.AddWithValue("@TP", testPrice);
                    cmd.Parameters.AddWithValue("@TKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Test Updated Successfully");
                    Con.Close();
                    DisplayTests();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int Key = 0;
        private void DisplayTests()
        {
            try
            {
                Con.Open();
                string query = "SELECT * FROM TestTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                LabDGV.DataSource = ds.Tables[0];
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

        private void LabExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Clear()
        {
            TestNameDb.Text = "";
            TestPriceDb.Text = "";
            Key = 0;
        }

        private void LabDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                TestNameDb.Text = LabDGV.Rows[e.RowIndex].Cells["TestName"].Value.ToString();
                TestPriceDb.Text = LabDGV.Rows[e.RowIndex].Cells["TestPrice"].Value.ToString();

                if (int.TryParse(LabDGV.Rows[e.RowIndex].Cells["TestNum"].Value.ToString(), out int keyValue))
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

        private void label14_Click(object sender, EventArgs e)
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
    }
}

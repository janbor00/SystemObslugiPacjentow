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
    public partial class Receptionists : Form
    {
        public Receptionists()
        {
            InitializeComponent();
            DisplayRec();
            if (Login.Role == "Receptionist")
            {
                RecepLink.Enabled = false;
                DocLink.Enabled = false;
                LabLink.Enabled = false;
                PatLink.Enabled = true;
                LogoutLink.Enabled = true;
            }
            if (Login.Role == "Administrator")
            {
                RecepLink.Enabled = true;
                DocLink.Enabled = true;
                LabLink.Enabled = true;
                PatLink.Enabled = false;
                LogoutLink.Enabled = true;
            }
            if (Login.Role == "Doctor")
            {
                RecepLink.Enabled = false;
                DocLink.Enabled = false;
                LabLink.Enabled = false;
                PatLink.Enabled = false;
                LogoutLink.Enabled = true;
            }
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\janbo\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30;");
        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select the receptionist");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM  ReceptionistTbl WHERE RecepId=@RKey", Con);

                    cmd.Parameters.AddWithValue("@RKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Receptionist deleted");
                    Con.Close();
                    DisplayRec();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void DisplayRec()
        {
            Con.Open();
            string query = "Select * from ReceptionistTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ReceptionistDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (RNameTb.Text == "" || RPassword.Text == "" || RPhoneTb.Text == "" || RAddressTb.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ReceptionistTbl(RecepName, RecepPhone, RecepAdd, RecepPass)values(@RN, @RP, @RA,@RPA)", Con);
                    cmd.Parameters.AddWithValue("@RN", RNameTb.Text);
                    cmd.Parameters.AddWithValue("@RP", RPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@RA", RAddressTb.Text);
                    cmd.Parameters.AddWithValue("@RPA", RPassword.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Receptionist added");
                    Con.Close();
                    DisplayRec();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        int Key = 0;

        private void ReceptionistDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure we have a valid row index
            if (e.RowIndex != -1)
            {
                RNameTb.Text = ReceptionistDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                RPhoneTb.Text = ReceptionistDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                RAddressTb.Text = ReceptionistDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                RPassword.Text = ReceptionistDGV.Rows[e.RowIndex].Cells[4].Value.ToString();

                // Safely try to get the key value
                if (int.TryParse(ReceptionistDGV.Rows[e.RowIndex].Cells[0].Value.ToString(), out int keyValue))
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

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RNameTb.Text) ||
                string.IsNullOrWhiteSpace(RPassword.Text) ||
                string.IsNullOrWhiteSpace(RPhoneTb.Text) ||
                string.IsNullOrWhiteSpace(RAddressTb.Text))
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE ReceptionistTbl SET RecepName=@RN, RecepPhone=@RP, RecepAdd=@RA, RecepPass=@RPA WHERE RecepId=@RKey", Con);
                    cmd.Parameters.AddWithValue("@RN", RNameTb.Text);
                    cmd.Parameters.AddWithValue("@RP", RPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@RA", RAddressTb.Text);
                    cmd.Parameters.AddWithValue("@RPA", RPassword.Text);
                    cmd.Parameters.AddWithValue("@RKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Receptionist Updated Successfully");
                    Con.Close();
                    DisplayRec();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void Clear()
        {
            RNameTb.Text = "";
            RPassword.Text = "";
            RPhoneTb.Text = "";
            RAddressTb.Text = "";
            Key = 0;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PatLink_Click(object sender, EventArgs e)
        {
            Patients Obj = new Patients();
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
    }
}

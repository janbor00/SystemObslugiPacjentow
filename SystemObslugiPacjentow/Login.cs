using System.Data;
using System.Data.SqlClient;

namespace SystemObslugiPacjentow
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string Role;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\janbo\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30;");
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(RoleDb.SelectedItem == null)
            {
                MessageBox.Show("Select your Role");
            }
            else if(RoleDb.SelectedIndex == 0)
            {
                if(LoginUsrnmDb.Text == "" || LoginPassDb.Text == "") 
                {
                    MessageBox.Show("Enter Administrator login data");
                }
                else if(LoginUsrnmDb.Text == "Administrator" && LoginPassDb.Text == "Password")
                {
                    Role = "Administrator";
                    Homes Obj = new Homes();
                    Obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong administrator name or password");
                };
            }
            else if (RoleDb.SelectedIndex == 1)
            {
                if (LoginUsrnmDb.Text == "" || LoginPassDb.Text == "")
                {
                    MessageBox.Show("Enter Doctor login data");
                }
                else
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM DoctorTbl WHERE DocName='"+LoginUsrnmDb.Text+ "' AND DocPass='"+LoginPassDb.Text+"'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if(dt.Rows[0][0].ToString()=="1")
                    {
                        Role = "Doctor";
                        Homes Obj = new Homes();
                        Obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Doctor not found");
                    }
                    Con.Close();
                }
                  
            }
            else if (RoleDb.SelectedIndex == 2)
            {
                if (LoginUsrnmDb.Text == "" || LoginPassDb.Text == "")
                {
                    MessageBox.Show("Enter Receptionist login data");
                }
                else
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM ReceptionistTbl WHERE RecepName='" + LoginUsrnmDb.Text + "' AND RecepPass='" + LoginPassDb.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Role = "Receptionist";
                        Homes Obj = new Homes();
                        Obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Receptionist not found");
                    }
                    Con.Close();
                }
            }
        }

        private void RstBtn_Click(object sender, EventArgs e)
        {
            RoleDb.SelectedItem = 0;
            LoginUsrnmDb.Text = "";
            LoginPassDb.Text = "";
        }

        private void LoginExitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}

using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Shopping_Mart_Application_Project_video_55
{
    public partial class Login : Form
    {
        public static string Username = "";
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public Login()
        {
            InitializeComponent();

            // ✅ Set only background image from Resources
            this.BackgroundImage = Properties.Resources.background;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "Select * from signup where name = @user and password = @pass";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@user", USERNAME.Text);
            cmd.Parameters.AddWithValue("@pass", PASSWORD1.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                MessageBox.Show("Login SuccesFully Done", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Username = USERNAME.Text;
                this.Hide();
                Form1 MainForm = new Form1();
                MainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login Failed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool check = checkBox1.Checked;
            switch (check)
            {
                case true:
                    PASSWORD1.UseSystemPasswordChar = false;
                    break;

                default:
                    PASSWORD1.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp Su = new SignUp();
            this.Hide();
            Su.ShowDialog();
        }
    }
}

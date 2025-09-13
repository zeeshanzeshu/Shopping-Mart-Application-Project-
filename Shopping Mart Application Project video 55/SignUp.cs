using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Shopping_Mart_Application_Project_video_55
{
    public partial class SignUp : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public SignUp()
        {
            InitializeComponent();

            // 👇 Hide password text with dots
            PASSWORD.UseSystemPasswordChar = true;
            CONFIRM_PASSWORD.UseSystemPasswordChar = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void SIGNUPBTN_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into signup values (@name,@surname,@gender,@age,@address,@email,@pass)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", NAME.Text);
            cmd.Parameters.AddWithValue("@surname", SURNAME.Text);
            cmd.Parameters.AddWithValue("@gender", GENDER.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@age", AGE.Value);
            cmd.Parameters.AddWithValue("@address", ADDRESS.Text);
            cmd.Parameters.AddWithValue("@email", EMAIL.Text);
            cmd.Parameters.AddWithValue("@pass", PASSWORD.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Registered Successfully !!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Username is : " + NAME.Text, "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                Login loginform = new Login();
                loginform.ShowDialog();
            }
            else
            {
                MessageBox.Show("Registered FAILED !!", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }
    }
}

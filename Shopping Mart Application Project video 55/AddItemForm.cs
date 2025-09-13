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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Xml.Linq;

namespace Shopping_Mart_Application_Project_video_55
{
    public partial class AddItemForm : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public AddItemForm()
        {
            InitializeComponent();
        }

        private void INSERTBTN_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cs);
            string query = "INSERT INTO items (item_name, item_price, item_discount) VALUES (@name, @price, @discount)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", NAMETXTBOX.Text);
            cmd.Parameters.AddWithValue("@price", PRICETXTBOX.Text);
            cmd.Parameters.AddWithValue("@discount", DISCOUNTTXTBOX.Text);



            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show(" ITEM ADDED Successfully !!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
               NAMETXTBOX.Clear();
                PRICETXTBOX.Clear();
                DISCOUNTTXTBOX.Clear();
                NAMETXTBOX.Focus();
            }
            else
            {
                MessageBox.Show("ITEM ADDING FAILED !!", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            con.Close();

        }
    }
}

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

namespace Shopping_Mart_Application_Project_video_55
{
    public partial class Edit_Item_form : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Edit_Item_form()
        {
            InitializeComponent();
            BindGridView();
        }

        private void Edit_Item_form_Load(object sender, EventArgs e)
        {

        }
        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "Select * from items ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // ✅ Only fix added
            {
                IDTXTBOX.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                NAMETXTBOX.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                PRICETXTBOX.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                DISCOUNTTXTBOX.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void UPDATEBTN_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cs);
            string query = "Update items set item_name = @name, item_price = @price, item_discount = @discount where item_id = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", IDTXTBOX.Text); 
            cmd.Parameters.AddWithValue("@name", NAMETXTBOX.Text);
            cmd.Parameters.AddWithValue("@price", PRICETXTBOX.Text );
            cmd.Parameters.AddWithValue("@discount", DISCOUNTTXTBOX.Text);



            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show(" ITEM UPDATED Successfully !!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindGridView();
                NAMETXTBOX.Clear();
                PRICETXTBOX.Clear();
                DISCOUNTTXTBOX.Clear();
                NAMETXTBOX.Focus();
            }
            else
            {
                MessageBox.Show("ITEM UPDATION FAILED !!", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            con.Close();
        }

        private void DELETEBTN_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cs);
            string query = "Delete from items where item_id = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", IDTXTBOX.Text);
          



            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show(" ITEM DELETED Successfully !!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindGridView();
                IDTXTBOX.Clear();
                NAMETXTBOX.Clear();
                PRICETXTBOX.Clear();
                DISCOUNTTXTBOX.Clear();
                NAMETXTBOX.Focus();
            }
            else
            {
                MessageBox.Show("ITEM IS NOT DELETED !!", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            con.Close();
        }
    }
}

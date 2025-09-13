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
    public partial class ViewDataForm : Form
    {

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public ViewDataForm()
        {
            InitializeComponent();
            BindGridView();
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

        private void button1_Click(object sender, EventArgs e)
        {
            AddItemForm addItemForm = new AddItemForm();
            addItemForm.ShowDialog();
        }

        private void UPDATEBTN_Click(object sender, EventArgs e)
        {
            Edit_Item_form EditItemForm = new Edit_Item_form();
            EditItemForm.ShowDialog();
        }

        private void DELETEBTN_Click(object sender, EventArgs e)
        {
            Edit_Item_form EditItemForm = new Edit_Item_form();
            EditItemForm.ShowDialog();
        }

        private void ViewDataForm_Activated(object sender, EventArgs e)
        {
            BindGridView();
        }
    } 
}

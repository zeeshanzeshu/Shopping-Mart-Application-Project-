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
    public partial class Details_And_Search_Form : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public Details_And_Search_Form()
        {
            InitializeComponent();
            BindGridView();
        }
        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "sp_getBothTablesData";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void SEARCHBTN_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "sp_getBothTablesDataByInvoice";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@invoiceID",SEARCHTXTBOX.Text);
            SqlDataAdapter sda = new SqlDataAdapter();
            //sda.SelectCommand.Parameters.AddWithValue("@invoiceID",SEARCHTXTBOX.Text);
            sda.SelectCommand = cmd;
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            dataGridView1.Columns[10].Visible = false;
            FINAL_COST.Text =   dataGridView1.Rows[0].Cells[10].Value.ToString();
        }

        private void SEARCH_DATE_TIMEBTN_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cs);
            string query = "sp_getBothTablesDataByDateTime";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@firstDate", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@secondDate", dateTimePicker2.Value);
            SqlDataAdapter sda = new SqlDataAdapter();
            //sda.SelectCommand.Parameters.AddWithValue("@invoiceID",SEARCHTXTBOX.Text);
            sda.SelectCommand = cmd;
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            //dataGridView1.Columns[10].Visible = false;
            //FINAL_COST.Text = dataGridView1.Rows[0].Cells[10].Value.ToString();
        }

        private void RESETBTN_Click(object sender, EventArgs e)
        {
            BindGridView();
        }
    }
}

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Shopping_Mart_Application_Project_video_55
{
    public partial class Form1 : Form
    {
        int FinalCost = 0;
        int SrNo = 0;
        int tax = 0;
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form1()
        {

            InitializeComponent();
            getInvoiceId();
            USER.Text = Login.Username;
            GetItems();
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "SR NO";
            dataGridView1.Columns[1].Name = "ITEM NAME";
            dataGridView1.Columns[2].Name = "UNIT PER PRICE";
            dataGridView1.Columns[3].Name = "DISCOUNT PER ITEM";
            dataGridView1.Columns[4].Name = "QUANTITY";
            dataGridView1.Columns[5].Name = "SUB TOTAL";
            dataGridView1.Columns[6].Name = "TAX";
            dataGridView1.Columns[7].Name = "TOTAL COST";

        }
        void GetItems()
        {
            SELECT_ITEM.Items.Clear();
            SqlConnection con = new SqlConnection(cs);
            string query = "Select * from items";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                string item_name = sdr.GetString(1);
                SELECT_ITEM.Items.Add(item_name);
            }
            SELECT_ITEM.Sorted = true;
            con.Close();
        }
        void Get_Price()
        {
            if (SELECT_ITEM.SelectedItem == null)
            {

            }
            else
            {

                int price = 0;
                SqlConnection con = new SqlConnection(cs);
                string query = "Select item_price from items where item_name = @name";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@name", SELECT_ITEM.SelectedItem.ToString());
                DataTable data = new DataTable();
                sda.Fill(data);

                if (data.Rows.Count > 0)
                {
                    price = Convert.ToInt32(data.Rows[0]["item_price"]);

                }
                UNIT_PRICE.Text = price.ToString();

            }
        }
        void Get_Discount()
        {
            if (SELECT_ITEM.SelectedItem == null)
            {

            }
            else
            {
                int Discount = 0;
                SqlConnection con = new SqlConnection(cs);
                string query = "Select item_discount from items where item_name = @name";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@name", SELECT_ITEM.SelectedItem.ToString());
                DataTable data = new DataTable();
                sda.Fill(data);

                if (data.Rows.Count > 0)
                {
                    Discount = Convert.ToInt32(data.Rows[0]["item_discount"]);

                }
                DISCOUNT_PER_ITEM.Text = Discount.ToString();

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SELECT_ITEM_SelectedIndexChanged(object sender, EventArgs e)
        {
            Get_Price();
            Get_Discount();
            QUANTITY.Enabled = true;
        }

        private void QUANTITY_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(QUANTITY.Text) == true)
            {

            }
            else
            {
                int price = Convert.ToInt32(UNIT_PRICE.Text);
                int Discount = Convert.ToInt32(DISCOUNT_PER_ITEM.Text);
                int quantity = Convert.ToInt32(QUANTITY.Text);
                int Subtotal = price * quantity;
                Subtotal = Subtotal - Discount * quantity;
                SUB_TOTAL.Text = Subtotal.ToString();
            }
        }

        private void SUB_TOTAL_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SUB_TOTAL.Text) == true)
            {

            }
            else
            {
                int SubTotal = Convert.ToInt32(SUB_TOTAL.Text);
                if (SubTotal >= 10000)
                {
                    tax = (int)(SubTotal * 0.15);
                    TAX.Text = tax.ToString();
                }
                else if (SubTotal >= 6000)
                {
                    tax = (int)(SubTotal * 0.10);
                    TAX.Text = tax.ToString();
                }
                else if (SubTotal >= 3000)
                {
                    tax = (int)(SubTotal * 0.7);
                    TAX.Text = tax.ToString();
                }
                else if (SubTotal >= 1000)
                {
                    tax = (int)(SubTotal * 0.5);
                    TAX.Text = tax.ToString();
                }
                else
                {
                    tax = (int)(SubTotal * 0.3);
                    TAX.Text = tax.ToString();
                }

            }
        }

        private void TAX_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TAX.Text) == true)
            {

            }
            else
            {
                int SubTotal = Convert.ToInt32(SUB_TOTAL.Text);
                int tax = Convert.ToInt32(TAX.Text);
                int TotalCost = SubTotal + tax;
                TOTAL_COST.Text = TotalCost.ToString();
            }
        }
        void AddDataToGridView(string Sr_No, string item_name, string unit_price, string discount, string quantity, string sub_total, string tax, string total_cost)
        {
            string[] row = { Sr_No, item_name, unit_price, discount, quantity, sub_total, tax, total_cost };
            dataGridView1.Rows.Add(row);

        }

        private void ADD_BTN_Click(object sender, EventArgs e)
        {
            if(SELECT_ITEM.SelectedItem != null)
            {
                AddDataToGridView((++SrNo).ToString(), SELECT_ITEM.SelectedItem.ToString(), UNIT_PRICE.Text, DISCOUNT_PER_ITEM.Text, QUANTITY.Text, SUB_TOTAL.Text, TAX.Text, TOTAL_COST.Text);
                ResetControls();
                CalculateFinalCost();
            }
            else
            {
                MessageBox.Show("Please Select an Item");
            }

         
        }
        void ResetControls()
        {
            SELECT_ITEM.SelectedItem = null;
            UNIT_PRICE.Clear();
            DISCOUNT_PER_ITEM.Clear();
            QUANTITY.Clear();
            SUB_TOTAL.Clear();
            TAX.Clear();
            TOTAL_COST.Clear();
            FINAL_COST.Clear();
            AMOUNT_PAID.Clear();
            CHANGE.Clear();
            QUANTITY.Enabled = false;

        }
        void CalculateFinalCost()
        {
            FinalCost = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                FinalCost = FinalCost + Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value);
            }
            FINAL_COST.Text = FinalCost.ToString();
        }

        private void AMOUNT_PAID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AMOUNT_PAID.Text))
            {

            }
            else
            {
                int AmountPaid = Convert.ToInt32(AMOUNT_PAID.Text);
                int FCost = Convert.ToInt32(FINAL_COST.Text);
                int change = AmountPaid - FCost;
                CHANGE.Text = change.ToString();
            }

        }

        private void RESET_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        private void CLEAR_GRIDVIEW_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
        void getInvoiceId()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "Select invoice_id from order_master";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            if (data.Rows.Count < 1)
            {
                INVOICE.Text = "1";
            }
            else
            {
                string query2 = "Select max(invoice_id) from order_master";
                SqlCommand cmd = new SqlCommand(query2, con);
                con.Open();
                int a = Convert.ToInt32(cmd.ExecuteScalar());
                a = a + 1;
                INVOICE.Text = a.ToString();
                con.Close();


            }
        }

        private void INSERTBTN_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cs);
            string query = "INSERT into  order_master values (@id,@user,@datetime,@finalcost)";
            SqlCommand cmd = new SqlCommand(@query, con);
            cmd.Parameters.AddWithValue("@id", INVOICE.Text);
            cmd.Parameters.AddWithValue("@user", USER.Text);
            cmd.Parameters.AddWithValue("@datetime", DateTime.Now);
            cmd.Parameters.AddWithValue("@finalcost", FINAL_COST.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Inserted Successfully !!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getInvoiceId();
                ResetControls();
            }
            else
            {
                MessageBox.Show("Insertion Failed!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            con.Close();
            InsertIntoOrderDetails();


        }
        int  getLastInsertedInvoiceId()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "Select max(invoice_id) from order_master";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open(); 
            int MaxInvoiceId = Convert.ToInt32 (cmd.ExecuteScalar());

            con.Close();
            return MaxInvoiceId;
        }
        void InsertIntoOrderDetails()
        {
            int a = 0;
            SqlConnection con = new SqlConnection(cs);
            try
            {
                con.Open();

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    // Skip new row or empty rows
                    if (dataGridView1.Rows[i].IsNewRow || dataGridView1.Rows[i].Cells[1].Value == null)
                        continue;

                    string query = "INSERT INTO order_details VALUES (@invoice_id, @name, @price, @discount, @quantity, @subtotal, @tax, @finalcost)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    int invoiceId = getLastInsertedInvoiceId(); // make sure this isn't null or invalid
                    cmd.Parameters.AddWithValue("@invoice_id", invoiceId);
                    cmd.Parameters.AddWithValue("@name", dataGridView1.Rows[i].Cells[1].Value?.ToString() ?? "");
                    cmd.Parameters.AddWithValue("@price", dataGridView1.Rows[i].Cells[2].Value ?? 0);
                    cmd.Parameters.AddWithValue("@discount", dataGridView1.Rows[i].Cells[3].Value ?? 0);
                    cmd.Parameters.AddWithValue("@quantity", dataGridView1.Rows[i].Cells[4].Value ?? 0);
                    cmd.Parameters.AddWithValue("@subtotal", dataGridView1.Rows[i].Cells[5].Value ?? 0);
                    cmd.Parameters.AddWithValue("@tax", dataGridView1.Rows[i].Cells[6].Value ?? 0);
                    cmd.Parameters.AddWithValue("@finalcost", dataGridView1.Rows[i].Cells[7].Value ?? 0);

                    a += cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting into order_details:\n" + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }


        private void QUANTITY_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;

            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void AMOUNT_PAID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;

            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void PRINT_PREVIEW_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.RM;
            Image img = bmp;
            e.Graphics.DrawImage(img, 30,5,800,250 );
            e.Graphics.DrawString("INVOICE ID : " + INVOICE.Text,new Font("Arial",15,FontStyle.Bold),Brushes.Black, new Point(30,300));
            e.Graphics.DrawString("USERNAME : " + USER.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 330));
            e.Graphics.DrawString("DATE : " + DateTime.Now.ToShortDateString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 360));
            e.Graphics.DrawString("Time: " + DateTime.Now.ToLongTimeString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 390));
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------" , new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 420));
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 480));
            e.Graphics.DrawString("ITEM", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 450));
            e.Graphics.DrawString("PRICE", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(260, 450));
            e.Graphics.DrawString("DISCOUNT", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(400, 450));
            e.Graphics.DrawString("QUANTITY", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(600, 450));

            // item name
            int gap = 510;
            if (dataGridView1.Rows.Count > 0 )
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    try
                    {
                        if (dataGridView1.Rows[i].Cells[1].Value != null) // Check for null
                        {
                            e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(),
                                new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, gap));
                            gap += 30;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            // price
            int gap1 = 510;
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    try
                    {
                        if (dataGridView1.Rows[i].Cells[1].Value != null) // Check for null
                        {
                            e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(),new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(270, gap1));
                            gap1 += 30;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            // DISCOUNT
            int gap2 = 510;
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    try
                    {
                        if (dataGridView1.Rows[i].Cells[3].Value != null) // Check for null
                        {
                            e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(430, gap2));
                            gap2 += 30;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            // QUANTITY
            int gap3 = 510;
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    try
                    {
                        if (dataGridView1.Rows[i].Cells[4].Value != null) // Check for null
                        {
                            e.Graphics.DrawString(dataGridView1.Rows[i].Cells[4].Value.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(630, gap3));
                            gap3 += 30;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            //Sub_total
               int      Sub_Total_Print = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Sub_Total_Print = Sub_Total_Print + Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
            }
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 820));

            e.Graphics.DrawString("Sub-Total : " + Sub_Total_Print.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 850));


            /// Tax
            /// 

            int Tax_print = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Tax_print = Tax_print + Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value);
            }
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 820));

            e.Graphics.DrawString("Tax : " + Tax_print.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 880 ));
            e.Graphics.DrawString("Final_Amount : " + FINAL_COST.Text.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 910));
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 950));
            e.Graphics.DrawString("Amount_Paid : " + AMOUNT_PAID.Text.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 990));
            e.Graphics.DrawString("Change : " + CHANGE.Text.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 1030));


        }

        private void PRINTBTN_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItemForm adf = new AddItemForm();
            adf.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            GetItems();
        }

        private void existToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit_Item_form edf = new Edit_Item_form();
            edf.ShowDialog();
        }

        private void viewDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewDataForm VDF = new ViewDataForm();
            VDF.ShowDialog();
        }

        private void detailsAndSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Details_And_Search_Form das = new Details_And_Search_Form();
            das.ShowDialog();
        }
    }
}

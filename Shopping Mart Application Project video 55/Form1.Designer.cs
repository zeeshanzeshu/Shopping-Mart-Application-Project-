namespace Shopping_Mart_Application_Project_video_55
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.INVOICE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.USER = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SELECT_ITEM = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UNIT_PRICE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DISCOUNT_PER_ITEM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.QUANTITY = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SUB_TOTAL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TAX = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TOTAL_COST = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.FINAL_COST = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.AMOUNT_PAID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CHANGE = new System.Windows.Forms.TextBox();
            this.ADD_BTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RESET = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CLEAR_GRIDVIEW = new System.Windows.Forms.Button();
            this.INSERTBTN = new System.Windows.Forms.Button();
            this.PRINT_PREVIEW = new System.Windows.Forms.Button();
            this.PRINTBTN = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsAndSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "INVOICE NUMBER";
            // 
            // INVOICE
            // 
            this.INVOICE.Location = new System.Drawing.Point(21, 262);
            this.INVOICE.Name = "INVOICE";
            this.INVOICE.ReadOnly = true;
            this.INVOICE.Size = new System.Drawing.Size(222, 20);
            this.INVOICE.TabIndex = 2;
            this.INVOICE.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "USER";
            // 
            // USER
            // 
            this.USER.Location = new System.Drawing.Point(22, 317);
            this.USER.Name = "USER";
            this.USER.ReadOnly = true;
            this.USER.Size = new System.Drawing.Size(222, 20);
            this.USER.TabIndex = 2;
            this.USER.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "SELECT ITEM";
            // 
            // SELECT_ITEM
            // 
            this.SELECT_ITEM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SELECT_ITEM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SELECT_ITEM.FormattingEnabled = true;
            this.SELECT_ITEM.Location = new System.Drawing.Point(21, 369);
            this.SELECT_ITEM.Name = "SELECT_ITEM";
            this.SELECT_ITEM.Size = new System.Drawing.Size(222, 21);
            this.SELECT_ITEM.TabIndex = 0;
            this.SELECT_ITEM.SelectedIndexChanged += new System.EventHandler(this.SELECT_ITEM_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "UNIT PRICE";
            // 
            // UNIT_PRICE
            // 
            this.UNIT_PRICE.Location = new System.Drawing.Point(21, 424);
            this.UNIT_PRICE.Name = "UNIT_PRICE";
            this.UNIT_PRICE.ReadOnly = true;
            this.UNIT_PRICE.Size = new System.Drawing.Size(222, 20);
            this.UNIT_PRICE.TabIndex = 1;
            this.UNIT_PRICE.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "DISCOUNT PER ITEM";
            // 
            // DISCOUNT_PER_ITEM
            // 
            this.DISCOUNT_PER_ITEM.Location = new System.Drawing.Point(21, 478);
            this.DISCOUNT_PER_ITEM.Name = "DISCOUNT_PER_ITEM";
            this.DISCOUNT_PER_ITEM.ReadOnly = true;
            this.DISCOUNT_PER_ITEM.Size = new System.Drawing.Size(222, 20);
            this.DISCOUNT_PER_ITEM.TabIndex = 2;
            this.DISCOUNT_PER_ITEM.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(335, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "QUANTITY";
            // 
            // QUANTITY
            // 
            this.QUANTITY.Enabled = false;
            this.QUANTITY.Location = new System.Drawing.Point(335, 261);
            this.QUANTITY.MaxLength = 99;
            this.QUANTITY.Name = "QUANTITY";
            this.QUANTITY.Size = new System.Drawing.Size(192, 20);
            this.QUANTITY.TabIndex = 3;
            this.QUANTITY.TextChanged += new System.EventHandler(this.QUANTITY_TextChanged);
            this.QUANTITY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QUANTITY_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(332, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "SUB_TOTAL";
            // 
            // SUB_TOTAL
            // 
            this.SUB_TOTAL.Location = new System.Drawing.Point(335, 317);
            this.SUB_TOTAL.Name = "SUB_TOTAL";
            this.SUB_TOTAL.ReadOnly = true;
            this.SUB_TOTAL.Size = new System.Drawing.Size(192, 20);
            this.SUB_TOTAL.TabIndex = 4;
            this.SUB_TOTAL.TextChanged += new System.EventHandler(this.SUB_TOTAL_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(334, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "TAX";
            // 
            // TAX
            // 
            this.TAX.Location = new System.Drawing.Point(335, 369);
            this.TAX.Name = "TAX";
            this.TAX.ReadOnly = true;
            this.TAX.Size = new System.Drawing.Size(192, 20);
            this.TAX.TabIndex = 5;
            this.TAX.TextChanged += new System.EventHandler(this.TAX_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(335, 403);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "TOTAL_COST";
            // 
            // TOTAL_COST
            // 
            this.TOTAL_COST.Location = new System.Drawing.Point(335, 424);
            this.TOTAL_COST.Name = "TOTAL_COST";
            this.TOTAL_COST.ReadOnly = true;
            this.TOTAL_COST.Size = new System.Drawing.Size(192, 20);
            this.TOTAL_COST.TabIndex = 6;
            this.TOTAL_COST.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(332, 457);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "FINAL_COST";
            // 
            // FINAL_COST
            // 
            this.FINAL_COST.Location = new System.Drawing.Point(335, 478);
            this.FINAL_COST.Name = "FINAL_COST";
            this.FINAL_COST.ReadOnly = true;
            this.FINAL_COST.Size = new System.Drawing.Size(192, 20);
            this.FINAL_COST.TabIndex = 7;
            this.FINAL_COST.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(584, 241);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 18);
            this.label12.TabIndex = 1;
            this.label12.Text = "AMOUNT_PAID";
            // 
            // AMOUNT_PAID
            // 
            this.AMOUNT_PAID.Location = new System.Drawing.Point(583, 261);
            this.AMOUNT_PAID.Name = "AMOUNT_PAID";
            this.AMOUNT_PAID.Size = new System.Drawing.Size(192, 20);
            this.AMOUNT_PAID.TabIndex = 8;
            this.AMOUNT_PAID.TextChanged += new System.EventHandler(this.AMOUNT_PAID_TextChanged);
            this.AMOUNT_PAID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AMOUNT_PAID_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(582, 298);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 18);
            this.label13.TabIndex = 1;
            this.label13.Text = "CHANGE";
            // 
            // CHANGE
            // 
            this.CHANGE.Location = new System.Drawing.Point(583, 318);
            this.CHANGE.Name = "CHANGE";
            this.CHANGE.ReadOnly = true;
            this.CHANGE.Size = new System.Drawing.Size(192, 20);
            this.CHANGE.TabIndex = 9;
            this.CHANGE.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ADD_BTN
            // 
            this.ADD_BTN.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ADD_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD_BTN.Location = new System.Drawing.Point(21, 516);
            this.ADD_BTN.Name = "ADD_BTN";
            this.ADD_BTN.Size = new System.Drawing.Size(79, 37);
            this.ADD_BTN.TabIndex = 10;
            this.ADD_BTN.Text = "ADD";
            this.ADD_BTN.UseVisualStyleBackColor = false;
            this.ADD_BTN.Click += new System.EventHandler(this.ADD_BTN_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 561);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(764, 151);
            this.dataGridView1.TabIndex = 5;
            // 
            // RESET
            // 
            this.RESET.BackColor = System.Drawing.Color.Red;
            this.RESET.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RESET.Location = new System.Drawing.Point(129, 516);
            this.RESET.Name = "RESET";
            this.RESET.Size = new System.Drawing.Size(79, 37);
            this.RESET.TabIndex = 11;
            this.RESET.Text = "RESET";
            this.RESET.UseVisualStyleBackColor = false;
            this.RESET.Click += new System.EventHandler(this.RESET_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(772, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // CLEAR_GRIDVIEW
            // 
            this.CLEAR_GRIDVIEW.BackColor = System.Drawing.Color.MediumBlue;
            this.CLEAR_GRIDVIEW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLEAR_GRIDVIEW.Location = new System.Drawing.Point(589, 513);
            this.CLEAR_GRIDVIEW.Name = "CLEAR_GRIDVIEW";
            this.CLEAR_GRIDVIEW.Size = new System.Drawing.Size(186, 39);
            this.CLEAR_GRIDVIEW.TabIndex = 13;
            this.CLEAR_GRIDVIEW.Text = "CLEAR GRIDVIEW";
            this.CLEAR_GRIDVIEW.UseVisualStyleBackColor = false;
            this.CLEAR_GRIDVIEW.Click += new System.EventHandler(this.CLEAR_GRIDVIEW_Click);
            // 
            // INSERTBTN
            // 
            this.INSERTBTN.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.INSERTBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INSERTBTN.Location = new System.Drawing.Point(236, 516);
            this.INSERTBTN.Name = "INSERTBTN";
            this.INSERTBTN.Size = new System.Drawing.Size(98, 37);
            this.INSERTBTN.TabIndex = 11;
            this.INSERTBTN.Text = "INSERT";
            this.INSERTBTN.UseVisualStyleBackColor = false;
            this.INSERTBTN.Click += new System.EventHandler(this.INSERTBTN_Click);
            // 
            // PRINT_PREVIEW
            // 
            this.PRINT_PREVIEW.BackColor = System.Drawing.Color.IndianRed;
            this.PRINT_PREVIEW.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRINT_PREVIEW.Location = new System.Drawing.Point(583, 365);
            this.PRINT_PREVIEW.Name = "PRINT_PREVIEW";
            this.PRINT_PREVIEW.Size = new System.Drawing.Size(192, 56);
            this.PRINT_PREVIEW.TabIndex = 14;
            this.PRINT_PREVIEW.Text = "PRINT PREVIEW";
            this.PRINT_PREVIEW.UseVisualStyleBackColor = false;
            this.PRINT_PREVIEW.Click += new System.EventHandler(this.PRINT_PREVIEW_Click);
            // 
            // PRINTBTN
            // 
            this.PRINTBTN.BackColor = System.Drawing.Color.IndianRed;
            this.PRINTBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRINTBTN.Location = new System.Drawing.Point(583, 424);
            this.PRINTBTN.Name = "PRINTBTN";
            this.PRINTBTN.Size = new System.Drawing.Size(192, 56);
            this.PRINTBTN.TabIndex = 14;
            this.PRINTBTN.Text = "PRINT ";
            this.PRINTBTN.UseVisualStyleBackColor = false;
            this.PRINTBTN.Click += new System.EventHandler(this.PRINTBTN_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.existToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.editToolStripMenuItem.Text = "Add Item";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // existToolStripMenuItem
            // 
            this.existToolStripMenuItem.Name = "existToolStripMenuItem";
            this.existToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.existToolStripMenuItem.Text = "Exist";
            this.existToolStripMenuItem.Click += new System.EventHandler(this.existToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editItemToolStripMenuItem});
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // editItemToolStripMenuItem
            // 
            this.editItemToolStripMenuItem.Name = "editItemToolStripMenuItem";
            this.editItemToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.editItemToolStripMenuItem.Text = "Edit Item";
            this.editItemToolStripMenuItem.Click += new System.EventHandler(this.editItemToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDataToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // viewDataToolStripMenuItem
            // 
            this.viewDataToolStripMenuItem.Name = "viewDataToolStripMenuItem";
            this.viewDataToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.viewDataToolStripMenuItem.Text = "View Data";
            this.viewDataToolStripMenuItem.Click += new System.EventHandler(this.viewDataToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailsAndSearchToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItem1.Text = "Details";
            // 
            // detailsAndSearchToolStripMenuItem
            // 
            this.detailsAndSearchToolStripMenuItem.Name = "detailsAndSearchToolStripMenuItem";
            this.detailsAndSearchToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.detailsAndSearchToolStripMenuItem.Text = "Details and Search";
            this.detailsAndSearchToolStripMenuItem.Click += new System.EventHandler(this.detailsAndSearchToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 713);
            this.Controls.Add(this.PRINTBTN);
            this.Controls.Add(this.PRINT_PREVIEW);
            this.Controls.Add(this.CLEAR_GRIDVIEW);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.INSERTBTN);
            this.Controls.Add(this.RESET);
            this.Controls.Add(this.ADD_BTN);
            this.Controls.Add(this.SELECT_ITEM);
            this.Controls.Add(this.CHANGE);
            this.Controls.Add(this.AMOUNT_PAID);
            this.Controls.Add(this.FINAL_COST);
            this.Controls.Add(this.TOTAL_COST);
            this.Controls.Add(this.TAX);
            this.Controls.Add(this.SUB_TOTAL);
            this.Controls.Add(this.QUANTITY);
            this.Controls.Add(this.DISCOUNT_PER_ITEM);
            this.Controls.Add(this.UNIT_PRICE);
            this.Controls.Add(this.USER);
            this.Controls.Add(this.INVOICE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox INVOICE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox USER;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SELECT_ITEM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UNIT_PRICE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DISCOUNT_PER_ITEM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox QUANTITY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SUB_TOTAL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TAX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TOTAL_COST;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox FINAL_COST;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox AMOUNT_PAID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox CHANGE;
        private System.Windows.Forms.Button ADD_BTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button RESET;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CLEAR_GRIDVIEW;
        private System.Windows.Forms.Button INSERTBTN;
        private System.Windows.Forms.Button PRINT_PREVIEW;
        private System.Windows.Forms.Button PRINTBTN;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem existToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem detailsAndSearchToolStripMenuItem;
    }
}


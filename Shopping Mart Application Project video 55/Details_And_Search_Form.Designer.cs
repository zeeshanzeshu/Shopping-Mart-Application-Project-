namespace Shopping_Mart_Application_Project_video_55
{
    partial class Details_And_Search_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Details_And_Search_Form));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SEARCHTXTBOX = new System.Windows.Forms.TextBox();
            this.SEARCHBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FINAL_COST = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SEARCH_DATE_TIMEBTN = new System.Windows.Forms.Button();
            this.RESETBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(627, 191);
            this.dataGridView1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(627, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "SEARCH BY INVOICE ID";
            // 
            // SEARCHTXTBOX
            // 
            this.SEARCHTXTBOX.Location = new System.Drawing.Point(24, 189);
            this.SEARCHTXTBOX.Name = "SEARCHTXTBOX";
            this.SEARCHTXTBOX.Size = new System.Drawing.Size(182, 20);
            this.SEARCHTXTBOX.TabIndex = 7;
            // 
            // SEARCHBTN
            // 
            this.SEARCHBTN.BackColor = System.Drawing.Color.IndianRed;
            this.SEARCHBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEARCHBTN.Location = new System.Drawing.Point(24, 216);
            this.SEARCHBTN.Name = "SEARCHBTN";
            this.SEARCHBTN.Size = new System.Drawing.Size(102, 31);
            this.SEARCHBTN.TabIndex = 8;
            this.SEARCHBTN.Text = "SEARCH";
            this.SEARCHBTN.UseVisualStyleBackColor = false;
            this.SEARCHBTN.Click += new System.EventHandler(this.SEARCHBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "FINAL COST";
            // 
            // FINAL_COST
            // 
            this.FINAL_COST.Location = new System.Drawing.Point(123, 277);
            this.FINAL_COST.Name = "FINAL_COST";
            this.FINAL_COST.ReadOnly = true;
            this.FINAL_COST.Size = new System.Drawing.Size(109, 20);
            this.FINAL_COST.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(301, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "FIRST DATE TIME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(301, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "SECOND DATE TIME";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss:tt";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(304, 189);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "MM/dd/yyyy hh:mm:ss:tt";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(304, 252);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // SEARCH_DATE_TIMEBTN
            // 
            this.SEARCH_DATE_TIMEBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SEARCH_DATE_TIMEBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEARCH_DATE_TIMEBTN.Location = new System.Drawing.Point(304, 281);
            this.SEARCH_DATE_TIMEBTN.Name = "SEARCH_DATE_TIMEBTN";
            this.SEARCH_DATE_TIMEBTN.Size = new System.Drawing.Size(92, 28);
            this.SEARCH_DATE_TIMEBTN.TabIndex = 8;
            this.SEARCH_DATE_TIMEBTN.Text = "SEARCH";
            this.SEARCH_DATE_TIMEBTN.UseVisualStyleBackColor = false;
            this.SEARCH_DATE_TIMEBTN.Click += new System.EventHandler(this.SEARCH_DATE_TIMEBTN_Click);
            // 
            // RESETBTN
            // 
            this.RESETBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RESETBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RESETBTN.Location = new System.Drawing.Point(411, 281);
            this.RESETBTN.Name = "RESETBTN";
            this.RESETBTN.Size = new System.Drawing.Size(90, 28);
            this.RESETBTN.TabIndex = 8;
            this.RESETBTN.Text = "RESET";
            this.RESETBTN.UseVisualStyleBackColor = false;
            this.RESETBTN.Click += new System.EventHandler(this.RESETBTN_Click);
            // 
            // Details_And_Search_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(627, 511);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.FINAL_COST);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RESETBTN);
            this.Controls.Add(this.SEARCH_DATE_TIMEBTN);
            this.Controls.Add(this.SEARCHBTN);
            this.Controls.Add(this.SEARCHTXTBOX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Details_And_Search_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Details_And_Search_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SEARCHTXTBOX;
        private System.Windows.Forms.Button SEARCHBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FINAL_COST;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button SEARCH_DATE_TIMEBTN;
        private System.Windows.Forms.Button RESETBTN;
    }
}
namespace Shopping_Mart_Application_Project_video_55
{
    partial class ViewDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewDataForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ADDBTN = new System.Windows.Forms.Button();
            this.UPDATEBTN = new System.Windows.Forms.Button();
            this.DELETEBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(627, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(246, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "VIEW DATA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(504, 198);
            this.dataGridView1.TabIndex = 6;
            // 
            // ADDBTN
            // 
            this.ADDBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ADDBTN.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDBTN.Location = new System.Drawing.Point(129, 405);
            this.ADDBTN.Name = "ADDBTN";
            this.ADDBTN.Size = new System.Drawing.Size(126, 45);
            this.ADDBTN.TabIndex = 7;
            this.ADDBTN.Text = "ADD ITEM";
            this.ADDBTN.UseVisualStyleBackColor = false;
            this.ADDBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // UPDATEBTN
            // 
            this.UPDATEBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.UPDATEBTN.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDATEBTN.Location = new System.Drawing.Point(261, 405);
            this.UPDATEBTN.Name = "UPDATEBTN";
            this.UPDATEBTN.Size = new System.Drawing.Size(126, 45);
            this.UPDATEBTN.TabIndex = 7;
            this.UPDATEBTN.Text = "UPDATE ITEM";
            this.UPDATEBTN.UseVisualStyleBackColor = false;
            this.UPDATEBTN.Click += new System.EventHandler(this.UPDATEBTN_Click);
            // 
            // DELETEBTN
            // 
            this.DELETEBTN.BackColor = System.Drawing.Color.Red;
            this.DELETEBTN.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETEBTN.Location = new System.Drawing.Point(393, 405);
            this.DELETEBTN.Name = "DELETEBTN";
            this.DELETEBTN.Size = new System.Drawing.Size(126, 45);
            this.DELETEBTN.TabIndex = 7;
            this.DELETEBTN.Text = "DELETE ITEM";
            this.DELETEBTN.UseVisualStyleBackColor = false;
            this.DELETEBTN.Click += new System.EventHandler(this.DELETEBTN_Click);
            // 
            // ViewDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(629, 462);
            this.Controls.Add(this.DELETEBTN);
            this.Controls.Add(this.UPDATEBTN);
            this.Controls.Add(this.ADDBTN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "ViewDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewDataForm";
            this.Activated += new System.EventHandler(this.ViewDataForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ADDBTN;
        private System.Windows.Forms.Button UPDATEBTN;
        private System.Windows.Forms.Button DELETEBTN;
    }
}
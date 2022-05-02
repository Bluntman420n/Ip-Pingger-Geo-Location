namespace Ip_Pigger_Geo_Location
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Geo_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TimesToRun = new System.Windows.Forms.NumericUpDown();
            this.Ping_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TimeZone_Lab = new System.Windows.Forms.Label();
            this.Zip_Lab = new System.Windows.Forms.Label();
            this.Lat_Lab = new System.Windows.Forms.Label();
            this.Region_Lab = new System.Windows.Forms.Label();
            this.County_Lab = new System.Windows.Forms.Label();
            this.City_Lab = new System.Windows.Forms.Label();
            this.ISP_Lab = new System.Windows.Forms.Label();
            this.IP_Lab = new System.Windows.Forms.Label();
            this.Going = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Long_Lab = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimesToRun)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 450);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ip Address";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(4, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Validated += new System.EventHandler(this.textBox1_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("NSimSun", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ip Pingger\r\nGeo Location";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ip_Pigger_Geo_Location.Properties.Resources.Ip_Pigger_Geo_Location;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Geo_btn);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(4, 380);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 58);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Geo Location";
            // 
            // Geo_btn
            // 
            this.Geo_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Geo_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.Geo_btn.FlatAppearance.BorderSize = 2;
            this.Geo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Geo_btn.ForeColor = System.Drawing.Color.Transparent;
            this.Geo_btn.Location = new System.Drawing.Point(22, 19);
            this.Geo_btn.Name = "Geo_btn";
            this.Geo_btn.Size = new System.Drawing.Size(79, 25);
            this.Geo_btn.TabIndex = 2;
            this.Geo_btn.Text = "Grab";
            this.Geo_btn.UseVisualStyleBackColor = true;
            this.Geo_btn.Click += new System.EventHandler(this.Geo_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.TimesToRun);
            this.groupBox1.Controls.Add(this.Ping_btn);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(4, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 160);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pingger";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(22, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "How Many Times";
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(30, 68);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 23);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Non Stop";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // TimesToRun
            // 
            this.TimesToRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.TimesToRun.ForeColor = System.Drawing.Color.White;
            this.TimesToRun.Location = new System.Drawing.Point(35, 42);
            this.TimesToRun.Name = "TimesToRun";
            this.TimesToRun.Size = new System.Drawing.Size(54, 20);
            this.TimesToRun.TabIndex = 1;
            // 
            // Ping_btn
            // 
            this.Ping_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ping_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.Ping_btn.FlatAppearance.BorderSize = 2;
            this.Ping_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ping_btn.ForeColor = System.Drawing.Color.Transparent;
            this.Ping_btn.Location = new System.Drawing.Point(22, 97);
            this.Ping_btn.Name = "Ping_btn";
            this.Ping_btn.Size = new System.Drawing.Size(79, 25);
            this.Ping_btn.TabIndex = 0;
            this.Ping_btn.Text = "Ping";
            this.Ping_btn.UseVisualStyleBackColor = true;
            this.Ping_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblResult);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(153, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 407);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "IP Pingger Area";
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(6, 19);
            this.lblResult.Name = "lblResult";
            this.lblResult.ReadOnly = true;
            this.lblResult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.lblResult.Size = new System.Drawing.Size(295, 382);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Long_Lab);
            this.groupBox4.Controls.Add(this.TimeZone_Lab);
            this.groupBox4.Controls.Add(this.Zip_Lab);
            this.groupBox4.Controls.Add(this.Lat_Lab);
            this.groupBox4.Controls.Add(this.Region_Lab);
            this.groupBox4.Controls.Add(this.County_Lab);
            this.groupBox4.Controls.Add(this.City_Lab);
            this.groupBox4.Controls.Add(this.ISP_Lab);
            this.groupBox4.Controls.Add(this.IP_Lab);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(498, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(290, 407);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Geo Location Area";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // TimeZone_Lab
            // 
            this.TimeZone_Lab.AutoSize = true;
            this.TimeZone_Lab.Location = new System.Drawing.Point(38, 381);
            this.TimeZone_Lab.Name = "TimeZone_Lab";
            this.TimeZone_Lab.Size = new System.Drawing.Size(0, 13);
            this.TimeZone_Lab.TabIndex = 7;
            this.TimeZone_Lab.Click += new System.EventHandler(this.label11_Click);
            // 
            // Zip_Lab
            // 
            this.Zip_Lab.AutoSize = true;
            this.Zip_Lab.Location = new System.Drawing.Point(38, 333);
            this.Zip_Lab.Name = "Zip_Lab";
            this.Zip_Lab.Size = new System.Drawing.Size(0, 13);
            this.Zip_Lab.TabIndex = 6;
            this.Zip_Lab.Click += new System.EventHandler(this.Zip_Lab_Click);
            // 
            // Lat_Lab
            // 
            this.Lat_Lab.AutoSize = true;
            this.Lat_Lab.Location = new System.Drawing.Point(38, 254);
            this.Lat_Lab.Name = "Lat_Lab";
            this.Lat_Lab.Size = new System.Drawing.Size(0, 13);
            this.Lat_Lab.TabIndex = 5;
            // 
            // Region_Lab
            // 
            this.Region_Lab.AutoSize = true;
            this.Region_Lab.Location = new System.Drawing.Point(38, 204);
            this.Region_Lab.Name = "Region_Lab";
            this.Region_Lab.Size = new System.Drawing.Size(0, 13);
            this.Region_Lab.TabIndex = 4;
            // 
            // County_Lab
            // 
            this.County_Lab.AutoSize = true;
            this.County_Lab.Location = new System.Drawing.Point(38, 160);
            this.County_Lab.Name = "County_Lab";
            this.County_Lab.Size = new System.Drawing.Size(0, 13);
            this.County_Lab.TabIndex = 3;
            // 
            // City_Lab
            // 
            this.City_Lab.AutoSize = true;
            this.City_Lab.Location = new System.Drawing.Point(38, 119);
            this.City_Lab.Name = "City_Lab";
            this.City_Lab.Size = new System.Drawing.Size(0, 13);
            this.City_Lab.TabIndex = 2;
            // 
            // ISP_Lab
            // 
            this.ISP_Lab.AutoSize = true;
            this.ISP_Lab.Location = new System.Drawing.Point(38, 82);
            this.ISP_Lab.Name = "ISP_Lab";
            this.ISP_Lab.Size = new System.Drawing.Size(0, 13);
            this.ISP_Lab.TabIndex = 1;
            // 
            // IP_Lab
            // 
            this.IP_Lab.AutoSize = true;
            this.IP_Lab.Location = new System.Drawing.Point(38, 40);
            this.IP_Lab.Name = "IP_Lab";
            this.IP_Lab.Size = new System.Drawing.Size(0, 13);
            this.IP_Lab.TabIndex = 0;
            // 
            // Going
            // 
            this.Going.Interval = 800;
            this.Going.Tick += new System.EventHandler(this.Going_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Ip_Pigger_Geo_Location.Properties.Resources.close;
            this.pictureBox2.Location = new System.Drawing.Point(780, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Long_Lab
            // 
            this.Long_Lab.AutoSize = true;
            this.Long_Lab.Location = new System.Drawing.Point(38, 295);
            this.Long_Lab.Name = "Long_Lab";
            this.Long_Lab.Size = new System.Drawing.Size(0, 13);
            this.Long_Lab.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimesToRun)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Ping_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown TimesToRun;
        private System.Windows.Forms.Button Geo_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox lblResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer Going;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label IP_Lab;
        private System.Windows.Forms.Label TimeZone_Lab;
        private System.Windows.Forms.Label Zip_Lab;
        private System.Windows.Forms.Label Lat_Lab;
        private System.Windows.Forms.Label Region_Lab;
        private System.Windows.Forms.Label County_Lab;
        private System.Windows.Forms.Label City_Lab;
        private System.Windows.Forms.Label ISP_Lab;
        private System.Windows.Forms.Label Long_Lab;
    }
}


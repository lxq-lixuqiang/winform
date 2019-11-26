namespace MyBanGumiSys
{
    partial class FrmNewAnime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewAnime));
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnimeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboyears = new System.Windows.Forms.ComboBox();
            this.cbomon = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbotype6 = new System.Windows.Forms.CheckBox();
            this.cbotype4 = new System.Windows.Forms.CheckBox();
            this.cbotype5 = new System.Windows.Forms.CheckBox();
            this.cbotype2 = new System.Windows.Forms.CheckBox();
            this.cbotype3 = new System.Windows.Forms.CheckBox();
            this.cbotype1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtneirong = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnimeTime = new System.Windows.Forms.TextBox();
            this.txtAnimeImg = new System.Windows.Forms.TextBox();
            this.txttype1 = new System.Windows.Forms.TextBox();
            this.cbopalygeshi = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称:";
            // 
            // txtAnimeName
            // 
            this.txtAnimeName.Location = new System.Drawing.Point(317, 159);
            this.txtAnimeName.Name = "txtAnimeName";
            this.txtAnimeName.Size = new System.Drawing.Size(253, 25);
            this.txtAnimeName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "年份:";
            // 
            // cboyears
            // 
            this.cboyears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboyears.FormattingEnabled = true;
            this.cboyears.Items.AddRange(new object[] {
            "2017",
            "2016",
            "2015",
            "2014"});
            this.cboyears.Location = new System.Drawing.Point(317, 204);
            this.cboyears.Name = "cboyears";
            this.cboyears.Size = new System.Drawing.Size(80, 23);
            this.cboyears.TabIndex = 2;
            // 
            // cbomon
            // 
            this.cbomon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomon.FormattingEnabled = true;
            this.cbomon.Items.AddRange(new object[] {
            "春",
            "夏",
            "秋",
            "冬"});
            this.cbomon.Location = new System.Drawing.Point(448, 204);
            this.cbomon.Name = "cbomon";
            this.cbomon.Size = new System.Drawing.Size(51, 23);
            this.cbomon.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbotype6);
            this.panel1.Controls.Add(this.cbotype4);
            this.panel1.Controls.Add(this.cbotype5);
            this.panel1.Controls.Add(this.cbotype2);
            this.panel1.Controls.Add(this.cbotype3);
            this.panel1.Controls.Add(this.cbotype1);
            this.panel1.Location = new System.Drawing.Point(317, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 80);
            this.panel1.TabIndex = 3;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // cbotype6
            // 
            this.cbotype6.AutoSize = true;
            this.cbotype6.Location = new System.Drawing.Point(164, 51);
            this.cbotype6.Name = "cbotype6";
            this.cbotype6.Size = new System.Drawing.Size(59, 19);
            this.cbotype6.TabIndex = 4;
            this.cbotype6.Text = "日常";
            this.cbotype6.UseVisualStyleBackColor = true;
            this.cbotype6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // cbotype4
            // 
            this.cbotype4.AutoSize = true;
            this.cbotype4.Location = new System.Drawing.Point(89, 51);
            this.cbotype4.Name = "cbotype4";
            this.cbotype4.Size = new System.Drawing.Size(59, 19);
            this.cbotype4.TabIndex = 4;
            this.cbotype4.Text = "后宫";
            this.cbotype4.UseVisualStyleBackColor = true;
            this.cbotype4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // cbotype5
            // 
            this.cbotype5.AutoSize = true;
            this.cbotype5.Location = new System.Drawing.Point(164, 9);
            this.cbotype5.Name = "cbotype5";
            this.cbotype5.Size = new System.Drawing.Size(59, 19);
            this.cbotype5.TabIndex = 2;
            this.cbotype5.Text = "热血";
            this.cbotype5.UseVisualStyleBackColor = true;
            this.cbotype5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // cbotype2
            // 
            this.cbotype2.AutoSize = true;
            this.cbotype2.Location = new System.Drawing.Point(89, 9);
            this.cbotype2.Name = "cbotype2";
            this.cbotype2.Size = new System.Drawing.Size(59, 19);
            this.cbotype2.TabIndex = 2;
            this.cbotype2.Text = "机战";
            this.cbotype2.UseVisualStyleBackColor = true;
            this.cbotype2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // cbotype3
            // 
            this.cbotype3.AutoSize = true;
            this.cbotype3.Location = new System.Drawing.Point(8, 51);
            this.cbotype3.Name = "cbotype3";
            this.cbotype3.Size = new System.Drawing.Size(59, 19);
            this.cbotype3.TabIndex = 3;
            this.cbotype3.Text = "搞笑";
            this.cbotype3.UseVisualStyleBackColor = true;
            this.cbotype3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // cbotype1
            // 
            this.cbotype1.AutoSize = true;
            this.cbotype1.Location = new System.Drawing.Point(8, 9);
            this.cbotype1.Name = "cbotype1";
            this.cbotype1.Size = new System.Drawing.Size(59, 19);
            this.cbotype1.TabIndex = 1;
            this.cbotype1.Text = "校园";
            this.cbotype1.UseVisualStyleBackColor = true;
            this.cbotype1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "类型:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "内容:";
            // 
            // txtneirong
            // 
            this.txtneirong.Location = new System.Drawing.Point(317, 351);
            this.txtneirong.Multiline = true;
            this.txtneirong.Name = "txtneirong";
            this.txtneirong.Size = new System.Drawing.Size(253, 68);
            this.txtneirong.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(822, 96);
            this.panel2.TabIndex = 7;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("宋体", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(224)))), ((int)(((byte)(219)))));
            this.label10.Location = new System.Drawing.Point(599, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 42);
            this.label10.TabIndex = 0;
            this.label10.Text = "动 漫";
            this.label10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.label10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.label10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 372);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(243, 218);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(578, 373);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(243, 218);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(403, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "年";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(501, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "季";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnSelect);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.txtneirong);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cboyears);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtAnimeTime);
            this.panel3.Controls.Add(this.txtAnimeImg);
            this.panel3.Controls.Add(this.txttype1);
            this.panel3.Controls.Add(this.txtAnimeName);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.cbomon);
            this.panel3.Controls.Add(this.cbopalygeshi);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(822, 592);
            this.panel3.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 491);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "上传时间:";
            // 
            // btnSelect
            // 
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelect.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelect.Location = new System.Drawing.Point(578, 116);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(80, 25);
            this.btnSelect.TabIndex = 9;
            this.btnSelect.Text = "浏 览";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(287, 536);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "确 定";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(440, 539);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "取 消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(233, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "动漫图片:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "视频格式:";
            // 
            // txtAnimeTime
            // 
            this.txtAnimeTime.Enabled = false;
            this.txtAnimeTime.Location = new System.Drawing.Point(314, 486);
            this.txtAnimeTime.Name = "txtAnimeTime";
            this.txtAnimeTime.Size = new System.Drawing.Size(253, 25);
            this.txtAnimeTime.TabIndex = 1;
            // 
            // txtAnimeImg
            // 
            this.txtAnimeImg.Enabled = false;
            this.txtAnimeImg.Location = new System.Drawing.Point(317, 116);
            this.txtAnimeImg.Name = "txtAnimeImg";
            this.txtAnimeImg.Size = new System.Drawing.Size(253, 25);
            this.txtAnimeImg.TabIndex = 1;
            // 
            // txttype1
            // 
            this.txttype1.Enabled = false;
            this.txttype1.Location = new System.Drawing.Point(317, 319);
            this.txttype1.Name = "txttype1";
            this.txttype1.Size = new System.Drawing.Size(253, 25);
            this.txttype1.TabIndex = 1;
            // 
            // cbopalygeshi
            // 
            this.cbopalygeshi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbopalygeshi.FormattingEnabled = true;
            this.cbopalygeshi.Items.AddRange(new object[] {
            "mkv",
            "3gp",
            "mp4",
            "flv"});
            this.cbopalygeshi.Location = new System.Drawing.Point(317, 444);
            this.cbopalygeshi.Name = "cbopalygeshi";
            this.cbopalygeshi.Size = new System.Drawing.Size(70, 23);
            this.cbopalygeshi.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.InitialDirectory = "f:\\";
            // 
            // FrmNewAnime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(822, 592);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmNewAnime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新动漫";
            this.Load += new System.EventHandler(this.FrmSelectAnime_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnimeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboyears;
        private System.Windows.Forms.ComboBox cbomon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbotype1;
        private System.Windows.Forms.CheckBox cbotype4;
        private System.Windows.Forms.CheckBox cbotype2;
        private System.Windows.Forms.CheckBox cbotype3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtneirong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbopalygeshi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAnimeImg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.CheckBox cbotype6;
        private System.Windows.Forms.CheckBox cbotype5;
        private System.Windows.Forms.TextBox txttype1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAnimeTime;
    }
}
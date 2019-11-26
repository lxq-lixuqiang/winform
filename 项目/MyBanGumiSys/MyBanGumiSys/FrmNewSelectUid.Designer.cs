namespace MyBanGumiSys
{
    partial class FrmNewSelectUid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewSelectUid));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rtnSexnv = new System.Windows.Forms.RadioButton();
            this.rbnSexnan = new System.Windows.Forms.RadioButton();
            this.txtUidEmil = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUidPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUidPwdque = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUidPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUidName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.Location = new System.Drawing.Point(260, 477);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 30);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "确 定";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Location = new System.Drawing.Point(395, 477);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 30);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "取 消";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(205)))), ((int)(((byte)(216)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 151);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新宋体", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(232, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "注 册";
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtUidEmil);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtUidPhone);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtUidPwdque);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtUidPwd);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtUidName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 533);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rtnSexnv);
            this.panel3.Controls.Add(this.rbnSexnan);
            this.panel3.Location = new System.Drawing.Point(296, 306);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(224, 52);
            this.panel3.TabIndex = 4;
            // 
            // rtnSexnv
            // 
            this.rtnSexnv.AutoSize = true;
            this.rtnSexnv.Location = new System.Drawing.Point(124, 15);
            this.rtnSexnv.Name = "rtnSexnv";
            this.rtnSexnv.Size = new System.Drawing.Size(43, 19);
            this.rtnSexnv.TabIndex = 4;
            this.rtnSexnv.Text = "女";
            this.rtnSexnv.UseVisualStyleBackColor = true;
            // 
            // rbnSexnan
            // 
            this.rbnSexnan.AutoSize = true;
            this.rbnSexnan.Checked = true;
            this.rbnSexnan.Location = new System.Drawing.Point(27, 15);
            this.rbnSexnan.Name = "rbnSexnan";
            this.rbnSexnan.Size = new System.Drawing.Size(43, 19);
            this.rbnSexnan.TabIndex = 4;
            this.rbnSexnan.TabStop = true;
            this.rbnSexnan.Text = "男";
            this.rbnSexnan.UseVisualStyleBackColor = true;
            // 
            // txtUidEmil
            // 
            this.txtUidEmil.Location = new System.Drawing.Point(296, 418);
            this.txtUidEmil.Name = "txtUidEmil";
            this.txtUidEmil.Size = new System.Drawing.Size(224, 25);
            this.txtUidEmil.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "邮箱:";
            // 
            // txtUidPhone
            // 
            this.txtUidPhone.Location = new System.Drawing.Point(296, 371);
            this.txtUidPhone.Name = "txtUidPhone";
            this.txtUidPhone.Size = new System.Drawing.Size(224, 25);
            this.txtUidPhone.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "性别:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "电话:";
            // 
            // txtUidPwdque
            // 
            this.txtUidPwdque.Location = new System.Drawing.Point(296, 267);
            this.txtUidPwdque.Name = "txtUidPwdque";
            this.txtUidPwdque.Size = new System.Drawing.Size(224, 25);
            this.txtUidPwdque.TabIndex = 3;
            this.txtUidPwdque.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "再次确认密码:";
            // 
            // txtUidPwd
            // 
            this.txtUidPwd.Location = new System.Drawing.Point(296, 222);
            this.txtUidPwd.Name = "txtUidPwd";
            this.txtUidPwd.Size = new System.Drawing.Size(224, 25);
            this.txtUidPwd.TabIndex = 2;
            this.txtUidPwd.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码:";
            // 
            // txtUidName
            // 
            this.txtUidName.Location = new System.Drawing.Point(296, 176);
            this.txtUidName.Name = "txtUidName";
            this.txtUidName.Size = new System.Drawing.Size(224, 25);
            this.txtUidName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "用户名:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 357);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmNewSelectUid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(696, 533);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNewSelectUid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户注册";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtUidEmil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUidPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUidPwdque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUidPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUidName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbnSexnan;
        private System.Windows.Forms.RadioButton rtnSexnv;
    }
}
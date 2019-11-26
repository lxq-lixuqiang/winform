namespace MyBanGumiSys
{
    partial class FrmUid
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUid));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UidName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UidSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UidPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UidEmil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.修改用户信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除用户信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panUpdate = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.buttQX = new System.Windows.Forms.Button();
            this.buttXZ = new System.Windows.Forms.Button();
            this.textUidEmil = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textUidPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtuIdID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textUidName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbtnan = new System.Windows.Forms.RadioButton();
            this.rtnnv = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panUpdate.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(693, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "性 别:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(942, 19);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "查  询";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.UidName,
            this.UidSex,
            this.UidPhone,
            this.UidEmil});
            this.dataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 60);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1105, 450);
            this.dataGridView.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "用户号";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // UidName
            // 
            this.UidName.DataPropertyName = "UidName";
            this.UidName.HeaderText = "登录名";
            this.UidName.Name = "UidName";
            this.UidName.ReadOnly = true;
            // 
            // UidSex
            // 
            this.UidSex.DataPropertyName = "UidSex";
            this.UidSex.HeaderText = "性别";
            this.UidSex.Name = "UidSex";
            this.UidSex.ReadOnly = true;
            // 
            // UidPhone
            // 
            this.UidPhone.DataPropertyName = "UidPhone";
            this.UidPhone.HeaderText = "电话";
            this.UidPhone.Name = "UidPhone";
            this.UidPhone.ReadOnly = true;
            // 
            // UidEmil
            // 
            this.UidEmil.DataPropertyName = "UidEmil";
            this.UidEmil.HeaderText = "邮箱";
            this.UidEmil.Name = "UidEmil";
            this.UidEmil.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改用户信息ToolStripMenuItem,
            this.删除用户信息ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(175, 56);
            // 
            // 修改用户信息ToolStripMenuItem
            // 
            this.修改用户信息ToolStripMenuItem.Name = "修改用户信息ToolStripMenuItem";
            this.修改用户信息ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.修改用户信息ToolStripMenuItem.Text = "修改用户信息";
            this.修改用户信息ToolStripMenuItem.Click += new System.EventHandler(this.修改用户信息ToolStripMenuItem_Click);
            // 
            // 删除用户信息ToolStripMenuItem
            // 
            this.删除用户信息ToolStripMenuItem.Name = "删除用户信息ToolStripMenuItem";
            this.删除用户信息ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.删除用户信息ToolStripMenuItem.Text = "删除用户信息";
            this.删除用户信息ToolStripMenuItem.Click += new System.EventHandler(this.删除用户信息ToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "全部",
            "男",
            "女"});
            this.comboBox1.Location = new System.Drawing.Point(757, 22);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(435, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "姓 名:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(500, 21);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 25);
            this.textBox1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 60);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(4, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "客户端";
            // 
            // panUpdate
            // 
            this.panUpdate.BackColor = System.Drawing.Color.White;
            this.panUpdate.Controls.Add(this.label9);
            this.panUpdate.Controls.Add(this.buttQX);
            this.panUpdate.Controls.Add(this.buttXZ);
            this.panUpdate.Controls.Add(this.textUidEmil);
            this.panUpdate.Controls.Add(this.label4);
            this.panUpdate.Controls.Add(this.textUidPhone);
            this.panUpdate.Controls.Add(this.label5);
            this.panUpdate.Controls.Add(this.label6);
            this.panUpdate.Controls.Add(this.txtuIdID);
            this.panUpdate.Controls.Add(this.label7);
            this.panUpdate.Controls.Add(this.textUidName);
            this.panUpdate.Controls.Add(this.label8);
            this.panUpdate.Controls.Add(this.panel3);
            this.panUpdate.Controls.Add(this.panel2);
            this.panUpdate.Location = new System.Drawing.Point(742, 66);
            this.panUpdate.Name = "panUpdate";
            this.panUpdate.Size = new System.Drawing.Size(363, 441);
            this.panUpdate.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label9.Font = new System.Drawing.Font("楷体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(5, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 27);
            this.label9.TabIndex = 17;
            this.label9.Text = "修改信息";
            // 
            // buttQX
            // 
            this.buttQX.FlatAppearance.BorderSize = 0;
            this.buttQX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttQX.Location = new System.Drawing.Point(226, 400);
            this.buttQX.Margin = new System.Windows.Forms.Padding(4);
            this.buttQX.Name = "buttQX";
            this.buttQX.Size = new System.Drawing.Size(100, 29);
            this.buttQX.TabIndex = 14;
            this.buttQX.Text = "取  消";
            this.buttQX.UseVisualStyleBackColor = true;
            this.buttQX.Click += new System.EventHandler(this.buttQX_Click);
            // 
            // buttXZ
            // 
            this.buttXZ.FlatAppearance.BorderSize = 0;
            this.buttXZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttXZ.Location = new System.Drawing.Point(67, 400);
            this.buttXZ.Margin = new System.Windows.Forms.Padding(4);
            this.buttXZ.Name = "buttXZ";
            this.buttXZ.Size = new System.Drawing.Size(100, 29);
            this.buttXZ.TabIndex = 15;
            this.buttXZ.Text = "修  改";
            this.buttXZ.UseVisualStyleBackColor = true;
            this.buttXZ.Click += new System.EventHandler(this.buttXZ_Click);
            // 
            // textUidEmil
            // 
            this.textUidEmil.Location = new System.Drawing.Point(96, 336);
            this.textUidEmil.Margin = new System.Windows.Forms.Padding(4);
            this.textUidEmil.Name = "textUidEmil";
            this.textUidEmil.Size = new System.Drawing.Size(228, 25);
            this.textUidEmil.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 341);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "邮  箱";
            // 
            // textUidPhone
            // 
            this.textUidPhone.Location = new System.Drawing.Point(96, 279);
            this.textUidPhone.Margin = new System.Windows.Forms.Padding(4);
            this.textUidPhone.Name = "textUidPhone";
            this.textUidPhone.Size = new System.Drawing.Size(228, 25);
            this.textUidPhone.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 284);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "电  话";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 217);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "性  别";
            // 
            // txtuIdID
            // 
            this.txtuIdID.Enabled = false;
            this.txtuIdID.Location = new System.Drawing.Point(96, 101);
            this.txtuIdID.Margin = new System.Windows.Forms.Padding(4);
            this.txtuIdID.Name = "txtuIdID";
            this.txtuIdID.Size = new System.Drawing.Size(228, 25);
            this.txtuIdID.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 106);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "用户号";
            // 
            // textUidName
            // 
            this.textUidName.Location = new System.Drawing.Point(96, 152);
            this.textUidName.Margin = new System.Windows.Forms.Padding(4);
            this.textUidName.Name = "textUidName";
            this.textUidName.Size = new System.Drawing.Size(228, 25);
            this.textUidName.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 157);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "用户名";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbtnan);
            this.panel3.Controls.Add(this.rtnnv);
            this.panel3.Location = new System.Drawing.Point(96, 200);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 49);
            this.panel3.TabIndex = 16;
            // 
            // rbtnan
            // 
            this.rbtnan.AutoSize = true;
            this.rbtnan.Checked = true;
            this.rbtnan.Location = new System.Drawing.Point(15, 15);
            this.rbtnan.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnan.Name = "rbtnan";
            this.rbtnan.Size = new System.Drawing.Size(43, 19);
            this.rbtnan.TabIndex = 3;
            this.rbtnan.TabStop = true;
            this.rbtnan.Text = "男";
            this.rbtnan.UseVisualStyleBackColor = true;
            // 
            // rtnnv
            // 
            this.rtnnv.AutoSize = true;
            this.rtnnv.Location = new System.Drawing.Point(129, 15);
            this.rtnnv.Margin = new System.Windows.Forms.Padding(4);
            this.rtnnv.Name = "rtnnv";
            this.rtnnv.Size = new System.Drawing.Size(43, 19);
            this.rtnnv.TabIndex = 3;
            this.rtnnv.TabStop = true;
            this.rtnnv.Text = "女";
            this.rtnnv.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 61);
            this.panel2.TabIndex = 18;
            // 
            // FrmUid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1105, 510);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "客户端";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panUpdate.ResumeLayout(false);
            this.panUpdate.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 修改用户信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除用户信息ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panUpdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttQX;
        private System.Windows.Forms.Button buttXZ;
        private System.Windows.Forms.TextBox textUidEmil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textUidPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtuIdID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textUidName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbtnan;
        private System.Windows.Forms.RadioButton rtnnv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UidName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UidSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn UidPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn UidEmil;
    }
}


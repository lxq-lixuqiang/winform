namespace MyBanGumiSys
{
    partial class FrmChaXunAniam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChaXunAniam));
            this.label3 = new System.Windows.Forms.Label();
            this.cboAniam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvAnime = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmDean = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMy = new System.Windows.Forms.ToolStripMenuItem();
            this.imgdatupian = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(2, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "最近新番";
            // 
            // cboAniam
            // 
            this.cboAniam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAniam.FormattingEnabled = true;
            this.cboAniam.Location = new System.Drawing.Point(146, 52);
            this.cboAniam.Name = "cboAniam";
            this.cboAniam.Size = new System.Drawing.Size(121, 23);
            this.cboAniam.TabIndex = 2;
            this.cboAniam.SelectedIndexChanged += new System.EventHandler(this.cboAniam_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(54, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "最近时间:";
            // 
            // lvAnime
            // 
            this.lvAnime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvAnime.ContextMenuStrip = this.contextMenuStrip1;
            this.lvAnime.LargeImageList = this.imgdatupian;
            this.lvAnime.Location = new System.Drawing.Point(8, 92);
            this.lvAnime.Name = "lvAnime";
            this.lvAnime.Size = new System.Drawing.Size(760, 355);
            this.lvAnime.TabIndex = 4;
            this.lvAnime.UseCompatibleStateImageBehavior = false;
            this.lvAnime.SelectedIndexChanged += new System.EventHandler(this.lvAnime_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDean,
            this.tsmMy});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 56);
            // 
            // tsmDean
            // 
            this.tsmDean.Name = "tsmDean";
            this.tsmDean.Size = new System.Drawing.Size(144, 26);
            this.tsmDean.Text = "动漫介绍";
            this.tsmDean.Click += new System.EventHandler(this.tsmDean_Click);
            // 
            // tsmMy
            // 
            this.tsmMy.Name = "tsmMy";
            this.tsmMy.Size = new System.Drawing.Size(144, 26);
            this.tsmMy.Text = "加入收藏";
            this.tsmMy.Click += new System.EventHandler(this.tsmMy_Click);
            // 
            // imgdatupian
            // 
            this.imgdatupian.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgdatupian.ImageStream")));
            this.imgdatupian.TransparentColor = System.Drawing.Color.Transparent;
            this.imgdatupian.Images.SetKeyName(0, "1.jpg");
            this.imgdatupian.Images.SetKeyName(1, "2.jpg");
            this.imgdatupian.Images.SetKeyName(2, "3.jpg");
            this.imgdatupian.Images.SetKeyName(3, "4.jpg");
            this.imgdatupian.Images.SetKeyName(4, "5.jpg");
            this.imgdatupian.Images.SetKeyName(5, "6.jpg");
            this.imgdatupian.Images.SetKeyName(6, "7.jpg");
            this.imgdatupian.Images.SetKeyName(7, "8.jpg");
            this.imgdatupian.Images.SetKeyName(8, "9.jpg");
            this.imgdatupian.Images.SetKeyName(9, "10.jpg");
            this.imgdatupian.Images.SetKeyName(10, "11.jpg");
            this.imgdatupian.Images.SetKeyName(11, "12.jpg");
            this.imgdatupian.Images.SetKeyName(12, "13.jpg");
            this.imgdatupian.Images.SetKeyName(13, "14.jpg");
            this.imgdatupian.Images.SetKeyName(14, "15.jpg");
            this.imgdatupian.Images.SetKeyName(15, "16.jpg");
            this.imgdatupian.Images.SetKeyName(16, "17.jpg");
            this.imgdatupian.Images.SetKeyName(17, "18.jpg");
            this.imgdatupian.Images.SetKeyName(18, "19.jpg");
            this.imgdatupian.Images.SetKeyName(19, "20.jpg");
            this.imgdatupian.Images.SetKeyName(20, "21.jpg");
            this.imgdatupian.Images.SetKeyName(21, "22.jpg");
            this.imgdatupian.Images.SetKeyName(22, "23.jpg");
            this.imgdatupian.Images.SetKeyName(23, "24.jpg");
            this.imgdatupian.Images.SetKeyName(24, "25.jpg");
            this.imgdatupian.Images.SetKeyName(25, "26.jpg");
            this.imgdatupian.Images.SetKeyName(26, "27.jpg");
            this.imgdatupian.Images.SetKeyName(27, "28.jpg");
            this.imgdatupian.Images.SetKeyName(28, "29.jpg");
            this.imgdatupian.Images.SetKeyName(29, "30.jpg");
            this.imgdatupian.Images.SetKeyName(30, "31.jpg");
            this.imgdatupian.Images.SetKeyName(31, "32.jpg");
            this.imgdatupian.Images.SetKeyName(32, "33.jpg");
            this.imgdatupian.Images.SetKeyName(33, "34.jpg");
            this.imgdatupian.Images.SetKeyName(34, "35.jpg");
            this.imgdatupian.Images.SetKeyName(35, "36.jpg");
            this.imgdatupian.Images.SetKeyName(36, "37.jpg");
            this.imgdatupian.Images.SetKeyName(37, "38.jpg");
            this.imgdatupian.Images.SetKeyName(38, "39.jpg");
            this.imgdatupian.Images.SetKeyName(39, "40.jpg");
            this.imgdatupian.Images.SetKeyName(40, "41.jpg");
            this.imgdatupian.Images.SetKeyName(41, "42.jpg");
            this.imgdatupian.Images.SetKeyName(42, "43.jpg");
            this.imgdatupian.Images.SetKeyName(43, "44.jpg");
            this.imgdatupian.Images.SetKeyName(44, "45.jpg");
            this.imgdatupian.Images.SetKeyName(45, "46.jpg");
            this.imgdatupian.Images.SetKeyName(46, "47.jpg");
            this.imgdatupian.Images.SetKeyName(47, "48.jpg");
            this.imgdatupian.Images.SetKeyName(48, "49.jpg");
            this.imgdatupian.Images.SetKeyName(49, "50.jpg");
            this.imgdatupian.Images.SetKeyName(50, "51.jpg");
            this.imgdatupian.Images.SetKeyName(51, "52.jpg");
            this.imgdatupian.Images.SetKeyName(52, "53.jpg");
            this.imgdatupian.Images.SetKeyName(53, "54.jpg");
            this.imgdatupian.Images.SetKeyName(54, "55.jpg");
            this.imgdatupian.Images.SetKeyName(55, "56.jpg");
            this.imgdatupian.Images.SetKeyName(56, "57.jpg");
            this.imgdatupian.Images.SetKeyName(57, "58.jpg");
            this.imgdatupian.Images.SetKeyName(58, "59.jpg");
            this.imgdatupian.Images.SetKeyName(59, "60.jpg");
            this.imgdatupian.Images.SetKeyName(60, "61.jpg");
            this.imgdatupian.Images.SetKeyName(61, "62.jpg");
            this.imgdatupian.Images.SetKeyName(62, "63.jpg");
            this.imgdatupian.Images.SetKeyName(63, "64.jpg");
            this.imgdatupian.Images.SetKeyName(64, "65.jpg");
            this.imgdatupian.Images.SetKeyName(65, "66.jpg");
            this.imgdatupian.Images.SetKeyName(66, "67.jpg");
            this.imgdatupian.Images.SetKeyName(67, "68.jpg");
            this.imgdatupian.Images.SetKeyName(68, "69.jpg");
            this.imgdatupian.Images.SetKeyName(69, "70.jpg");
            this.imgdatupian.Images.SetKeyName(70, "71.jpg");
            this.imgdatupian.Images.SetKeyName(71, "72.jpg");
            this.imgdatupian.Images.SetKeyName(72, "73.jpg");
            this.imgdatupian.Images.SetKeyName(73, "74.jpg");
            this.imgdatupian.Images.SetKeyName(74, "75.jpg");
            this.imgdatupian.Images.SetKeyName(75, "76.jpg");
            this.imgdatupian.Images.SetKeyName(76, "77.jpg");
            this.imgdatupian.Images.SetKeyName(77, "78.jpg");
            this.imgdatupian.Images.SetKeyName(78, "79.jpg");
            this.imgdatupian.Images.SetKeyName(79, "80.jpg");
            this.imgdatupian.Images.SetKeyName(80, "81.jpg");
            this.imgdatupian.Images.SetKeyName(81, "82.jpg");
            this.imgdatupian.Images.SetKeyName(82, "83.jpg");
            this.imgdatupian.Images.SetKeyName(83, "84.jpg");
            this.imgdatupian.Images.SetKeyName(84, "85.jpg");
            this.imgdatupian.Images.SetKeyName(85, "86.jpg");
            this.imgdatupian.Images.SetKeyName(86, "87.jpg");
            this.imgdatupian.Images.SetKeyName(87, "88.jpg");
            this.imgdatupian.Images.SetKeyName(88, "89.jpg");
            this.imgdatupian.Images.SetKeyName(89, "90.jpg");
            this.imgdatupian.Images.SetKeyName(90, "91.jpg");
            this.imgdatupian.Images.SetKeyName(91, "92.jpg");
            this.imgdatupian.Images.SetKeyName(92, "93.jpg");
            this.imgdatupian.Images.SetKeyName(93, "94.jpg");
            this.imgdatupian.Images.SetKeyName(94, "95.jpg");
            this.imgdatupian.Images.SetKeyName(95, "96.jpg");
            this.imgdatupian.Images.SetKeyName(96, "97.jpg");
            this.imgdatupian.Images.SetKeyName(97, "98.jpg");
            this.imgdatupian.Images.SetKeyName(98, "99.jpg");
            this.imgdatupian.Images.SetKeyName(99, "100.jpg");
            this.imgdatupian.Images.SetKeyName(100, "101.jpg");
            this.imgdatupian.Images.SetKeyName(101, "102.jpg");
            this.imgdatupian.Images.SetKeyName(102, "103.jpg");
            this.imgdatupian.Images.SetKeyName(103, "104.jpg");
            this.imgdatupian.Images.SetKeyName(104, "105.jpg");
            this.imgdatupian.Images.SetKeyName(105, "106.jpg");
            this.imgdatupian.Images.SetKeyName(106, "107.jpg");
            this.imgdatupian.Images.SetKeyName(107, "108.jpg");
            this.imgdatupian.Images.SetKeyName(108, "109.jpg");
            this.imgdatupian.Images.SetKeyName(109, "110.jpg");
            this.imgdatupian.Images.SetKeyName(110, "111.jpg");
            this.imgdatupian.Images.SetKeyName(111, "112.jpg");
            this.imgdatupian.Images.SetKeyName(112, "113.jpg");
            this.imgdatupian.Images.SetKeyName(113, "114.jpg");
            this.imgdatupian.Images.SetKeyName(114, "115.jpg");
            this.imgdatupian.Images.SetKeyName(115, "116.jpg");
            this.imgdatupian.Images.SetKeyName(116, "117.jpg");
            this.imgdatupian.Images.SetKeyName(117, "118.jpg");
            this.imgdatupian.Images.SetKeyName(118, "119.jpg");
            this.imgdatupian.Images.SetKeyName(119, "120.jpg");
            this.imgdatupian.Images.SetKeyName(120, "121.jpg");
            this.imgdatupian.Images.SetKeyName(121, "122.jpg");
            this.imgdatupian.Images.SetKeyName(122, "123.jpg");
            this.imgdatupian.Images.SetKeyName(123, "124.jpg");
            this.imgdatupian.Images.SetKeyName(124, "125.jpg");
            this.imgdatupian.Images.SetKeyName(125, "126.jpg");
            this.imgdatupian.Images.SetKeyName(126, "127.jpg");
            this.imgdatupian.Images.SetKeyName(127, "128.jpg");
            this.imgdatupian.Images.SetKeyName(128, "129.jpg");
            this.imgdatupian.Images.SetKeyName(129, "130.jpg");
            this.imgdatupian.Images.SetKeyName(130, "131.jpg");
            this.imgdatupian.Images.SetKeyName(131, "132.jpg");
            this.imgdatupian.Images.SetKeyName(132, "133.jpg");
            this.imgdatupian.Images.SetKeyName(133, "134.jpg");
            this.imgdatupian.Images.SetKeyName(134, "135.jpg");
            this.imgdatupian.Images.SetKeyName(135, "136.jpg");
            this.imgdatupian.Images.SetKeyName(136, "137.jpg");
            this.imgdatupian.Images.SetKeyName(137, "138.jpg");
            this.imgdatupian.Images.SetKeyName(138, "139.jpg");
            this.imgdatupian.Images.SetKeyName(139, "140.jpg");
            this.imgdatupian.Images.SetKeyName(140, "141.jpg");
            this.imgdatupian.Images.SetKeyName(141, "142.jpg");
            this.imgdatupian.Images.SetKeyName(142, "143.jpg");
            this.imgdatupian.Images.SetKeyName(143, "144.jpg");
            this.imgdatupian.Images.SetKeyName(144, "145.jpg");
            this.imgdatupian.Images.SetKeyName(145, "146.jpg");
            this.imgdatupian.Images.SetKeyName(146, "147.jpg");
            this.imgdatupian.Images.SetKeyName(147, "148.jpg");
            this.imgdatupian.Images.SetKeyName(148, "149.jpg");
            this.imgdatupian.Images.SetKeyName(149, "150.jpg");
            this.imgdatupian.Images.SetKeyName(150, "151.jpg");
            this.imgdatupian.Images.SetKeyName(151, "152.jpg");
            this.imgdatupian.Images.SetKeyName(152, "153.jpg");
            this.imgdatupian.Images.SetKeyName(153, "154.jpg");
            this.imgdatupian.Images.SetKeyName(154, "155.jpg");
            this.imgdatupian.Images.SetKeyName(155, "156.jpg");
            this.imgdatupian.Images.SetKeyName(156, "157.jpg");
            this.imgdatupian.Images.SetKeyName(157, "158.jpg");
            // 
            // FrmChaXunAniam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 459);
            this.Controls.Add(this.lvAnime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboAniam);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmChaXunAniam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询动漫";
            this.Load += new System.EventHandler(this.FrmChaXunAniam_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboAniam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvAnime;
        private System.Windows.Forms.ImageList imgdatupian;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmDean;
        private System.Windows.Forms.ToolStripMenuItem tsmMy;
    }
}
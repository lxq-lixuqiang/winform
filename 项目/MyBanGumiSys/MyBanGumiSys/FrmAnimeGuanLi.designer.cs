namespace MyBanGumiSys
{
    partial class FrmAnimeGuanLi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnimeGuanLi));
            this.lvAnime = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmimg = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmXinXi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSelect = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cbopalygeshi = new System.Windows.Forms.ComboBox();
            this.cbomon = new System.Windows.Forms.ComboBox();
            this.cboyears = new System.Windows.Forms.ComboBox();
            this.btnAnimeImg = new System.Windows.Forms.Button();
            this.buttQX = new System.Windows.Forms.Button();
            this.buttXZ = new System.Windows.Forms.Button();
            this.txtneirong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAnimeImg = new System.Windows.Forms.TextBox();
            this.txtUidName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pibAnimeImg = new System.Windows.Forms.PictureBox();
            this.panUpdate = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibAnimeImg)).BeginInit();
            this.panUpdate.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvAnime
            // 
            this.lvAnime.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvAnime.ContextMenuStrip = this.contextMenuStrip1;
            this.lvAnime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAnime.LargeImageList = this.imageList1;
            this.lvAnime.Location = new System.Drawing.Point(0, 70);
            this.lvAnime.Margin = new System.Windows.Forms.Padding(4);
            this.lvAnime.Name = "lvAnime";
            this.lvAnime.Size = new System.Drawing.Size(1151, 607);
            this.lvAnime.TabIndex = 5;
            this.lvAnime.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "名称";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "年份";
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "季节";
            this.columnHeader4.Width = 50;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "类型";
            this.columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "人气";
            this.columnHeader6.Width = 70;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "上传时间";
            this.columnHeader7.Width = 170;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "视频格式";
            this.columnHeader8.Width = 73;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmimg,
            this.tsmXinXi,
            this.tsmUpdate});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 76);
            // 
            // tsmimg
            // 
            this.tsmimg.Name = "tsmimg";
            this.tsmimg.Size = new System.Drawing.Size(138, 24);
            this.tsmimg.Text = "图片模式";
            this.tsmimg.Click += new System.EventHandler(this.tsmimg_Click);
            // 
            // tsmXinXi
            // 
            this.tsmXinXi.Name = "tsmXinXi";
            this.tsmXinXi.Size = new System.Drawing.Size(138, 24);
            this.tsmXinXi.Text = "详细模式";
            this.tsmXinXi.Click += new System.EventHandler(this.tsmXinXi_Click);
            // 
            // tsmUpdate
            // 
            this.tsmUpdate.Name = "tsmUpdate";
            this.tsmUpdate.Size = new System.Drawing.Size(138, 24);
            this.tsmUpdate.Text = "修改信息";
            this.tsmUpdate.Click += new System.EventHandler(this.tsmUpdate_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.jpg");
            this.imageList1.Images.SetKeyName(1, "2.jpg");
            this.imageList1.Images.SetKeyName(2, "3.jpg");
            this.imageList1.Images.SetKeyName(3, "4.jpg");
            this.imageList1.Images.SetKeyName(4, "5.jpg");
            this.imageList1.Images.SetKeyName(5, "6.jpg");
            this.imageList1.Images.SetKeyName(6, "7.jpg");
            this.imageList1.Images.SetKeyName(7, "8.jpg");
            this.imageList1.Images.SetKeyName(8, "9.jpg");
            this.imageList1.Images.SetKeyName(9, "10.jpg");
            this.imageList1.Images.SetKeyName(10, "11.jpg");
            this.imageList1.Images.SetKeyName(11, "12.jpg");
            this.imageList1.Images.SetKeyName(12, "13.jpg");
            this.imageList1.Images.SetKeyName(13, "14.jpg");
            this.imageList1.Images.SetKeyName(14, "15.jpg");
            this.imageList1.Images.SetKeyName(15, "16.jpg");
            this.imageList1.Images.SetKeyName(16, "17.jpg");
            this.imageList1.Images.SetKeyName(17, "18.jpg");
            this.imageList1.Images.SetKeyName(18, "19.jpg");
            this.imageList1.Images.SetKeyName(19, "20.jpg");
            this.imageList1.Images.SetKeyName(20, "21.jpg");
            this.imageList1.Images.SetKeyName(21, "22.jpg");
            this.imageList1.Images.SetKeyName(22, "23.jpg");
            this.imageList1.Images.SetKeyName(23, "24.jpg");
            this.imageList1.Images.SetKeyName(24, "25.jpg");
            this.imageList1.Images.SetKeyName(25, "26.jpg");
            this.imageList1.Images.SetKeyName(26, "27.jpg");
            this.imageList1.Images.SetKeyName(27, "28.jpg");
            this.imageList1.Images.SetKeyName(28, "29.jpg");
            this.imageList1.Images.SetKeyName(29, "30.jpg");
            this.imageList1.Images.SetKeyName(30, "31.jpg");
            this.imageList1.Images.SetKeyName(31, "32.jpg");
            this.imageList1.Images.SetKeyName(32, "33.jpg");
            this.imageList1.Images.SetKeyName(33, "34.jpg");
            this.imageList1.Images.SetKeyName(34, "35.jpg");
            this.imageList1.Images.SetKeyName(35, "36.jpg");
            this.imageList1.Images.SetKeyName(36, "37.jpg");
            this.imageList1.Images.SetKeyName(37, "38.jpg");
            this.imageList1.Images.SetKeyName(38, "39.jpg");
            this.imageList1.Images.SetKeyName(39, "40.jpg");
            this.imageList1.Images.SetKeyName(40, "41.jpg");
            this.imageList1.Images.SetKeyName(41, "42.jpg");
            this.imageList1.Images.SetKeyName(42, "43.jpg");
            this.imageList1.Images.SetKeyName(43, "44.jpg");
            this.imageList1.Images.SetKeyName(44, "45.jpg");
            this.imageList1.Images.SetKeyName(45, "46.jpg");
            this.imageList1.Images.SetKeyName(46, "47.jpg");
            this.imageList1.Images.SetKeyName(47, "48.jpg");
            this.imageList1.Images.SetKeyName(48, "49.jpg");
            this.imageList1.Images.SetKeyName(49, "50.jpg");
            this.imageList1.Images.SetKeyName(50, "51.jpg");
            this.imageList1.Images.SetKeyName(51, "52.jpg");
            this.imageList1.Images.SetKeyName(52, "53.jpg");
            this.imageList1.Images.SetKeyName(53, "54.jpg");
            this.imageList1.Images.SetKeyName(54, "55.jpg");
            this.imageList1.Images.SetKeyName(55, "56.jpg");
            this.imageList1.Images.SetKeyName(56, "57.jpg");
            this.imageList1.Images.SetKeyName(57, "58.jpg");
            this.imageList1.Images.SetKeyName(58, "59.jpg");
            this.imageList1.Images.SetKeyName(59, "60.jpg");
            this.imageList1.Images.SetKeyName(60, "61.jpg");
            this.imageList1.Images.SetKeyName(61, "62.jpg");
            this.imageList1.Images.SetKeyName(62, "63.jpg");
            this.imageList1.Images.SetKeyName(63, "64.jpg");
            this.imageList1.Images.SetKeyName(64, "65.jpg");
            this.imageList1.Images.SetKeyName(65, "66.jpg");
            this.imageList1.Images.SetKeyName(66, "67.jpg");
            this.imageList1.Images.SetKeyName(67, "68.jpg");
            this.imageList1.Images.SetKeyName(68, "69.jpg");
            this.imageList1.Images.SetKeyName(69, "70.jpg");
            this.imageList1.Images.SetKeyName(70, "71.jpg");
            this.imageList1.Images.SetKeyName(71, "72.jpg");
            this.imageList1.Images.SetKeyName(72, "73.jpg");
            this.imageList1.Images.SetKeyName(73, "74.jpg");
            this.imageList1.Images.SetKeyName(74, "75.jpg");
            this.imageList1.Images.SetKeyName(75, "76.jpg");
            this.imageList1.Images.SetKeyName(76, "77.jpg");
            this.imageList1.Images.SetKeyName(77, "78.jpg");
            this.imageList1.Images.SetKeyName(78, "79.jpg");
            this.imageList1.Images.SetKeyName(79, "80.jpg");
            this.imageList1.Images.SetKeyName(80, "81.jpg");
            this.imageList1.Images.SetKeyName(81, "82.jpg");
            this.imageList1.Images.SetKeyName(82, "83.jpg");
            this.imageList1.Images.SetKeyName(83, "84.jpg");
            this.imageList1.Images.SetKeyName(84, "85.jpg");
            this.imageList1.Images.SetKeyName(85, "86.jpg");
            this.imageList1.Images.SetKeyName(86, "87.jpg");
            this.imageList1.Images.SetKeyName(87, "88.jpg");
            this.imageList1.Images.SetKeyName(88, "89.jpg");
            this.imageList1.Images.SetKeyName(89, "90.jpg");
            this.imageList1.Images.SetKeyName(90, "91.jpg");
            this.imageList1.Images.SetKeyName(91, "92.jpg");
            this.imageList1.Images.SetKeyName(92, "93.jpg");
            this.imageList1.Images.SetKeyName(93, "94.jpg");
            this.imageList1.Images.SetKeyName(94, "95.jpg");
            this.imageList1.Images.SetKeyName(95, "96.jpg");
            this.imageList1.Images.SetKeyName(96, "97.jpg");
            this.imageList1.Images.SetKeyName(97, "98.jpg");
            this.imageList1.Images.SetKeyName(98, "99.jpg");
            this.imageList1.Images.SetKeyName(99, "100.jpg");
            this.imageList1.Images.SetKeyName(100, "101.jpg");
            this.imageList1.Images.SetKeyName(101, "102.jpg");
            this.imageList1.Images.SetKeyName(102, "103.jpg");
            this.imageList1.Images.SetKeyName(103, "104.jpg");
            this.imageList1.Images.SetKeyName(104, "105.jpg");
            this.imageList1.Images.SetKeyName(105, "106.jpg");
            this.imageList1.Images.SetKeyName(106, "107.jpg");
            this.imageList1.Images.SetKeyName(107, "108.jpg");
            this.imageList1.Images.SetKeyName(108, "109.jpg");
            this.imageList1.Images.SetKeyName(109, "110.jpg");
            this.imageList1.Images.SetKeyName(110, "111.jpg");
            this.imageList1.Images.SetKeyName(111, "112.jpg");
            this.imageList1.Images.SetKeyName(112, "113.jpg");
            this.imageList1.Images.SetKeyName(113, "114.jpg");
            this.imageList1.Images.SetKeyName(114, "115.jpg");
            this.imageList1.Images.SetKeyName(115, "116.jpg");
            this.imageList1.Images.SetKeyName(116, "117.jpg");
            this.imageList1.Images.SetKeyName(117, "118.jpg");
            this.imageList1.Images.SetKeyName(118, "119.jpg");
            this.imageList1.Images.SetKeyName(119, "120.jpg");
            this.imageList1.Images.SetKeyName(120, "121.jpg");
            this.imageList1.Images.SetKeyName(121, "122.jpg");
            this.imageList1.Images.SetKeyName(122, "123.jpg");
            this.imageList1.Images.SetKeyName(123, "124.jpg");
            this.imageList1.Images.SetKeyName(124, "125.jpg");
            this.imageList1.Images.SetKeyName(125, "126.jpg");
            this.imageList1.Images.SetKeyName(126, "127.jpg");
            this.imageList1.Images.SetKeyName(127, "128.jpg");
            this.imageList1.Images.SetKeyName(128, "129.jpg");
            this.imageList1.Images.SetKeyName(129, "130.jpg");
            this.imageList1.Images.SetKeyName(130, "131.jpg");
            this.imageList1.Images.SetKeyName(131, "132.jpg");
            this.imageList1.Images.SetKeyName(132, "133.jpg");
            this.imageList1.Images.SetKeyName(133, "134.jpg");
            this.imageList1.Images.SetKeyName(134, "135.jpg");
            this.imageList1.Images.SetKeyName(135, "136.jpg");
            this.imageList1.Images.SetKeyName(136, "137.jpg");
            this.imageList1.Images.SetKeyName(137, "138.jpg");
            this.imageList1.Images.SetKeyName(138, "139.jpg");
            this.imageList1.Images.SetKeyName(139, "140.jpg");
            this.imageList1.Images.SetKeyName(140, "141.jpg");
            this.imageList1.Images.SetKeyName(141, "142.jpg");
            this.imageList1.Images.SetKeyName(142, "143.jpg");
            this.imageList1.Images.SetKeyName(143, "144.jpg");
            this.imageList1.Images.SetKeyName(144, "145.jpg");
            this.imageList1.Images.SetKeyName(145, "146.jpg");
            this.imageList1.Images.SetKeyName(146, "147.jpg");
            this.imageList1.Images.SetKeyName(147, "148.jpg");
            this.imageList1.Images.SetKeyName(148, "149.jpg");
            this.imageList1.Images.SetKeyName(149, "150.jpg");
            this.imageList1.Images.SetKeyName(150, "151.jpg");
            this.imageList1.Images.SetKeyName(151, "152.jpg");
            this.imageList1.Images.SetKeyName(152, "153.jpg");
            this.imageList1.Images.SetKeyName(153, "154.jpg");
            this.imageList1.Images.SetKeyName(154, "155.jpg");
            this.imageList1.Images.SetKeyName(155, "156.jpg");
            this.imageList1.Images.SetKeyName(156, "157.jpg");
            this.imageList1.Images.SetKeyName(157, "158.jpg");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(5, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "动漫端";
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Location = new System.Drawing.Point(1027, 29);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(100, 29);
            this.btnSelect.TabIndex = 8;
            this.btnSelect.Text = "查  询";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(646, 31);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(133, 25);
            this.txtName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.label2.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(578, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "姓 名:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.label1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(806, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "年份:";
            // 
            // cboSelect
            // 
            this.cboSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelect.FormattingEnabled = true;
            this.cboSelect.Items.AddRange(new object[] {
            "全部",
            "2017",
            "2016",
            "2015",
            "2014"});
            this.cboSelect.Location = new System.Drawing.Point(864, 32);
            this.cboSelect.Name = "cboSelect";
            this.cboSelect.Size = new System.Drawing.Size(133, 23);
            this.cboSelect.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.cboSelect);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1151, 70);
            this.panel1.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.label9.Font = new System.Drawing.Font("楷体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(5, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 27);
            this.label9.TabIndex = 17;
            this.label9.Text = "修改动漫";
            // 
            // cbopalygeshi
            // 
            this.cbopalygeshi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbopalygeshi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbopalygeshi.FormattingEnabled = true;
            this.cbopalygeshi.Items.AddRange(new object[] {
            "mkv",
            "3gp",
            "mp4",
            "flv"});
            this.cbopalygeshi.Location = new System.Drawing.Point(308, 241);
            this.cbopalygeshi.Name = "cbopalygeshi";
            this.cbopalygeshi.Size = new System.Drawing.Size(70, 23);
            this.cbopalygeshi.TabIndex = 11;
            // 
            // cbomon
            // 
            this.cbomon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbomon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomon.FormattingEnabled = true;
            this.cbomon.Items.AddRange(new object[] {
            "春",
            "夏",
            "秋",
            "冬"});
            this.cbomon.Location = new System.Drawing.Point(468, 194);
            this.cbomon.Name = "cbomon";
            this.cbomon.Size = new System.Drawing.Size(60, 23);
            this.cbomon.TabIndex = 11;
            // 
            // cboyears
            // 
            this.cboyears.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboyears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboyears.FormattingEnabled = true;
            this.cboyears.Items.AddRange(new object[] {
            "2017",
            "2016",
            "2015",
            "2014"});
            this.cboyears.Location = new System.Drawing.Point(308, 194);
            this.cboyears.Name = "cboyears";
            this.cboyears.Size = new System.Drawing.Size(70, 23);
            this.cboyears.TabIndex = 11;
            // 
            // btnAnimeImg
            // 
            this.btnAnimeImg.BackColor = System.Drawing.SystemColors.Window;
            this.btnAnimeImg.FlatAppearance.BorderSize = 0;
            this.btnAnimeImg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnimeImg.Location = new System.Drawing.Point(423, 402);
            this.btnAnimeImg.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnimeImg.Name = "btnAnimeImg";
            this.btnAnimeImg.Size = new System.Drawing.Size(100, 29);
            this.btnAnimeImg.TabIndex = 14;
            this.btnAnimeImg.Text = "图片浏览";
            this.btnAnimeImg.UseVisualStyleBackColor = false;
            this.btnAnimeImg.Click += new System.EventHandler(this.btnAnimeImg_Click);
            // 
            // buttQX
            // 
            this.buttQX.BackColor = System.Drawing.SystemColors.Window;
            this.buttQX.FlatAppearance.BorderSize = 0;
            this.buttQX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttQX.Location = new System.Drawing.Point(308, 462);
            this.buttQX.Margin = new System.Windows.Forms.Padding(4);
            this.buttQX.Name = "buttQX";
            this.buttQX.Size = new System.Drawing.Size(100, 29);
            this.buttQX.TabIndex = 14;
            this.buttQX.Text = "取  消";
            this.buttQX.UseVisualStyleBackColor = false;
            this.buttQX.Click += new System.EventHandler(this.buttQX_Click);
            // 
            // buttXZ
            // 
            this.buttXZ.BackColor = System.Drawing.SystemColors.Window;
            this.buttXZ.FlatAppearance.BorderSize = 0;
            this.buttXZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttXZ.Location = new System.Drawing.Point(143, 462);
            this.buttXZ.Margin = new System.Windows.Forms.Padding(4);
            this.buttXZ.Name = "buttXZ";
            this.buttXZ.Size = new System.Drawing.Size(100, 29);
            this.buttXZ.TabIndex = 15;
            this.buttXZ.Text = "修  改";
            this.buttXZ.UseVisualStyleBackColor = false;
            this.buttXZ.Click += new System.EventHandler(this.buttXZ_Click);
            // 
            // txtneirong
            // 
            this.txtneirong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtneirong.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtneirong.Location = new System.Drawing.Point(308, 287);
            this.txtneirong.Margin = new System.Windows.Forms.Padding(4);
            this.txtneirong.Multiline = true;
            this.txtneirong.Name = "txtneirong";
            this.txtneirong.Size = new System.Drawing.Size(221, 92);
            this.txtneirong.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "季 节";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(382, 198);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "年";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(254, 245);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 15);
            this.label11.TabIndex = 5;
            this.label11.Text = "格 式";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(254, 290);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 15);
            this.label12.TabIndex = 5;
            this.label12.Text = "内 容";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "年 份";
            // 
            // txtAnimeImg
            // 
            this.txtAnimeImg.Enabled = false;
            this.txtAnimeImg.Location = new System.Drawing.Point(38, 404);
            this.txtAnimeImg.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnimeImg.Name = "txtAnimeImg";
            this.txtAnimeImg.Size = new System.Drawing.Size(367, 25);
            this.txtAnimeImg.TabIndex = 13;
            // 
            // txtUidName
            // 
            this.txtUidName.Location = new System.Drawing.Point(308, 148);
            this.txtUidName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUidName.Name = "txtUidName";
            this.txtUidName.Size = new System.Drawing.Size(221, 25);
            this.txtUidName.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 151);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "名 称";
            // 
            // pibAnimeImg
            // 
            this.pibAnimeImg.Location = new System.Drawing.Point(38, 136);
            this.pibAnimeImg.Name = "pibAnimeImg";
            this.pibAnimeImg.Size = new System.Drawing.Size(205, 243);
            this.pibAnimeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibAnimeImg.TabIndex = 19;
            this.pibAnimeImg.TabStop = false;
            // 
            // panUpdate
            // 
            this.panUpdate.BackColor = System.Drawing.Color.White;
            this.panUpdate.Controls.Add(this.cbopalygeshi);
            this.panUpdate.Controls.Add(this.label12);
            this.panUpdate.Controls.Add(this.cbomon);
            this.panUpdate.Controls.Add(this.label4);
            this.panUpdate.Controls.Add(this.label11);
            this.panUpdate.Controls.Add(this.cboyears);
            this.panUpdate.Controls.Add(this.txtAnimeImg);
            this.panUpdate.Controls.Add(this.label10);
            this.panUpdate.Controls.Add(this.btnAnimeImg);
            this.panUpdate.Controls.Add(this.txtUidName);
            this.panUpdate.Controls.Add(this.buttQX);
            this.panUpdate.Controls.Add(this.label6);
            this.panUpdate.Controls.Add(this.label8);
            this.panUpdate.Controls.Add(this.buttXZ);
            this.panUpdate.Controls.Add(this.txtneirong);
            this.panUpdate.Controls.Add(this.pibAnimeImg);
            this.panUpdate.Controls.Add(this.panel2);
            this.panUpdate.Location = new System.Drawing.Point(592, 96);
            this.panUpdate.Name = "panUpdate";
            this.panUpdate.Size = new System.Drawing.Size(559, 532);
            this.panUpdate.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(559, 70);
            this.panel2.TabIndex = 20;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmAnimeGuanLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 677);
            this.Controls.Add(this.lvAnime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panUpdate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAnimeGuanLi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "动漫端";
            this.Load += new System.EventHandler(this.MainForm3_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibAnimeImg)).EndInit();
            this.panUpdate.ResumeLayout(false);
            this.panUpdate.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvAnime;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmimg;
        private System.Windows.Forms.ToolStripMenuItem tsmXinXi;
        private System.Windows.Forms.ToolStripMenuItem tsmUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSelect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttQX;
        private System.Windows.Forms.Button buttXZ;
        private System.Windows.Forms.TextBox txtneirong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUidName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboyears;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbomon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbopalygeshi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAnimeImg;
        private System.Windows.Forms.TextBox txtAnimeImg;
        private System.Windows.Forms.PictureBox pibAnimeImg;
        private System.Windows.Forms.Panel panUpdate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel2;
    }
}
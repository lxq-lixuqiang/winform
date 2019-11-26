using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyBanGumiSys
{
    public partial class FrmMain : Form
    {
        //属性
        SqlConnection conn = null;
        string[] MyAnime = new string[160];
        string MyShouCang;
        bool isOk = true;
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 动漫查询
        /// </summary>
        public void AnimeSelect()
        {
            try
            {
                lvAnime.Items.Clear();
                conn = new SqlConnection(gonggong.connString);
                conn.Open();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(" SELECT     a.Id,a.AnimeName, m.mon, y.years ");
                sb.AppendLine(" FROM         Anime as a ");
                sb.AppendLine(" INNER JOIN montype as m ON a.mon = m.monId INNER JOIN ");
                sb.AppendLine(" yearstype as y ON a.years = y.yearsId WHERE 1=1");

                if (Convert.ToString(tvSelect.SelectedNode.Level) == "1")
                {
                    sb.AppendFormat(" AND  y.years={0}", tvSelect.SelectedNode.Text);
                }
                if (Convert.ToString(tvSelect.SelectedNode.Level) == "2")
                {
                    sb.AppendFormat(" AND m.mon='{0}'", tvSelect.SelectedNode.Text);
                }

                SqlCommand com = new SqlCommand(sb.ToString(), conn);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(reader["AnimeName"]), Convert.ToInt32(reader["Id"]) - 1);
                    lvAnime.Items.Add(item);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("动漫番异常!原因:" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 退出按钮移动到图标上方触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbExit_MouseMove(object sender, MouseEventArgs e)
        {
            PbExit.ImageLocation = @"..\..\..\..\..\图片\Image 111.png";
        }

        /// <summary>
        /// 退出按钮鼠标没有移动时显示的状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbExit_MouseLeave(object sender, EventArgs e)
        {
            PbExit.ImageLocation = @"..\..\..\..\..\图片\Image 11.png";
        }

        /// <summary>
        /// 最小化按钮移动到图标上方触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbMin_MouseMove(object sender, MouseEventArgs e)
        {
            pbMin.ImageLocation = @"..\..\..\..\..\图片\Image 13.png";
        }

        /// <summary>
        /// 最小化按钮鼠标没有移动时显示的状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbMin_MouseLeave(object sender, EventArgs e)
        {
            pbMin.ImageLocation = @"..\..\..\..\..\图片\Image 131.png";
        }

        /// <summary>
        /// 最小化按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //拖动窗口的属性
        int x, y;
        bool IsMove = false;
        /// <summary>
        /// 拖动窗口，单击释放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            IsMove = false;
        }

        /// <summary>
        /// 拖动窗口,移动上方出现效果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMove)
            {
                this.Location = new Point(this.Location.X + (e.X - x), this.Location.Y + (e.Y - y));
            }
            //隐藏登录表单
            this.pannewShow.Hide();
        }

        /// <summary>
        /// 移动到登录图片上时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            lbldenglu.ForeColor = Color.Orange;
        }

        /// <summary>
        /// 没有移动到登录图片时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            lbldenglu.ForeColor = Color.White;
        }

        /// <summary>
        ///(2)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            ptnGuanYu.ImageLocation = @"..\..\..\..\..\图片\5now.png";
        }

        /// <summary>
        /// (2)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            ptnGuanYu.ImageLocation = @"..\..\..\..\..\图片\5now - 副本.png";
        }

        /// <summary>
        /// (4)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {

            ptnAnimeSelect.ImageLocation = @"..\..\..\..\..\图片\1now.png";
        }

        /// <summary>
        /// (4)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            ptnAnimeSelect.ImageLocation = @"..\..\..\..\..\图片\1now - 副本.png";
        }

        //移动到图标上方显示边框
        public void bankuang(Panel panel)
        {
            panel.BorderStyle = BorderStyle.FixedSingle;
        }

        //没有移动到图标上方的不显示边框
        public void Nobankuang(Panel panel)
        {
            panel.BorderStyle = BorderStyle.None;
        }

        /// <summary>
        /// (5)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            ptnAnimeBaiHang.ImageLocation = @"..\..\..\..\..\图片\3now.png";
        }

        /// <summary>
        /// (5)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            ptnAnimeBaiHang.ImageLocation = @"..\..\..\..\..\图片\3now - 副本.png";
        }

        /// <summary>
        /// 登录图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (lbldenglu.Text!="未登录") { 
            this.pannewShow.Show();
                laluidName.Text= gonggong.uidName;
            }
            else
            {
                FrmDengLu frm = new FrmDengLu();
                frm.ShowDialog();
                if (gonggong.uidName != "未登录") {
                lbldenglu.Text = gonggong.uidName;
                laluidtype.Text = gonggong.type;
                lalUidSex.Text = gonggong.Sex;
                pictureBox2.ImageLocation = @"..\..\..\..\..\图片\Image 101.png";
                    if (laluidtype.Text == "管理员")
                    {
                        tsmMy.Text = "客户端";
                        tsmSelectAnime.Text = "动漫端";
                        ptbtype.ImageLocation= @"..\..\..\..\..\图片\aaa.jpg";
                        pictureBox2.ImageLocation = @"..\..\..\..\..\图片\Image 120441.png";
                        pictureBox7.ImageLocation = @"..\..\..\..\..\图片\Image 120441.png"; 
                    }
                    else
                    {
                        ptbtype.ImageLocation = @"..\..\..\..\..\图片\timg (2).jpg";
                        pictureBox7.ImageLocation = @"..\..\..\..\..\图片\Image 101.png";
                    }
                    if (lalUidSex.Text == "男")
                    {
                        ptbSex.ImageLocation = @"..\..\..\..\..\图片\Image 220459.png";
                    }
                    else
                    {
                        tsmMy.Text = "我的收藏";
                        tsmSelectAnime.Text = "投稿";
                        ptbSex.ImageLocation = @"..\..\..\..\..\图片\timg (3).jpg";
                        foreach (Control var in this.pelMain.Controls)
                        {
                            if (var is Form)
                            {
                                var.Hide();
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //隐藏登录表单
            this.pannewShow.Hide();
            this.Hide();
            timImg.Enabled = true;
            FrmXiangChuangKou frm = new FrmXiangChuangKou();
            frm.ShowDialog();
            panel9.Hide();
            //树形图展开‘全部’
            tvSelect.Nodes[0].Expand();
            AnimeSelectjiazai();
        }

        /// <summary>
        /// 动漫番加载
        /// </summary>
        public void AnimeSelectjiazai()
        {
            try
            {
                conn = new SqlConnection(gonggong.connString);
                conn.Open();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(" SELECT     a.Id,a.AnimeName, m.mon, y.years ");
                sb.AppendLine(" FROM         Anime as a ");
                sb.AppendLine(" INNER JOIN montype as m ON a.mon = m.monId INNER JOIN ");
                sb.AppendLine(" yearstype as y ON a.years = y.yearsId WHERE 1=1");

                if (!string.IsNullOrEmpty(txtAnimeName.Text.Trim()))
                {
                    sb.AppendFormat(" AND a.AnimeName  LIKE '%{0}%'", txtAnimeName.Text.Trim());
                }
                SqlCommand com = new SqlCommand(sb.ToString(), conn);
                SqlDataReader reader = com.ExecuteReader();
                if (reader.HasRows) { 
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(reader["AnimeName"]), Convert.ToInt32(reader["Id"]) - 1);
                    lvAnime.Items.Add(item);
                }
                reader.Close();
                }
                else
                {
                    MessageBox.Show("没有找到相关的动漫名!",gonggong.tishi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("动漫番加载异常!原因:" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void timTime_Tick(object sender, EventArgs e)
        {
            lalTime.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        /// <summary>
        /// 退出应用程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认要退出吗?",gonggong.tishi, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
    }

        /// <summary>
        /// (7)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel7_MouseMove(object sender, MouseEventArgs e)
        {
            ptnNowAnime.ImageLocation = @"..\..\..\..\..\图片\2now.png";
        }

        /// <summary>
        /// (7)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel7_MouseLeave(object sender, EventArgs e)
        {
            ptnNowAnime.ImageLocation = @"..\..\..\..\..\图片\2now - 副本.png";
        }

        /// <summary>
        /// 退出账号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmExitzhanghao_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退出账号吗?", gonggong.tishi, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                gonggong.type = "";
                lbldenglu.Text = "未登录";
                gonggong.uidName = "未登录";
                pictureBox2.ImageLocation = @"..\..\..\..\..\图片\Image 9.png";
                //隐藏窗口
                foreach (Control var in this.pelMain.Controls)
                {
                    if (var is Form)
                    {
                            var.Hide();
                    }
                }
            }
            //隐藏登录表单
            this.pannewShow.Hide();
            panel9.Hide();
        }

        /// <summary>
        /// 我的收藏和客户端
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmMy_Click(object sender, EventArgs e)
        {
            if (tsmMy.Text == "我的收藏")
            {
                FrmMyAnime frm = new FrmMyAnime();
                frm.ShowDialog();
            }
            else
            {
                if (Application.OpenForms["FrmUid"] == null) { 
                FrmUid frm = new FrmUid();
                OpenChuangKe(frm);
                }
                else
                {
                    Application.OpenForms["FrmUid"].Show();
                }
                //隐藏其他所有的窗口
                yinChang("FrmUid");
                panel9.Hide();
            }
        }

        //设置窗口
        public void OpenChuangKe(Form frm)
        {
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            this.pelMain.Controls.Add(frm);
            frm.Show();
        }

        //显示当前窗口,隐藏其他所有窗口
        public void yinChang(string frm)
        {
            foreach (Control var in this.pelMain.Controls)
            {
                if (var is Form)
                {
                    if (var.Name != frm)
                    {
                        var.Hide();
                    }
                }
            }
        }

        /// <summary>
        /// 关于我们
        /// </summary>
        public void GuanYuWoMen()
        {
            FrmGuanYuWoMen frm = new FrmGuanYuWoMen();
        frm.ShowDialog();
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmZuCe frm = new FrmZuCe();
            frm.ShowDialog();
        }

        /// <summary>
        /// 投稿
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmSelectAnime_Click(object sender, EventArgs e)
        {
            if (tsmSelectAnime.Text== "投稿")
            {
                FrmNewAnime frm = new FrmNewAnime();
                frm.ShowDialog();
            }
            else
            {
                //动漫端
                if (Application.OpenForms["FrmAnimeGuanLi"] == null)
                {
                    FrmAnimeGuanLi frm = new FrmAnimeGuanLi();
                    OpenChuangKe(frm);
                }
                else
                {
                    Application.OpenForms["FrmAnimeGuanLi"].Show();
                }
                //隐藏其他所有的窗口
                yinChang("FrmAnimeGuanLi");
                panel9.Hide();
            }
            
        }

        public void XinFan()
        {
            if (Application.OpenForms["FrmChaXunAniam"] == null)
            {
                FrmChaXunAniam frm = new FrmChaXunAniam();
                OpenChuangKe(frm);
            }
            else
            {
                Application.OpenForms["FrmChaXunAniam"].Show();
            }
            //隐藏其他所有的窗口
            yinChang("FrmChaXunAniam");
            panel9.Hide();
        }

        /// <summary>
        /// (3)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            ptnAnimeBiZi.ImageLocation = @"..\..\..\..\..\图片\4now.png";
        }

        /// <summary>
        /// (3)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            ptnAnimeBiZi.ImageLocation = @"..\..\..\..\..\图片\4now - 副本.png";
        }

        int num = 0;
        /// <summary>
        /// 图片先出现的定时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timImg_Tick(object sender, EventArgs e)
        {
            if (num == 4)
            {
                timImg.Enabled = false;
                this.Show();
            }
            num++;
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAnimeName.Text.Trim()))
            {
                MessageBox.Show("请输入您要查找的动漫名!",gonggong.tishi, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { 
            panel9.Show();
            lvAnime.Items.Clear();
            AnimeSelectjiazai();
            foreach (Control var in this.pelMain.Controls)
            {
                if (var is Form)
                {
                    var.Hide();
                }
            }
            }
        }

        /// <summary>
        /// 树节点框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvSelect_AfterSelect(object sender, TreeViewEventArgs e)
        {
            AnimeSelect();
        }


        /// <summary>
        /// 动漫介绍
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmDean_Click(object sender, EventArgs e)
        {
            if (lvAnime.SelectedItems.Count == 0)
            {
                MessageBox.Show("请先选择一个动漫", gonggong.tishi);
            }
            else
            {
                //获取图标下的名字lvAnime.SelectedItems[0].Text
                try
                {
                    conn = new SqlConnection(gonggong.connString);
                    conn.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine(" SELECT     a.AnimeImg, ");
                    sb.AppendLine("            a.AnimeName, ");
                    sb.AppendLine("            a.type1, ");
                    sb.AppendLine("            a.neirong, ");
                    sb.AppendLine("            a.payback, ");
                    sb.AppendLine("            a.AnimeTime, ");
                    sb.AppendLine("            a.palygeshi, ");
                    sb.AppendLine("            m.mon, ");
                    sb.AppendLine("            y.years ");
                    sb.AppendLine(" FROM         Anime as a ");
                    sb.AppendLine(" INNER JOIN montype as m ON a.mon = m.monId ");
                    sb.AppendLine(" INNER JOIN yearstype as y ON a.years = y.yearsId ");
                    sb.AppendFormat(" WHERE AnimeName = '{0}' ", lvAnime.SelectedItems[0].Text);
                    SqlCommand com = new SqlCommand(sb.ToString(), conn);
                    SqlDataReader reader = com.ExecuteReader();
                    if (reader.Read())
                    {
                        gonggong.AnimeImg = Convert.ToString(reader["AnimeImg"]);
                        gonggong.AnimeName = Convert.ToString(reader["AnimeName"]);
                        gonggong.type1 = Convert.ToString(reader["type1"]);
                        gonggong.payback = Convert.ToString(reader["payback"]);
                        gonggong.AnimeTime = Convert.ToString(reader["AnimeTime"]);
                        gonggong.palygeshi = Convert.ToString(reader["palygeshi"]);
                        gonggong.mon = Convert.ToString(reader["mon"]);
                        gonggong.years = Convert.ToString(reader["years"]);
                        gonggong.neirong = Convert.ToString(reader["neirong"]);
                        FrmAnimeMain frm = new FrmAnimeMain();
                        frm.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("获取动漫名称异常!原因:" + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        /// <summary>
        /// 加我的收藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmMy1_Click(object sender, EventArgs e)
        {
            if (lvAnime.SelectedItems.Count == 0)
            {
                MessageBox.Show("请先选择一个动漫", gonggong.tishi);
            }
            else
            {
                try
                {
                    conn = new SqlConnection(gonggong.connString);
                    conn.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine(" SELECT     MySouCang ");
                    sb.AppendLine(" FROM         UidName ");
                    sb.AppendFormat(" WHERE  UidName = '{0}' AND  UidPwd = '{1}' ", gonggong.uidName, gonggong.uidpwd);
                    SqlCommand com = new SqlCommand(sb.ToString(), conn);
                    MyShouCang = Convert.ToString(com.ExecuteScalar());
                    //拆分字符串
                    MyAnime = MyShouCang.Trim().Split(' ');
                    AnimeIsNo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("查询动漫异常!原因:" + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        /// <summary>
        /// 查询用户是否已有此动漫
        /// </summary>
        public void AnimeIsNo()
        {
            try
            {
                conn = new SqlConnection(gonggong.connString);
                conn.Open();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(" SELECT     Id ");
                sb.AppendLine(" FROM         Anime ");
                sb.AppendFormat(" WHERE  AnimeName = '{0}' ", lvAnime.SelectedItems[0].Text);
                SqlCommand com = new SqlCommand(sb.ToString(), conn);
                string num = Convert.ToString(com.ExecuteScalar());
                bool isOk = true;
                for (int i = 0; i < MyAnime.Length && MyAnime[i] != null; i++)
                {
                    if (MyAnime[i] == num)
                    {
                        MessageBox.Show("您已收藏了此动漫!", gonggong.tishi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        isOk = false;
                        break;
                    }
                }
                if (isOk)
                {
                    MyShouCang += " " + num + " ";
                    //更新用户的收藏
                    UpdateAnime();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询用户已有的动漫异常!原因:" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 更新用户的收藏
        /// </summary>
        public void UpdateAnime()
        {
            try
            {
                conn = new SqlConnection(gonggong.connString);
                conn.Open();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(" UPDATE    UidName ");
                sb.AppendFormat(" SET    MySouCang = '{0}' ", MyShouCang.Trim());
                sb.AppendFormat(" WHERE  UidName = '{0}' AND  UidPwd = '{1}' ", gonggong.uidName, gonggong.uidpwd);
                SqlCommand com = new SqlCommand(sb.ToString(), conn);
                int num = com.ExecuteNonQuery();
                if (num > 0)
                {
                    MessageBox.Show("加入收藏成功!", gonggong.tishi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("加入收藏失败!", gonggong.tishi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("更新用户的收藏异常!原因:" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 图片控件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvAnime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gonggong.type != "客 户")
            {
                tsmMy1.Enabled = false;
            }
            else
            {
                tsmMy1.Enabled = true;
            }
        }

        /// <summary>
        /// 鼠标离开小窗口时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuStrip6_MouseLeave(object sender, EventArgs e)
        {
            pannewShow.Hide();
        }

        /// <summary>
        /// 壁纸站
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmAnimeBiZi"] == null)
            {
                FrmAnimeBiZi frm = new FrmAnimeBiZi();
                OpenChuangKe(frm);
            }
            else
            {
                Application.OpenForms["FrmAnimeBiZi"].Show();
            }
            //隐藏其他所有的窗口
            yinChang("FrmAnimeBiZi");
            panel9.Hide();
        }

        /// <summary>
        /// 动漫番
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptnAnimeSelect_Click(object sender, EventArgs e)
        {
            panel9.Show();
            foreach (Control var in this.pelMain.Controls)
            {
                if (var is Form)
                {
                    var.Hide();
                }
            }
        }

        /// <summary>
        /// 最近新番
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptnNowAnime_Click(object sender, EventArgs e)
        {
            XinFan();
        }

        /// <summary>
        /// 动漫榜
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptnAnimeBaiHang_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmBaiXun"] == null)
            {
                FrmBaiXun frm = new FrmBaiXun();
                OpenChuangKe(frm);
            }
            else
            {
                Application.OpenForms["FrmBaiXun"].Show();
            }
            //隐藏其他所有的窗口
            yinChang("FrmBaiXun");
            panel9.Hide();
        }

        /// <summary>
        /// 壁纸站
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptnAnimeBiZi_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmAnimeBiZi"] == null)
            {
                FrmAnimeBiZi frm = new FrmAnimeBiZi();
                OpenChuangKe(frm);
            }
            else
            {
                Application.OpenForms["FrmAnimeBiZi"].Show();
            }
            //隐藏其他所有的窗口
            yinChang("FrmAnimeBiZi");
            panel9.Hide();
        }

        /// <summary>
        /// 关于我们
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptnGuanYu_Click(object sender, EventArgs e)
        {
            if (gonggong.num > 3)
            {
                gonggong.num = 0;
            }
            GuanYuWoMen();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// 拖动窗口，单击未释放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            IsMove = true;
        }
    }
}

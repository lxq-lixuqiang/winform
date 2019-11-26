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
    public partial class FrmNewAnime : Form
    {
        //属性
        SqlConnection conn = null;
        public FrmNewAnime()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退出投稿吗?",gonggong.tishi, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)== DialogResult.OK) {
                this.Close();
            }
        }

        /// <summary>
        /// 浏览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(this.openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                txtAnimeImg.Text = openFileDialog1.FileName;
            }
        }

        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSelectAnime_Load(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "jpg图片|*.jpg|png图片|*.png";
            cbomon.SelectedIndex = 0;
            cboyears.SelectedIndex = 0;
            cbopalygeshi.SelectedIndex = 0;
            txtAnimeTime.Text = DateTime.Now.ToString();
        }

        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAnimeImg.Text.Trim()) ||
                string.IsNullOrEmpty(txtAnimeName.Text.Trim()) ||
                string.IsNullOrEmpty(txtneirong.Text.Trim()) ||
                string.IsNullOrEmpty(txttype1.Text.Trim()))
            {
                MessageBox.Show("所有的信息不能都为空!", gonggong.tishi, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                try
                {
                    //动漫人气随机产生
                    Random ran = new Random();
                    string sujishu = Convert.ToString(ran.Next(700000, 1100000));
                    //上传日期
                    DateTime time = Convert.ToDateTime(txtAnimeTime.Text);
                    conn = new SqlConnection(gonggong.connString);
                    conn.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine(" INSERT INTO Anime(AnimeImg, ");
                    sb.AppendLine("                   AnimeName, ");
                    sb.AppendLine("                   years, ");
                    sb.AppendLine("                   mon, ");
                    sb.AppendLine("                   type1, ");
                    sb.AppendLine("                   neirong, ");
                    sb.AppendLine("                   payback, ");
                    sb.AppendLine("                   AnimeTime, ");
                    sb.AppendLine("                   palygeshi) ");
                    sb.AppendFormat(" VALUES('{0}', '{1}', {2}, {3}, '{4}', '{5}', '{6}', '{7}', '{8}')",txtAnimeImg.Text.Trim(),
                                        txtAnimeName.Text.Trim(),
                                        cboyears.SelectedIndex+1,
                                        cbomon.SelectedIndex+1,
                                        txttype1.Text.Trim(),
                                        txtneirong.Text.Trim(),
                                        sujishu,
                                        time,
                                        cbopalygeshi.Text);
                    SqlCommand com = new SqlCommand(sb.ToString(), conn);
                    int num = com.ExecuteNonQuery();
                    if (num > 0)
                    {
                        MessageBox.Show("添加成功！", gonggong.tishi);
                        //清空数据
                        qingkong();
                    }
                    else
                    {
                        MessageBox.Show("添加失败！", gonggong.tishi);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("添加动漫异常!原因:"+ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        /// <summary>
        /// 清空数据
        /// </summary>
        public void qingkong()
        {
            txtAnimeImg.Clear();
            txtAnimeName.Clear();
            txtneirong.Clear();
            cbotype1.Checked = false;
            cbotype2.Checked = false;
            cbotype3.Checked = false;
            cbotype4.Checked = false;
            cbotype5.Checked = false;
            cbotype6.Checked = false;
            cbomon.SelectedIndex = 0;
            cboyears.SelectedIndex = 0;
            cbopalygeshi.SelectedIndex = 0;
        }

        public void type1()
        {
            txttype1.Clear();
            StringBuilder sb = new StringBuilder();
            if (cbotype1.Checked == true)
            {
               sb.Append("校园 ");
            }
            if (cbotype2.Checked == true)
            {
                sb.Append("机战 ");
            }
            if (cbotype3.Checked == true)
            {
                sb.Append("搞笑 ");
            }
            if (cbotype4.Checked == true)
            {
                sb.Append("后宫 ");
            }
            if (cbotype5.Checked == true)
            {
                sb.Append("热血 ");
            }
            if (cbotype6.Checked == true)
            {
                sb.Append("日常 ");
            }
            txttype1.Text =Convert.ToString(sb);
        }

        /// <summary>
        /// 移动到类型上面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //类型
            type1();
        }

        /// <summary>
        /// 在标题栏上移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMove)
            {
                this.Location = new Point(this.Location.X + (e.X - x), this.Location.Y + (e.Y - y));
            }
        }

        //拖动窗口的属性
        int x, y;
        bool IsMove = false;


        /// <summary>
        /// 拖动窗口，单击释放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            IsMove = false;
        }

        /// <summary>
        /// 在标题栏上单击未释放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            IsMove = true;
        }
    }
}

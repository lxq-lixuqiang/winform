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
    public partial class FrmAnimeMain : Form
    {
        //属性
        SqlConnection conn = null;
        bool isNo = false;
        string[] MyAnime = new string[160];
        string MyShouCang;
        public FrmAnimeMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 移动到收藏图片上时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isNo)
            {
                ptbshoucang.ImageLocation = @"..\..\..\..\..\图片\SC2.png";
            }
            else
            {
                ptbshoucang.ImageLocation = @"..\..\..\..\..\图片\SC3.png";
            }
        }

        /// <summary>
        /// 没有移动到收藏图片时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_MouseLeave(object sender, EventArgs e)
        {
            if (!isNo) { 
            ptbshoucang.ImageLocation = @"..\..\..\..\..\图片\SC1.png";
            }
            else
            {
            ptbshoucang.ImageLocation = @"..\..\..\..\..\图片\SC3.png";
            }
        }

        /// <summary>
        /// 收藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptbshoucang_Click(object sender, EventArgs e)
        {
            if(gonggong.type == "客 户") { 
                if(ptbshoucang.ImageLocation != @"..\..\..\..\..\图片\SC3.png") { 
            isNo = true;
            ptbshoucang.ImageLocation = @"..\..\..\..\..\图片\SC3.png";
                UpdateAnime();
                }
            }
            else
            {
                MessageBox.Show("请先以客户的身份登录才能收藏!", gonggong.tishi, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("收藏成功!", gonggong.tishi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("收藏失败!", gonggong.tishi, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAnimeMain_Load(object sender, EventArgs e)
        {
            this.Text = gonggong.AnimeName;
            ptbAnimeImg.ImageLocation = gonggong.AnimeImg;
            lalAnimeName.Text = gonggong.AnimeName;
            lalAnimeTime.Text = gonggong.AnimeTime;
            lalmon.Text = gonggong.mon;
            lalneirong.Text = gonggong.neirong;
            lalpalygeshi.Text = gonggong.palygeshi;
            laltype1.Text = gonggong.type1;
            lalyears.Text = gonggong.years;
            lalpayback.Text = gonggong.payback;
            if(gonggong.type=="客 户") { 
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
                sb.AppendFormat(" WHERE  AnimeName = '{0}' ", gonggong.AnimeName);
                SqlCommand com = new SqlCommand(sb.ToString(), conn);
                string num = Convert.ToString(com.ExecuteScalar());
                bool isOk = true ;
                for (int i = 0; i < MyAnime.Length && MyAnime[i] != null; i++)
                {
                    if (MyAnime[i] == num)
                    {
                        ptbshoucang.ImageLocation = @"..\..\..\..\..\图片\SC3.png";
                        isOk = false;
                        isNo = true;
                        break;
                    }
                }
                if (isOk)
                {
                    MyShouCang += " " + num + " ";
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
            /// 移动到关闭图片上
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            ptnExit.ImageLocation = @"..\..\..\..\..\图片\closeHover.png";
        }

        /// <summary>
        /// 没有移动到关闭图片上
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptoExit_MouseLeave(object sender, EventArgs e)
        {
            ptnExit.ImageLocation = @"..\..\..\..\..\图片\close.png";
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptnExit_Click(object sender, EventArgs e)
        {
                this.Close();
        }
    }
}

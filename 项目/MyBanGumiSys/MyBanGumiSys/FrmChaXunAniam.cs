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
    public partial class FrmChaXunAniam : Form
    {
        //属性
        SqlConnection conn = null;
        string[] MyAnime = new string[160];
        string MyShouCang;
        public FrmChaXunAniam()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmChaXunAniam_Load(object sender, EventArgs e)
        {
            //当前时间
            for (int i = -1; i > -5; i--)
            {
                cboAniam.Items.Add(DateTime.Now.AddDays(i).ToString("yyyy-MM-dd"));
            }
            cboAniam.SelectedIndex = 0;
            cboAnima();
        }

        /// <summary>
        /// 下拉框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboAniam_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboAnima();
        }

        public void cboAnima()
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
                sb.AppendLine(" yearstype as y ON a.years = y.yearsId ");
                if (cboAniam.SelectedIndex == 0)
                {
                    sb.AppendFormat(" WHERE y.years={0} AND m.mon='{1}'", 2017, "冬");
                }else if (cboAniam.SelectedIndex == 1)
                {
                    sb.AppendFormat(" WHERE y.years={0} AND m.mon='{1}'", 2017, "春");
                }
                else if (cboAniam.SelectedIndex == 2)
                {
                    sb.AppendFormat(" WHERE y.years={0} AND m.mon='{1}'", 2017, "夏");
                }
                else if (cboAniam.SelectedIndex == 3)
                {
                    sb.AppendFormat(" WHERE y.years={0} AND m.mon='{1}'", 2017, "秋");
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
                MessageBox.Show("下拉框异常!原因:" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
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
                MessageBox.Show("请先选择一个动漫", gonggong.tishi, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    SqlCommand com = new SqlCommand(sb.ToString(),conn);
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
                    MessageBox.Show("获取动漫名称异常!原因:"+ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        /// <summary>
        /// 动漫收藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmMy_Click(object sender, EventArgs e)
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
                tsmMy.Enabled = false;
            }
            else
            {
                tsmMy.Enabled = true;
            }
        }
    }
}

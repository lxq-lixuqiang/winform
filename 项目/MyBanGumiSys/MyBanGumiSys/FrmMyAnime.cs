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
    public partial class FrmMyAnime : Form
    {
        //属性
        SqlConnection conn = null;
        string[] MyAnime = new string[160];
        string My;
        bool UpdateAnime = false;
        string AnimeId;
        string Name;
        public FrmMyAnime()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 图片模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmimg_Click(object sender, EventArgs e)
        {
            lvAnime.View = View.LargeIcon;
        }

        /// <summary>
        /// 详细模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmXinXi_Click(object sender, EventArgs e)
        {
            lvAnime.View = View.Details;
        }

        /// <summary>
        /// 取消收藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmShouCang_Click(object sender, EventArgs e)
        {
            if (lvAnime.SelectedItems.Count == 0)
            {
                MessageBox.Show("请先选择一个动漫", gonggong.tishi, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                My = "";
                Name = lvAnime.SelectedItems[0].Text;
                if (MessageBox.Show("确定要取消收藏此动漫吗?", gonggong.tishi, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    UpdateAnime = true;
                    //清除之前的数据
                    lvAnime.Items.Clear();
                    //按动漫名称查询动漫Id
                    SelectAnime();
                    MyAnimefangfa();
                    UpdateMyAnime();
                }
            }
        }

        /// <summary>
        /// 按动漫名称查询动漫Id
        /// </summary>
        public void SelectAnime()
        {
            try
            {

                conn = new SqlConnection(gonggong.connString);
                conn.Open();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(" SELECT     Id ");
                sb.AppendLine(" FROM         Anime ");
                sb.AppendFormat(" WHERE  AnimeName = '{0}' ", Name);
                SqlCommand com = new SqlCommand(sb.ToString(), conn);
                AnimeId = Convert.ToString(com.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询动漫Id异常!原因:" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 更新我的收藏
        /// </summary>
        public void UpdateMyAnime()
        {
            try
            {
                conn = new SqlConnection(gonggong.connString);
                conn.Open();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(" UPDATE    UidName ");
                sb.AppendFormat(" SET    MySouCang = '{0}' ", My.Trim());
                sb.AppendFormat(" WHERE  UidName = '{0}' AND  UidPwd = '{1}' ", gonggong.uidName, gonggong.uidpwd);
                SqlCommand com = new SqlCommand(sb.ToString(), conn);
                int num = com.ExecuteNonQuery();
                if (num > 0)
                {
                    MessageBox.Show("取消成功!", gonggong.tishi);
                }
                else
                {
                    MessageBox.Show("取消失败!", gonggong.tishi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("更新我的收藏异常!原因:" + ex.Message);
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
        private void FrmMyAnime_Load(object sender, EventArgs e)
        {
            cboSelect.SelectedIndex = 0;
            try
            {
                conn = new SqlConnection(gonggong.connString);
                conn.Open();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(" SELECT     MySouCang ");
                sb.AppendLine(" FROM         UidName ");
                sb.AppendFormat(" WHERE  UidName = '{0}' AND  UidPwd = '{1}' ", gonggong.uidName, gonggong.uidpwd);
                SqlCommand com = new SqlCommand(sb.ToString(), conn);
                string MyShouCang = Convert.ToString(com.ExecuteScalar());
                //拆分字符串
                MyAnime = MyShouCang.Trim().Split(' ');
                if (string.IsNullOrEmpty(MyAnime[0]))
                {
                    MessageBox.Show("您还没有收藏的动漫", gonggong.tishi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MyAnimefangfa();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载事件异常!原因:" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 动漫查找
        /// </summary>
        public void MyAnimefangfa()
        {
            //循环查找动漫
            for (int i = 0; i < MyAnime.Length && MyAnime[i] != null; i++)
            {
                try
                {
                    conn = new SqlConnection(gonggong.connString);
                    conn.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine(" SELECT     a.AnimeImg,  ");
                    sb.AppendLine("            a.AnimeName, ");
                    sb.AppendLine("            a.type1, ");
                    sb.AppendLine("            a.neirong, ");
                    sb.AppendLine("            a.payback, ");
                    sb.AppendLine("            a.AnimeTime, ");
                    sb.AppendLine("            a.palygeshi, ");
                    sb.AppendLine("            m.mon, ");
                    sb.AppendLine("            y.years, ");
                    sb.AppendLine("            a.Id ");
                    sb.AppendLine(" FROM   Anime as a ");
                    sb.AppendLine(" INNER JOIN montype as m ON a.mon = m.monId ");
                    sb.AppendLine(" INNER JOIN yearstype as y ON a.years = y.yearsId WHERE 1=1");
                    if (!string.IsNullOrEmpty(MyAnime[i])) { 
                    sb.AppendFormat("AND Id={0} ", MyAnime[i]);
                    }
                    else{
                        continue;
                    }
                    if (MyAnime[i] == AnimeId)
                    {
                        MyAnime[i] = "";
                        continue;
                    }
                    if (!string.IsNullOrEmpty(txtuidName.Text.Trim()))
                    {
                        sb.AppendFormat(" AND  a.AnimeName like '%{0}%'", txtuidName.Text.Trim());
                    }
                    if (cboSelect.SelectedIndex > 0)
                    {
                        sb.AppendFormat(" AND  y.years ={0}", cboSelect.Text);
                    }
                    SqlCommand com = new SqlCommand(sb.ToString(), conn);
                    SqlDataReader reader = com.ExecuteReader();
                    if (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(Convert.ToString(reader["AnimeName"]), Convert.ToInt32(reader["Id"]) - 1);
                        item.SubItems.AddRange(new string[]{
                        reader["years"].ToString(),
                        reader["mon"].ToString(),
                        reader["type1"].ToString(),
                        reader["payback"].ToString(),
                        reader["AnimeTime"].ToString(),
                        reader["palygeshi"].ToString()});
                        lvAnime.Items.Add(item);
                    }
                    if (UpdateAnime)
                    {
                        //更新用户的收藏
                        My += " " + MyAnime[i];
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("查找动漫异常!原因:" + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        /// <summary>
        /// 动漫介绍
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmSelect_Click(object sender, EventArgs e)
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
        /// 查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            // 清除之前的数据
            lvAnime.Items.Clear();
            MyAnimefangfa();
            if (Convert.ToString(lvAnime.Items.Count) == "0")
            {
                MessageBox.Show("没有找到相关的信息!", gonggong.tishi);
            }
        }
    }
    }

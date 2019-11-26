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
    public partial class FrmBaiXun : Form
    {
        //属性
        SqlConnection conn = null;
        public FrmBaiXun()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBaiXun_Load(object sender, EventArgs e)
        {
            renqi();
            xinfan();
            shangchuang();
        }

        /// <summary>
        /// 人气排行
        /// </summary>
        public void renqi()
        {
            try
            {
                conn = new SqlConnection(gonggong.connString);
                conn.Open();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(" SELECT     AnimeName, payback ");
                sb.AppendLine(" FROM         Anime ");
                sb.AppendLine(" ORDER BY payback desc ");
                SqlCommand com = new SqlCommand(sb.ToString(), conn);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(reader["AnimeName"]));
                    item.SubItems.AddRange(new string[]{
                        Convert.ToString(reader["payback"])});
                    lvRenQi.Items.Add(item);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("人气排行异常,原因:"+ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 2017新番
        /// </summary>
        public void xinfan()
        {
            try
            {
                conn = new SqlConnection(gonggong.connString);
                conn.Open();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(" SELECT     a.AnimeName, m.mon, y.years ");
                sb.AppendLine(" FROM         Anime as a ");
                sb.AppendLine(" INNER JOIN montype as m ON a.mon = m.monId ");
                sb.AppendLine(" INNER JOIN yearstype as y ON a.years = y.yearsId ");
                sb.AppendLine(" WHERE y.years = 2017 ");
                sb.AppendLine(" order by m.mon desc ");
                SqlCommand com = new SqlCommand(sb.ToString(), conn);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(reader["AnimeName"]));
                    item.SubItems.AddRange(new string[]{
                        Convert.ToString(reader["years"]),
                    Convert.ToString(reader["mon"])});
                    lvXinfan.Items.Add(item);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("2017年新番异常,原因:" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 最新上传
        /// </summary>
        public void shangchuang()
        {
            try
            {
                conn = new SqlConnection(gonggong.connString);
                conn.Open();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(" SELECT     AnimeName, AnimeTime ");
                sb.AppendLine(" FROM         Anime ");
                sb.AppendLine(" order by AnimeTime desc ");
                SqlCommand com = new SqlCommand(sb.ToString(), conn);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(reader["AnimeName"]));
                    item.SubItems.AddRange(new string[]{
                        Convert.ToString(reader["AnimeTime"])});
                    lvNewTime.Items.Add(item);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("最新上传异常,原因:" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

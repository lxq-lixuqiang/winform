using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBanGumiSys
{
    public partial class FrmAnimeGuanLi : Form
    {
        //属性
        SqlConnection conn = null;
        int Id;
        public FrmAnimeGuanLi()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm3_Load(object sender, EventArgs e)
        {
            Select();
            cboSelect.SelectedIndex = 0;
            this.openFileDialog1.Filter = "jpg图片|*.jpg|png图片|*.png";
        }

        public void Select()
        {
            try
            {
                conn = new SqlConnection(gonggong.connString);
                conn.Open();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(" SELECT     a.Id,  ");
                sb.AppendLine("            a.AnimeImg, ");
                sb.AppendLine("            a.AnimeName, ");
                sb.AppendLine("            a.type1, ");
                sb.AppendLine("            a.payback, ");
                sb.AppendLine("            a.AnimeTime, ");
                sb.AppendLine("            a.palygeshi, ");
                sb.AppendLine("            m.mon, ");
                sb.AppendLine("            y.years ");
                sb.AppendLine(" FROM         Anime as a ");
                sb.AppendLine(" INNER JOIN montype as m ON a.mon = m.monId ");
                sb.AppendLine("  INNER JOIN  yearstype as y ON a.years = y.yearsId WHERE 1=1");

                if (!string.IsNullOrEmpty(txtName.Text.Trim()))
                {
                    sb.AppendFormat(" AND  a.AnimeName like '%{0}%'", txtName.Text.Trim());
                }
                if (cboSelect.SelectedIndex > 0)
                {
                    sb.AppendFormat(" AND  y.years ='{0}'", cboSelect.Text);
                }

                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                //查询多值
                SqlDataReader reder = cmd.ExecuteReader();
                if (reder.HasRows)
                {
                    while (reder.Read())
                    {
                        ListViewItem item = new ListViewItem(reder["AnimeName"].ToString(), Convert.ToInt32(reder["Id"]) - 1);
                        item.SubItems.AddRange(new string[]{
                        reder["years"].ToString(),
                        reder["mon"].ToString(),
                        reder["type1"].ToString(),
                        reder["payback"].ToString(),
                        reder["AnimeTime"].ToString(),
                        reder["palygeshi"].ToString()});
                        this.lvAnime.Items.Add(item);
                    }
                    reder.Close();
            }else{
                    MessageBox.Show("没有查询到相关的信息",gonggong.tishi, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
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
        /// 修改信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmUpdate_Click(object sender, EventArgs e)
        {
            if (lvAnime.SelectedItems.Count == 0)
            {
                MessageBox.Show("请先选择一个动漫", gonggong.tishi);
            }
            else {
                try
                {
            lvAnime.Enabled = false;
            btnSelect.Enabled = false;
            (panUpdate as Control).Dock = DockStyle.Right;//Dock向右
             txtName.Enabled = false;
            cboSelect.Enabled = false;
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
                    sb.AppendLine("            a.Id, ");
                    sb.AppendLine("            m.mon, ");
                    sb.AppendLine("            y.years ");
                    sb.AppendLine(" FROM         Anime as a ");
                    sb.AppendLine(" INNER JOIN montype as m ON a.mon = m.monId ");
                    sb.AppendLine(" INNER JOIN yearstype as y ON a.years = y.yearsId ");
                    sb.AppendFormat(" WHERE a.AnimeName='{0}' ", lvAnime.SelectedItems[0].Text);
                    SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
            //查询多值
            SqlDataReader reder = cmd.ExecuteReader();
                if (reder.Read())
                {
                        Id = Convert.ToInt32(reder["Id"]);
                        txtUidName.Text= Convert.ToString(reder["AnimeName"]);
                        txtAnimeImg.Text = Convert.ToString(reder["AnimeImg"]);
                        pibAnimeImg.ImageLocation = txtAnimeImg.Text;
                        txtneirong.Text = Convert.ToString(reder["neirong"]);
                        cbomon.Text = Convert.ToString(reder["mon"]);
                        cbopalygeshi.Text = Convert.ToString(reder["palygeshi"]);
                        cboyears.Text = Convert.ToString(reder["years"]);
                    }
                reder.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("修改信息异常!原因:"+ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            lvAnime.Items.Clear();
            Select();
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttQX_Click(object sender, EventArgs e)
        {
            DialogResult der = MessageBox.Show("确认要取消修改吗？", gonggong.tishi,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (der == DialogResult.Yes)
            {
                lvAnime.Enabled = true;
                btnSelect.Enabled = true;
                (panUpdate as Control).Dock = DockStyle.None;//Dock恢复
                txtName.Enabled = true;
                cboSelect.Enabled = true;
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttXZ_Click(object sender, EventArgs e)
        {
            //非空验证
            if (string.IsNullOrEmpty(txtUidName.Text.Trim()) ||
                string.IsNullOrEmpty(txtneirong.Text.Trim()) ||
                string.IsNullOrEmpty(txtAnimeImg.Text.Trim()))
            {
                MessageBox.Show("信息不能为空!",gonggong.tishi, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { 
            try
            {
                conn = new SqlConnection(gonggong.connString);
                conn.Open();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(" UPDATE    Anime ");
                sb.AppendFormat(" SET   AnimeImg = '{0}',AnimeName = '{1}',years = {2},mon = {3},neirong = '{4}',palygeshi = '{5}' ",
                            txtAnimeImg.Text,
                            txtUidName.Text.Trim(),
                            cboyears.SelectedIndex+1,
                            cbomon.SelectedIndex+1,
                            txtneirong.Text.Trim(),
                            cbopalygeshi.Text);
                sb.AppendFormat(" WHERE Id = {0} ",Id);
                SqlCommand com = new SqlCommand(sb.ToString(), conn);
                int num = com.ExecuteNonQuery();
                if (num > 0)
                {
                    MessageBox.Show("修改成功！", gonggong.tishi);
                    lvAnime.Enabled = true;
                    btnSelect.Enabled = true;
                    (panUpdate as Control).Dock = DockStyle.None;//Dock恢复
                    txtName.Enabled = true;
                    cboSelect.Enabled = true;
                    lvAnime.Items.Clear();
                    Select();
                }
                else
                {
                    MessageBox.Show("修改失败！", gonggong.tishi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改动漫信息异常!原因:"+ex.Message);
            }
            finally
            {
                conn.Close();
            }
            }
        }

        /// <summary>
        /// 图片浏览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnimeImg_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtAnimeImg.Text = openFileDialog1.FileName;
                pibAnimeImg.ImageLocation = txtAnimeImg.Text;
            }
        }
    }
}

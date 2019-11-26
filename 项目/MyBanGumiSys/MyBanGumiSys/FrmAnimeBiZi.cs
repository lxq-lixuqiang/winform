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
    public partial class FrmAnimeBiZi : Form
    {
        //属性
        SqlConnection conn = null;
        int num = 1;
        public FrmAnimeBiZi()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAnimeBiZi_Load(object sender, EventArgs e)
        {
            SelectAnimetu();
        }

        /// <summary>
        /// 查询动漫图片
        /// </summary>
        public void SelectAnimetu()
        {
            try
            {
                if (lvAnimeBizi.Items.Count>0)
                {
                    lvAnimeBizi.Items.Clear();
                }
                conn = new SqlConnection(gonggong.connString);
                conn.Open();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(" SELECT     Id, biziName ");
                sb.AppendLine(" FROM         AnimeBizhi ");
                sb.AppendFormat(" WHERE weizhi ={0} ",num);
                SqlCommand com = new SqlCommand(sb.ToString(), conn);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem("", Convert.ToInt32(reader["Id"]) - 1);
                    lvAnimeBizi.Items.Add(item);
                }
                reader.Close();
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
        /// (1)单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e)
        {
            num = 1;
            SelectAnimetu();
        }

        /// <summary>
        /// (1)移动到上面时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            biankuan(label1);
        }

        /// <summary>
        /// 设置边框
        /// </summary>
        /// <param name="panel"></param>
        public void biankuan(Label label)
        {
            label.BorderStyle = BorderStyle.FixedSingle;
            label.ForeColor = Color.Red;
        }

        /// <summary>
        /// (1)没有移动到上面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            NobianKuan(label1);
        }

        /// <summary>
        /// 无边框设置
        /// </summary>
        /// <param name="label"></param>
        public void NobianKuan(Label label)
        {
            label.BorderStyle = BorderStyle.None;
            label.ForeColor = Color.Black;
        }

        /// <summary>
        /// (2)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label2_MouseLeave(object sender, EventArgs e)
        {
            NobianKuan(label2);
        }

        /// <summary>
        /// (2)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            biankuan(label2);
        }

        /// <summary>
        /// (3)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            biankuan(label4);
        }

        /// <summary>
        /// (3)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label4_MouseLeave(object sender, EventArgs e)
        {
            NobianKuan(label4);
        }

        /// <summary>
        /// (4)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            biankuan(label5);
        }

        /// <summary>
        /// (4)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label5_MouseLeave(object sender, EventArgs e)
        {
            NobianKuan(label5);
        }

        /// <summary>
        /// 都无边框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAnimeBiZi_MouseMove(object sender, MouseEventArgs e)
        {
            label1.BorderStyle = BorderStyle.None;
            label1.ForeColor = Color.Black;

            label2.BorderStyle = BorderStyle.None;
            label2.ForeColor = Color.Black;

            label4.BorderStyle = BorderStyle.None;
            label4.ForeColor = Color.Black;

            label5.BorderStyle = BorderStyle.None;
            label5.ForeColor = Color.Black;
        }

        /// <summary>
        /// (2)单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label2_Click(object sender, EventArgs e)
        {
            num = 2;
            SelectAnimetu();
        }

        /// <summary>
        /// (3)单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label4_Click(object sender, EventArgs e)
        {
            num = 3;
            SelectAnimetu();
        }

        /// <summary>
        /// (4)单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label5_Click(object sender, EventArgs e)
        {
            num = 4;
            SelectAnimetu();
        }

        /// <summary>
        /// 鼠标双击时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvAnimeBizi_DoubleClick(object sender, EventArgs e)
        {
            SelectImg();
        }

        /// <summary>
        /// 查看壁纸
        /// </summary>
        public void SelectImg()
        {
            try
            {
                //显示图片索引Convert.ToString(lvAnimeBizi.SelectedItems[0].ImageIndex+1);
                conn = new SqlConnection(gonggong.connString);
                conn.Open();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(" SELECT     biziName ");
                sb.AppendLine(" FROM         AnimeBizhi ");
                sb.AppendFormat(" WHERE  Id = {0} ", Convert.ToString(lvAnimeBizi.SelectedItems[0].ImageIndex + 1));
                SqlCommand com = new SqlCommand(sb.ToString(), conn);
                string imgName = Convert.ToString(com.ExecuteScalar());
                gonggong.AnimeImage = imgName;
                FrmAnimeImg frm = new FrmAnimeImg();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("鼠标双击异常!原因:" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmSelect_Click(object sender, EventArgs e)
        {
            if (lvAnimeBizi.SelectedItems.Count == 0)
            {
                MessageBox.Show("请先选择一个动漫", gonggong.tishi, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SelectImg();
            }
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmSave_Click(object sender, EventArgs e)
        {
            if (lvAnimeBizi.SelectedItems.Count == 0)
            {
                MessageBox.Show("请先选择一个动漫", gonggong.tishi, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if (gonggong.type != "客 户")
            {
                MessageBox.Show("请先以客户的身份登录才能保存图片!", gonggong.tishi, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string NewTime = DateTime.Now.ToString("yyyy-MM-dd");
                saveFileDialog1.FileName = NewTime; //默认文件名
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("保存成功!",gonggong.tishi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}

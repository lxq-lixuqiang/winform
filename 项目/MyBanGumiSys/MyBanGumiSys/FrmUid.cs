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
    public partial class FrmUid : Form
    {
        DataSet S = new DataSet();
        SqlConnection conn = null;

        public FrmUid()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 查询所有用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView.Enabled = true;
            button1.Enabled = true;
            this.comboBox1.SelectedIndex = 0;
            (panUpdate as Control).Dock = DockStyle.None;//Dock恢复
            textBox1.Enabled = true;
            comboBox1.Enabled = true;
            Select();
        }
        /// <summary>
        /// 按条件查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            S.Tables["UidName"].Clear();
            Select();
        }

        /// <summary>
        /// 按条件查询
        /// </summary>
        public void Select()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(" SELECT [ID] ");
                sb.AppendLine("       ,[UidName] ");
                sb.AppendLine("       ,[UidSex] ");
                sb.AppendLine("       ,[UidPhone] ");
                sb.AppendLine("       ,[UidEmil] ");
                sb.AppendLine("   FROM [UidName] WHERE 1 = 1 ");
                if (comboBox1.Text.Trim() != "全部")
                {
                    sb.AppendFormat("   AND [UidSex] = '{0}' ", comboBox1.Text.Trim());
                }
                if (!string.IsNullOrEmpty(textBox1.Text.Trim()))
                {
                    sb.AppendFormat("   AND [UidName] LIKE '%{0}%' ", textBox1.Text.Trim());
                }
                SqlDataAdapter sda = new SqlDataAdapter(sb.ToString(), gonggong.connString);
                int num = sda.Fill(S, "UidName");
                this.dataGridView.DataSource = S.Tables["UidName"];
                if (num <= 0)
                {
                    MessageBox.Show("没有查询到相关的信息", gonggong.tishi, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 修改用户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtuIdID.Text = Convert.ToString(dataGridView.CurrentRow.Cells["ID"].Value);
            textUidName.Text = Convert.ToString(dataGridView.CurrentRow.Cells["UidName"].Value);
            if (Convert.ToString(dataGridView.CurrentRow.Cells["UidSex"].Value) == "男")
            {
                rbtnan.Checked = true;
            }
            else {
                rtnnv.Checked = true;
            }
            textUidPhone.Text = Convert.ToString(dataGridView.CurrentRow.Cells["UidPhone"].Value);
            textUidEmil.Text = Convert.ToString(dataGridView.CurrentRow.Cells["UidEmil"].Value);
            dataGridView.Enabled = false;
            button1.Enabled = false;
            (panUpdate as Control).Dock = DockStyle.Right;//Dock向右
            textBox1.Enabled = false;
            comboBox1.Enabled = false;

        }

        /// <summary>
        /// 删除用户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除用户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除吗?", gonggong.tishi, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    string uidID = Convert.ToString(dataGridView.CurrentRow.Cells["ID"].Value);
                    conn = new SqlConnection(gonggong.connString);
                    conn.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine(" DELETE FROM UidName ");
                    sb.AppendFormat("  WHERE ID = '{0}' ", uidID);
                    SqlCommand com = new SqlCommand(sb.ToString(), conn);
                    int num = com.ExecuteNonQuery();
                    if (num > 0)
                    {
                        MessageBox.Show("删除成功！", gonggong.tishi);
                        button1_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("删除失败！", gonggong.tishi);
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
                dataGridView.Enabled = true;
                button1.Enabled = true;
                (panUpdate as Control).Dock = DockStyle.None;//Dock恢复
                textBox1.Enabled = true;
                comboBox1.Enabled = true;
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
            if (string.IsNullOrEmpty(this.textUidName.Text.Trim()) ||
               string.IsNullOrEmpty(this.textUidPhone.Text.Trim()))
            {
                MessageBox.Show("信息不能为空！", gonggong.tishi);
            }
            else
            {
                try
                {
                    string uidID = Convert.ToString(dataGridView.CurrentRow.Cells["ID"].Value);
                    conn = new SqlConnection(gonggong.connString);
                    conn.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat("   UPDATE  UidName ");
                    sb.AppendFormat("   SET         UidName = '{0}', UidPhone = '{1}',UidSex = '{2}', UidEmil = '{3}' ",
                        this.textUidName.Text.Trim(),
                        this.textUidPhone.Text.Trim(),
                        this.rbtnan.Checked ? "男" : "女",
                        this.textUidEmil.Text.Trim());
                    sb.AppendFormat("  WHERE [ID] = {0} ", uidID);
                    SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                    int M = cmd.ExecuteNonQuery();
                    if (M > 0)
                    {
                        MessageBox.Show("修改成功！", gonggong.tishi);
                        dataGridView.Enabled = true;
                        button1.Enabled = true;
                        button1_Click(sender, e);
                        (panUpdate as Control).Dock = DockStyle.None;//Dock恢复
                        textBox1.Enabled = true;
                        comboBox1.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("修改失败！",gonggong.tishi);
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
            }
    }
}

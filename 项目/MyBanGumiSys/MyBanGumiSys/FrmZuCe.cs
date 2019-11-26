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
    public partial class FrmZuCe : Form
    {
        SqlConnection conn = null;
        public FrmZuCe()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("确定要取消修改密码吗?",gonggong.tishi, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtpwd.Text.Trim()))
            {
                MessageBox.Show("信息不能为空！", gonggong.tishi, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(txtnewpwd.Text.Trim()!=txtnewpwdci.Text.Trim())
            {
                MessageBox.Show("两次的密码必须一致！", gonggong.tishi, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }else if (txtnewpwd.Text.Trim().Length<5)
            {
                MessageBox.Show("密码必须是5位数以上！", gonggong.tishi, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtpwd.Text.Trim()!=gonggong.uidpwd)
            {
                MessageBox.Show("原密码错误！", gonggong.tishi, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }else
            {
                try
                {
                    conn = new SqlConnection(gonggong.connString);
                    conn.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine(" UPDATE    UidName");
                    sb.AppendFormat(" SET      UidPwd ='{0}' ",txtnewpwd.Text.Trim());
                    sb.AppendFormat(" WHERE      UidName ='{0}' ", txtUidName.Text.Trim());
                    SqlCommand com = new SqlCommand(sb.ToString(), conn);
                    int num = com.ExecuteNonQuery();
                    if (num == 1)
                    {
                        MessageBox.Show("更新成功！",gonggong.tishi);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("更新失败！", gonggong.tishi);
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
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmZuCe_Load(object sender, EventArgs e)
        {
            txtUidName.Text= gonggong.uidName;
        }
    }
}

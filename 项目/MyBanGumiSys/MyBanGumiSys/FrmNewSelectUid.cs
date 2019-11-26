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
    public partial class FrmNewSelectUid : Form
    {
        //属性
        SqlConnection conn = null;
        public FrmNewSelectUid()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认要退出注册窗口吗?", gonggong.tishi, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUidName.Text.Trim()))
            {
                MessageBox.Show("用户名不能为空!", gonggong.tishi, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }else if (string.IsNullOrEmpty(txtUidPwd.Text.Trim()))
            {
                MessageBox.Show("密码不能为空!", gonggong.tishi, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (string.IsNullOrEmpty(txtUidPhone.Text.Trim()))
            {
                MessageBox.Show("电话不能为空!", gonggong.tishi, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtUidPwd.Text.Trim().Length<5)
            {
                MessageBox.Show("密码必须在5位或5位以上!", gonggong.tishi, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (string.IsNullOrEmpty(txtUidPwdque.Text.Trim())!= string.IsNullOrEmpty(txtUidPwd.Text.Trim()))
            {
                MessageBox.Show("两次密码必须一致!", gonggong.tishi, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                try
                {
                    conn = new SqlConnection(gonggong.connString);
                    conn.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine(" INSERT INTO UidName(UidPwd, UidSex, UidPhone, UidEmil, UidName) ");
                    sb.AppendFormat(" VALUES('{0}', '{1}', '{2}', '{3}', '{4}') ",
                                       txtUidPwd.Text.Trim(),
                                       rbnSexnan.Checked ? "男" : "女",
                                       txtUidPhone.Text.Trim(),
                                       txtUidEmil.Text.Trim(),
                                       txtUidName.Text.Trim());
                    SqlCommand com = new SqlCommand(sb.ToString(),conn);
                    int num = com.ExecuteNonQuery();
                    if (num > 0)
                    {
                        MessageBox.Show("注册成功!",gonggong.tishi);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("注册失败!", gonggong.tishi);
                    }  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("注册异常!原因:"+ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

    }
}

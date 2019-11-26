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
    public partial class FrmDengLu : Form
    {
        //属性
        SqlConnection conn = null;
        int yanzhenma;
        public FrmDengLu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 最小化按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptbMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// 最小化按钮移动到图标上方触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptbMin_MouseMove(object sender, MouseEventArgs e)
        {
            ptbMin.ImageLocation = @"..\..\..\..\..\图片\Image 13.png";
        }

        /// <summary>
        /// 最小化按钮鼠标没有移动时显示的状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptbMin_MouseLeave(object sender, EventArgs e)
        {
            ptbMin.ImageLocation = @"..\..\..\..\..\图片\Image 131.png";
        }


        /// <summary>
        /// 退出窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptbExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认要退出登录窗口吗?", gonggong.tishi, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        /// <summary>
        /// 退出按钮移动到图标上方触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptbExit_MouseMove(object sender, MouseEventArgs e)
        {
            ptbExit.ImageLocation = @"..\..\..\..\..\图片\Image 111.png";
        }

        /// <summary>
        /// 退出按钮鼠标没有移动时显示的状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptbExit_MouseLeave(object sender, EventArgs e)
        {
            ptbExit.ImageLocation = @"..\..\..\..\..\图片\Image 11.png";
        }

        //拖动窗口的属性
        int x, y;
        bool IsMove = false;

        /// <summary>
        /// 拖动窗口,移动上方出现效果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMove)
            {
                this.Location = new Point(this.Location.X + (e.X - x), this.Location.Y + (e.Y - y));
            }
        }

        /// <summary>
        /// 拖动窗口，单击未释放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            IsMove = true;
        }

        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmDengLu_Load(object sender, EventArgs e)
        {
            cbotype.SelectedIndex = 0;
            HuanTuPian();
        }

        /// <summary>
        /// 保存键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtuid.Text.Trim()) ||
                string.IsNullOrEmpty(txtpwd.Text.Trim()) ||
                string.IsNullOrEmpty(txtyanzheng.Text.Trim()))
            {
                MessageBox.Show("所有的信息不能为空!",gonggong.tishi, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (Convert.ToString(yanzhenma)!=txtyanzheng.Text.Trim())
            {
                MessageBox.Show("验证码输入错误!", gonggong.tishi, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                HuanTuPian();
                txtyanzheng.Clear();
            }
            else
            {
                try
                {
                conn = new SqlConnection(gonggong.connString);
                    conn.Open();
                StringBuilder sb = new StringBuilder();
                //判断类型
                if(cbotype.Text == "管理员") {
                  sb.AppendLine(" Select Sex ");
                  sb.AppendLine(" from GuanLiYuan ");
                  sb.AppendFormat(" where Name = '{0}' and pwd = '{1}' ", txtuid.Text.Trim(), txtpwd.Text.Trim());
                  gonggong.type = "管理员";
                 }
                 else
                 {
                  sb.AppendLine(" Select uidSex ");
                  sb.AppendLine(" from  UidName ");
                   sb.AppendFormat(" where uidName = '{0}' and uidPwd = '{1}' ", txtuid.Text.Trim(), txtpwd.Text.Trim());
                   gonggong.type = "客 户";
                    }
                
                SqlCommand com = new SqlCommand(sb.ToString(),conn);
                string num =(string)com.ExecuteScalar();
                if (!string.IsNullOrEmpty(num))
                {
                    MessageBox.Show("登录成功！", gonggong.tishi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gonggong.uidName = txtuid.Text.Trim();
                    this.Close();
                    gonggong.Sex = num;
                    gonggong.uidpwd = txtpwd.Text.Trim();
                }
                else
                {
                    MessageBox.Show("登录失败！", gonggong.tishi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("登录异常,原因:"+ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZC_Click(object sender, EventArgs e)
        {
            FrmNewSelectUid frm = new FrmNewSelectUid();
            frm.ShowDialog();
        }

        /// <summary>
        /// 下拉框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbotype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbotype.SelectedIndex == 0)
            {
                txtuid.Text = "莉莉";
                txtpwd.Text = "34322sfd";
            }
            else{
                txtuid.Text = "众云";
                txtpwd.Text = "123456";
            }
        }

        /// <summary>
        /// 换一张图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HuanTuPian();
        }

        int zhuanghui;
        /// <summary>
        /// 验证码更换
        /// </summary>
        public void HuanTuPian()
        {
            //随机数
            Random ran = new Random();
            int num = ran.Next(1000, 9999);
            lalyanzhen.Text = Convert.ToString(num);
                yanzhenma =num;
           
        }

        /// <summary>
        /// 拖动窗口，单击释放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            IsMove = false;
        }
    }
}

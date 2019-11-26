using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBanGumiSys
{
    public partial class FrmGuanYuWoMen : Form
    {
        
        public FrmGuanYuWoMen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 移动到确定上方
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            label3.BorderStyle = BorderStyle.FixedSingle;
        }

        /// <summary>
        /// 没有移动到确定上方
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BorderStyle = BorderStyle.None;
        }

        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmGuanYuWoMen_Load(object sender, EventArgs e)
        {
            if (gonggong.num == 0)
            {
                this.BackgroundImage = Image.FromFile(System.IO.Path.GetFullPath(@"..\..\..\..\..\图片\Image 180445.png"));
                gonggong.num++;
            }
            else if (gonggong.num == 1)
            {
                this.BackgroundImage = Image.FromFile(System.IO.Path.GetFullPath(@"..\..\..\..\..\图片\fa311bd70cf3606ddceeb77151fa945410b14751.png"));
                gonggong.num++;
            }
            else if (gonggong.num == 2)
            {
                this.BackgroundImage = Image.FromFile(System.IO.Path.GetFullPath(@"..\..\..\..\..\图片\a204431de646b59891bf74e13167ad65ae6d9a50.png"));
                gonggong.num++;
            }
            else
            {
                this.BackgroundImage = Image.FromFile(System.IO.Path.GetFullPath(@"..\..\..\..\..\图片\460650e454e8ab3fa1f04bc4e661f798ffe67d83.png"));
                gonggong.num++;
            }
        }
    }
}

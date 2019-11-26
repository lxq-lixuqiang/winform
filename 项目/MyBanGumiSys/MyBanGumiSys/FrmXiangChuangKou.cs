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
    public partial class FrmXiangChuangKou : Form
    {
        public FrmXiangChuangKou()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmXiangChuangKou_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            pictureBox1.BackColor = Color.FromArgb(102, 197, 236);
        }

        int num = 0;
        /// <summary>
        /// 定时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (num ==1)
            {
                pictureBox1.BackColor = Color.FromArgb(42, 176, 230);
                timer1.Interval = 1000;
            }
            else if(num==5)
            {
                timer1.Enabled = false;
                this.Close();
            }
            num++;
        }
    }
}

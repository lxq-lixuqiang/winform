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
    public partial class FrmAnimeImg : Form
    {
        public FrmAnimeImg()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAnimeImg_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(System.IO.Path.GetFullPath(gonggong.AnimeImage));
        }
    }
}

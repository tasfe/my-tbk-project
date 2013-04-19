using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SEND_EMAIL
{
    /// <summary>
    /// 此为任务6：
    /// 功能：根据每个客户生成的推荐邮件。
    /// 为每个客户生成一封邮件，邮件标题建议：淘宝网为您推荐的性价比最高的xxxx,仅供参考
    /// 此任务建议在中午11:30-12：30最合适
    /// 建议可以配置邮箱，不能总用一个邮箱发，防止被gmail封号哦
    /// </summary>
    public partial class SEND_EMAIL : Form
    {
        public SEND_EMAIL()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GET_TBKDATA
{
    /// <summary>
    /// 此为任务4：
    /// 功能：根据任务3获取的每个客户咨询的关键字
    /// 使用淘宝客api获取可以推荐给该顾客的商品，并保存到数据库
    /// 此处也有可能要获取活动，或者整个店铺的推广方式等
    /// 必须得有图片哦
    /// </summary>
    public partial class GET_TBKDATA : Form
    {
        public GET_TBKDATA()
        {
            InitializeComponent();
        }

        private void GET_TBKDATA_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ANALYSE_CHAT
{
    
    /// <summary>
    /// 此为任务3：
    /// 功能：分析任务2中生成的客户的每个人的聊天记录
    /// 得出每个客户要购买的商品，哪怕是类型，
    /// 这里可能需要拿到商品的名称，里边的关键字，可否采用爬虫的方式，拿到类目，价格等
    /// 并保存到数据库
    /// 甚至可以拿到风格，材质等信息，越多越好
    /// 可能需要加一些字典表，来识别究竟要买的是什么东西了
    /// 字典表可以拿淘宝的类目名称，即可作为字典
    /// </summary>
    public partial class ANALYSE_CHAT : Form
    {
        public ANALYSE_CHAT()
        {
            InitializeComponent();
        }

        private void ANALYSE_CHAT_Load(object sender, EventArgs e)
        {

        }
    }
}

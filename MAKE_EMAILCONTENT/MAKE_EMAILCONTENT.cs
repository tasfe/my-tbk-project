using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MAKE_EMAILCONTENT
{
    
    /// <summary>
    /// 此为任务5：
    /// 功能：
    /// 根据任务4获取的需要推荐的内容，
    /// 有些可能有店铺，有些可能有活动，有些可能只有商品
    /// 自动匹配排列（事先应该有模板吧）生成合适的html布局
    /// 此项目要有页面可以预览生成的html，可手动修改
    /// 可配置模板等功能
    /// </summary>
    public partial class MAKE_EMAILCONTENT : Form
    {
        public MAKE_EMAILCONTENT()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

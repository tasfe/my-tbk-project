using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KPI_CUST
{
    /// <summary>
    /// 此为任务1
    /// 功能：以后采用windows任务，配置执行exe的执行时间即可。
    /// 执行时间：每日 00:10，获取昨天的数据
    /// 启动之后，获取kpi数据库中当天未购买
    /// 或者拍单但是未付款的客户信息
    /// 之后插入配置好的数据库中，表：t_kpi_cust
    /// </summary>
   
    public partial class GetKPI_CUST : Form
    {
        public GetKPI_CUST()
        {
            InitializeComponent();
        }

        private void GetKPI_CUST_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRM_CUST
{
    /// <summary>
    /// 此为任务2.
    /// 功能：根据任务1，生成的表，
    /// 去每个对应的bi_crm库，获取该客户的邮箱信息，
    /// 如果没有获取到邮箱的客户舍弃，
    /// 将有邮箱信息的客户存入表 t_crm_cust中
    /// </summary>
    public partial class GETCRM_CUSt : Form
    {
        public GETCRM_CUSt()
        {
            InitializeComponent();
        }

        private void GETCRM_CUSt_Load(object sender, EventArgs e)
        {

        }
    }
}

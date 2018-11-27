using BLL;
using MODEL;
using System;
using System.Data;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmiAplay : Form
    {
        /// <summary>
        /// 播放方式配置
        /// </summary>
        /// <param name="configInfo"></param>
        public FrmiAplay()
        {
            InitializeComponent();
        }
        private void btnAddType_Click(object sender, EventArgs e)
        {
            if (PublicClass.CreateXmlInfo(Application.StartupPath + @"\\" + @"ActionShow.txt", "ActionType", "AcitonId", "ActionName", txtTypeId.Text, txtTypeName.Text))
            {
                MessageBox.Show("添加成功！");
                txtTypeId.Clear();
                txtTypeName.Clear();
                txtTypeId.Focus();
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }
    }
}

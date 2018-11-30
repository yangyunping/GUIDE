using BLL;
using MODEL;
using System;
using System.Data;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmOperateLED : Form
    {
        BllScreeenSetting screeenSetting = new BllScreeenSetting();
        /// <summary>
        /// 播放方式配置
        /// </summary>
        /// <param name="configInfo"></param>
        public FrmOperateLED()
        {
            InitializeComponent();

            //屏幕信息
            DataTable dtScreen = screeenSetting.GetScreenSetting(string.Empty);
            cmbLEDId.ValueMember = "AddressNum";
            cmbLEDId.DisplayMember = "ScreenID";
            cmbLEDId.DataSource = dtScreen;
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

        private void btnClearProgram_Click(object sender, EventArgs e)
        {
            LEDShow.DeleteProgram(Convert.ToInt32(cmbLEDId.SelectedValue));//删除指定控制卡所有节目
            MessageBox.Show("清除屏幕已保存显示！");
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (LEDShow.User_OpenScreen(Convert.ToInt32(cmbLEDId.SelectedValue)))
            {
                MessageBox.Show("开屏成功！");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (LEDShow.User_CloseScreen(Convert.ToInt32(cmbLEDId.SelectedValue)))
            {
                MessageBox.Show("关屏成功！");
            }
        }
    }
}

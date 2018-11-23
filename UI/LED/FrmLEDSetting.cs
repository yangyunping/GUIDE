using MODEL;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmLEDSetting : Form
    {
        public readonly string _EQSetPath = Application.StartupPath + @"\\" + @"EQ2008_Dll_Set.ini";//配置文件存放路径
        public FrmLEDSetting()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 添加控制卡参数到配置文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            int carTpe = 0;
            if (cmbControlType.Text.Equals("21-EQ2013"))
            {
                carTpe = 21;
            }
            else if (cmbControlType.Text.Equals("22-EQ2023"))
            {
                carTpe = 22;
            }
            else if (cmbControlType.Text.Equals("23-EQ2033"))
            {
                carTpe = 23;
            }
            else
            {
                MessageBox.Show("信息不全!");
                return;
            }
            int colorStyle = 0;
            if (cmbColor.Text.Equals("单色"))
            {
                colorStyle = 0;
            }
            else if (cmbColor.Text.Equals("双色"))
            {
                colorStyle = 1;
            }

            PublicClass.WritePrivateProfileString(@"地址：" + Convert.ToInt32(cmbControlnerAdress.Text), "CardType", carTpe.ToString(), _EQSetPath);//控制类型
            PublicClass.WritePrivateProfileString(@"地址：" + Convert.ToInt32(cmbControlnerAdress.Text), "CardAddress", cmbControlnerAdress.Text, _EQSetPath);//控制地址
            PublicClass.WritePrivateProfileString(@"地址：" + Convert.ToInt32(cmbControlnerAdress.Text), "CommunicationMode", "1", _EQSetPath);//通讯方式
            PublicClass.WritePrivateProfileString(@"地址：" + Convert.ToInt32(cmbControlnerAdress.Text), "ScreemHeight", txtWidth.Text, _EQSetPath);//显示屏宽度
            PublicClass.WritePrivateProfileString(@"地址：" + Convert.ToInt32(cmbControlnerAdress.Text), "ScreemWidth", txtHeight.Text, _EQSetPath);//显示屏高度
            PublicClass.WritePrivateProfileString(@"地址：" + Convert.ToInt32(cmbControlnerAdress.Text), "SerialBaud", "57600", _EQSetPath);//串口通信波特率
            PublicClass.WritePrivateProfileString(@"地址：" + Convert.ToInt32(cmbControlnerAdress.Text), "SerialNum","1", _EQSetPath);//串口通信串口号
            PublicClass.WritePrivateProfileString(@"地址：" + Convert.ToInt32(cmbControlnerAdress.Text), "NetPort", "5005", _EQSetPath);//网络通信端口号
            PublicClass.WritePrivateProfileString(@"地址：" + Convert.ToInt32(cmbControlnerAdress.Text), "IpAddress0", IpAddress0.Text, _EQSetPath); //IP地址
            PublicClass.WritePrivateProfileString(@"地址：" + Convert.ToInt32(cmbControlnerAdress.Text), "IpAddress1", IpAddress1.Text, _EQSetPath); 
            PublicClass.WritePrivateProfileString(@"地址：" + Convert.ToInt32(cmbControlnerAdress.Text), "IpAddress2", IpAddress2.Text, _EQSetPath);
            PublicClass.WritePrivateProfileString(@"地址：" + Convert.ToInt32(cmbControlnerAdress.Text), "IpAddress3", IpAddress3.Text, _EQSetPath);
            PublicClass.WritePrivateProfileString(@"地址：" + Convert.ToInt32(cmbControlnerAdress.Text), "ColorStyle", colorStyle.ToString(), _EQSetPath); //显示屏颜色类型

            MessageBox.Show("保存成功！");
        }
        /// <summary>
        /// 添加EQ动态库提供的播放方式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// 匹配LED编号和控制卡地址码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddLED_Click(object sender, EventArgs e)
        {
            if (PublicClass.CreateXmlInfo(Application.StartupPath + @"\\" + @"LEDSetting.txt", "LEDNum", "LEDid", "LEDAddress", txtLEDid.Text, txtAdress.Text))
            {
                MessageBox.Show("添加成功！");
                txtLEDid.Clear();
                txtAdress.Clear();
                txtLEDid.Focus();
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        private void txtTypeName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddType_Click(null, null);
            }
        }

        private void txtAdress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddLED_Click(null, null);
            }
        }
    }
}

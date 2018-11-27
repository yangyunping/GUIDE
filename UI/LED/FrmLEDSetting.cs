using MODEL;
using System;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class FrmLEDSetting : Form
    {
        public readonly string _EQSetPath = Application.StartupPath + @"\\" + @"EQ2008_Dll_Set.ini";//配置文件存放路径
        BllScreeenSetting bllScreeenSetting = new BllScreeenSetting();
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
         
            ScreeenSetting screeenSetting = new ScreeenSetting();
            screeenSetting.ScreenID = txtLEDid.Text.Trim();
            screeenSetting.ScreenWidth = Convert.ToInt32(txtWidth.Text);
            screeenSetting.ScreenHeight = Convert.ToInt32(txtHeight.Text);
            screeenSetting.AddressNum = Convert.ToInt32(cmbCarAdress.Text);
            screeenSetting.CarName = cmbControlType.Text;
            screeenSetting.ColorStyle = cmbColor.Text;
            screeenSetting.IpAddress = IpAddress0.Text +"."+ IpAddress1.Text + "." + IpAddress2.Text + "." + IpAddress3.Text;
            bllScreeenSetting.InsertScreenSetting(screeenSetting);

            //保存到EQ诣阔LED动态库指定的文件里
            PublicClass.WritePrivateProfileString(@"地址：" + (Convert.ToInt32(cmbCarAdress.Text)-1), "CardType", carTpe.ToString(), _EQSetPath);//控制类型
            PublicClass.WritePrivateProfileString(@"地址：" + (Convert.ToInt32(cmbCarAdress.Text)-1), "CardAddress", (Convert.ToInt32(cmbCarAdress.Text) - 1).ToString(), _EQSetPath);//控制地址
            PublicClass.WritePrivateProfileString(@"地址：" + (Convert.ToInt32(cmbCarAdress.Text)-1), "CommunicationMode", "1", _EQSetPath);//通讯方式
            PublicClass.WritePrivateProfileString(@"地址：" + (Convert.ToInt32(cmbCarAdress.Text)-1), "ScreemWidth", txtWidth.Text, _EQSetPath);//显示屏宽度
            PublicClass.WritePrivateProfileString(@"地址：" + (Convert.ToInt32(cmbCarAdress.Text)-1), "ScreemHeight", txtHeight.Text, _EQSetPath);//显示屏高度
            PublicClass.WritePrivateProfileString(@"地址：" + (Convert.ToInt32(cmbCarAdress.Text)-1), "SerialBaud", "57600", _EQSetPath);//串口通信波特率
            PublicClass.WritePrivateProfileString(@"地址：" + (Convert.ToInt32(cmbCarAdress.Text)-1), "SerialNum","1", _EQSetPath);//串口通信串口号
            PublicClass.WritePrivateProfileString(@"地址：" + (Convert.ToInt32(cmbCarAdress.Text)-1), "NetPort", "5005", _EQSetPath);//网络通信端口号
            PublicClass.WritePrivateProfileString(@"地址：" + (Convert.ToInt32(cmbCarAdress.Text)-1), "IpAddress0", IpAddress0.Text, _EQSetPath); //IP地址
            PublicClass.WritePrivateProfileString(@"地址：" + (Convert.ToInt32(cmbCarAdress.Text)-1), "IpAddress1", IpAddress1.Text, _EQSetPath); 
            PublicClass.WritePrivateProfileString(@"地址：" + (Convert.ToInt32(cmbCarAdress.Text)-1), "IpAddress2", IpAddress2.Text, _EQSetPath);
            PublicClass.WritePrivateProfileString(@"地址：" + (Convert.ToInt32(cmbCarAdress.Text)-1), "IpAddress3", IpAddress3.Text, _EQSetPath);
            PublicClass.WritePrivateProfileString(@"地址：" + (Convert.ToInt32(cmbCarAdress.Text)-1), "ColorStyle", colorStyle.ToString(), _EQSetPath); //显示屏颜色类型

            MessageBox.Show("保存成功！");
        }

        /// <summary>
        /// 匹配LED编号和控制卡地址码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddLEDTxt()
        {
            if (PublicClass.CreateXmlInfo(Application.StartupPath + @"\\" + @"LEDSetting.txt", "LEDNum", "LEDid", "LEDAddress", txtLEDid.Text, cmbCarAdress.Text))
            {
                MessageBox.Show("添加成功！");
                txtLEDid.Clear();
                txtLEDid.Focus();
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }
    }
}

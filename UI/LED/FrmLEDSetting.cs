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
        private int id = -1;
        public FrmLEDSetting()
        {
            InitializeComponent();
        }
        public FrmLEDSetting(ScreenSetting screeenSetting)
        {
            InitializeComponent();
            id = screeenSetting.ID;
            txtLEDid.Text = screeenSetting.ScreenID;
            txtWidth.Text = screeenSetting.ScreenWidth.ToString();
            txtHeight.Text = screeenSetting.ScreenHeight.ToString();
            cmbControlType.Text = screeenSetting.CarName;
            cmbCarAdress.Text = screeenSetting.AddressNum.ToString();
            cmbColor.Text = screeenSetting.ColorStyle;
            IpAddress0.Text = screeenSetting.IpAddress.Split('.')[0].ToString();
            IpAddress1.Text = screeenSetting.IpAddress.Split('.')[1].ToString();
            IpAddress2.Text = screeenSetting.IpAddress.Split('.')[2].ToString(); 
            IpAddress3.Text = screeenSetting.IpAddress.Split('.')[3].ToString();
            txtFontSize.Text = screeenSetting.FontSize.ToString();
        }
        /// <summary>
        /// 添加控制卡参数到配置文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
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

                ScreenSetting screenSetting = new ScreenSetting();
                screenSetting.ScreenID = txtLEDid.Text.Trim();
                screenSetting.ScreenWidth = Convert.ToInt32(txtWidth.Text);
                screenSetting.ScreenHeight = Convert.ToInt32(txtHeight.Text);
                screenSetting.AddressNum = Convert.ToInt32(cmbCarAdress.Text);
                screenSetting.CarName = cmbControlType.Text;
                screenSetting.ColorStyle = cmbColor.Text;
                screenSetting.IpAddress = IpAddress0.Text + "." + IpAddress1.Text + "." + IpAddress2.Text + "." + IpAddress3.Text;
                screenSetting.FontSize = Convert.ToInt32(txtFontSize.Text);
                if (id == -1)//判断是修改还是新增
                {
                    bllScreeenSetting.InsertScreenSetting(screenSetting);
                }
                else
                {
                    screenSetting.ID = id;
                    bllScreeenSetting.UpdateScreenSetting(screenSetting);
                }
              

                //保存到EQ诣阔LED动态库指定的文件里
                PublicClass.WritePrivateProfileString(@"地址：" + (Convert.ToInt32(cmbCarAdress.Text) - 1), "CardType", carTpe.ToString(), _EQSetPath);//控制类型
                PublicClass.WritePrivateProfileString(@"地址：" + (Convert.ToInt32(cmbCarAdress.Text) - 1), "CardAddress", (Convert.ToInt32(cmbCarAdress.Text) - 1).ToString(), _EQSetPath);//控制地址
                PublicClass.WritePrivateProfileString(@"地址：" + (Convert.ToInt32(cmbCarAdress.Text) - 1), "CommunicationMode", "1", _EQSetPath);//通讯方式
                PublicClass.WritePrivateProfileString(@"地址：" + (Convert.ToInt32(cmbCarAdress.Text) - 1), "ScreemWidth", txtWidth.Text, _EQSetPath);//显示屏宽度
                PublicClass.WritePrivateProfileString(@"地址：" + (Convert.ToInt32(cmbCarAdress.Text) - 1), "ScreemHeight", txtHeight.Text, _EQSetPath);//显示屏高度
                PublicClass.WritePrivateProfileString(@"地址：" + (Convert.ToInt32(cmbCarAdress.Text) - 1), "SerialBaud", "57600", _EQSetPath);//串口通信波特率
                PublicClass.WritePrivateProfileString(@"地址：" + (Convert.ToInt32(cmbCarAdress.Text) - 1), "SerialNum", "1", _EQSetPath);//串口通信串口号
                PublicClass.WritePrivateProfileString(@"地址：" + (Convert.ToInt32(cmbCarAdress.Text) - 1), "NetPort", "5005", _EQSetPath);//网络通信端口号
                PublicClass.WritePrivateProfileString(@"地址：" + (Convert.ToInt32(cmbCarAdress.Text) - 1), "IpAddress0", IpAddress0.Text, _EQSetPath); //IP地址
                PublicClass.WritePrivateProfileString(@"地址：" + (Convert.ToInt32(cmbCarAdress.Text) - 1), "IpAddress1", IpAddress1.Text, _EQSetPath);
                PublicClass.WritePrivateProfileString(@"地址：" + (Convert.ToInt32(cmbCarAdress.Text) - 1), "IpAddress2", IpAddress2.Text, _EQSetPath);
                PublicClass.WritePrivateProfileString(@"地址：" + (Convert.ToInt32(cmbCarAdress.Text) - 1), "IpAddress3", IpAddress3.Text, _EQSetPath);
                PublicClass.WritePrivateProfileString(@"地址：" + (Convert.ToInt32(cmbCarAdress.Text) - 1), "ColorStyle", colorStyle.ToString(), _EQSetPath); //显示屏颜色类型

                MessageBox.Show("保存成功！");
                if (id != -1)
                {
                    this.Close();//修改完关闭窗体
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbColor.Text.Equals("双色"))
            {
                btnFontColor.Enabled = true;
            }
            else
            {
                btnFontColor.Enabled = false;
            }
        }
    }
}

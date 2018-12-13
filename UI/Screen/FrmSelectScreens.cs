using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UI.LED
{
    public partial class FrmSelectScreens : Form
    {
        BllScreeenSetting bllScreeenSetting = new BllScreeenSetting();
        public FrmSelectScreens()
        {
            InitializeComponent();

            //LED编号
            //屏幕信息
            DataTable dtScreen = bllScreeenSetting.GetScreenSetting(string.Empty);
            lstScreenIds.DataSource = dtScreen;
            lstScreenIds.ValueMember = "AddressNum";
            lstScreenIds.DisplayMember = "ScreenID";
        }
    }
}

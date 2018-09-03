using BLL;
using MODEL;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmConfigAdd : UserControl
    {
        BlllConfiguration blllConfiguration = new BlllConfiguration();
        public FrmConfigAdd()
        {
            InitializeComponent();
        }
        public FrmConfigAdd(Configuration configuration)
        {
            InitializeComponent();
            txtConfigNo.Text = configuration.ConfigName;
            GroupNum.Value = configuration.ConfigNum;
            txtConfigNo.ReadOnly = true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtConfigNo.Text) || GroupNum.Value == 0)
                {
                    MessageBox.Show("添加有误（编组不能为0），请完善核对信息!");
                    return;
                }
                Configuration configuration = new Configuration();
                configuration.ConfigName = txtConfigNo.Text;
                configuration.ConfigNum = Convert.ToInt32(GroupNum.Value);
                if (blllConfiguration.InsertOrModifyConfig(configuration))
                {
                    MessageBox.Show("添加修改成功！");
                    txtConfigNo.Clear();
                    GroupNum.Value = 0;
                }
                else
                {
                    MessageBox.Show("添加修改失败！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ((Form)this.Parent)?.Close();
        }
    }
}

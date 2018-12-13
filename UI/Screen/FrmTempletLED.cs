using MODEL;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class FrmTempletLED : Form
    {
        BllTempletShow bllTempletShow = new BllTempletShow();
        private int templetId = -1;
        public FrmTempletLED()
        {
            InitializeComponent();
        }
        public FrmTempletLED(TempletShow templetShow)
        {
            InitializeComponent();
            templetId = templetShow.ID;
            txtContent.Text = templetShow.ShowContent;
        }

        private void btnSava_Click(object sender, EventArgs e)
        {
            try
            {
                TempletShow templetShow = new TempletShow();
                templetShow.ShowContent = txtContent.Text.Trim();
                if (!string.IsNullOrEmpty(txtContent.Text))
                {
                    if (templetId == -1)
                    {
                        if (bllTempletShow.InsertTempletShow(templetShow))
                        {
                            MessageBox.Show("添加模板成功！");
                            txtContent.Clear();
                        }
                    }
                    else
                    {
                        templetShow.ID = templetId;
                        if (bllTempletShow.ModifyTempletShow(templetShow))
                        {
                            MessageBox.Show("修改模板成功！");
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请完善信息！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

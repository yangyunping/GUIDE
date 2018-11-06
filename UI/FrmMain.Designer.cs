namespace UI
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tdbShow = new System.Windows.Forms.ToolStripDropDownButton();
            this.AreaShowSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSreen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConfigNum = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.皮肤更换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.密码修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSearchManage = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbBegin = new System.Windows.Forms.ToolStripButton();
            this.tsbEmployee = new System.Windows.Forms.ToolStripButton();
            this.tsbConfig = new System.Windows.Forms.ToolStripButton();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.pnlThemes = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOrigal = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lstContent = new System.Windows.Forms.ListBox();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.pnlShow = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.pnlThemes.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStrip1.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tdbShow,
            this.tsmSearchManage,
            this.tsbBegin,
            this.tsbEmployee,
            this.tsbConfig,
            this.tsbClear});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(924, 42);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tdbShow
            // 
            this.tdbShow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AreaShowSearch,
            this.tsmSreen,
            this.tsmConfigNum,
            this.tsmSetting,
            this.皮肤更换ToolStripMenuItem,
            this.密码修改ToolStripMenuItem});
            this.tdbShow.Image = global::UI.Properties.Resources.homescreen;
            this.tdbShow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tdbShow.Name = "tdbShow";
            this.tdbShow.Size = new System.Drawing.Size(117, 39);
            this.tdbShow.Text = "显示配置";
            // 
            // AreaShowSearch
            // 
            this.AreaShowSearch.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.AreaShowSearch.Name = "AreaShowSearch";
            this.AreaShowSearch.Size = new System.Drawing.Size(180, 24);
            this.AreaShowSearch.Text = "区域设置";
            this.AreaShowSearch.Click += new System.EventHandler(this.AreaShowSearch_Click);
            // 
            // tsmSreen
            // 
            this.tsmSreen.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.tsmSreen.Name = "tsmSreen";
            this.tsmSreen.Size = new System.Drawing.Size(180, 24);
            this.tsmSreen.Text = "显示器设置";
            this.tsmSreen.Click += new System.EventHandler(this.tsmSreen_Click);
            // 
            // tsmConfigNum
            // 
            this.tsmConfigNum.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.tsmConfigNum.Name = "tsmConfigNum";
            this.tsmConfigNum.Size = new System.Drawing.Size(180, 24);
            this.tsmConfigNum.Text = "编组设置";
            this.tsmConfigNum.Click += new System.EventHandler(this.配置查询ToolStripMenuItem_Click);
            // 
            // tsmSetting
            // 
            this.tsmSetting.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.tsmSetting.Name = "tsmSetting";
            this.tsmSetting.Size = new System.Drawing.Size(180, 24);
            this.tsmSetting.Text = "列表顺序设置";
            this.tsmSetting.Click += new System.EventHandler(this.设置ToolStripMenuItem_Click);
            // 
            // 皮肤更换ToolStripMenuItem
            // 
            this.皮肤更换ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.皮肤更换ToolStripMenuItem.Name = "皮肤更换ToolStripMenuItem";
            this.皮肤更换ToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.皮肤更换ToolStripMenuItem.Text = "皮肤更换";
            this.皮肤更换ToolStripMenuItem.Click += new System.EventHandler(this.皮肤更换ToolStripMenuItem_Click);
            // 
            // 密码修改ToolStripMenuItem
            // 
            this.密码修改ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.密码修改ToolStripMenuItem.Name = "密码修改ToolStripMenuItem";
            this.密码修改ToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.密码修改ToolStripMenuItem.Text = "密码修改";
            this.密码修改ToolStripMenuItem.Click += new System.EventHandler(this.密码修改ToolStripMenuItem_Click);
            // 
            // tsmSearchManage
            // 
            this.tsmSearchManage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmSearchManage.Image = ((System.Drawing.Image)(resources.GetObject("tsmSearchManage.Image")));
            this.tsmSearchManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmSearchManage.Name = "tsmSearchManage";
            this.tsmSearchManage.Size = new System.Drawing.Size(82, 39);
            this.tsmSearchManage.Text = "查询管理";
            this.tsmSearchManage.Click += new System.EventHandler(this.tsmSearchManage_Click);
            // 
            // tsbBegin
            // 
            this.tsbBegin.Image = global::UI.Properties.Resources.player_play;
            this.tsbBegin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBegin.Name = "tsbBegin";
            this.tsbBegin.Size = new System.Drawing.Size(78, 39);
            this.tsbBegin.Text = "启动";
            this.tsbBegin.Click += new System.EventHandler(this.tsbBegin_Click);
            // 
            // tsbEmployee
            // 
            this.tsbEmployee.Image = global::UI.Properties.Resources.Users;
            this.tsbEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEmployee.Name = "tsbEmployee";
            this.tsbEmployee.Size = new System.Drawing.Size(108, 39);
            this.tsbEmployee.Text = "员工管理";
            this.tsbEmployee.Click += new System.EventHandler(this.tsbEmployee_Click);
            // 
            // tsbConfig
            // 
            this.tsbConfig.Image = global::UI.Properties.Resources.System;
            this.tsbConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConfig.Name = "tsbConfig";
            this.tsbConfig.Size = new System.Drawing.Size(108, 39);
            this.tsbConfig.Text = "配置信息";
            this.tsbConfig.Click += new System.EventHandler(this.tsbConfig_Click);
            // 
            // tsbClear
            // 
            this.tsbClear.Image = global::UI.Properties.Resources.Recicle_bin;
            this.tsbClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClear.Name = "tsbClear";
            this.tsbClear.Size = new System.Drawing.Size(108, 39);
            this.tsbClear.Text = "清空界面";
            this.tsbClear.Click += new System.EventHandler(this.tsbClear_Click);
            // 
            // pnlThemes
            // 
            this.pnlThemes.Controls.Add(this.btnClose);
            this.pnlThemes.Controls.Add(this.btnOrigal);
            this.pnlThemes.Controls.Add(this.btnSave);
            this.pnlThemes.Controls.Add(this.lstContent);
            this.pnlThemes.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlThemes.Location = new System.Drawing.Point(0, 42);
            this.pnlThemes.Name = "pnlThemes";
            this.pnlThemes.Size = new System.Drawing.Size(318, 510);
            this.pnlThemes.TabIndex = 0;
            this.pnlThemes.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(227, 137);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 31);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "关  闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOrigal
            // 
            this.btnOrigal.Location = new System.Drawing.Point(227, 79);
            this.btnOrigal.Name = "btnOrigal";
            this.btnOrigal.Size = new System.Drawing.Size(75, 31);
            this.btnOrigal.TabIndex = 2;
            this.btnOrigal.Text = "恢复默认";
            this.btnOrigal.UseVisualStyleBackColor = true;
            this.btnOrigal.Click += new System.EventHandler(this.btnOrigal_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(227, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 31);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保 存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lstContent
            // 
            this.lstContent.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstContent.FormattingEnabled = true;
            this.lstContent.ItemHeight = 12;
            this.lstContent.Location = new System.Drawing.Point(0, 0);
            this.lstContent.Name = "lstContent";
            this.lstContent.Size = new System.Drawing.Size(221, 510);
            this.lstContent.TabIndex = 0;
            this.lstContent.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // pnlShow
            // 
            this.pnlShow.AutoSize = true;
            this.pnlShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlShow.Location = new System.Drawing.Point(318, 42);
            this.pnlShow.Name = "pnlShow";
            this.pnlShow.Size = new System.Drawing.Size(606, 510);
            this.pnlShow.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 552);
            this.Controls.Add(this.pnlShow);
            this.Controls.Add(this.pnlThemes);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "引导管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlThemes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tdbShow;
        private System.Windows.Forms.ToolStripMenuItem AreaShowSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmConfigNum;
        private System.Windows.Forms.ToolStripMenuItem tsmSetting;
        private System.Windows.Forms.ToolStripButton tsbClear;
        private System.Windows.Forms.ToolStripDropDownButton tsmSearchManage;
        private System.Windows.Forms.ToolStripButton tsbBegin;
        private System.Windows.Forms.ToolStripButton tsbEmployee;
        private System.Windows.Forms.ToolStripButton tsbConfig;
        private System.Windows.Forms.ToolStripMenuItem tsmSreen;
        private System.Windows.Forms.ToolStripMenuItem 皮肤更换ToolStripMenuItem;
        private System.Windows.Forms.Panel pnlThemes;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOrigal;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lstContent;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Panel pnlShow;
        private System.Windows.Forms.ToolStripMenuItem 密码修改ToolStripMenuItem;
    }
}


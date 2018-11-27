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
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tdbShow = new System.Windows.Forms.ToolStripDropDownButton();
            this.AreaShowSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSreenToArea = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAplay = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScreenSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.皮肤更换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.密码修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmByOrderSet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmResetOrderShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmTempletShow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTepletSet = new System.Windows.Forms.ToolStripMenuItem();
            this.模板查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDefinedShow = new System.Windows.Forms.ToolStripButton();
            this.tsmReadyShow = new System.Windows.Forms.ToolStripButton();
            this.tsbEmployee = new System.Windows.Forms.ToolStripButton();
            this.tsbConfig = new System.Windows.Forms.ToolStripButton();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.pnlThemes = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOrigal = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lstContent = new System.Windows.Forms.ListBox();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.pnlShow = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lED查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton1,
            this.tsmDefinedShow,
            this.tsmReadyShow,
            this.tsbEmployee,
            this.tsbConfig,
            this.tsbClear,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1044, 42);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tdbShow
            // 
            this.tdbShow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AreaShowSearch,
            this.tsmSreenToArea,
            this.tsmiAplay,
            this.tsmScreenSetting,
            this.lED查询ToolStripMenuItem,
            this.皮肤更换ToolStripMenuItem,
            this.密码修改ToolStripMenuItem});
            this.tdbShow.Image = global::UI.Properties.Resources.homescreen;
            this.tdbShow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tdbShow.Name = "tdbShow";
            this.tdbShow.Size = new System.Drawing.Size(117, 39);
            this.tdbShow.Text = "系统设置";
            // 
            // AreaShowSearch
            // 
            this.AreaShowSearch.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.AreaShowSearch.Name = "AreaShowSearch";
            this.AreaShowSearch.Size = new System.Drawing.Size(180, 24);
            this.AreaShowSearch.Text = "区域设置";
            this.AreaShowSearch.Click += new System.EventHandler(this.AreaShowSearch_Click);
            // 
            // tsmSreenToArea
            // 
            this.tsmSreenToArea.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.tsmSreenToArea.Name = "tsmSreenToArea";
            this.tsmSreenToArea.Size = new System.Drawing.Size(180, 24);
            this.tsmSreenToArea.Text = "区域LED匹配";
            this.tsmSreenToArea.Click += new System.EventHandler(this.tsmSreen_Click);
            // 
            // tsmiAplay
            // 
            this.tsmiAplay.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.tsmiAplay.Name = "tsmiAplay";
            this.tsmiAplay.Size = new System.Drawing.Size(180, 24);
            this.tsmiAplay.Text = "播放方式配置";
            this.tsmiAplay.Visible = false;
            this.tsmiAplay.Click += new System.EventHandler(this.配置查询ToolStripMenuItem_Click);
            // 
            // tsmScreenSetting
            // 
            this.tsmScreenSetting.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.tsmScreenSetting.Name = "tsmScreenSetting";
            this.tsmScreenSetting.Size = new System.Drawing.Size(180, 24);
            this.tsmScreenSetting.Text = "LED参数配置";
            this.tsmScreenSetting.Click += new System.EventHandler(this.lED参数配置ToolStripMenuItem_Click);
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
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmByOrderSet,
            this.tsmResetOrderShow});
            this.toolStripDropDownButton2.Image = global::UI.Properties.Resources.clock_alt;
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(117, 39);
            this.toolStripDropDownButton2.Text = "排序显示";
            // 
            // tsmByOrderSet
            // 
            this.tsmByOrderSet.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.tsmByOrderSet.Name = "tsmByOrderSet";
            this.tsmByOrderSet.Size = new System.Drawing.Size(180, 24);
            this.tsmByOrderSet.Text = "排序设置";
            this.tsmByOrderSet.Click += new System.EventHandler(this.排序设置ToolStripMenuItem_Click);
            // 
            // tsmResetOrderShow
            // 
            this.tsmResetOrderShow.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.tsmResetOrderShow.Name = "tsmResetOrderShow";
            this.tsmResetOrderShow.Size = new System.Drawing.Size(180, 24);
            this.tsmResetOrderShow.Text = "重置预显示";
            this.tsmResetOrderShow.Click += new System.EventHandler(this.lED显示ToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTempletShow,
            this.tsmTepletSet,
            this.模板查询ToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::UI.Properties.Resources.Laptop_white;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(117, 39);
            this.toolStripDropDownButton1.Text = "模板显示";
            // 
            // tsmTempletShow
            // 
            this.tsmTempletShow.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.tsmTempletShow.Name = "tsmTempletShow";
            this.tsmTempletShow.Size = new System.Drawing.Size(180, 24);
            this.tsmTempletShow.Text = "模板LED显示";
            this.tsmTempletShow.Click += new System.EventHandler(this.模板显示ToolStripMenuItem_Click);
            // 
            // tsmTepletSet
            // 
            this.tsmTepletSet.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.tsmTepletSet.Name = "tsmTepletSet";
            this.tsmTepletSet.Size = new System.Drawing.Size(180, 24);
            this.tsmTepletSet.Text = "模板设置";
            this.tsmTepletSet.Click += new System.EventHandler(this.模板设置ToolStripMenuItem_Click);
            // 
            // 模板查询ToolStripMenuItem
            // 
            this.模板查询ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.模板查询ToolStripMenuItem.Name = "模板查询ToolStripMenuItem";
            this.模板查询ToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.模板查询ToolStripMenuItem.Text = "模板查询";
            this.模板查询ToolStripMenuItem.Click += new System.EventHandler(this.模板查询ToolStripMenuItem_Click);
            // 
            // tsmDefinedShow
            // 
            this.tsmDefinedShow.Image = global::UI.Properties.Resources.Applications;
            this.tsmDefinedShow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmDefinedShow.Name = "tsmDefinedShow";
            this.tsmDefinedShow.Size = new System.Drawing.Size(123, 39);
            this.tsmDefinedShow.Text = "自定义显示";
            this.tsmDefinedShow.Click += new System.EventHandler(this.tsmDefinedShow_Click);
            // 
            // tsmReadyShow
            // 
            this.tsmReadyShow.Image = global::UI.Properties.Resources.universalsearch;
            this.tsmReadyShow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmReadyShow.Name = "tsmReadyShow";
            this.tsmReadyShow.Size = new System.Drawing.Size(123, 39);
            this.tsmReadyShow.Text = "预显示查询";
            this.tsmReadyShow.Click += new System.EventHandler(this.tsmReadyShow_Click);
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
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 39);
            this.toolStripButton1.Text = "toolStripButton1";
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
            this.pnlThemes.Size = new System.Drawing.Size(318, 398);
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
            this.lstContent.Size = new System.Drawing.Size(221, 398);
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
            this.pnlShow.Size = new System.Drawing.Size(726, 398);
            this.pnlShow.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lED查询ToolStripMenuItem
            // 
            this.lED查询ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.lED查询ToolStripMenuItem.Name = "lED查询ToolStripMenuItem";
            this.lED查询ToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.lED查询ToolStripMenuItem.Text = "LED查询";
            this.lED查询ToolStripMenuItem.Click += new System.EventHandler(this.lED查询ToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1044, 440);
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
        private System.Windows.Forms.ToolStripMenuItem tsmiAplay;
        private System.Windows.Forms.ToolStripButton tsbClear;
        private System.Windows.Forms.ToolStripButton tsbEmployee;
        private System.Windows.Forms.ToolStripButton tsbConfig;
        private System.Windows.Forms.ToolStripMenuItem tsmSreenToArea;
        private System.Windows.Forms.ToolStripMenuItem 皮肤更换ToolStripMenuItem;
        private System.Windows.Forms.Panel pnlThemes;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOrigal;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lstContent;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Panel pnlShow;
        private System.Windows.Forms.ToolStripMenuItem 密码修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem tsmByOrderSet;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem tsmTempletShow;
        private System.Windows.Forms.ToolStripMenuItem tsmTepletSet;
        private System.Windows.Forms.ToolStripMenuItem 模板查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsmDefinedShow;
        private System.Windows.Forms.ToolStripButton tsmReadyShow;
        private System.Windows.Forms.ToolStripMenuItem tsmScreenSetting;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem tsmResetOrderShow;
        private System.Windows.Forms.ToolStripMenuItem lED查询ToolStripMenuItem;
    }
}


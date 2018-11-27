namespace UI
{
    partial class FrmDefinedShow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.cmbLEDId = new System.Windows.Forms.ComboBox();
            this.btnFontSetting = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbShowType = new System.Windows.Forms.ComboBox();
            this.btnFontColor = new System.Windows.Forms.Button();
            this.fontDialogLed = new System.Windows.Forms.FontDialog();
            this.colorDialogLed = new System.Windows.Forms.ColorDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddTxt = new System.Windows.Forms.Button();
            this.btnAddTime = new System.Windows.Forms.Button();
            this.btnSendData = new System.Windows.Forms.Button();
            this.chkYear = new System.Windows.Forms.CheckBox();
            this.chkWeek = new System.Windows.Forms.CheckBox();
            this.chkTime = new System.Windows.Forms.CheckBox();
            this.btndefault = new System.Windows.Forms.Button();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.chkFoild = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "LED编号";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(109, 103);
            this.txtContent.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(363, 152);
            this.txtContent.TabIndex = 1;
            this.txtContent.Text = "网红城市-重庆欢迎你，重庆众乐科技欢迎你！";
            // 
            // cmbLEDId
            // 
            this.cmbLEDId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLEDId.FormattingEnabled = true;
            this.cmbLEDId.Location = new System.Drawing.Point(109, 31);
            this.cmbLEDId.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbLEDId.Name = "cmbLEDId";
            this.cmbLEDId.Size = new System.Drawing.Size(143, 28);
            this.cmbLEDId.TabIndex = 2;
            this.cmbLEDId.SelectedIndexChanged += new System.EventHandler(this.cmbLEDId_SelectedIndexChanged);
            // 
            // btnFontSetting
            // 
            this.btnFontSetting.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnFontSetting.Location = new System.Drawing.Point(109, 291);
            this.btnFontSetting.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFontSetting.Name = "btnFontSetting";
            this.btnFontSetting.Size = new System.Drawing.Size(70, 42);
            this.btnFontSetting.TabIndex = 3;
            this.btnFontSetting.Text = "字体设置";
            this.btnFontSetting.UseVisualStyleBackColor = true;
            this.btnFontSetting.Click += new System.EventHandler(this.btnFontSetting_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "播放方式";
            // 
            // cmbShowType
            // 
            this.cmbShowType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShowType.FormattingEnabled = true;
            this.cmbShowType.Location = new System.Drawing.Point(340, 31);
            this.cmbShowType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbShowType.Name = "cmbShowType";
            this.cmbShowType.Size = new System.Drawing.Size(132, 28);
            this.cmbShowType.TabIndex = 6;
            // 
            // btnFontColor
            // 
            this.btnFontColor.Enabled = false;
            this.btnFontColor.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnFontColor.Location = new System.Drawing.Point(203, 291);
            this.btnFontColor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFontColor.Name = "btnFontColor";
            this.btnFontColor.Size = new System.Drawing.Size(71, 42);
            this.btnFontColor.TabIndex = 9;
            this.btnFontColor.Text = "字体颜色";
            this.btnFontColor.UseVisualStyleBackColor = true;
            this.btnFontColor.Click += new System.EventHandler(this.btnFontColor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "播放内容";
            // 
            // btnAddTxt
            // 
            this.btnAddTxt.Location = new System.Drawing.Point(393, 291);
            this.btnAddTxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddTxt.Name = "btnAddTxt";
            this.btnAddTxt.Size = new System.Drawing.Size(79, 42);
            this.btnAddTxt.TabIndex = 13;
            this.btnAddTxt.Text = "添加文本";
            this.btnAddTxt.UseVisualStyleBackColor = true;
            this.btnAddTxt.Click += new System.EventHandler(this.btnAddTxt_Click);
            // 
            // btnAddTime
            // 
            this.btnAddTime.Location = new System.Drawing.Point(393, 373);
            this.btnAddTime.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddTime.Name = "btnAddTime";
            this.btnAddTime.Size = new System.Drawing.Size(79, 42);
            this.btnAddTime.TabIndex = 14;
            this.btnAddTime.Text = "添加时间";
            this.btnAddTime.UseVisualStyleBackColor = true;
            this.btnAddTime.Click += new System.EventHandler(this.btnAddTime_Click);
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(393, 454);
            this.btnSendData.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(79, 40);
            this.btnSendData.TabIndex = 15;
            this.btnSendData.Text = "发送数据";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // chkYear
            // 
            this.chkYear.AutoSize = true;
            this.chkYear.Location = new System.Drawing.Point(109, 382);
            this.chkYear.Name = "chkYear";
            this.chkYear.Size = new System.Drawing.Size(70, 24);
            this.chkYear.TabIndex = 16;
            this.chkYear.Text = "年月日";
            this.chkYear.UseVisualStyleBackColor = true;
            // 
            // chkWeek
            // 
            this.chkWeek.AutoSize = true;
            this.chkWeek.Location = new System.Drawing.Point(196, 382);
            this.chkWeek.Name = "chkWeek";
            this.chkWeek.Size = new System.Drawing.Size(56, 24);
            this.chkWeek.TabIndex = 17;
            this.chkWeek.Text = "星期";
            this.chkWeek.UseVisualStyleBackColor = true;
            // 
            // chkTime
            // 
            this.chkTime.AutoSize = true;
            this.chkTime.Location = new System.Drawing.Point(269, 382);
            this.chkTime.Name = "chkTime";
            this.chkTime.Size = new System.Drawing.Size(56, 24);
            this.chkTime.TabIndex = 18;
            this.chkTime.Text = "时间";
            this.chkTime.UseVisualStyleBackColor = true;
            // 
            // btndefault
            // 
            this.btndefault.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btndefault.Location = new System.Drawing.Point(298, 291);
            this.btndefault.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btndefault.Name = "btndefault";
            this.btndefault.Size = new System.Drawing.Size(71, 42);
            this.btndefault.TabIndex = 23;
            this.btndefault.Text = "默认字体";
            this.btndefault.UseVisualStyleBackColor = true;
            this.btndefault.Click += new System.EventHandler(this.btndefault_Click);
            // 
            // chkDelete
            // 
            this.chkDelete.AutoSize = true;
            this.chkDelete.Checked = true;
            this.chkDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDelete.Location = new System.Drawing.Point(109, 463);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.Size = new System.Drawing.Size(112, 24);
            this.chkDelete.TabIndex = 24;
            this.chkDelete.Text = "清除已有显示";
            this.chkDelete.UseVisualStyleBackColor = true;
            // 
            // chkFoild
            // 
            this.chkFoild.AutoSize = true;
            this.chkFoild.Checked = true;
            this.chkFoild.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFoild.Location = new System.Drawing.Point(241, 463);
            this.chkFoild.Name = "chkFoild";
            this.chkFoild.Size = new System.Drawing.Size(84, 24);
            this.chkFoild.TabIndex = 25;
            this.chkFoild.Text = "字体加粗";
            this.chkFoild.UseVisualStyleBackColor = true;
            // 
            // FrmDefinedShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 533);
            this.Controls.Add(this.chkFoild);
            this.Controls.Add(this.chkDelete);
            this.Controls.Add(this.btndefault);
            this.Controls.Add(this.chkTime);
            this.Controls.Add(this.chkWeek);
            this.Controls.Add(this.chkYear);
            this.Controls.Add(this.btnSendData);
            this.Controls.Add(this.btnAddTime);
            this.Controls.Add(this.btnAddTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFontColor);
            this.Controls.Add(this.cmbShowType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFontSetting);
            this.Controls.Add(this.cmbLEDId);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDefinedShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "自定义实时显示";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.ComboBox cmbLEDId;
        private System.Windows.Forms.Button btnFontSetting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbShowType;
        private System.Windows.Forms.Button btnFontColor;
        private System.Windows.Forms.FontDialog fontDialogLed;
        private System.Windows.Forms.ColorDialog colorDialogLed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddTxt;
        private System.Windows.Forms.Button btnAddTime;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.CheckBox chkYear;
        private System.Windows.Forms.CheckBox chkWeek;
        private System.Windows.Forms.CheckBox chkTime;
        private System.Windows.Forms.Button btndefault;
        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.CheckBox chkFoild;
    }
}
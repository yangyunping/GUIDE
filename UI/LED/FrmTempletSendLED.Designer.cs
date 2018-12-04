namespace UI.LED
{
    partial class FrmTempletSendLED
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
            this.cmbContent = new System.Windows.Forms.ComboBox();
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnSendData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.chkFoild = new System.Windows.Forms.CheckBox();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTIme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFontColor = new System.Windows.Forms.Button();
            this.btnFontSetting = new System.Windows.Forms.Button();
            this.fontDialogled = new System.Windows.Forms.FontDialog();
            this.colorDialogLed = new System.Windows.Forms.ColorDialog();
            this.cmbShowType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtScreenId = new System.Windows.Forms.TextBox();
            this.btnlstClose = new System.Windows.Forms.Button();
            this.pnlScreenIds = new System.Windows.Forms.Panel();
            this.lstScreenIds = new System.Windows.Forms.CheckedListBox();
            this.pnlScreenIds.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "模板内容";
            // 
            // cmbContent
            // 
            this.cmbContent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContent.FormattingEnabled = true;
            this.cmbContent.Location = new System.Drawing.Point(108, 28);
            this.cmbContent.Name = "cmbContent";
            this.cmbContent.Size = new System.Drawing.Size(341, 27);
            this.cmbContent.TabIndex = 1;
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.Location = new System.Drawing.Point(43, 245);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(80, 23);
            this.chkDate.TabIndex = 2;
            this.chkDate.Text = "显示时间";
            this.chkDate.UseVisualStyleBackColor = true;
            this.chkDate.CheckedChanged += new System.EventHandler(this.chkDate_CheckedChanged);
            // 
            // dtpBegin
            // 
            this.dtpBegin.Enabled = false;
            this.dtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpBegin.Location = new System.Drawing.Point(128, 241);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(98, 24);
            this.dtpBegin.TabIndex = 3;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Enabled = false;
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEnd.Location = new System.Drawing.Point(232, 241);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(98, 24);
            this.dtpEnd.TabIndex = 4;
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(350, 309);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(98, 43);
            this.btnSendData.TabIndex = 7;
            this.btnSendData.Text = "保  存";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "LED编号";
            // 
            // chkDelete
            // 
            this.chkDelete.AutoSize = true;
            this.chkDelete.Location = new System.Drawing.Point(349, 242);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.Size = new System.Drawing.Size(106, 23);
            this.chkDelete.TabIndex = 25;
            this.chkDelete.Text = "清除已有显示";
            this.chkDelete.UseVisualStyleBackColor = true;
            // 
            // chkFoild
            // 
            this.chkFoild.AutoSize = true;
            this.chkFoild.Checked = true;
            this.chkFoild.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFoild.Location = new System.Drawing.Point(43, 320);
            this.chkFoild.Name = "chkFoild";
            this.chkFoild.Size = new System.Drawing.Size(80, 23);
            this.chkFoild.TabIndex = 26;
            this.chkFoild.Text = "字体加粗";
            this.chkFoild.UseVisualStyleBackColor = true;
            // 
            // cmbPosition
            // 
            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Items.AddRange(new object[] {
            "居中",
            "左对齐",
            "右对齐"});
            this.cmbPosition.Location = new System.Drawing.Point(350, 99);
            this.cmbPosition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(99, 28);
            this.cmbPosition.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.label3.Location = new System.Drawing.Point(276, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 62;
            this.label3.Text = "显示位置";
            // 
            // txtTIme
            // 
            this.txtTIme.Location = new System.Drawing.Point(350, 171);
            this.txtTIme.Name = "txtTIme";
            this.txtTIme.Size = new System.Drawing.Size(99, 24);
            this.txtTIme.TabIndex = 65;
            this.txtTIme.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.label4.Location = new System.Drawing.Point(276, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 66;
            this.label4.Text = "循环时间";
            // 
            // btnFontColor
            // 
            this.btnFontColor.Enabled = false;
            this.btnFontColor.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnFontColor.Location = new System.Drawing.Point(207, 310);
            this.btnFontColor.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnFontColor.Name = "btnFontColor";
            this.btnFontColor.Size = new System.Drawing.Size(75, 40);
            this.btnFontColor.TabIndex = 68;
            this.btnFontColor.Text = "字体颜色";
            this.btnFontColor.UseVisualStyleBackColor = true;
            this.btnFontColor.Visible = false;
            this.btnFontColor.Click += new System.EventHandler(this.btnFontColor_Click);
            // 
            // btnFontSetting
            // 
            this.btnFontSetting.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnFontSetting.Location = new System.Drawing.Point(128, 310);
            this.btnFontSetting.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnFontSetting.Name = "btnFontSetting";
            this.btnFontSetting.Size = new System.Drawing.Size(75, 40);
            this.btnFontSetting.TabIndex = 67;
            this.btnFontSetting.Text = "字体设置";
            this.btnFontSetting.UseVisualStyleBackColor = true;
            this.btnFontSetting.Click += new System.EventHandler(this.btnFontSetting_Click);
            // 
            // fontDialogled
            // 
            this.fontDialogled.Apply += new System.EventHandler(this.fontDialogled_Apply);
            // 
            // cmbShowType
            // 
            this.cmbShowType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShowType.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.cmbShowType.FormattingEnabled = true;
            this.cmbShowType.Location = new System.Drawing.Point(108, 171);
            this.cmbShowType.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cmbShowType.Name = "cmbShowType";
            this.cmbShowType.Size = new System.Drawing.Size(118, 27);
            this.cmbShowType.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.label5.Location = new System.Drawing.Point(39, 174);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 69;
            this.label5.Text = "播放方式";
            // 
            // txtScreenId
            // 
            this.txtScreenId.Location = new System.Drawing.Point(108, 100);
            this.txtScreenId.Name = "txtScreenId";
            this.txtScreenId.ReadOnly = true;
            this.txtScreenId.Size = new System.Drawing.Size(118, 24);
            this.txtScreenId.TabIndex = 71;
            this.txtScreenId.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtScreenId_MouseDoubleClick);
            // 
            // btnlstClose
            // 
            this.btnlstClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlstClose.Location = new System.Drawing.Point(166, 1);
            this.btnlstClose.Name = "btnlstClose";
            this.btnlstClose.Size = new System.Drawing.Size(52, 27);
            this.btnlstClose.TabIndex = 73;
            this.btnlstClose.Text = "关闭";
            this.btnlstClose.UseVisualStyleBackColor = true;
            this.btnlstClose.Click += new System.EventHandler(this.btnlstClose_Click);
            // 
            // pnlScreenIds
            // 
            this.pnlScreenIds.Controls.Add(this.btnlstClose);
            this.pnlScreenIds.Controls.Add(this.lstScreenIds);
            this.pnlScreenIds.Location = new System.Drawing.Point(106, 3);
            this.pnlScreenIds.Name = "pnlScreenIds";
            this.pnlScreenIds.Size = new System.Drawing.Size(218, 349);
            this.pnlScreenIds.TabIndex = 74;
            this.pnlScreenIds.Visible = false;
            // 
            // lstScreenIds
            // 
            this.lstScreenIds.CheckOnClick = true;
            this.lstScreenIds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstScreenIds.FormattingEnabled = true;
            this.lstScreenIds.Location = new System.Drawing.Point(0, 0);
            this.lstScreenIds.Name = "lstScreenIds";
            this.lstScreenIds.Size = new System.Drawing.Size(218, 349);
            this.lstScreenIds.TabIndex = 74;
            this.lstScreenIds.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstScreenIds_ItemCheck);
            // 
            // FrmTempletSendLED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 365);
            this.Controls.Add(this.pnlScreenIds);
            this.Controls.Add(this.txtScreenId);
            this.Controls.Add(this.cmbShowType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFontColor);
            this.Controls.Add(this.btnFontSetting);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTIme);
            this.Controls.Add(this.cmbPosition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkFoild);
            this.Controls.Add(this.chkDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSendData);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpBegin);
            this.Controls.Add(this.chkDate);
            this.Controls.Add(this.cmbContent);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTempletSendLED";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "模板发送";
            this.pnlScreenIds.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbContent;
        private System.Windows.Forms.CheckBox chkDate;
        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.CheckBox chkFoild;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTIme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFontColor;
        private System.Windows.Forms.Button btnFontSetting;
        private System.Windows.Forms.FontDialog fontDialogled;
        private System.Windows.Forms.ColorDialog colorDialogLed;
        private System.Windows.Forms.ComboBox cmbShowType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtScreenId;
        private System.Windows.Forms.Button btnlstClose;
        private System.Windows.Forms.Panel pnlScreenIds;
        private System.Windows.Forms.CheckedListBox lstScreenIds;
    }
}
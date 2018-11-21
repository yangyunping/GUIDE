namespace UI
{
    partial class FrmLEDSetting
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
            this.cmbControlnerAdress = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbControlType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbShowType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.IpAddress0 = new System.Windows.Forms.TextBox();
            this.IpAddress1 = new System.Windows.Forms.TextBox();
            this.IpAddress2 = new System.Windows.Forms.TextBox();
            this.IpAddress3 = new System.Windows.Forms.TextBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "控制卡地址";
            // 
            // cmbControlnerAdress
            // 
            this.cmbControlnerAdress.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbControlnerAdress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbControlnerAdress.FormattingEnabled = true;
            this.cmbControlnerAdress.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbControlnerAdress.Location = new System.Drawing.Point(128, 89);
            this.cmbControlnerAdress.Name = "cmbControlnerAdress";
            this.cmbControlnerAdress.Size = new System.Drawing.Size(157, 27);
            this.cmbControlnerAdress.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = " IP  地址";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "×";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "宽";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "分  辨  率";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(144, 159);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(54, 24);
            this.txtWidth.TabIndex = 9;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(256, 159);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(53, 24);
            this.txtHeight.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(232, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "高";
            // 
            // cmbControlType
            // 
            this.cmbControlType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbControlType.FormattingEnabled = true;
            this.cmbControlType.Items.AddRange(new object[] {
            "21-EQ2013",
            "22-EQ2023",
            "23-EQ2033"});
            this.cmbControlType.Location = new System.Drawing.Point(128, 20);
            this.cmbControlType.Name = "cmbControlType";
            this.cmbControlType.Size = new System.Drawing.Size(154, 27);
            this.cmbControlType.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "控制卡类型";
            // 
            // cmbShowType
            // 
            this.cmbShowType.AutoCompleteCustomSource.AddRange(new string[] {
            "1-立即显示",
            "2-左移",
            "3-连续左移",
            "5-上移",
            "6-连续上移"});
            this.cmbShowType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShowType.FormattingEnabled = true;
            this.cmbShowType.Items.AddRange(new object[] {
            "1-立即显示",
            "2-左移",
            "3-连续左移",
            "5-上移",
            "6-连续上移"});
            this.cmbShowType.Location = new System.Drawing.Point(128, 228);
            this.cmbShowType.Name = "cmbShowType";
            this.cmbShowType.Size = new System.Drawing.Size(157, 27);
            this.cmbShowType.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 19);
            this.label10.TabIndex = 14;
            this.label10.Text = "滚屏方式";
            // 
            // IpAddress0
            // 
            this.IpAddress0.Location = new System.Drawing.Point(128, 297);
            this.IpAddress0.Name = "IpAddress0";
            this.IpAddress0.Size = new System.Drawing.Size(57, 24);
            this.IpAddress0.TabIndex = 16;
            this.IpAddress0.Text = "192";
            // 
            // IpAddress1
            // 
            this.IpAddress1.Location = new System.Drawing.Point(195, 297);
            this.IpAddress1.Name = "IpAddress1";
            this.IpAddress1.Size = new System.Drawing.Size(57, 24);
            this.IpAddress1.TabIndex = 17;
            this.IpAddress1.Text = "168";
            // 
            // IpAddress2
            // 
            this.IpAddress2.Location = new System.Drawing.Point(263, 297);
            this.IpAddress2.Name = "IpAddress2";
            this.IpAddress2.Size = new System.Drawing.Size(57, 24);
            this.IpAddress2.TabIndex = 18;
            this.IpAddress2.Text = "1";
            // 
            // IpAddress3
            // 
            this.IpAddress3.Location = new System.Drawing.Point(327, 297);
            this.IpAddress3.Name = "IpAddress3";
            this.IpAddress3.Size = new System.Drawing.Size(57, 24);
            this.IpAddress3.TabIndex = 19;
            // 
            // cmbColor
            // 
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "单色",
            "双色"});
            this.cmbColor.Location = new System.Drawing.Point(128, 362);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(157, 27);
            this.cmbColor.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 19);
            this.label11.TabIndex = 20;
            this.label11.Text = " 颜    色";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(128, 416);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 38);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "保 存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmLEDSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 473);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.IpAddress3);
            this.Controls.Add(this.IpAddress2);
            this.Controls.Add(this.IpAddress1);
            this.Controls.Add(this.IpAddress0);
            this.Controls.Add(this.cmbShowType);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbControlType);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbControlnerAdress);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmLEDSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LED配置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbControlnerAdress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbControlType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbShowType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox IpAddress0;
        private System.Windows.Forms.TextBox IpAddress1;
        private System.Windows.Forms.TextBox IpAddress2;
        private System.Windows.Forms.TextBox IpAddress3;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSave;
    }
}
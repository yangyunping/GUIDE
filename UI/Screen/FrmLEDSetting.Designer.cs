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
            this.cmbCarAdress = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbControlType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.IpAddress0 = new System.Windows.Forms.TextBox();
            this.IpAddress1 = new System.Windows.Forms.TextBox();
            this.IpAddress2 = new System.Windows.Forms.TextBox();
            this.IpAddress3 = new System.Windows.Forms.TextBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFontSize = new System.Windows.Forms.TextBox();
            this.btnFontColor = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLEDid = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "控制卡地址";
            // 
            // cmbCarAdress
            // 
            this.cmbCarAdress.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbCarAdress.FormattingEnabled = true;
            this.cmbCarAdress.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cmbCarAdress.Location = new System.Drawing.Point(176, 177);
            this.cmbCarAdress.Name = "cmbCarAdress";
            this.cmbCarAdress.Size = new System.Drawing.Size(157, 27);
            this.cmbCarAdress.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = " IP  地址";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "×";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "宽";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "分  辨  率";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(198, 245);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(54, 24);
            this.txtWidth.TabIndex = 9;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(308, 245);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(53, 24);
            this.txtHeight.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 248);
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
            this.cmbControlType.Location = new System.Drawing.Point(176, 110);
            this.cmbControlType.Name = "cmbControlType";
            this.cmbControlType.Size = new System.Drawing.Size(157, 27);
            this.cmbControlType.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(91, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "控制卡类型";
            // 
            // IpAddress0
            // 
            this.IpAddress0.Location = new System.Drawing.Point(176, 312);
            this.IpAddress0.Name = "IpAddress0";
            this.IpAddress0.Size = new System.Drawing.Size(57, 24);
            this.IpAddress0.TabIndex = 16;
            this.IpAddress0.Text = "192";
            // 
            // IpAddress1
            // 
            this.IpAddress1.Location = new System.Drawing.Point(243, 312);
            this.IpAddress1.Name = "IpAddress1";
            this.IpAddress1.Size = new System.Drawing.Size(57, 24);
            this.IpAddress1.TabIndex = 17;
            this.IpAddress1.Text = "168";
            // 
            // IpAddress2
            // 
            this.IpAddress2.Location = new System.Drawing.Point(311, 312);
            this.IpAddress2.Name = "IpAddress2";
            this.IpAddress2.Size = new System.Drawing.Size(57, 24);
            this.IpAddress2.TabIndex = 18;
            this.IpAddress2.Text = "1";
            // 
            // IpAddress3
            // 
            this.IpAddress3.Location = new System.Drawing.Point(375, 312);
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
            this.cmbColor.Location = new System.Drawing.Point(176, 380);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(124, 27);
            this.cmbColor.TabIndex = 21;
            this.cmbColor.SelectedIndexChanged += new System.EventHandler(this.cmbColor_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(86, 384);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 19);
            this.label11.TabIndex = 20;
            this.label11.Text = "LED颜色类型";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(176, 494);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 41);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "保  存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFontSize);
            this.groupBox1.Controls.Add(this.btnFontColor);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtLEDid);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbColor);
            this.groupBox1.Controls.Add(this.cmbCarAdress);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.IpAddress3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.IpAddress2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.IpAddress1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.IpAddress0);
            this.groupBox1.Controls.Add(this.txtWidth);
            this.groupBox1.Controls.Add(this.txtHeight);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbControlType);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 556);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "控制卡参数配置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "最大字体大小";
            // 
            // txtFontSize
            // 
            this.txtFontSize.Location = new System.Drawing.Point(176, 447);
            this.txtFontSize.Name = "txtFontSize";
            this.txtFontSize.Size = new System.Drawing.Size(124, 24);
            this.txtFontSize.TabIndex = 26;
            // 
            // btnFontColor
            // 
            this.btnFontColor.Enabled = false;
            this.btnFontColor.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnFontColor.Location = new System.Drawing.Point(325, 372);
            this.btnFontColor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFontColor.Name = "btnFontColor";
            this.btnFontColor.Size = new System.Drawing.Size(71, 42);
            this.btnFontColor.TabIndex = 24;
            this.btnFontColor.Text = "字体颜色";
            this.btnFontColor.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(99, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 19);
            this.label12.TabIndex = 6;
            this.label12.Text = "LED编号";
            // 
            // txtLEDid
            // 
            this.txtLEDid.Location = new System.Drawing.Point(176, 44);
            this.txtLEDid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLEDid.Name = "txtLEDid";
            this.txtLEDid.Size = new System.Drawing.Size(157, 24);
            this.txtLEDid.TabIndex = 5;
            this.txtLEDid.MouseLeave += new System.EventHandler(this.txtLEDid_MouseLeave);
            // 
            // FrmLEDSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 571);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmLEDSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LED配置";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCarAdress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbControlType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox IpAddress0;
        private System.Windows.Forms.TextBox IpAddress1;
        private System.Windows.Forms.TextBox IpAddress2;
        private System.Windows.Forms.TextBox IpAddress3;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLEDid;
        private System.Windows.Forms.Button btnFontColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFontSize;
    }
}
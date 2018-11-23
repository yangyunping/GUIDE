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
            this.IpAddress0 = new System.Windows.Forms.TextBox();
            this.IpAddress1 = new System.Windows.Forms.TextBox();
            this.IpAddress2 = new System.Windows.Forms.TextBox();
            this.IpAddress3 = new System.Windows.Forms.TextBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddType = new System.Windows.Forms.Button();
            this.txtTypeId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAddLED = new System.Windows.Forms.Button();
            this.txtLEDid = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 133);
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
            this.cmbControlnerAdress.Location = new System.Drawing.Point(132, 129);
            this.cmbControlnerAdress.Name = "cmbControlnerAdress";
            this.cmbControlnerAdress.Size = new System.Drawing.Size(157, 27);
            this.cmbControlnerAdress.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = " IP  地址";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "×";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "宽";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "分  辨  率";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(147, 198);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(54, 24);
            this.txtWidth.TabIndex = 9;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(259, 198);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(53, 24);
            this.txtHeight.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 201);
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
            this.cmbControlType.Location = new System.Drawing.Point(132, 62);
            this.cmbControlType.Name = "cmbControlType";
            this.cmbControlType.Size = new System.Drawing.Size(154, 27);
            this.cmbControlType.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "控制卡类型";
            // 
            // IpAddress0
            // 
            this.IpAddress0.Location = new System.Drawing.Point(132, 269);
            this.IpAddress0.Name = "IpAddress0";
            this.IpAddress0.Size = new System.Drawing.Size(57, 24);
            this.IpAddress0.TabIndex = 16;
            this.IpAddress0.Text = "192";
            // 
            // IpAddress1
            // 
            this.IpAddress1.Location = new System.Drawing.Point(199, 269);
            this.IpAddress1.Name = "IpAddress1";
            this.IpAddress1.Size = new System.Drawing.Size(57, 24);
            this.IpAddress1.TabIndex = 17;
            this.IpAddress1.Text = "168";
            // 
            // IpAddress2
            // 
            this.IpAddress2.Location = new System.Drawing.Point(267, 269);
            this.IpAddress2.Name = "IpAddress2";
            this.IpAddress2.Size = new System.Drawing.Size(57, 24);
            this.IpAddress2.TabIndex = 18;
            this.IpAddress2.Text = "1";
            // 
            // IpAddress3
            // 
            this.IpAddress3.Location = new System.Drawing.Point(331, 269);
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
            this.cmbColor.Location = new System.Drawing.Point(129, 336);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(157, 27);
            this.cmbColor.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(52, 340);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 19);
            this.label11.TabIndex = 20;
            this.label11.Text = " 颜    色";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(306, 330);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 38);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "保 存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbColor);
            this.groupBox1.Controls.Add(this.cmbControlnerAdress);
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
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 401);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "控制卡参数配置";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnAddType);
            this.groupBox2.Controls.Add(this.txtTypeId);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTypeName);
            this.groupBox2.Location = new System.Drawing.Point(461, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 172);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "播放方式";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "类别编号";
            // 
            // btnAddType
            // 
            this.btnAddType.Location = new System.Drawing.Point(276, 112);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(78, 35);
            this.btnAddType.TabIndex = 4;
            this.btnAddType.Text = "添  加";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // txtTypeId
            // 
            this.txtTypeId.Location = new System.Drawing.Point(132, 55);
            this.txtTypeId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTypeId.Name = "txtTypeId";
            this.txtTypeId.Size = new System.Drawing.Size(116, 24);
            this.txtTypeId.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "类别名称";
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(132, 117);
            this.txtTypeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(116, 24);
            this.txtTypeName.TabIndex = 2;
            this.txtTypeName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTypeName_KeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.btnAddLED);
            this.groupBox3.Controls.Add(this.txtLEDid);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtAdress);
            this.groupBox3.Location = new System.Drawing.Point(461, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(389, 200);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LED信息";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(65, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 19);
            this.label12.TabIndex = 6;
            this.label12.Text = "LED编号";
            // 
            // btnAddLED
            // 
            this.btnAddLED.Location = new System.Drawing.Point(276, 114);
            this.btnAddLED.Name = "btnAddLED";
            this.btnAddLED.Size = new System.Drawing.Size(78, 35);
            this.btnAddLED.TabIndex = 9;
            this.btnAddLED.Text = "添  加";
            this.btnAddLED.UseVisualStyleBackColor = true;
            this.btnAddLED.Click += new System.EventHandler(this.btnAddLED_Click);
            // 
            // txtLEDid
            // 
            this.txtLEDid.Location = new System.Drawing.Point(132, 60);
            this.txtLEDid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLEDid.Name = "txtLEDid";
            this.txtLEDid.Size = new System.Drawing.Size(116, 24);
            this.txtLEDid.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(65, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 19);
            this.label13.TabIndex = 8;
            this.label13.Text = "控制卡ID";
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(132, 119);
            this.txtAdress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(116, 24);
            this.txtAdress.TabIndex = 7;
            this.txtAdress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdress_KeyDown);
            // 
            // FrmLEDSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 422);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmLEDSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LED配置";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox IpAddress0;
        private System.Windows.Forms.TextBox IpAddress1;
        private System.Windows.Forms.TextBox IpAddress2;
        private System.Windows.Forms.TextBox IpAddress3;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.TextBox txtTypeId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAddLED;
        private System.Windows.Forms.TextBox txtLEDid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAdress;
    }
}
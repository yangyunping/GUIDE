namespace UI.LED
{
    partial class FrmByOrderShow
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
            this.cmbScreens = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GroupNum = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.cmbAreaId = new System.Windows.Forms.ComboBox();
            this.cmbByOrder = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFontColor = new System.Windows.Forms.Button();
            this.btnFontSetting = new System.Windows.Forms.Button();
            this.fontDialogled = new System.Windows.Forms.FontDialog();
            this.colorDialogLed = new System.Windows.Forms.ColorDialog();
            this.chkFontBold = new System.Windows.Forms.CheckBox();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTIme = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGoupName = new System.Windows.Forms.TextBox();
            this.chkDeleteProgram = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.GroupNum)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbScreens
            // 
            this.cmbScreens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScreens.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbScreens.FormattingEnabled = true;
            this.cmbScreens.Location = new System.Drawing.Point(334, 37);
            this.cmbScreens.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbScreens.Name = "cmbScreens";
            this.cmbScreens.Size = new System.Drawing.Size(125, 28);
            this.cmbScreens.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(259, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 51;
            this.label7.Text = "LED起始编号";
            // 
            // GroupNum
            // 
            this.GroupNum.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupNum.Location = new System.Drawing.Point(334, 111);
            this.GroupNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupNum.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.GroupNum.Name = "GroupNum";
            this.GroupNum.Size = new System.Drawing.Size(125, 26);
            this.GroupNum.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(274, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "编   组";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CalendarFont = new System.Drawing.Font("微软雅黑", 10F);
            this.dtpEnd.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEnd.Location = new System.Drawing.Point(334, 265);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(127, 24);
            this.dtpEnd.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.label5.Location = new System.Drawing.Point(268, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 45;
            this.label5.Text = "结束时间";
            // 
            // dtpBegin
            // 
            this.dtpBegin.CalendarFont = new System.Drawing.Font("微软雅黑", 10F);
            this.dtpBegin.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.dtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpBegin.Location = new System.Drawing.Point(99, 265);
            this.dtpBegin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(125, 24);
            this.dtpBegin.TabIndex = 44;
            // 
            // cmbAreaId
            // 
            this.cmbAreaId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAreaId.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbAreaId.FormattingEnabled = true;
            this.cmbAreaId.Location = new System.Drawing.Point(99, 37);
            this.cmbAreaId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbAreaId.Name = "cmbAreaId";
            this.cmbAreaId.Size = new System.Drawing.Size(125, 28);
            this.cmbAreaId.TabIndex = 43;
            this.cmbAreaId.SelectedIndexChanged += new System.EventHandler(this.cmbAreaId_SelectedIndexChanged);
            // 
            // cmbByOrder
            // 
            this.cmbByOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbByOrder.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbByOrder.FormattingEnabled = true;
            this.cmbByOrder.Items.AddRange(new object[] {
            "正序",
            "倒序"});
            this.cmbByOrder.Location = new System.Drawing.Point(99, 110);
            this.cmbByOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbByOrder.Name = "cmbByOrder";
            this.cmbByOrder.Size = new System.Drawing.Size(127, 28);
            this.cmbByOrder.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.label4.Location = new System.Drawing.Point(28, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 41;
            this.label4.Text = "显示顺序";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.label2.Location = new System.Drawing.Point(28, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 40;
            this.label2.Text = "开始时间";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(376, 332);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 42);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "保存发送";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.label1.Location = new System.Drawing.Point(34, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "区域名";
            // 
            // btnFontColor
            // 
            this.btnFontColor.Enabled = false;
            this.btnFontColor.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnFontColor.Location = new System.Drawing.Point(38, 391);
            this.btnFontColor.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnFontColor.Name = "btnFontColor";
            this.btnFontColor.Size = new System.Drawing.Size(75, 40);
            this.btnFontColor.TabIndex = 56;
            this.btnFontColor.Text = "字体颜色";
            this.btnFontColor.UseVisualStyleBackColor = true;
            this.btnFontColor.Visible = false;
            this.btnFontColor.Click += new System.EventHandler(this.btnFontColor_Click);
            // 
            // btnFontSetting
            // 
            this.btnFontSetting.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnFontSetting.Location = new System.Drawing.Point(117, 391);
            this.btnFontSetting.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnFontSetting.Name = "btnFontSetting";
            this.btnFontSetting.Size = new System.Drawing.Size(75, 40);
            this.btnFontSetting.TabIndex = 55;
            this.btnFontSetting.Text = "字体设置";
            this.btnFontSetting.UseVisualStyleBackColor = true;
            this.btnFontSetting.Visible = false;
            this.btnFontSetting.Click += new System.EventHandler(this.btnFontSetting_Click);
            // 
            // chkFontBold
            // 
            this.chkFontBold.AutoSize = true;
            this.chkFontBold.Checked = true;
            this.chkFontBold.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFontBold.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.chkFontBold.Location = new System.Drawing.Point(186, 342);
            this.chkFontBold.Name = "chkFontBold";
            this.chkFontBold.Size = new System.Drawing.Size(80, 23);
            this.chkFontBold.TabIndex = 57;
            this.chkFontBold.Text = "字体加粗";
            this.chkFontBold.UseVisualStyleBackColor = true;
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
            this.cmbPosition.Location = new System.Drawing.Point(99, 185);
            this.cmbPosition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(125, 28);
            this.cmbPosition.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.label3.Location = new System.Drawing.Point(28, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 58;
            this.label3.Text = "显示位置";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.label8.Location = new System.Drawing.Point(28, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 19);
            this.label8.TabIndex = 68;
            this.label8.Text = "显示时长";
            // 
            // txtTIme
            // 
            this.txtTIme.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTIme.Location = new System.Drawing.Point(99, 340);
            this.txtTIme.Name = "txtTIme";
            this.txtTIme.Size = new System.Drawing.Size(81, 26);
            this.txtTIme.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(273, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 69;
            this.label9.Text = "编组名";
            // 
            // txtGoupName
            // 
            this.txtGoupName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGoupName.Location = new System.Drawing.Point(334, 186);
            this.txtGoupName.Name = "txtGoupName";
            this.txtGoupName.Size = new System.Drawing.Size(125, 26);
            this.txtGoupName.TabIndex = 70;
            // 
            // chkDeleteProgram
            // 
            this.chkDeleteProgram.AutoSize = true;
            this.chkDeleteProgram.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.chkDeleteProgram.Location = new System.Drawing.Point(272, 342);
            this.chkDeleteProgram.Name = "chkDeleteProgram";
            this.chkDeleteProgram.Size = new System.Drawing.Size(93, 23);
            this.chkDeleteProgram.TabIndex = 71;
            this.chkDeleteProgram.Text = "清除已显示";
            this.chkDeleteProgram.UseVisualStyleBackColor = true;
            // 
            // FrmByOrderShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 389);
            this.Controls.Add(this.chkDeleteProgram);
            this.Controls.Add(this.txtGoupName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTIme);
            this.Controls.Add(this.cmbPosition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkFontBold);
            this.Controls.Add(this.btnFontColor);
            this.Controls.Add(this.btnFontSetting);
            this.Controls.Add(this.cmbScreens);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GroupNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpBegin);
            this.Controls.Add(this.cmbAreaId);
            this.Controls.Add(this.cmbByOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Name = "FrmByOrderShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "排序显示";
            ((System.ComponentModel.ISupportInitialize)(this.GroupNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbScreens;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown GroupNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.ComboBox cmbAreaId;
        private System.Windows.Forms.ComboBox cmbByOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFontColor;
        private System.Windows.Forms.Button btnFontSetting;
        private System.Windows.Forms.FontDialog fontDialogled;
        private System.Windows.Forms.ColorDialog colorDialogLed;
        private System.Windows.Forms.CheckBox chkFontBold;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTIme;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGoupName;
        private System.Windows.Forms.CheckBox chkDeleteProgram;
    }
}
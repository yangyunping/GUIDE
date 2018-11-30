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
            this.txtFontName = new System.Windows.Forms.TextBox();
            this.txtFontSize = new System.Windows.Forms.TextBox();
            this.btnSendData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLEDId = new System.Windows.Forms.ComboBox();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.chkFoild = new System.Windows.Forms.CheckBox();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtiAplay = new System.Windows.Forms.TextBox();
            this.txtTIme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 32);
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
            this.cmbContent.Size = new System.Drawing.Size(365, 27);
            this.cmbContent.TabIndex = 1;
            this.cmbContent.SelectedIndexChanged += new System.EventHandler(this.cmbContent_SelectedIndexChanged);
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.Location = new System.Drawing.Point(45, 200);
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
            this.dtpBegin.Location = new System.Drawing.Point(131, 199);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(98, 24);
            this.dtpBegin.TabIndex = 3;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Enabled = false;
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEnd.Location = new System.Drawing.Point(258, 199);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(98, 24);
            this.dtpEnd.TabIndex = 4;
            // 
            // txtFontName
            // 
            this.txtFontName.Enabled = false;
            this.txtFontName.Location = new System.Drawing.Point(108, 61);
            this.txtFontName.Name = "txtFontName";
            this.txtFontName.Size = new System.Drawing.Size(88, 24);
            this.txtFontName.TabIndex = 5;
            // 
            // txtFontSize
            // 
            this.txtFontSize.Enabled = false;
            this.txtFontSize.Location = new System.Drawing.Point(247, 61);
            this.txtFontSize.Name = "txtFontSize";
            this.txtFontSize.Size = new System.Drawing.Size(87, 24);
            this.txtFontSize.TabIndex = 6;
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(375, 272);
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
            this.label2.Location = new System.Drawing.Point(41, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "LED编号";
            // 
            // cmbLEDId
            // 
            this.cmbLEDId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLEDId.FormattingEnabled = true;
            this.cmbLEDId.Location = new System.Drawing.Point(108, 123);
            this.cmbLEDId.Name = "cmbLEDId";
            this.cmbLEDId.Size = new System.Drawing.Size(121, 27);
            this.cmbLEDId.TabIndex = 9;
            this.cmbLEDId.SelectedIndexChanged += new System.EventHandler(this.cmbLEDId_SelectedIndexChanged);
            // 
            // chkDelete
            // 
            this.chkDelete.AutoSize = true;
            this.chkDelete.Location = new System.Drawing.Point(45, 282);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.Size = new System.Drawing.Size(106, 23);
            this.chkDelete.TabIndex = 25;
            this.chkDelete.Text = "删除已有显示";
            this.chkDelete.UseVisualStyleBackColor = true;
            // 
            // chkFoild
            // 
            this.chkFoild.AutoSize = true;
            this.chkFoild.Checked = true;
            this.chkFoild.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFoild.Location = new System.Drawing.Point(393, 200);
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
            this.cmbPosition.Location = new System.Drawing.Point(328, 122);
            this.cmbPosition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(145, 28);
            this.cmbPosition.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.label3.Location = new System.Drawing.Point(254, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 62;
            this.label3.Text = "显示位置";
            // 
            // txtiAplay
            // 
            this.txtiAplay.Enabled = false;
            this.txtiAplay.Location = new System.Drawing.Point(386, 61);
            this.txtiAplay.Name = "txtiAplay";
            this.txtiAplay.Size = new System.Drawing.Size(87, 24);
            this.txtiAplay.TabIndex = 64;
            // 
            // txtTIme
            // 
            this.txtTIme.Location = new System.Drawing.Point(259, 281);
            this.txtTIme.Name = "txtTIme";
            this.txtTIme.Size = new System.Drawing.Size(64, 24);
            this.txtTIme.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.label4.Location = new System.Drawing.Point(192, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 66;
            this.label4.Text = "循环时间";
            // 
            // FrmTempletSendLED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 340);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTIme);
            this.Controls.Add(this.txtiAplay);
            this.Controls.Add(this.cmbPosition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkFoild);
            this.Controls.Add(this.chkDelete);
            this.Controls.Add(this.cmbLEDId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSendData);
            this.Controls.Add(this.txtFontSize);
            this.Controls.Add(this.txtFontName);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbContent;
        private System.Windows.Forms.CheckBox chkDate;
        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.TextBox txtFontName;
        private System.Windows.Forms.TextBox txtFontSize;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLEDId;
        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.CheckBox chkFoild;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtiAplay;
        private System.Windows.Forms.TextBox txtTIme;
        private System.Windows.Forms.Label label4;
    }
}
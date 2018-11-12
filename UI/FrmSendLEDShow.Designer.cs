namespace UI
{
    partial class FrmSendLEDShow
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
            this.cmbAddress = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.chkWeek = new System.Windows.Forms.CheckBox();
            this.chkTime = new System.Windows.Forms.CheckBox();
            this.btnAddTime = new System.Windows.Forms.Button();
            this.btnAddTxt = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddProgram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "控 制 卡";
            // 
            // cmbAddress
            // 
            this.cmbAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddress.FormattingEnabled = true;
            this.cmbAddress.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbAddress.Location = new System.Drawing.Point(110, 23);
            this.cmbAddress.Name = "cmbAddress";
            this.cmbAddress.Size = new System.Drawing.Size(167, 20);
            this.cmbAddress.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "显示内容";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(110, 86);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(167, 119);
            this.txtContent.TabIndex = 3;
            this.txtContent.Text = "重庆众乐科技有限公司，欢迎你的到来！！";
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.Location = new System.Drawing.Point(42, 269);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(48, 16);
            this.chkDate.TabIndex = 4;
            this.chkDate.Text = "日期";
            this.chkDate.UseVisualStyleBackColor = true;
            // 
            // chkWeek
            // 
            this.chkWeek.AutoSize = true;
            this.chkWeek.Location = new System.Drawing.Point(96, 269);
            this.chkWeek.Name = "chkWeek";
            this.chkWeek.Size = new System.Drawing.Size(48, 16);
            this.chkWeek.TabIndex = 5;
            this.chkWeek.Text = "星期";
            this.chkWeek.UseVisualStyleBackColor = true;
            // 
            // chkTime
            // 
            this.chkTime.AutoSize = true;
            this.chkTime.Location = new System.Drawing.Point(150, 269);
            this.chkTime.Name = "chkTime";
            this.chkTime.Size = new System.Drawing.Size(48, 16);
            this.chkTime.TabIndex = 6;
            this.chkTime.Text = "时间";
            this.chkTime.UseVisualStyleBackColor = true;
            // 
            // btnAddTime
            // 
            this.btnAddTime.Location = new System.Drawing.Point(202, 265);
            this.btnAddTime.Name = "btnAddTime";
            this.btnAddTime.Size = new System.Drawing.Size(75, 23);
            this.btnAddTime.TabIndex = 7;
            this.btnAddTime.Text = "添加时间";
            this.btnAddTime.UseVisualStyleBackColor = true;
            this.btnAddTime.Click += new System.EventHandler(this.btnAddTime_Click);
            // 
            // btnAddTxt
            // 
            this.btnAddTxt.Location = new System.Drawing.Point(202, 221);
            this.btnAddTxt.Name = "btnAddTxt";
            this.btnAddTxt.Size = new System.Drawing.Size(75, 23);
            this.btnAddTxt.TabIndex = 8;
            this.btnAddTxt.Text = "添加内容";
            this.btnAddTxt.UseVisualStyleBackColor = true;
            this.btnAddTxt.Click += new System.EventHandler(this.btnAddTxt_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(59, 336);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "发送数据";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(202, 336);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "清空控制卡";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddProgram
            // 
            this.btnAddProgram.Location = new System.Drawing.Point(110, 221);
            this.btnAddProgram.Name = "btnAddProgram";
            this.btnAddProgram.Size = new System.Drawing.Size(75, 23);
            this.btnAddProgram.TabIndex = 11;
            this.btnAddProgram.Text = "添加节目";
            this.btnAddProgram.UseVisualStyleBackColor = true;
            this.btnAddProgram.Click += new System.EventHandler(this.btnAddProgram_Click);
            // 
            // FrmSendLEDShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 393);
            this.Controls.Add(this.btnAddProgram);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnAddTxt);
            this.Controls.Add(this.btnAddTime);
            this.Controls.Add(this.chkTime);
            this.Controls.Add(this.chkWeek);
            this.Controls.Add(this.chkDate);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAddress);
            this.Controls.Add(this.label1);
            this.Name = "FrmSendLEDShow";
            this.Text = "发送显示内容";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.CheckBox chkDate;
        private System.Windows.Forms.CheckBox chkWeek;
        private System.Windows.Forms.CheckBox chkTime;
        private System.Windows.Forms.Button btnAddTime;
        private System.Windows.Forms.Button btnAddTxt;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddProgram;
    }
}
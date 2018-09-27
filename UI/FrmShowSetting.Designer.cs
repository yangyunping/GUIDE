namespace UI
{
    partial class FrmShowSetting
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAreaId = new System.Windows.Forms.ComboBox();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfigName = new System.Windows.Forms.TextBox();
            this.GroupNum = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbScreens = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numAddress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GroupNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.label2.Location = new System.Drawing.Point(39, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "开始时间";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(310, 313);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 37);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "保 存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReturn.Location = new System.Drawing.Point(106, 313);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(93, 37);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "重 置";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(39, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "区域名";
            // 
            // cmbOrder
            // 
            this.cmbOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrder.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Items.AddRange(new object[] {
            "正序",
            "倒序"});
            this.cmbOrder.Location = new System.Drawing.Point(104, 99);
            this.cmbOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(118, 28);
            this.cmbOrder.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(39, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "显示顺序";
            // 
            // cmbAreaId
            // 
            this.cmbAreaId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAreaId.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbAreaId.FormattingEnabled = true;
            this.cmbAreaId.Location = new System.Drawing.Point(104, 30);
            this.cmbAreaId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbAreaId.Name = "cmbAreaId";
            this.cmbAreaId.Size = new System.Drawing.Size(125, 28);
            this.cmbAreaId.TabIndex = 24;
            this.cmbAreaId.SelectedIndexChanged += new System.EventHandler(this.cmbAreaId_SelectedIndexChanged);
            // 
            // dtpBegin
            // 
            this.dtpBegin.CalendarFont = new System.Drawing.Font("微软雅黑", 10F);
            this.dtpBegin.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.dtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpBegin.Location = new System.Drawing.Point(106, 238);
            this.dtpBegin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(125, 24);
            this.dtpBegin.TabIndex = 25;
            // 
            // dtpEnd
            // 
            this.dtpEnd.CalendarFont = new System.Drawing.Font("微软雅黑", 10F);
            this.dtpEnd.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEnd.Location = new System.Drawing.Point(347, 238);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(118, 24);
            this.dtpEnd.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.label5.Location = new System.Drawing.Point(274, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "结束时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(39, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "配置编号";
            // 
            // txtConfigName
            // 
            this.txtConfigName.Location = new System.Drawing.Point(106, 168);
            this.txtConfigName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfigName.Name = "txtConfigName";
            this.txtConfigName.ReadOnly = true;
            this.txtConfigName.Size = new System.Drawing.Size(114, 26);
            this.txtConfigName.TabIndex = 29;
            // 
            // GroupNum
            // 
            this.GroupNum.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupNum.Location = new System.Drawing.Point(338, 168);
            this.GroupNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupNum.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.GroupNum.Name = "GroupNum";
            this.GroupNum.ReadOnly = true;
            this.GroupNum.Size = new System.Drawing.Size(126, 26);
            this.GroupNum.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(274, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "编   组";
            // 
            // cmbScreens
            // 
            this.cmbScreens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScreens.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbScreens.FormattingEnabled = true;
            this.cmbScreens.Location = new System.Drawing.Point(339, 30);
            this.cmbScreens.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbScreens.Name = "cmbScreens";
            this.cmbScreens.Size = new System.Drawing.Size(125, 28);
            this.cmbScreens.TabIndex = 33;
            this.cmbScreens.SelectedIndexChanged += new System.EventHandler(this.cmbScreens_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(274, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "显示器";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(274, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "地址码";
            // 
            // numAddress
            // 
            this.numAddress.Location = new System.Drawing.Point(339, 100);
            this.numAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numAddress.Name = "numAddress";
            this.numAddress.ReadOnly = true;
            this.numAddress.Size = new System.Drawing.Size(125, 26);
            this.numAddress.TabIndex = 36;
            // 
            // FrmShowSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 383);
            this.Controls.Add(this.numAddress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbScreens);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GroupNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtConfigName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpBegin);
            this.Controls.Add(this.cmbAreaId);
            this.Controls.Add(this.cmbOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmShowSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "配置编号";
            ((System.ComponentModel.ISupportInitialize)(this.GroupNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbAreaId;
        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfigName;
        private System.Windows.Forms.NumericUpDown GroupNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbScreens;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox numAddress;
    }
}
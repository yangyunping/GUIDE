namespace UI
{
    partial class FrmOperateLED
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddType = new System.Windows.Forms.Button();
            this.txtTypeId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbLEDId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearProgram = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnAddType);
            this.groupBox2.Controls.Add(this.txtTypeId);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtTypeName);
            this.groupBox2.Location = new System.Drawing.Point(35, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 172);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "播放方式";
            this.groupBox2.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "类别编号";
            // 
            // btnAddType
            // 
            this.btnAddType.Location = new System.Drawing.Point(256, 107);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(78, 35);
            this.btnAddType.TabIndex = 4;
            this.btnAddType.Text = "添  加";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // txtTypeId
            // 
            this.txtTypeId.Location = new System.Drawing.Point(112, 50);
            this.txtTypeId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTypeId.Name = "txtTypeId";
            this.txtTypeId.Size = new System.Drawing.Size(116, 26);
            this.txtTypeId.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "类别名称";
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(112, 112);
            this.txtTypeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(116, 26);
            this.txtTypeName.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.cmbLEDId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnClearProgram);
            this.groupBox1.Location = new System.Drawing.Point(35, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 171);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "开关关闭LED屏";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(255, 108);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(78, 35);
            this.btnOpen.TabIndex = 8;
            this.btnOpen.Text = "打开屏幕";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(152, 108);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 35);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "关闭屏幕";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbLEDId
            // 
            this.cmbLEDId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLEDId.FormattingEnabled = true;
            this.cmbLEDId.Location = new System.Drawing.Point(114, 43);
            this.cmbLEDId.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbLEDId.Name = "cmbLEDId";
            this.cmbLEDId.Size = new System.Drawing.Size(143, 28);
            this.cmbLEDId.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "LED编号";
            // 
            // btnClearProgram
            // 
            this.btnClearProgram.Location = new System.Drawing.Point(49, 108);
            this.btnClearProgram.Name = "btnClearProgram";
            this.btnClearProgram.Size = new System.Drawing.Size(78, 35);
            this.btnClearProgram.TabIndex = 4;
            this.btnClearProgram.Text = "清除保存";
            this.btnClearProgram.UseVisualStyleBackColor = true;
            this.btnClearProgram.Click += new System.EventHandler(this.btnClearProgram_Click);
            // 
            // FrmOperateLED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 482);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmOperateLED";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "播放方式配置";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.TextBox txtTypeId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClearProgram;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbLEDId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpen;
    }
}
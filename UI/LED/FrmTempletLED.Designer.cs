namespace UI
{
    partial class FrmTempletLED
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
            this.btnFontColor = new System.Windows.Forms.Button();
            this.btnFontSetting = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.cmbShowType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSava = new System.Windows.Forms.Button();
            this.fontDialogled = new System.Windows.Forms.FontDialog();
            this.colorDialogLed = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // btnFontColor
            // 
            this.btnFontColor.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnFontColor.Location = new System.Drawing.Point(228, 331);
            this.btnFontColor.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnFontColor.Name = "btnFontColor";
            this.btnFontColor.Size = new System.Drawing.Size(75, 40);
            this.btnFontColor.TabIndex = 11;
            this.btnFontColor.Text = "字体颜色";
            this.btnFontColor.UseVisualStyleBackColor = true;
            this.btnFontColor.Click += new System.EventHandler(this.btnFontColor_Click);
            // 
            // btnFontSetting
            // 
            this.btnFontSetting.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnFontSetting.Location = new System.Drawing.Point(121, 331);
            this.btnFontSetting.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnFontSetting.Name = "btnFontSetting";
            this.btnFontSetting.Size = new System.Drawing.Size(75, 40);
            this.btnFontSetting.TabIndex = 10;
            this.btnFontSetting.Text = "字体设置";
            this.btnFontSetting.UseVisualStyleBackColor = true;
            this.btnFontSetting.Click += new System.EventHandler(this.btnFontSetting_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.label5.Location = new System.Drawing.Point(43, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "播放内容";
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.txtContent.Location = new System.Drawing.Point(121, 98);
            this.txtContent.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(351, 193);
            this.txtContent.TabIndex = 13;
            this.txtContent.Text = "网红城市-重庆欢迎你，重庆众乐科技欢迎你！";
            // 
            // cmbShowType
            // 
            this.cmbShowType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShowType.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.cmbShowType.FormattingEnabled = true;
            this.cmbShowType.Location = new System.Drawing.Point(121, 30);
            this.cmbShowType.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cmbShowType.Name = "cmbShowType";
            this.cmbShowType.Size = new System.Drawing.Size(153, 27);
            this.cmbShowType.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.label2.Location = new System.Drawing.Point(43, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "播放方式";
            // 
            // btnSava
            // 
            this.btnSava.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnSava.Location = new System.Drawing.Point(385, 333);
            this.btnSava.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnSava.Name = "btnSava";
            this.btnSava.Size = new System.Drawing.Size(87, 38);
            this.btnSava.TabIndex = 17;
            this.btnSava.Text = "保  存";
            this.btnSava.UseVisualStyleBackColor = true;
            this.btnSava.Click += new System.EventHandler(this.btnSava_Click);
            // 
            // FrmTempletLED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 431);
            this.Controls.Add(this.btnSava);
            this.Controls.Add(this.cmbShowType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btnFontColor);
            this.Controls.Add(this.btnFontSetting);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTempletLED";
            this.Text = "LED模板内容设置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFontColor;
        private System.Windows.Forms.Button btnFontSetting;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.ComboBox cmbShowType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSava;
        private System.Windows.Forms.FontDialog fontDialogled;
        private System.Windows.Forms.ColorDialog colorDialogLed;
    }
}
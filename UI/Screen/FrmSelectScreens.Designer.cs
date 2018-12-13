namespace UI.LED
{
    partial class FrmSelectScreens
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
            this.pnlScreenIds = new System.Windows.Forms.Panel();
            this.btnlstClose = new System.Windows.Forms.Button();
            this.lstScreenIds = new System.Windows.Forms.CheckedListBox();
            this.pnlScreenIds.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlScreenIds
            // 
            this.pnlScreenIds.Controls.Add(this.btnlstClose);
            this.pnlScreenIds.Controls.Add(this.lstScreenIds);
            this.pnlScreenIds.Location = new System.Drawing.Point(68, 31);
            this.pnlScreenIds.Name = "pnlScreenIds";
            this.pnlScreenIds.Size = new System.Drawing.Size(218, 349);
            this.pnlScreenIds.TabIndex = 75;
            this.pnlScreenIds.Visible = false;
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
            // 
            // FrmSelectScreens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlScreenIds);
            this.Name = "FrmSelectScreens";
            this.Text = "屏幕筛选";
            this.pnlScreenIds.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlScreenIds;
        private System.Windows.Forms.Button btnlstClose;
        private System.Windows.Forms.CheckedListBox lstScreenIds;
    }
}
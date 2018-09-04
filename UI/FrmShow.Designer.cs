namespace UI
{
    partial class FrmShow
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tsMenue = new System.Windows.Forms.ToolStrip();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.tsbBegin = new System.Windows.Forms.ToolStripButton();
            this.tsbEnd = new System.Windows.Forms.ToolStripButton();
            this.tsMenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tsMenue
            // 
            this.tsMenue.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.tsMenue.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.tsMenue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbBegin,
            this.tsbEnd});
            this.tsMenue.Location = new System.Drawing.Point(0, 0);
            this.tsMenue.Name = "tsMenue";
            this.tsMenue.Size = new System.Drawing.Size(994, 37);
            this.tsMenue.TabIndex = 1;
            this.tsMenue.Text = "toolStrip1";
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 37);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(994, 618);
            this.pnlContent.TabIndex = 2;
            // 
            // tsbBegin
            // 
            this.tsbBegin.Image = global::UI.Properties.Resources.player_play;
            this.tsbBegin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBegin.Name = "tsbBegin";
            this.tsbBegin.Size = new System.Drawing.Size(73, 34);
            this.tsbBegin.Text = "开始";
            this.tsbBegin.Click += new System.EventHandler(this.tsbBegin_Click);
            // 
            // tsbEnd
            // 
            this.tsbEnd.Image = global::UI.Properties.Resources.Pause;
            this.tsbEnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEnd.Name = "tsbEnd";
            this.tsbEnd.Size = new System.Drawing.Size(73, 34);
            this.tsbEnd.Text = "停止";
            this.tsbEnd.Click += new System.EventHandler(this.tsbEnd_Click);
            // 
            // FrmShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(994, 655);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.tsMenue);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmShow";
            this.Text = "显示";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tsMenue.ResumeLayout(false);
            this.tsMenue.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip tsMenue;
        private System.Windows.Forms.ToolStripButton tsbBegin;
        private System.Windows.Forms.ToolStripButton tsbEnd;
        private System.Windows.Forms.Panel pnlContent;
    }
}
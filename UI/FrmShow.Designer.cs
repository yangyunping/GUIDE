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
            this.tsbBegin = new System.Windows.Forms.ToolStripButton();
            this.tsbLED = new System.Windows.Forms.ToolStripButton();
            this.tsmRefurbish = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pnlContent = new System.Windows.Forms.TabPage();
            this.tbPhoto = new System.Windows.Forms.TabPage();
            this.pnlPhoto = new System.Windows.Forms.Panel();
            this.tsMenue.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbPhoto.SuspendLayout();
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
            this.tsmRefurbish,
            this.tsbLED});
            this.tsMenue.Location = new System.Drawing.Point(0, 0);
            this.tsMenue.Name = "tsMenue";
            this.tsMenue.Size = new System.Drawing.Size(994, 42);
            this.tsMenue.TabIndex = 1;
            this.tsMenue.Text = "toolStrip1";
            // 
            // tsbBegin
            // 
            this.tsbBegin.Image = global::UI.Properties.Resources.player_play;
            this.tsbBegin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBegin.Name = "tsbBegin";
            this.tsbBegin.Size = new System.Drawing.Size(108, 39);
            this.tsbBegin.Text = "显示示例";
            this.tsbBegin.Click += new System.EventHandler(this.tsbBegin_Click);
            // 
            // tsbLED
            // 
            this.tsbLED.Image = global::UI.Properties.Resources.Pause;
            this.tsbLED.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLED.Name = "tsbLED";
            this.tsbLED.Size = new System.Drawing.Size(105, 39);
            this.tsbLED.Text = "LED显示";
            this.tsbLED.Click += new System.EventHandler(this.tsbLEDhow_Click);
            // 
            // tsmRefurbish
            // 
            this.tsmRefurbish.Image = global::UI.Properties.Resources.clock_alt;
            this.tsmRefurbish.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmRefurbish.Name = "tsmRefurbish";
            this.tsmRefurbish.Size = new System.Drawing.Size(108, 39);
            this.tsmRefurbish.Text = "图例刷新";
            this.tsmRefurbish.Click += new System.EventHandler(this.tsmRefurbish_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pnlContent);
            this.tabControl1.Controls.Add(this.tbPhoto);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.tabControl1.Location = new System.Drawing.Point(0, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(994, 613);
            this.tabControl1.TabIndex = 2;
            // 
            // pnlContent
            // 
            this.pnlContent.Location = new System.Drawing.Point(4, 28);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(3);
            this.pnlContent.Size = new System.Drawing.Size(986, 581);
            this.pnlContent.TabIndex = 0;
            this.pnlContent.Text = "列   表";
            this.pnlContent.UseVisualStyleBackColor = true;
            // 
            // tbPhoto
            // 
            this.tbPhoto.Controls.Add(this.pnlPhoto);
            this.tbPhoto.Location = new System.Drawing.Point(4, 28);
            this.tbPhoto.Name = "tbPhoto";
            this.tbPhoto.Padding = new System.Windows.Forms.Padding(3);
            this.tbPhoto.Size = new System.Drawing.Size(986, 581);
            this.tbPhoto.TabIndex = 1;
            this.tbPhoto.Text = "图   例";
            this.tbPhoto.UseVisualStyleBackColor = true;
            // 
            // pnlPhoto
            // 
            this.pnlPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPhoto.Location = new System.Drawing.Point(3, 3);
            this.pnlPhoto.Name = "pnlPhoto";
            this.pnlPhoto.Size = new System.Drawing.Size(980, 575);
            this.pnlPhoto.TabIndex = 0;
            this.pnlPhoto.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPhoto_Paint);
            // 
            // FrmShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(994, 655);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tsMenue);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmShow";
            this.Text = "显示";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tsMenue.ResumeLayout(false);
            this.tsMenue.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbPhoto.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip tsMenue;
        private System.Windows.Forms.ToolStripButton tsbBegin;
        private System.Windows.Forms.ToolStripButton tsbLED;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pnlContent;
        private System.Windows.Forms.TabPage tbPhoto;
        private System.Windows.Forms.Panel pnlPhoto;
        private System.Windows.Forms.ToolStripButton tsmRefurbish;
    }
}
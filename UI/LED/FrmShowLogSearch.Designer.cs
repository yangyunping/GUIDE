namespace UI.LED
{
    partial class FrmShowLogSearch
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbShowState = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvTemShow = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemShow)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbShowState);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 70);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "显示状态";
            // 
            // cmbShowState
            // 
            this.cmbShowState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShowState.FormattingEnabled = true;
            this.cmbShowState.Items.AddRange(new object[] {
            "全部",
            "开始",
            "暂停",
            "模板实时显示",
            "自定义实时显示"});
            this.cmbShowState.Location = new System.Drawing.Point(112, 23);
            this.cmbShowState.Name = "cmbShowState";
            this.cmbShowState.Size = new System.Drawing.Size(121, 27);
            this.cmbShowState.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(257, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(79, 38);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查 询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvTemShow
            // 
            this.dgvTemShow.AllowUserToAddRows = false;
            this.dgvTemShow.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvTemShow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTemShow.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvTemShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTemShow.Location = new System.Drawing.Point(0, 70);
            this.dgvTemShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTemShow.Name = "dgvTemShow";
            this.dgvTemShow.ReadOnly = true;
            this.dgvTemShow.RowHeadersWidth = 11;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvTemShow.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTemShow.RowTemplate.Height = 23;
            this.dgvTemShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTemShow.Size = new System.Drawing.Size(793, 415);
            this.dgvTemShow.TabIndex = 4;
            this.dgvTemShow.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTemShow_CellFormatting);
            // 
            // FrmShowLogSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTemShow);
            this.Controls.Add(this.panel1);
            this.Name = "FrmShowLogSearch";
            this.Size = new System.Drawing.Size(793, 485);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvTemShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbShowState;
    }
}

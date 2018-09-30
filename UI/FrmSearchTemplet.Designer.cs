namespace UI
{
    partial class FrmSearchTemplet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvContent = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddShow = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbMenues = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContent)).BeginInit();
            this.panel1.SuspendLayout();
            this.grbMenues.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvContent
            // 
            this.dgvContent.AllowUserToAddRows = false;
            this.dgvContent.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContent.Location = new System.Drawing.Point(0, 96);
            this.dgvContent.MultiSelect = false;
            this.dgvContent.Name = "dgvContent";
            this.dgvContent.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContent.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContent.RowHeadersWidth = 20;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.dgvContent.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvContent.RowTemplate.Height = 23;
            this.dgvContent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContent.Size = new System.Drawing.Size(652, 414);
            this.dgvContent.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbMenues);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 96);
            this.panel1.TabIndex = 2;
            // 
            // btnAddShow
            // 
            this.btnAddShow.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnAddShow.Location = new System.Drawing.Point(531, 36);
            this.btnAddShow.Name = "btnAddShow";
            this.btnAddShow.Size = new System.Drawing.Size(78, 40);
            this.btnAddShow.TabIndex = 22;
            this.btnAddShow.Text = "显示添加";
            this.btnAddShow.UseVisualStyleBackColor = true;
            this.btnAddShow.Visible = false;
            this.btnAddShow.Click += new System.EventHandler(this.btnAddShow_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnAdd.Location = new System.Drawing.Point(459, 36);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 40);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnModify.Location = new System.Drawing.Point(313, 36);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(64, 40);
            this.btnModify.TabIndex = 20;
            this.btnModify.Text = "修 改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnDelete.Location = new System.Drawing.Point(383, 36);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 40);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "删 除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnSearch.Location = new System.Drawing.Point(241, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 40);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "查 询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtKey.Location = new System.Drawing.Point(86, 43);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(132, 26);
            this.txtKey.TabIndex = 17;
            this.txtKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKey_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(29, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "关键字";
            // 
            // grbMenues
            // 
            this.grbMenues.Controls.Add(this.btnAddShow);
            this.grbMenues.Controls.Add(this.label1);
            this.grbMenues.Controls.Add(this.btnAdd);
            this.grbMenues.Controls.Add(this.txtKey);
            this.grbMenues.Controls.Add(this.btnModify);
            this.grbMenues.Controls.Add(this.btnSearch);
            this.grbMenues.Controls.Add(this.btnDelete);
            this.grbMenues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbMenues.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.grbMenues.Location = new System.Drawing.Point(0, 0);
            this.grbMenues.Name = "grbMenues";
            this.grbMenues.Size = new System.Drawing.Size(652, 96);
            this.grbMenues.TabIndex = 4;
            this.grbMenues.TabStop = false;
            this.grbMenues.Text = "菜单";
            // 
            // FrmSearchTemplet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvContent);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSearchTemplet";
            this.Size = new System.Drawing.Size(652, 510);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContent)).EndInit();
            this.panel1.ResumeLayout(false);
            this.grbMenues.ResumeLayout(false);
            this.grbMenues.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddShow;
        private System.Windows.Forms.GroupBox grbMenues;
    }
}

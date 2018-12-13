namespace UI
{
    partial class FrmConfig
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
            this.cmbStyle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddStyle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.txtType = new System.Windows.Forms.TextBox();
            this.btnSearcxh = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTypeClose = new System.Windows.Forms.Button();
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.grpAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbStyle
            // 
            this.cmbStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStyle.FormattingEnabled = true;
            this.cmbStyle.Location = new System.Drawing.Point(67, 31);
            this.cmbStyle.Name = "cmbStyle";
            this.cmbStyle.Size = new System.Drawing.Size(125, 28);
            this.cmbStyle.TabIndex = 0;
            this.cmbStyle.SelectedIndexChanged += new System.EventHandler(this.cmbStyle_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "类别";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(269, 31);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(125, 26);
            this.txtKey.TabIndex = 2;
            this.txtKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContent_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAdd.Location = new System.Drawing.Point(476, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 40);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "新  增";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDelete.Location = new System.Drawing.Point(628, 26);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 40);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "删  除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddStyle
            // 
            this.btnAddStyle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAddStyle.Location = new System.Drawing.Point(704, 26);
            this.btnAddStyle.Name = "btnAddStyle";
            this.btnAddStyle.Size = new System.Drawing.Size(94, 39);
            this.btnAddStyle.TabIndex = 6;
            this.btnAddStyle.Text = "新增类别";
            this.btnAddStyle.UseVisualStyleBackColor = false;
            this.btnAddStyle.Click += new System.EventHandler(this.btnAddStyle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "关键字";
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnModify.Location = new System.Drawing.Point(552, 26);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(70, 40);
            this.btnModify.TabIndex = 9;
            this.btnModify.Text = "修 改";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(804, 33);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(125, 26);
            this.txtType.TabIndex = 10;
            this.txtType.Visible = false;
            // 
            // btnSearcxh
            // 
            this.btnSearcxh.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSearcxh.Location = new System.Drawing.Point(400, 25);
            this.btnSearcxh.Name = "btnSearcxh";
            this.btnSearcxh.Size = new System.Drawing.Size(70, 40);
            this.btnSearcxh.TabIndex = 11;
            this.btnSearcxh.Text = "查  询";
            this.btnSearcxh.UseVisualStyleBackColor = false;
            this.btnSearcxh.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(101, 77);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(145, 26);
            this.txtContent.TabIndex = 12;
            this.txtContent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContent_KeyDown_1);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSave.Location = new System.Drawing.Point(169, 133);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 40);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "保 存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCancle.Location = new System.Drawing.Point(41, 133);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 40);
            this.btnCancle.TabIndex = 14;
            this.btnCancle.Text = "取 消";
            this.btnCancle.UseVisualStyleBackColor = false;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "内  容";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "类  别";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(101, 22);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(145, 28);
            this.cmbType.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTypeClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbStyle);
            this.panel1.Controls.Add(this.btnSearcxh);
            this.panel1.Controls.Add(this.txtKey);
            this.panel1.Controls.Add(this.txtType);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnModify);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnAddStyle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 80);
            this.panel1.TabIndex = 16;
            // 
            // btnTypeClose
            // 
            this.btnTypeClose.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnTypeClose.Location = new System.Drawing.Point(935, 25);
            this.btnTypeClose.Name = "btnTypeClose";
            this.btnTypeClose.Size = new System.Drawing.Size(75, 40);
            this.btnTypeClose.TabIndex = 15;
            this.btnTypeClose.Text = "取 消";
            this.btnTypeClose.UseVisualStyleBackColor = false;
            this.btnTypeClose.Visible = false;
            this.btnTypeClose.Click += new System.EventHandler(this.btnTypeClose_Click);
            // 
            // grpAdd
            // 
            this.grpAdd.Controls.Add(this.label4);
            this.grpAdd.Controls.Add(this.label2);
            this.grpAdd.Controls.Add(this.btnSave);
            this.grpAdd.Controls.Add(this.cmbType);
            this.grpAdd.Controls.Add(this.btnCancle);
            this.grpAdd.Controls.Add(this.txtContent);
            this.grpAdd.Location = new System.Drawing.Point(400, 80);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Size = new System.Drawing.Size(286, 192);
            this.grpAdd.TabIndex = 16;
            this.grpAdd.TabStop = false;
            this.grpAdd.Visible = false;
            // 
            // dgvShow
            // 
            this.dgvShow.AllowUserToAddRows = false;
            this.dgvShow.AllowUserToDeleteRows = false;
            this.dgvShow.BackgroundColor = System.Drawing.Color.White;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShow.Location = new System.Drawing.Point(0, 80);
            this.dgvShow.MultiSelect = false;
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.ReadOnly = true;
            this.dgvShow.RowHeadersWidth = 11;
            this.dgvShow.RowTemplate.Height = 23;
            this.dgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShow.Size = new System.Drawing.Size(1017, 425);
            this.dgvShow.TabIndex = 17;
            this.dgvShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShow_CellClick);
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.grpAdd);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmConfig";
            this.Size = new System.Drawing.Size(1017, 505);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStyle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddStyle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Button btnSearcxh;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Button btnTypeClose;
    }
}
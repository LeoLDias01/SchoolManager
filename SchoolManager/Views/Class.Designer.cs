namespace SchoolManager.Views
{
    partial class Class
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Class));
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.customPanel1 = new SchoolManager.Components.CustomPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbTerm = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTerm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClass
            // 
            this.dgvClass.AllowUserToAddRows = false;
            this.dgvClass.AllowUserToDeleteRows = false;
            this.dgvClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClass.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvClass.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colClass,
            this.colTerm,
            this.colEdit,
            this.colDelete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClass.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClass.EnableHeadersVisualStyles = false;
            this.dgvClass.Location = new System.Drawing.Point(205, 103);
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.ReadOnly = true;
            this.dgvClass.RowHeadersVisible = false;
            this.dgvClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClass.Size = new System.Drawing.Size(1047, 566);
            this.dgvClass.TabIndex = 41;
            this.dgvClass.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClass_CellContentClick);
            this.dgvClass.SelectionChanged += new System.EventHandler(this.dgvClass_SelectionChanged);
            // 
            // customPanel1
            // 
            this.customPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.customPanel1.Controls.Add(this.btnClear);
            this.customPanel1.Controls.Add(this.btnSearch);
            this.customPanel1.Controls.Add(this.btnAdd);
            this.customPanel1.Controls.Add(this.cmbTerm);
            this.customPanel1.Controls.Add(this.label3);
            this.customPanel1.Controls.Add(this.txtClass);
            this.customPanel1.Controls.Add(this.label2);
            this.customPanel1.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.customPanel1.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.customPanel1.CorTextoBotao = System.Drawing.Color.White;
            this.customPanel1.ForeColor = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(205, 49);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1047, 48);
            this.customPanel1.TabIndex = 42;
            this.customPanel1.TamanhoBorda = 0;
            this.customPanel1.TamanhoRaio = 10;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(960, 1);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(39, 45);
            this.btnClear.TabIndex = 45;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(915, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(39, 42);
            this.btnSearch.TabIndex = 44;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(1005, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(39, 42);
            this.btnAdd.TabIndex = 43;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbTerm
            // 
            this.cmbTerm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTerm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTerm.FormattingEnabled = true;
            this.cmbTerm.Location = new System.Drawing.Point(360, 14);
            this.cmbTerm.Name = "cmbTerm";
            this.cmbTerm.Size = new System.Drawing.Size(158, 21);
            this.cmbTerm.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(306, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Período";
            // 
            // txtClass
            // 
            this.txtClass.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClass.Location = new System.Drawing.Point(60, 14);
            this.txtClass.MaxLength = 80;
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(230, 22);
            this.txtClass.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Turma";
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colClass
            // 
            this.colClass.DataPropertyName = "Name";
            this.colClass.FillWeight = 189.8439F;
            this.colClass.HeaderText = "Turma";
            this.colClass.Name = "colClass";
            this.colClass.ReadOnly = true;
            // 
            // colTerm
            // 
            this.colTerm.DataPropertyName = "TermDescription";
            this.colTerm.FillWeight = 189.8439F;
            this.colTerm.HeaderText = "Período";
            this.colTerm.Name = "colTerm";
            this.colTerm.ReadOnly = true;
            // 
            // colEdit
            // 
            this.colEdit.FillWeight = 10.15228F;
            this.colEdit.HeaderText = "";
            this.colEdit.Image = ((System.Drawing.Image)(resources.GetObject("colEdit.Image")));
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            // 
            // colDelete
            // 
            this.colDelete.FillWeight = 10.1598F;
            this.colDelete.HeaderText = "";
            this.colDelete.Image = ((System.Drawing.Image)(resources.GetObject("colDelete.Image")));
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            // 
            // Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.dgvClass);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Class";
            this.Text = "Class";
            this.Load += new System.EventHandler(this.Class_Load);
            this.Controls.SetChildIndex(this.dgvClass, 0);
            this.Controls.SetChildIndex(this.customPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClass;
        private Components.CustomPanel customPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbTerm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTerm;
        private System.Windows.Forms.DataGridViewImageColumn colEdit;
        private System.Windows.Forms.DataGridViewImageColumn colDelete;
    }
}
namespace SchoolManager.Views
{
    partial class Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customPanel1 = new SchoolManager.Components.CustomPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbTerm = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.colClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTerm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            this.SuspendLayout();
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
            this.customPanel1.Location = new System.Drawing.Point(205, 55);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1047, 48);
            this.customPanel1.TabIndex = 43;
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
            // 
            // cmbTerm
            // 
            this.cmbTerm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTerm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTerm.FormattingEnabled = true;
            this.cmbTerm.Location = new System.Drawing.Point(360, 14);
            this.cmbTerm.Name = "cmbTerm";
            this.cmbTerm.Size = new System.Drawing.Size(165, 21);
            this.cmbTerm.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(306, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Turma";
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
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Aluno";
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
            this.colClass,
            this.colTerm,
            this.colEdit,
            this.colDelete});
            this.dgvClass.EnableHeadersVisualStyles = false;
            this.dgvClass.Location = new System.Drawing.Point(205, 107);
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.ReadOnly = true;
            this.dgvClass.RowHeadersVisible = false;
            this.dgvClass.Size = new System.Drawing.Size(1047, 566);
            this.dgvClass.TabIndex = 44;
            // 
            // colClass
            // 
            this.colClass.HeaderText = "Aluno";
            this.colClass.Name = "colClass";
            this.colClass.ReadOnly = true;
            // 
            // colTerm
            // 
            this.colTerm.HeaderText = "Turma";
            this.colTerm.Name = "colTerm";
            this.colTerm.ReadOnly = true;
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "";
            this.colEdit.Image = ((System.Drawing.Image)(resources.GetObject("colEdit.Image")));
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "";
            this.colDelete.Image = ((System.Drawing.Image)(resources.GetObject("colDelete.Image")));
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.dgvClass);
            this.Controls.Add(this.customPanel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Students";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Students_Load);
            this.Controls.SetChildIndex(this.customPanel1, 0);
            this.Controls.SetChildIndex(this.dgvClass, 0);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.CustomPanel customPanel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbTerm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTerm;
        private System.Windows.Forms.DataGridViewImageColumn colEdit;
        private System.Windows.Forms.DataGridViewImageColumn colDelete;
    }
}
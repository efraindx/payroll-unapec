namespace Nomina
{
    partial class PositionForm
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
            this.positionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payrollunapecDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._payroll_unapecDataSet = new Nomina._payroll_unapecDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.positionName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.positionMinSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.positionMaxSalary = new System.Windows.Forms.TextBox();
            this.positionsDataGrid = new System.Windows.Forms.DataGridView();
            this.cmbRiesgo = new System.Windows.Forms.ComboBox();
            this.savePosition = new System.Windows.Forms.Button();
            this.positionsTableAdapter = new Nomina._payroll_unapecDataSetTableAdapters.PositionsTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._payroll_unapecDataSet1 = new Nomina._payroll_unapecDataSet();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.riskLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.minSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollunapecDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._payroll_unapecDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._payroll_unapecDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // positionsBindingSource
            // 
            this.positionsBindingSource.DataMember = "Positions";
            this.positionsBindingSource.DataSource = this.payrollunapecDataSetBindingSource;
            // 
            // payrollunapecDataSetBindingSource
            // 
            this.payrollunapecDataSetBindingSource.DataSource = this._payroll_unapecDataSet;
            this.payrollunapecDataSetBindingSource.Position = 0;
            // 
            // _payroll_unapecDataSet
            // 
            this._payroll_unapecDataSet.DataSetName = "_payroll_unapecDataSet";
            this._payroll_unapecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // positionName
            // 
            this.positionName.Location = new System.Drawing.Point(104, 34);
            this.positionName.Name = "positionName";
            this.positionName.Size = new System.Drawing.Size(121, 20);
            this.positionName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nivel de Riesgo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Salario Min:";
            // 
            // positionMinSalary
            // 
            this.positionMinSalary.Location = new System.Drawing.Point(331, 31);
            this.positionMinSalary.Name = "positionMinSalary";
            this.positionMinSalary.Size = new System.Drawing.Size(100, 20);
            this.positionMinSalary.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Salario Max:";
            // 
            // positionMaxSalary
            // 
            this.positionMaxSalary.Location = new System.Drawing.Point(331, 70);
            this.positionMaxSalary.Name = "positionMaxSalary";
            this.positionMaxSalary.Size = new System.Drawing.Size(100, 20);
            this.positionMaxSalary.TabIndex = 8;
            // 
            // positionsDataGrid
            // 
            this.positionsDataGrid.AllowUserToAddRows = false;
            this.positionsDataGrid.AllowUserToDeleteRows = false;
            this.positionsDataGrid.AutoGenerateColumns = false;
            this.positionsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.positionsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.riskLevelDataGridViewTextBoxColumn,
            this.minSalaryDataGridViewTextBoxColumn,
            this.maxSalaryDataGridViewTextBoxColumn});
            this.positionsDataGrid.DataSource = this.positionsBindingSource;
            this.positionsDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.positionsDataGrid.Location = new System.Drawing.Point(12, 153);
            this.positionsDataGrid.Name = "positionsDataGrid";
            this.positionsDataGrid.Size = new System.Drawing.Size(523, 167);
            this.positionsDataGrid.TabIndex = 0;
            this.positionsDataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellValueChanged);
            this.positionsDataGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGrid_DataError);
            // 
            // cmbRiesgo
            // 
            this.cmbRiesgo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRiesgo.FormattingEnabled = true;
            this.cmbRiesgo.Items.AddRange(new object[] {
            "Alto",
            "Medio",
            "Bajo"});
            this.cmbRiesgo.Location = new System.Drawing.Point(104, 73);
            this.cmbRiesgo.Name = "cmbRiesgo";
            this.cmbRiesgo.Size = new System.Drawing.Size(121, 21);
            this.cmbRiesgo.TabIndex = 11;
            // 
            // savePosition
            // 
            this.savePosition.Location = new System.Drawing.Point(15, 115);
            this.savePosition.Name = "savePosition";
            this.savePosition.Size = new System.Drawing.Size(75, 23);
            this.savePosition.TabIndex = 9;
            this.savePosition.Text = "Guardar";
            this.savePosition.UseVisualStyleBackColor = true;
            this.savePosition.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // positionsTableAdapter
            // 
            this.positionsTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nomina.Properties.Resources.iconPuesto;
            this.pictureBox1.Location = new System.Drawing.Point(440, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 91);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // _payroll_unapecDataSet1
            // 
            this._payroll_unapecDataSet1.DataSetName = "_payroll_unapecDataSet";
            this._payroll_unapecDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(104, 115);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // riskLevelDataGridViewTextBoxColumn
            // 
            this.riskLevelDataGridViewTextBoxColumn.DataPropertyName = "RiskLevel";
            this.riskLevelDataGridViewTextBoxColumn.HeaderText = "Riesgo";
            this.riskLevelDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Alto",
            "Medio",
            "Bajo"});
            this.riskLevelDataGridViewTextBoxColumn.Name = "riskLevelDataGridViewTextBoxColumn";
            this.riskLevelDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.riskLevelDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.riskLevelDataGridViewTextBoxColumn.Width = 80;
            // 
            // minSalaryDataGridViewTextBoxColumn
            // 
            this.minSalaryDataGridViewTextBoxColumn.DataPropertyName = "MinSalary";
            this.minSalaryDataGridViewTextBoxColumn.HeaderText = "Salario Min.";
            this.minSalaryDataGridViewTextBoxColumn.Name = "minSalaryDataGridViewTextBoxColumn";
            // 
            // maxSalaryDataGridViewTextBoxColumn
            // 
            this.maxSalaryDataGridViewTextBoxColumn.DataPropertyName = "MaxSalary";
            this.maxSalaryDataGridViewTextBoxColumn.HeaderText = "Salario Max.";
            this.maxSalaryDataGridViewTextBoxColumn.Name = "maxSalaryDataGridViewTextBoxColumn";
            // 
            // PositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 332);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbRiesgo);
            this.Controls.Add(this.positionsDataGrid);
            this.Controls.Add(this.savePosition);
            this.Controls.Add(this.positionMaxSalary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.positionMinSalary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.positionName);
            this.Controls.Add(this.label1);
            this.Name = "PositionForm";
            this.Text = "Mantenimiento de Puestos";
            this.Load += new System.EventHandler(this.StandardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollunapecDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._payroll_unapecDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._payroll_unapecDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource payrollunapecDataSetBindingSource;
        private _payroll_unapecDataSet _payroll_unapecDataSet;
        private System.Windows.Forms.BindingSource positionsBindingSource;
        private _payroll_unapecDataSetTableAdapters.PositionsTableAdapter positionsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox positionName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox positionMinSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox positionMaxSalary;
        private System.Windows.Forms.Button savePosition;
        private System.Windows.Forms.DataGridView positionsDataGrid;
        private System.Windows.Forms.ComboBox cmbRiesgo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private _payroll_unapecDataSet _payroll_unapecDataSet1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn riskLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxSalaryDataGridViewTextBoxColumn;
    }
}
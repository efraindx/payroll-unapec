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
            this.positionsTableAdapter = new Nomina._payroll_unapecDataSetTableAdapters.PositionsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.positionName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.positionRisk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.positionMinSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.positionMaxSalary = new System.Windows.Forms.TextBox();
            this.savePosition = new System.Windows.Forms.Button();
            this.cancelPosition = new System.Windows.Forms.Button();
            this.positionsDataGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.riskLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollunapecDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._payroll_unapecDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsDataGrid)).BeginInit();
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
            // positionsTableAdapter
            // 
            this.positionsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // positionName
            // 
            this.positionName.Location = new System.Drawing.Point(65, 32);
            this.positionName.Name = "positionName";
            this.positionName.Size = new System.Drawing.Size(100, 20);
            this.positionName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Riesgo";
            // 
            // positionRisk
            // 
            this.positionRisk.Location = new System.Drawing.Point(65, 66);
            this.positionRisk.Name = "positionRisk";
            this.positionRisk.Size = new System.Drawing.Size(100, 20);
            this.positionRisk.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Salario Min";
            // 
            // positionMinSalary
            // 
            this.positionMinSalary.Location = new System.Drawing.Point(277, 31);
            this.positionMinSalary.Name = "positionMinSalary";
            this.positionMinSalary.Size = new System.Drawing.Size(100, 20);
            this.positionMinSalary.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Salario Max";
            // 
            // positionMaxSalary
            // 
            this.positionMaxSalary.Location = new System.Drawing.Point(277, 66);
            this.positionMaxSalary.Name = "positionMaxSalary";
            this.positionMaxSalary.Size = new System.Drawing.Size(100, 20);
            this.positionMaxSalary.TabIndex = 8;
            // 
            // savePosition
            // 
            this.savePosition.Location = new System.Drawing.Point(96, 113);
            this.savePosition.Name = "savePosition";
            this.savePosition.Size = new System.Drawing.Size(75, 23);
            this.savePosition.TabIndex = 9;
            this.savePosition.Text = "Guardar";
            this.savePosition.UseVisualStyleBackColor = true;
            this.savePosition.Click += new System.EventHandler(this.savePosition_Click);
            // 
            // cancelPosition
            // 
            this.cancelPosition.Location = new System.Drawing.Point(15, 113);
            this.cancelPosition.Name = "cancelPosition";
            this.cancelPosition.Size = new System.Drawing.Size(75, 23);
            this.cancelPosition.TabIndex = 10;
            this.cancelPosition.Text = "Cancelar";
            this.cancelPosition.UseVisualStyleBackColor = true;
            // 
            // positionsDataGrid
            // 
            this.positionsDataGrid.AutoGenerateColumns = false;
            this.positionsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.positionsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.riskLevelDataGridViewTextBoxColumn,
            this.minSalaryDataGridViewTextBoxColumn,
            this.maxSalaryDataGridViewTextBoxColumn});
            this.positionsDataGrid.DataSource = this.positionsBindingSource;
            this.positionsDataGrid.Location = new System.Drawing.Point(12, 170);
            this.positionsDataGrid.Name = "positionsDataGrid";
            this.positionsDataGrid.Size = new System.Drawing.Size(523, 150);
            this.positionsDataGrid.TabIndex = 0;
            this.positionsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.riskLevelDataGridViewTextBoxColumn.Name = "riskLevelDataGridViewTextBoxColumn";
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
            this.Controls.Add(this.positionsDataGrid);
            this.Controls.Add(this.cancelPosition);
            this.Controls.Add(this.savePosition);
            this.Controls.Add(this.positionMaxSalary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.positionMinSalary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.positionRisk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.positionName);
            this.Controls.Add(this.label1);
            this.Name = "PositionForm";
            this.Text = "Mantenimiento de Puestos";
            this.Load += new System.EventHandler(this.PositionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollunapecDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._payroll_unapecDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsDataGrid)).EndInit();
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
        private System.Windows.Forms.TextBox positionRisk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox positionMinSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox positionMaxSalary;
        private System.Windows.Forms.Button savePosition;
        private System.Windows.Forms.Button cancelPosition;
        private System.Windows.Forms.DataGridView positionsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn riskLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxSalaryDataGridViewTextBoxColumn;
    }
}
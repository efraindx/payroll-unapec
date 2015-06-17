namespace Nomina
{
    partial class DeductionTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeductionTypeForm));
            this.cmbDeductionStatus = new System.Windows.Forms.ComboBox();
            this.cmbDeductionSalaryDependent = new System.Windows.Forms.ComboBox();
            this.txtDeductionName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._payroll_unapecDataSet1 = new Nomina._payroll_unapecDataSet1();
            this.transactionTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionTypesTableAdapter = new Nomina._payroll_unapecDataSet1TableAdapters.TransactionTypesTableAdapter();
            this.tableAdapterManager = new Nomina._payroll_unapecDataSet1TableAdapters.TableAdapterManager();
            this.deductionTypeDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._payroll_unapecDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deductionTypeDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDeductionStatus
            // 
            this.cmbDeductionStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeductionStatus.FormattingEnabled = true;
            this.cmbDeductionStatus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbDeductionStatus.Location = new System.Drawing.Point(95, 62);
            this.cmbDeductionStatus.Name = "cmbDeductionStatus";
            this.cmbDeductionStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbDeductionStatus.TabIndex = 12;
            // 
            // cmbDeductionSalaryDependent
            // 
            this.cmbDeductionSalaryDependent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeductionSalaryDependent.FormattingEnabled = true;
            this.cmbDeductionSalaryDependent.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cmbDeductionSalaryDependent.Location = new System.Drawing.Point(122, 95);
            this.cmbDeductionSalaryDependent.Name = "cmbDeductionSalaryDependent";
            this.cmbDeductionSalaryDependent.Size = new System.Drawing.Size(94, 21);
            this.cmbDeductionSalaryDependent.TabIndex = 11;
            // 
            // txtDeductionName
            // 
            this.txtDeductionName.Location = new System.Drawing.Point(95, 30);
            this.txtDeductionName.Name = "txtDeductionName";
            this.txtDeductionName.Size = new System.Drawing.Size(121, 20);
            this.txtDeductionName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Depende de Salario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Estado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre:";
            // 
            // _payroll_unapecDataSet1
            // 
            this._payroll_unapecDataSet1.DataSetName = "_payroll_unapecDataSet1";
            this._payroll_unapecDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionTypesBindingSource
            // 
            this.transactionTypesBindingSource.DataMember = "TransactionTypes";
            this.transactionTypesBindingSource.DataSource = this._payroll_unapecDataSet1;
            this.transactionTypesBindingSource.Filter = "isIncome=false";
            // 
            // transactionTypesTableAdapter
            // 
            this.transactionTypesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TransactionTypesTableAdapter = this.transactionTypesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Nomina._payroll_unapecDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // deductionTypeDataGrid
            // 
            this.deductionTypeDataGrid.AllowUserToAddRows = false;
            this.deductionTypeDataGrid.AllowUserToDeleteRows = false;
            this.deductionTypeDataGrid.AutoGenerateColumns = false;
            this.deductionTypeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deductionTypeDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3});
            this.deductionTypeDataGrid.DataSource = this.transactionTypesBindingSource;
            this.deductionTypeDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.deductionTypeDataGrid.Location = new System.Drawing.Point(12, 172);
            this.deductionTypeDataGrid.Name = "deductionTypeDataGrid";
            this.deductionTypeDataGrid.Size = new System.Drawing.Size(370, 220);
            this.deductionTypeDataGrid.TabIndex = 14;
            this.deductionTypeDataGrid.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.DataGrid_CellParsing);
            this.deductionTypeDataGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGrid_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn4.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn4.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SalaryDependent";
            this.dataGridViewTextBoxColumn3.HeaderText = "Depende de Salario";
            this.dataGridViewTextBoxColumn3.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(106, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nomina.Properties.Resources.iconDeductionType;
            this.pictureBox1.Location = new System.Drawing.Point(251, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 127);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // DeductionTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 404);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deductionTypeDataGrid);
            this.Controls.Add(this.cmbDeductionStatus);
            this.Controls.Add(this.cmbDeductionSalaryDependent);
            this.Controls.Add(this.txtDeductionName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeductionTypeForm";
            this.Text = "Matenimiento de Tipo de Deducciones";
            this.Load += new System.EventHandler(this.StandardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._payroll_unapecDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deductionTypeDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbDeductionStatus;
        private System.Windows.Forms.ComboBox cmbDeductionSalaryDependent;
        private System.Windows.Forms.TextBox txtDeductionName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private _payroll_unapecDataSet1 _payroll_unapecDataSet1;
        private System.Windows.Forms.BindingSource transactionTypesBindingSource;
        private _payroll_unapecDataSet1TableAdapters.TransactionTypesTableAdapter transactionTypesTableAdapter;
        private _payroll_unapecDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView deductionTypeDataGrid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
    }
}
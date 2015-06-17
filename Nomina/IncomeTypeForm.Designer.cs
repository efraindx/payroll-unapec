namespace Nomina
{
    partial class IncomeTypeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIncomeName = new System.Windows.Forms.TextBox();
            this.cmbSalaryDependent = new System.Windows.Forms.ComboBox();
            this.cmbIncomeStatus = new System.Windows.Forms.ComboBox();
            this.transactionTypesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.transactionTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._payroll_unapecDataSet1 = new Nomina._payroll_unapecDataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.transactionTypesTableAdapter = new Nomina._payroll_unapecDataSet1TableAdapters.TransactionTypesTableAdapter();
            this.tableAdapterManager = new Nomina._payroll_unapecDataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._payroll_unapecDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Depende de Salario:";
            // 
            // txtIncomeName
            // 
            this.txtIncomeName.Location = new System.Drawing.Point(95, 28);
            this.txtIncomeName.Name = "txtIncomeName";
            this.txtIncomeName.Size = new System.Drawing.Size(121, 20);
            this.txtIncomeName.TabIndex = 3;
            // 
            // cmbSalaryDependent
            // 
            this.cmbSalaryDependent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalaryDependent.FormattingEnabled = true;
            this.cmbSalaryDependent.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cmbSalaryDependent.Location = new System.Drawing.Point(122, 93);
            this.cmbSalaryDependent.Name = "cmbSalaryDependent";
            this.cmbSalaryDependent.Size = new System.Drawing.Size(94, 21);
            this.cmbSalaryDependent.TabIndex = 4;
            // 
            // cmbIncomeStatus
            // 
            this.cmbIncomeStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIncomeStatus.FormattingEnabled = true;
            this.cmbIncomeStatus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbIncomeStatus.Location = new System.Drawing.Point(95, 60);
            this.cmbIncomeStatus.Name = "cmbIncomeStatus";
            this.cmbIncomeStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbIncomeStatus.TabIndex = 5;
            // 
            // transactionTypesDataGridView
            // 
            this.transactionTypesDataGridView.AllowUserToAddRows = false;
            this.transactionTypesDataGridView.AllowUserToDeleteRows = false;
            this.transactionTypesDataGridView.AutoGenerateColumns = false;
            this.transactionTypesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionTypesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3});
            this.transactionTypesDataGridView.DataSource = this.transactionTypesBindingSource;
            this.transactionTypesDataGridView.Location = new System.Drawing.Point(12, 172);
            this.transactionTypesDataGridView.Name = "transactionTypesDataGridView";
            this.transactionTypesDataGridView.Size = new System.Drawing.Size(371, 220);
            this.transactionTypesDataGridView.TabIndex = 8;
            this.transactionTypesDataGridView.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.DataGrid_CellParsing);
            this.transactionTypesDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGrid_DataError);
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
            // transactionTypesBindingSource
            // 
            this.transactionTypesBindingSource.DataMember = "TransactionTypes";
            this.transactionTypesBindingSource.DataSource = this._payroll_unapecDataSet1;
            this.transactionTypesBindingSource.Filter = "isIncome=true";
            // 
            // _payroll_unapecDataSet1
            // 
            this._payroll_unapecDataSet1.DataSetName = "_payroll_unapecDataSet1";
            this._payroll_unapecDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(106, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nomina.Properties.Resources.iconIncomeType;
            this.pictureBox1.Location = new System.Drawing.Point(253, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 124);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
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
            // IncomeTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 412);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.transactionTypesDataGridView);
            this.Controls.Add(this.cmbIncomeStatus);
            this.Controls.Add(this.cmbSalaryDependent);
            this.Controls.Add(this.txtIncomeName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IncomeTypeForm";
            this.Text = "Mantenimiento de Tipo de Ingreso";
            this.Load += new System.EventHandler(this.StandardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._payroll_unapecDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIncomeName;
        private System.Windows.Forms.ComboBox cmbSalaryDependent;
        private System.Windows.Forms.ComboBox cmbIncomeStatus;
        private _payroll_unapecDataSet1 _payroll_unapecDataSet1;
        private System.Windows.Forms.BindingSource transactionTypesBindingSource;
        private _payroll_unapecDataSet1TableAdapters.TransactionTypesTableAdapter transactionTypesTableAdapter;
        private _payroll_unapecDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView transactionTypesDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
    }
}
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
            this.deductionStatus = new System.Windows.Forms.ComboBox();
            this.deductionDependency = new System.Windows.Forms.ComboBox();
            this.deductionName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._payroll_unapecDataSet1 = new Nomina._payroll_unapecDataSet1();
            this.transactionTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionTypesTableAdapter = new Nomina._payroll_unapecDataSet1TableAdapters.TransactionTypesTableAdapter();
            this.tableAdapterManager = new Nomina._payroll_unapecDataSet1TableAdapters.TableAdapterManager();
            this.transactionTypesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._payroll_unapecDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // deductionStatus
            // 
            this.deductionStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deductionStatus.FormattingEnabled = true;
            this.deductionStatus.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.deductionStatus.Location = new System.Drawing.Point(95, 62);
            this.deductionStatus.Name = "deductionStatus";
            this.deductionStatus.Size = new System.Drawing.Size(121, 21);
            this.deductionStatus.TabIndex = 12;
            // 
            // deductionDependency
            // 
            this.deductionDependency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deductionDependency.FormattingEnabled = true;
            this.deductionDependency.Items.AddRange(new object[] {
            "NINGUNA",
            "SALARIAL"});
            this.deductionDependency.Location = new System.Drawing.Point(95, 95);
            this.deductionDependency.Name = "deductionDependency";
            this.deductionDependency.Size = new System.Drawing.Size(121, 21);
            this.deductionDependency.TabIndex = 11;
            // 
            // deductionName
            // 
            this.deductionName.Location = new System.Drawing.Point(95, 30);
            this.deductionName.Name = "deductionName";
            this.deductionName.Size = new System.Drawing.Size(121, 20);
            this.deductionName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dependencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nomina.Properties.Resources.iconDeduction;
            this.pictureBox1.Location = new System.Drawing.Point(249, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 120);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
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
            this.transactionTypesDataGridView.Size = new System.Drawing.Size(370, 220);
            this.transactionTypesDataGridView.TabIndex = 14;
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
            "ACTIVO",
            "INACTIVO"});
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SalaryDependent";
            this.dataGridViewTextBoxColumn3.HeaderText = "Dependencia";
            this.dataGridViewTextBoxColumn3.Items.AddRange(new object[] {
            "NINGUNA",
            "SALARIAL"});
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
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DeductionTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 404);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.transactionTypesDataGridView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.deductionStatus);
            this.Controls.Add(this.deductionDependency);
            this.Controls.Add(this.deductionName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeductionTypeForm";
            this.Text = "Matenimiento de Tipo de Deducciones";
            this.Load += new System.EventHandler(this.DeductionTypeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._payroll_unapecDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox deductionStatus;
        private System.Windows.Forms.ComboBox deductionDependency;
        private System.Windows.Forms.TextBox deductionName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private _payroll_unapecDataSet1 _payroll_unapecDataSet1;
        private System.Windows.Forms.BindingSource transactionTypesBindingSource;
        private _payroll_unapecDataSet1TableAdapters.TransactionTypesTableAdapter transactionTypesTableAdapter;
        private _payroll_unapecDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView transactionTypesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
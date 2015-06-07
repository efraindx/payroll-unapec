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
            this.incomeName = new System.Windows.Forms.TextBox();
            this.incomeDependency = new System.Windows.Forms.ComboBox();
            this.incomeStatus = new System.Windows.Forms.ComboBox();
            this._payroll_unapecDataSet1 = new Nomina._payroll_unapecDataSet1();
            this.transactionTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionTypesTableAdapter = new Nomina._payroll_unapecDataSet1TableAdapters.TransactionTypesTableAdapter();
            this.tableAdapterManager = new Nomina._payroll_unapecDataSet1TableAdapters.TableAdapterManager();
            this.transactionTypesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._payroll_unapecDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dependencia";
            // 
            // incomeName
            // 
            this.incomeName.Location = new System.Drawing.Point(95, 28);
            this.incomeName.Name = "incomeName";
            this.incomeName.Size = new System.Drawing.Size(121, 20);
            this.incomeName.TabIndex = 3;
            // 
            // incomeDependency
            // 
            this.incomeDependency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.incomeDependency.FormattingEnabled = true;
            this.incomeDependency.Items.AddRange(new object[] {
            "NINGUNA",
            "SALARIAL"});
            this.incomeDependency.Location = new System.Drawing.Point(95, 93);
            this.incomeDependency.Name = "incomeDependency";
            this.incomeDependency.Size = new System.Drawing.Size(121, 21);
            this.incomeDependency.TabIndex = 4;
            // 
            // incomeStatus
            // 
            this.incomeStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.incomeStatus.FormattingEnabled = true;
            this.incomeStatus.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.incomeStatus.Location = new System.Drawing.Point(95, 60);
            this.incomeStatus.Name = "incomeStatus";
            this.incomeStatus.Size = new System.Drawing.Size(121, 21);
            this.incomeStatus.TabIndex = 5;
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
            this.transactionTypesBindingSource.Filter = "isIncome=true";
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
            this.transactionTypesDataGridView.Size = new System.Drawing.Size(371, 220);
            this.transactionTypesDataGridView.TabIndex = 8;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nomina.Properties.Resources.iconIncome;
            this.pictureBox1.Location = new System.Drawing.Point(249, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 120);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(106, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // IncomeTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 412);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.transactionTypesDataGridView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.incomeStatus);
            this.Controls.Add(this.incomeDependency);
            this.Controls.Add(this.incomeName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IncomeTypeForm";
            this.Text = "Mantenimiento de Tipo de Ingreso";
            this.Load += new System.EventHandler(this.IncomeTypeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._payroll_unapecDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox incomeName;
        private System.Windows.Forms.ComboBox incomeDependency;
        private System.Windows.Forms.ComboBox incomeStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private _payroll_unapecDataSet1 _payroll_unapecDataSet1;
        private System.Windows.Forms.BindingSource transactionTypesBindingSource;
        private _payroll_unapecDataSet1TableAdapters.TransactionTypesTableAdapter transactionTypesTableAdapter;
        private _payroll_unapecDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView transactionTypesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
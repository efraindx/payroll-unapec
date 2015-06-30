namespace Nomina
{
    partial class TransactionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionForm));
            this.payrollName = new System.Windows.Forms.Label();
            this.transactionsDataGridView = new System.Windows.Forms.DataGridView();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.payrollPeriocity = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.transactionAmmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.transactionDetail = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.transactionEmployee = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmbMonths = new System.Windows.Forms.ComboBox();
            this.cmbQuincena = new System.Windows.Forms.ComboBox();
            this.cmbSemana = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._payroll_unapecDataSet = new Nomina._payroll_unapecDataSet();
            this.employeesTableAdapter = new Nomina._payroll_unapecDataSetTableAdapters.EmployeesTableAdapter();
            this._payroll_unapecDataSet1 = new Nomina._payroll_unapecDataSet1();
            this.transactionTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionTypesTableAdapter = new Nomina._payroll_unapecDataSet1TableAdapters.TransactionTypesTableAdapter();
            this.employeesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._payroll_unapecDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._payroll_unapecDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // payrollName
            // 
            this.payrollName.AutoSize = true;
            this.payrollName.Location = new System.Drawing.Point(13, 18);
            this.payrollName.Name = "payrollName";
            this.payrollName.Size = new System.Drawing.Size(65, 13);
            this.payrollName.TabIndex = 0;
            this.payrollName.Text = "payrollName";
            // 
            // transactionsDataGridView
            // 
            this.transactionsDataGridView.AllowUserToAddRows = false;
            this.transactionsDataGridView.AllowUserToDeleteRows = false;
            this.transactionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Employee,
            this.TransactionName,
            this.TransactionType,
            this.TransactionAmount,
            this.Status});
            this.transactionsDataGridView.Location = new System.Drawing.Point(16, 142);
            this.transactionsDataGridView.Name = "transactionsDataGridView";
            this.transactionsDataGridView.Size = new System.Drawing.Size(543, 231);
            this.transactionsDataGridView.TabIndex = 1;
            // 
            // Employee
            // 
            this.Employee.HeaderText = "Empleado";
            this.Employee.Name = "Employee";
            // 
            // TransactionName
            // 
            this.TransactionName.HeaderText = "Transacción";
            this.TransactionName.Name = "TransactionName";
            // 
            // TransactionType
            // 
            this.TransactionType.HeaderText = "Tipo";
            this.TransactionType.Name = "TransactionType";
            // 
            // TransactionAmount
            // 
            this.TransactionAmount.HeaderText = "Monto";
            this.TransactionAmount.Name = "TransactionAmount";
            // 
            // Status
            // 
            this.Status.HeaderText = "Estado";
            this.Status.Items.AddRange(new object[] {
            "Pendiente",
            "Aplicada",
            "Cancelada"});
            this.Status.Name = "Status";
            // 
            // payrollPeriocity
            // 
            this.payrollPeriocity.AutoSize = true;
            this.payrollPeriocity.Location = new System.Drawing.Point(13, 42);
            this.payrollPeriocity.Name = "payrollPeriocity";
            this.payrollPeriocity.Size = new System.Drawing.Size(77, 13);
            this.payrollPeriocity.TabIndex = 2;
            this.payrollPeriocity.Text = "payrollPeriocity";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.transactionAmmount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.transactionDetail);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.transactionEmployee);
            this.panel1.Location = new System.Drawing.Point(16, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 61);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Agregar Transacción";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Monto";
            // 
            // transactionAmmount
            // 
            this.transactionAmmount.Location = new System.Drawing.Point(294, 25);
            this.transactionAmmount.Name = "transactionAmmount";
            this.transactionAmmount.Size = new System.Drawing.Size(100, 20);
            this.transactionAmmount.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Transacción";
            // 
            // transactionDetail
            // 
            this.transactionDetail.DataSource = this.transactionTypesBindingSource;
            this.transactionDetail.DisplayMember = "Name";
            this.transactionDetail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transactionDetail.FormattingEnabled = true;
            this.transactionDetail.Location = new System.Drawing.Point(158, 25);
            this.transactionDetail.Name = "transactionDetail";
            this.transactionDetail.Size = new System.Drawing.Size(121, 21);
            this.transactionDetail.TabIndex = 2;
            this.transactionDetail.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empleados";
            // 
            // transactionEmployee
            // 
            this.transactionEmployee.DataSource = this.employeesBindingSource1;
            this.transactionEmployee.DisplayMember = "Name";
            this.transactionEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transactionEmployee.FormattingEnabled = true;
            this.transactionEmployee.Location = new System.Drawing.Point(7, 25);
            this.transactionEmployee.Name = "transactionEmployee";
            this.transactionEmployee.Size = new System.Drawing.Size(130, 21);
            this.transactionEmployee.TabIndex = 0;
            this.transactionEmployee.ValueMember = "Id";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(97, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cmbMonths
            // 
            this.cmbMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonths.FormattingEnabled = true;
            this.cmbMonths.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmbMonths.Location = new System.Drawing.Point(132, 39);
            this.cmbMonths.Name = "cmbMonths";
            this.cmbMonths.Size = new System.Drawing.Size(121, 21);
            this.cmbMonths.TabIndex = 6;
            // 
            // cmbQuincena
            // 
            this.cmbQuincena.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuincena.FormattingEnabled = true;
            this.cmbQuincena.Items.AddRange(new object[] {
            "1ra Quincena",
            "2da Quincena"});
            this.cmbQuincena.Location = new System.Drawing.Point(132, 12);
            this.cmbQuincena.Name = "cmbQuincena";
            this.cmbQuincena.Size = new System.Drawing.Size(121, 21);
            this.cmbQuincena.TabIndex = 7;
            // 
            // cmbSemana
            // 
            this.cmbSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemana.FormattingEnabled = true;
            this.cmbSemana.Items.AddRange(new object[] {
            "1ra Semana",
            "2da Semana",
            "3ra Semana",
            "4ta Semana"});
            this.cmbSemana.Location = new System.Drawing.Point(132, 12);
            this.cmbSemana.Name = "cmbSemana";
            this.cmbSemana.Size = new System.Drawing.Size(121, 21);
            this.cmbSemana.TabIndex = 8;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this._payroll_unapecDataSet;
            // 
            // _payroll_unapecDataSet
            // 
            this._payroll_unapecDataSet.DataSetName = "_payroll_unapecDataSet";
            this._payroll_unapecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
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
            // 
            // transactionTypesTableAdapter
            // 
            this.transactionTypesTableAdapter.ClearBeforeFill = true;
            // 
            // employeesBindingSource1
            // 
            this.employeesBindingSource1.DataMember = "Employees";
            this.employeesBindingSource1.DataSource = this._payroll_unapecDataSet;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 418);
            this.Controls.Add(this.cmbSemana);
            this.Controls.Add(this.cmbQuincena);
            this.Controls.Add(this.cmbMonths);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.payrollPeriocity);
            this.Controls.Add(this.transactionsDataGridView);
            this.Controls.Add(this.payrollName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TransactionForm";
            this.Text = "Payroll Name";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._payroll_unapecDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._payroll_unapecDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label payrollName;
        private System.Windows.Forms.DataGridView transactionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionAmount;
        private System.Windows.Forms.DataGridViewComboBoxColumn Status;
        public System.Windows.Forms.Label payrollPeriocity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox transactionEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox transactionAmmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox transactionDetail;
        private _payroll_unapecDataSet _payroll_unapecDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private _payroll_unapecDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmbMonths;
        private System.Windows.Forms.ComboBox cmbQuincena;
        private System.Windows.Forms.ComboBox cmbSemana;
        private _payroll_unapecDataSet1 _payroll_unapecDataSet1;
        private System.Windows.Forms.BindingSource transactionTypesBindingSource;
        private _payroll_unapecDataSet1TableAdapters.TransactionTypesTableAdapter transactionTypesTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource1;
    }
}
﻿namespace Nomina
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
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._payroll_unapecDataSet = new Nomina._payroll_unapecDataSet();
            this.employeesTableAdapter = new Nomina._payroll_unapecDataSetTableAdapters.EmployeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._payroll_unapecDataSet)).BeginInit();
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
            this.transactionDetail.FormattingEnabled = true;
            this.transactionDetail.Items.AddRange(new object[] {
            "Prueba"});
            this.transactionDetail.Location = new System.Drawing.Point(158, 25);
            this.transactionDetail.Name = "transactionDetail";
            this.transactionDetail.Size = new System.Drawing.Size(121, 21);
            this.transactionDetail.TabIndex = 2;
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
            this.transactionEmployee.FormattingEnabled = true;
            this.transactionEmployee.Location = new System.Drawing.Point(7, 25);
            this.transactionEmployee.Name = "transactionEmployee";
            this.transactionEmployee.Size = new System.Drawing.Size(130, 21);
            this.transactionEmployee.TabIndex = 0;
            this.transactionEmployee.ValueMember = "Cedula";
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
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 383);
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
    }
}
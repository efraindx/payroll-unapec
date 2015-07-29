namespace Nomina
{
    partial class PayrollReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.all = new Nomina.all();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PayrollsTableAdapter = new Nomina.allTableAdapters.PayrollsTableAdapter();
            this.DataTable1TableAdapter = new Nomina.allTableAdapters.DataTableReportTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTransactionType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.employeesTableAdapter = new Nomina.allTableAdapters.EmployeesTableAdapter();
            this.fKPayrollEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbNomina = new System.Windows.Forms.ComboBox();
            this.payrollsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._payroll_unapecDataSet6 = new Nomina._payroll_unapecDataSet6();
            this.payrollsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payrollsTableAdapter1 = new Nomina._payroll_unapecDataSet6TableAdapters.PayrollsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.all)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPayrollEmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._payroll_unapecDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTableReport";
            this.DataTable1BindingSource.DataSource = this.all;
            // 
            // all
            // 
            this.all.DataSetName = "all";
            this.all.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Nomina.PayrollReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(42, 33);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(684, 327);
            this.reportViewer1.TabIndex = 0;
            // 
            // PayrollsTableAdapter
            // 
            this.PayrollsTableAdapter.ClearBeforeFill = true;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo Transacción:";
            // 
            // cmbTransactionType
            // 
            this.cmbTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransactionType.FormattingEnabled = true;
            this.cmbTransactionType.Items.AddRange(new object[] {
            "TODOS",
            "INGRESO",
            "DEDUCCION"});
            this.cmbTransactionType.Location = new System.Drawing.Point(388, 6);
            this.cmbTransactionType.Name = "cmbTransactionType";
            this.cmbTransactionType.Size = new System.Drawing.Size(121, 21);
            this.cmbTransactionType.TabIndex = 2;
            this.cmbTransactionType.SelectedIndexChanged += new System.EventHandler(this.cmbTransactionType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Empleado:";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.DisplayMember = "Id";
            this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(92, 6);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(121, 21);
            this.cmbEmployee.TabIndex = 4;
            this.cmbEmployee.ValueMember = "Id";
            this.cmbEmployee.SelectedIndexChanged += new System.EventHandler(this.cmbEmployee_SelectedIndexChanged);
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.all;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(564, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nómina:";
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // cmbNomina
            // 
            this.cmbNomina.DisplayMember = "Id";
            this.cmbNomina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomina.FormattingEnabled = true;
            this.cmbNomina.Location = new System.Drawing.Point(616, 6);
            this.cmbNomina.Name = "cmbNomina";
            this.cmbNomina.Size = new System.Drawing.Size(121, 21);
            this.cmbNomina.TabIndex = 6;
            this.cmbNomina.ValueMember = "Id";
            this.cmbNomina.SelectedIndexChanged += new System.EventHandler(this.cmbNomina_SelectedIndexChanged);
            // 
            // payrollsBindingSource1
            // 
            this.payrollsBindingSource1.DataMember = "Payrolls";
            this.payrollsBindingSource1.DataSource = this._payroll_unapecDataSet6;
            // 
            // _payroll_unapecDataSet6
            // 
            this._payroll_unapecDataSet6.DataSetName = "_payroll_unapecDataSet6";
            this._payroll_unapecDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // payrollsBindingSource
            // 
            this.payrollsBindingSource.DataMember = "Payrolls";
            this.payrollsBindingSource.DataSource = this.all;
            // 
            // payrollsTableAdapter1
            // 
            this.payrollsTableAdapter1.ClearBeforeFill = true;
            // 
            // PayrollReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 361);
            this.Controls.Add(this.cmbNomina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTransactionType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PayrollReportForm";
            this.Text = "PayrollReportForm";
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Load += new System.EventHandler(this.PayrollReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.all)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPayrollEmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._payroll_unapecDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private all all;
        private allTableAdapters.PayrollsTableAdapter PayrollsTableAdapter;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private allTableAdapters.DataTableReportTableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTransactionType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private allTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource fKPayrollEmployeeBindingSource;
        private System.Windows.Forms.ComboBox cmbNomina;
        private System.Windows.Forms.BindingSource payrollsBindingSource;
        private _payroll_unapecDataSet6 _payroll_unapecDataSet6;
        private System.Windows.Forms.BindingSource payrollsBindingSource1;
        private _payroll_unapecDataSet6TableAdapters.PayrollsTableAdapter payrollsTableAdapter1;
    }
}
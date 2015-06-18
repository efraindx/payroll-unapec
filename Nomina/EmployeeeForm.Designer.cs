namespace Nomina
{
    partial class EmployeeeForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.employeeCedula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.employeeDepartment = new System.Windows.Forms.ComboBox();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._payroll_unapecDataSet = new Nomina._payroll_unapecDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.employeePosition = new System.Windows.Forms.ComboBox();
            this.positionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.employeeSalary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.employeePayroll = new System.Windows.Forms.ComboBox();
            this.payrollsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._payroll_unapecDataSet2 = new Nomina._payroll_unapecDataSet2();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.departmentsTableAdapter = new Nomina._payroll_unapecDataSetTableAdapters.DepartmentsTableAdapter();
            this.positionsTableAdapter = new Nomina._payroll_unapecDataSetTableAdapters.PositionsTableAdapter();
            this.payrollsTableAdapter = new Nomina._payroll_unapecDataSet2TableAdapters.PayrollsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._payroll_unapecDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._payroll_unapecDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nomina.Properties.Resources.iconEmployee3;
            this.pictureBox1.Location = new System.Drawing.Point(469, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 86);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // employeeName
            // 
            this.employeeName.Location = new System.Drawing.Point(328, 12);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(121, 20);
            this.employeeName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cédula:";
            // 
            // employeeCedula
            // 
            this.employeeCedula.Location = new System.Drawing.Point(101, 12);
            this.employeeCedula.Name = "employeeCedula";
            this.employeeCedula.ShortcutsEnabled = false;
            this.employeeCedula.Size = new System.Drawing.Size(121, 20);
            this.employeeCedula.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Departamento:";
            // 
            // employeeDepartment
            // 
            this.employeeDepartment.DataSource = this.departmentsBindingSource;
            this.employeeDepartment.DisplayMember = "Name";
            this.employeeDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeDepartment.FormattingEnabled = true;
            this.employeeDepartment.Location = new System.Drawing.Point(101, 45);
            this.employeeDepartment.Name = "employeeDepartment";
            this.employeeDepartment.Size = new System.Drawing.Size(121, 21);
            this.employeeDepartment.TabIndex = 6;
            this.employeeDepartment.ValueMember = "Id";
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this._payroll_unapecDataSet;
            // 
            // _payroll_unapecDataSet
            // 
            this._payroll_unapecDataSet.DataSetName = "_payroll_unapecDataSet";
            this._payroll_unapecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Puesto:";
            // 
            // employeePosition
            // 
            this.employeePosition.DataSource = this.positionsBindingSource;
            this.employeePosition.DisplayMember = "Name";
            this.employeePosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeePosition.FormattingEnabled = true;
            this.employeePosition.Location = new System.Drawing.Point(328, 45);
            this.employeePosition.Name = "employeePosition";
            this.employeePosition.Size = new System.Drawing.Size(121, 21);
            this.employeePosition.TabIndex = 8;
            this.employeePosition.ValueMember = "Id";
            // 
            // positionsBindingSource
            // 
            this.positionsBindingSource.DataMember = "Positions";
            this.positionsBindingSource.DataSource = this._payroll_unapecDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Salario Mensual:";
            // 
            // employeeSalary
            // 
            this.employeeSalary.Location = new System.Drawing.Point(328, 79);
            this.employeeSalary.Name = "employeeSalary";
            this.employeeSalary.Size = new System.Drawing.Size(121, 20);
            this.employeeSalary.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nómina:";
            // 
            // employeePayroll
            // 
            this.employeePayroll.DataSource = this.payrollsBindingSource;
            this.employeePayroll.DisplayMember = "Name";
            this.employeePayroll.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeePayroll.FormattingEnabled = true;
            this.employeePayroll.Location = new System.Drawing.Point(101, 78);
            this.employeePayroll.Name = "employeePayroll";
            this.employeePayroll.Size = new System.Drawing.Size(121, 21);
            this.employeePayroll.TabIndex = 12;
            this.employeePayroll.ValueMember = "Id";
            // 
            // payrollsBindingSource
            // 
            this.payrollsBindingSource.DataMember = "Payrolls";
            this.payrollsBindingSource.DataSource = this._payroll_unapecDataSet2;
            // 
            // _payroll_unapecDataSet2
            // 
            this._payroll_unapecDataSet2.DataSetName = "_payroll_unapecDataSet2";
            this._payroll_unapecDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(15, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 150);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 20;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cédula";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nombre";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Departamento";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Puesto";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Salario Mensual";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Nómina";
            this.Column7.Name = "Column7";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // positionsTableAdapter
            // 
            this.positionsTableAdapter.ClearBeforeFill = true;
            // 
            // payrollsTableAdapter
            // 
            this.payrollsTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 394);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.employeePayroll);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.employeeSalary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.employeePosition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.employeeDepartment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.employeeCedula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.employeeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EmployeeeForm";
            this.Text = "Mantenimiento de Empleados";
            this.Load += new System.EventHandler(this.EmployeeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._payroll_unapecDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._payroll_unapecDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox employeeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox employeeCedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox employeeDepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox employeePosition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox employeeSalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox employeePayroll;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private _payroll_unapecDataSet _payroll_unapecDataSet;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private _payroll_unapecDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.BindingSource positionsBindingSource;
        private _payroll_unapecDataSetTableAdapters.PositionsTableAdapter positionsTableAdapter;
        private _payroll_unapecDataSet2 _payroll_unapecDataSet2;
        private System.Windows.Forms.BindingSource payrollsBindingSource;
        private _payroll_unapecDataSet2TableAdapters.PayrollsTableAdapter payrollsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}
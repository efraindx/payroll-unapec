namespace Nomina.Views
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.employeeCedula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.employeeDepartment = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.employeePosition = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.employeeSalary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.employeePayroll = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.all = new Nomina.all();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new Nomina.allTableAdapters.EmployeesTableAdapter();
            this.tableAdapterManager = new Nomina.allTableAdapters.TableAdapterManager();
            this.departmentsTableAdapter = new Nomina.allTableAdapters.DepartmentsTableAdapter();
            this.payrollsTableAdapter = new Nomina.allTableAdapters.PayrollsTableAdapter();
            this.positionsTableAdapter = new Nomina.allTableAdapters.PositionsTableAdapter();
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.positionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.payrollsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.positionsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.payrollsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.all)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollsBindingSource1)).BeginInit();
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
            this.employeeDepartment.DataSource = this.departmentsBindingSource1;
            this.employeeDepartment.DisplayMember = "Name";
            this.employeeDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeDepartment.FormattingEnabled = true;
            this.employeeDepartment.Location = new System.Drawing.Point(101, 45);
            this.employeeDepartment.Name = "employeeDepartment";
            this.employeeDepartment.Size = new System.Drawing.Size(121, 21);
            this.employeeDepartment.TabIndex = 6;
            this.employeeDepartment.ValueMember = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Puesto:";
            // 
            // employeePosition
            // 
            this.employeePosition.DataSource = this.positionsBindingSource1;
            this.employeePosition.DisplayMember = "Name";
            this.employeePosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeePosition.FormattingEnabled = true;
            this.employeePosition.Location = new System.Drawing.Point(328, 45);
            this.employeePosition.Name = "employeePosition";
            this.employeePosition.Size = new System.Drawing.Size(121, 21);
            this.employeePosition.TabIndex = 8;
            this.employeePosition.ValueMember = "Id";
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
            this.employeePayroll.DataSource = this.payrollsBindingSource1;
            this.employeePayroll.DisplayMember = "Name";
            this.employeePayroll.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeePayroll.FormattingEnabled = true;
            this.employeePayroll.Location = new System.Drawing.Point(101, 78);
            this.employeePayroll.Name = "employeePayroll";
            this.employeePayroll.Size = new System.Drawing.Size(121, 21);
            this.employeePayroll.TabIndex = 12;
            this.employeePayroll.ValueMember = "Id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // all
            // 
            this.all.DataSetName = "all";
            this.all.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.all;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartmentsTableAdapter = this.departmentsTableAdapter;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.PayrollsTableAdapter = this.payrollsTableAdapter;
            this.tableAdapterManager.PositionsTableAdapter = this.positionsTableAdapter;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.TransactionsTableAdapter = null;
            this.tableAdapterManager.TransactionTypesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Nomina.allTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserRoleTableAdapter = null;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // payrollsTableAdapter
            // 
            this.payrollsTableAdapter.ClearBeforeFill = true;
            // 
            // positionsTableAdapter
            // 
            this.positionsTableAdapter.ClearBeforeFill = true;
            // 
            // employeesDataGridView
            // 
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.employeesDataGridView.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.DataGrid_CellParsing);
            this.employeesDataGridView.AllowUserToAddRows = false;
            this.employeesDataGridView.AllowUserToDeleteRows = false;
            this.employeesDataGridView.AutoGenerateColumns = false;
            this.employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.employeesDataGridView.DataSource = this.employeesBindingSource;
            this.employeesDataGridView.Location = new System.Drawing.Point(13, 216);
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.Size = new System.Drawing.Size(582, 220);
            this.employeesDataGridView.TabIndex = 16;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cedula";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cédula";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Salary";
            this.dataGridViewTextBoxColumn4.HeaderText = "Salario";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Position_Id";
            this.dataGridViewTextBoxColumn5.DataSource = this.positionsBindingSource;
            this.dataGridViewTextBoxColumn5.DisplayMember = "Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Puesto";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "Id";
            // 
            // positionsBindingSource
            // 
            this.positionsBindingSource.DataMember = "Positions";
            this.positionsBindingSource.DataSource = this.all;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Department_Id";
            this.dataGridViewTextBoxColumn6.DataSource = this.departmentsBindingSource;
            this.dataGridViewTextBoxColumn6.DisplayMember = "Name";
            this.dataGridViewTextBoxColumn6.HeaderText = "Departamento";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "Id";
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this.all;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Payroll_Id";
            this.dataGridViewTextBoxColumn7.DataSource = this.payrollsBindingSource;
            this.dataGridViewTextBoxColumn7.DisplayMember = "Name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Nómina";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.ValueMember = "Id";
            // 
            // payrollsBindingSource
            // 
            this.payrollsBindingSource.DataMember = "Payrolls";
            this.payrollsBindingSource.DataSource = this.all;
            // 
            // departmentsBindingSource1
            // 
            this.departmentsBindingSource1.DataMember = "Departments";
            this.departmentsBindingSource1.DataSource = this.all;
            // 
            // positionsBindingSource1
            // 
            this.positionsBindingSource1.DataMember = "Positions";
            this.positionsBindingSource1.DataSource = this.all;
            // 
            // payrollsBindingSource1
            // 
            this.payrollsBindingSource1.DataMember = "Payrolls";
            this.payrollsBindingSource1.DataSource = this.all;
            // 
            // EmployeeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 456);
            this.Controls.Add(this.employeesDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
            ((System.ComponentModel.ISupportInitialize)(this.all)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollsBindingSource1)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private all all;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private allTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private allTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView employeesDataGridView;
        private allTableAdapters.PositionsTableAdapter positionsTableAdapter;
        private System.Windows.Forms.BindingSource positionsBindingSource;
        private allTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private allTableAdapters.PayrollsTableAdapter payrollsTableAdapter;
        private System.Windows.Forms.BindingSource payrollsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource departmentsBindingSource1;
        private System.Windows.Forms.BindingSource positionsBindingSource1;
        private System.Windows.Forms.BindingSource payrollsBindingSource1;
    }
}
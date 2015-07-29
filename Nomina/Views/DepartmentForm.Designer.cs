namespace Nomina.Views
{
    partial class DepartmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentForm));
            this.label1 = new System.Windows.Forms.Label();
            this.departmentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteDepartment = new System.Windows.Forms.Button();
            this.saveDepartment = new System.Windows.Forms.Button();
            this.departmentsDataGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._payroll_unapecDataSet = new Nomina._payroll_unapecDataSet();
            this.departmentsTableAdapter = new Nomina._payroll_unapecDataSetTableAdapters.DepartmentsTableAdapter();
            this.departmentLocation = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._payroll_unapecDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // departmentName
            // 
            this.departmentName.Location = new System.Drawing.Point(78, 32);
            this.departmentName.Name = "departmentName";
            this.departmentName.Size = new System.Drawing.Size(165, 20);
            this.departmentName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ubicacion";
            // 
            // deleteDepartment
            // 
            this.deleteDepartment.Location = new System.Drawing.Point(94, 133);
            this.deleteDepartment.Name = "deleteDepartment";
            this.deleteDepartment.Size = new System.Drawing.Size(75, 23);
            this.deleteDepartment.TabIndex = 4;
            this.deleteDepartment.Text = "Eliminar";
            this.deleteDepartment.UseVisualStyleBackColor = true;
            this.deleteDepartment.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // saveDepartment
            // 
            this.saveDepartment.Location = new System.Drawing.Point(13, 133);
            this.saveDepartment.Name = "saveDepartment";
            this.saveDepartment.Size = new System.Drawing.Size(75, 23);
            this.saveDepartment.TabIndex = 5;
            this.saveDepartment.Text = "Guardar";
            this.saveDepartment.UseVisualStyleBackColor = true;
            this.saveDepartment.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // departmentsDataGrid
            // 
            this.departmentsDataGrid.AllowUserToAddRows = false;
            this.departmentsDataGrid.AllowUserToDeleteRows = false;
            this.departmentsDataGrid.AutoGenerateColumns = false;
            this.departmentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmentsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn});
            this.departmentsDataGrid.DataSource = this.departmentsBindingSource;
            this.departmentsDataGrid.Location = new System.Drawing.Point(13, 188);
            this.departmentsDataGrid.Name = "departmentsDataGrid";
            this.departmentsDataGrid.Size = new System.Drawing.Size(327, 123);
            this.departmentsDataGrid.TabIndex = 6;
            this.departmentsDataGrid.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.DataGrid_CellParsing);
            this.departmentsDataGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGrid_DataError);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 30;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Ubicación";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.Width = 200;
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
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // departmentLocation
            // 
            this.departmentLocation.Location = new System.Drawing.Point(78, 58);
            this.departmentLocation.Name = "departmentLocation";
            this.departmentLocation.Size = new System.Drawing.Size(165, 59);
            this.departmentLocation.TabIndex = 2;
            this.departmentLocation.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nomina.Properties.Resources.iconDepartment;
            this.pictureBox1.Location = new System.Drawing.Point(249, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 85);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 323);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.departmentLocation);
            this.Controls.Add(this.departmentsDataGrid);
            this.Controls.Add(this.saveDepartment);
            this.Controls.Add(this.deleteDepartment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.departmentName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DepartmentForm";
            this.Text = "Mantenimiento de Departamentos";
            this.Load += new System.EventHandler(this.StandardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._payroll_unapecDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox departmentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteDepartment;
        private System.Windows.Forms.Button saveDepartment;
        private System.Windows.Forms.DataGridView departmentsDataGrid;
        private _payroll_unapecDataSet _payroll_unapecDataSet;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private _payroll_unapecDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.RichTextBox departmentLocation;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
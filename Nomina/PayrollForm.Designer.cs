namespace Nomina
{
    partial class PayrollForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayrollForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.payrollPeriocity = new System.Windows.Forms.ComboBox();
            this.payrollName = new System.Windows.Forms.TextBox();
            this.payrollsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.payrollsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._payroll_unapecDataSet2 = new Nomina._payroll_unapecDataSet2();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.payrollsTableAdapter = new Nomina._payroll_unapecDataSet2TableAdapters.PayrollsTableAdapter();
            this.tableAdapterManager = new Nomina._payroll_unapecDataSet2TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.payrollsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._payroll_unapecDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Periocidad";
            // 
            // payrollPeriocity
            // 
            this.payrollPeriocity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payrollPeriocity.FormattingEnabled = true;
            this.payrollPeriocity.Items.AddRange(new object[] {
            "Semanal",
            "Quincenal",
            "Mensual"});
            this.payrollPeriocity.Location = new System.Drawing.Point(76, 63);
            this.payrollPeriocity.Name = "payrollPeriocity";
            this.payrollPeriocity.Size = new System.Drawing.Size(121, 21);
            this.payrollPeriocity.TabIndex = 2;
            // 
            // payrollName
            // 
            this.payrollName.Location = new System.Drawing.Point(76, 30);
            this.payrollName.Name = "payrollName";
            this.payrollName.Size = new System.Drawing.Size(121, 20);
            this.payrollName.TabIndex = 0;
            // 
            // payrollsDataGridView
            // 
            this.payrollsDataGridView.AllowUserToAddRows = false;
            this.payrollsDataGridView.AllowUserToDeleteRows = false;
            this.payrollsDataGridView.AutoGenerateColumns = false;
            this.payrollsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payrollsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Action});
            this.payrollsDataGridView.DataSource = this.payrollsBindingSource;
            this.payrollsDataGridView.Location = new System.Drawing.Point(16, 153);
            this.payrollsDataGridView.Name = "payrollsDataGridView";
            this.payrollsDataGridView.Size = new System.Drawing.Size(333, 137);
            this.payrollsDataGridView.TabIndex = 5;
            this.payrollsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.payrollsDataGridView_CellClick);
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
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Periocity";
            this.dataGridViewTextBoxColumn3.HeaderText = "Periocidad";
            this.dataGridViewTextBoxColumn3.Items.AddRange(new object[] {
            "Semanal",
            "Quincenal",
            "Mensual"});
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Action
            // 
            this.Action.HeaderText = "Accion";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Text = "Correr";
            this.Action.ToolTipText = "Correr";
            this.Action.UseColumnTextForButtonValue = true;
            this.Action.Width = 60;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaveNewItem);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nomina.Properties.Resources.iconPayroll;
            this.pictureBox1.Location = new System.Drawing.Point(220, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 134);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // payrollsTableAdapter
            // 
            this.payrollsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PayrollsTableAdapter = this.payrollsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Nomina._payroll_unapecDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // PayrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 301);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.payrollsDataGridView);
            this.Controls.Add(this.payrollName);
            this.Controls.Add(this.payrollPeriocity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PayrollForm";
            this.Text = "Mantenimiento de Nominas";
            this.Load += new System.EventHandler(this.PayrollForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payrollsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._payroll_unapecDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox payrollPeriocity;
        private System.Windows.Forms.TextBox payrollName;
        private _payroll_unapecDataSet2 _payroll_unapecDataSet2;
        private System.Windows.Forms.BindingSource payrollsBindingSource;
        private _payroll_unapecDataSet2TableAdapters.PayrollsTableAdapter payrollsTableAdapter;
        private _payroll_unapecDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView payrollsDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
    }
}
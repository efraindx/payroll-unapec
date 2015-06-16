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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionForm));
            this.payrollName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // payrollName
            // 
            this.payrollName.AutoSize = true;
            this.payrollName.Location = new System.Drawing.Point(13, 25);
            this.payrollName.Name = "payrollName";
            this.payrollName.Size = new System.Drawing.Size(35, 13);
            this.payrollName.TabIndex = 0;
            this.payrollName.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Employee,
            this.TransactionName,
            this.TransactionType,
            this.TransactionAmount,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(16, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 236);
            this.dataGridView1.TabIndex = 1;
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
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 351);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.payrollName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TransactionForm";
            this.Text = "Transacciones de Nómina";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label payrollName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionAmount;
        private System.Windows.Forms.DataGridViewComboBoxColumn Status;
    }
}
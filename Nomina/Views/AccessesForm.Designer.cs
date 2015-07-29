namespace Nomina.Views
{
    partial class AccessesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccessesForm));
            this._payroll_unapecDataSet5 = new Nomina._payroll_unapecDataSet5();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolesTableAdapter = new Nomina._payroll_unapecDataSet5TableAdapters.RolesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.availableAccesses = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this._payroll_unapecDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _payroll_unapecDataSet5
            // 
            this._payroll_unapecDataSet5.DataSetName = "_payroll_unapecDataSet5";
            this._payroll_unapecDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "Roles";
            this.rolesBindingSource.DataSource = this._payroll_unapecDataSet5;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione los permisos que desea";
            // 
            // availableAccesses
            // 
            this.availableAccesses.DataSource = this._payroll_unapecDataSet5;
            this.availableAccesses.DisplayMember = "Roles.Name";
            this.availableAccesses.FormattingEnabled = true;
            this.availableAccesses.Location = new System.Drawing.Point(16, 29);
            this.availableAccesses.Name = "availableAccesses";
            this.availableAccesses.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.availableAccesses.Size = new System.Drawing.Size(170, 121);
            this.availableAccesses.TabIndex = 3;
            this.availableAccesses.ValueMember = "Roles.Id";
            // 
            // AccessesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 190);
            this.Controls.Add(this.availableAccesses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccessesForm";
            this.Text = "Permisos";
            this.Load += new System.EventHandler(this.AccessesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._payroll_unapecDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private _payroll_unapecDataSet5 _payroll_unapecDataSet5;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private _payroll_unapecDataSet5TableAdapters.RolesTableAdapter rolesTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox availableAccesses;
    }
}
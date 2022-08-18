
namespace ejemploentityforms
{
    partial class FrmVerTrabajadores
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ejercicioDataSet = new ejemploentityforms.ejercicioDataSet();
            this.trabajadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trabajadorTableAdapter = new ejemploentityforms.ejercicioDataSetTableAdapters.trabajadorTableAdapter();
            this.idtrabajadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidopatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidomatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numempleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpuestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajadorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtrabajadorDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidopatDataGridViewTextBoxColumn,
            this.apellidomatDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.numempleadoDataGridViewTextBoxColumn,
            this.idusuarioDataGridViewTextBoxColumn,
            this.idpuestoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.trabajadorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(946, 313);
            this.dataGridView1.TabIndex = 0;
            // 
            // ejercicioDataSet
            // 
            this.ejercicioDataSet.DataSetName = "ejercicioDataSet";
            this.ejercicioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trabajadorBindingSource
            // 
            this.trabajadorBindingSource.DataMember = "trabajador";
            this.trabajadorBindingSource.DataSource = this.ejercicioDataSet;
            // 
            // trabajadorTableAdapter
            // 
            this.trabajadorTableAdapter.ClearBeforeFill = true;
            // 
            // idtrabajadorDataGridViewTextBoxColumn
            // 
            this.idtrabajadorDataGridViewTextBoxColumn.DataPropertyName = "id_trabajador";
            this.idtrabajadorDataGridViewTextBoxColumn.HeaderText = "id_trabajador";
            this.idtrabajadorDataGridViewTextBoxColumn.Name = "idtrabajadorDataGridViewTextBoxColumn";
            this.idtrabajadorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidopatDataGridViewTextBoxColumn
            // 
            this.apellidopatDataGridViewTextBoxColumn.DataPropertyName = "apellido_pat";
            this.apellidopatDataGridViewTextBoxColumn.HeaderText = "apellido_pat";
            this.apellidopatDataGridViewTextBoxColumn.Name = "apellidopatDataGridViewTextBoxColumn";
            // 
            // apellidomatDataGridViewTextBoxColumn
            // 
            this.apellidomatDataGridViewTextBoxColumn.DataPropertyName = "apellido_mat";
            this.apellidomatDataGridViewTextBoxColumn.HeaderText = "apellido_mat";
            this.apellidomatDataGridViewTextBoxColumn.Name = "apellidomatDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // numempleadoDataGridViewTextBoxColumn
            // 
            this.numempleadoDataGridViewTextBoxColumn.DataPropertyName = "num_empleado";
            this.numempleadoDataGridViewTextBoxColumn.HeaderText = "num_empleado";
            this.numempleadoDataGridViewTextBoxColumn.Name = "numempleadoDataGridViewTextBoxColumn";
            // 
            // idusuarioDataGridViewTextBoxColumn
            // 
            this.idusuarioDataGridViewTextBoxColumn.DataPropertyName = "id_usuario";
            this.idusuarioDataGridViewTextBoxColumn.HeaderText = "id_usuario";
            this.idusuarioDataGridViewTextBoxColumn.Name = "idusuarioDataGridViewTextBoxColumn";
            // 
            // idpuestoDataGridViewTextBoxColumn
            // 
            this.idpuestoDataGridViewTextBoxColumn.DataPropertyName = "id_puesto";
            this.idpuestoDataGridViewTextBoxColumn.HeaderText = "id_puesto";
            this.idpuestoDataGridViewTextBoxColumn.Name = "idpuestoDataGridViewTextBoxColumn";
            // 
            // FrmVerTrabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmVerTrabajadores";
            this.Text = "FrmVerTrabajadores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmVerTrabajadores_FormClosed);
            this.Load += new System.EventHandler(this.FrmVerTrabajadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajadorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ejercicioDataSet ejercicioDataSet;
        private System.Windows.Forms.BindingSource trabajadorBindingSource;
        private ejercicioDataSetTableAdapters.trabajadorTableAdapter trabajadorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtrabajadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidopatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidomatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numempleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpuestoDataGridViewTextBoxColumn;
    }
}
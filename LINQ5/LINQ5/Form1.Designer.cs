namespace LINQ5
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ejercicioDataSet = new LINQ5.ejercicioDataSet();
            this.ejercicioDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linqDatos = new LINQ5.LinqDatos();
            this.linqDatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new LINQ5.LinqDatosTableAdapters.usuariosTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipousuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.trabajadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trabajadorTableAdapter = new LINQ5.LinqDatosTableAdapters.trabajadorTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.ejercicioDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linqDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linqDatosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajadorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.passwdDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.tipousuarioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usuariosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(558, 166);
            this.dataGridView1.TabIndex = 0;
            // 
            // ejercicioDataSet
            // 
            this.ejercicioDataSet.DataSetName = "ejercicioDataSet";
            this.ejercicioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ejercicioDataSetBindingSource
            // 
            this.ejercicioDataSetBindingSource.DataSource = this.ejercicioDataSet;
            this.ejercicioDataSetBindingSource.Position = 0;
            // 
            // linqDatos
            // 
            this.linqDatos.DataSetName = "LinqDatos";
            this.linqDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // linqDatosBindingSource
            // 
            this.linqDatosBindingSource.DataSource = this.linqDatos;
            this.linqDatosBindingSource.Position = 0;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.linqDatosBindingSource;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            // 
            // passwdDataGridViewTextBoxColumn
            // 
            this.passwdDataGridViewTextBoxColumn.DataPropertyName = "passwd";
            this.passwdDataGridViewTextBoxColumn.HeaderText = "passwd";
            this.passwdDataGridViewTextBoxColumn.Name = "passwdDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // tipousuarioDataGridViewTextBoxColumn
            // 
            this.tipousuarioDataGridViewTextBoxColumn.DataPropertyName = "tipo_usuario";
            this.tipousuarioDataGridViewTextBoxColumn.HeaderText = "tipo_usuario";
            this.tipousuarioDataGridViewTextBoxColumn.Name = "tipousuarioDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtrabajadorDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidopatDataGridViewTextBoxColumn,
            this.apellidomatDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.numempleadoDataGridViewTextBoxColumn,
            this.idusuarioDataGridViewTextBoxColumn,
            this.idpuestoDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.trabajadorBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 195);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(872, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // trabajadorBindingSource
            // 
            this.trabajadorBindingSource.DataMember = "trabajador";
            this.trabajadorBindingSource.DataSource = this.linqDatos;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicioDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linqDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linqDatosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajadorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ejercicioDataSetBindingSource;
        private ejercicioDataSet ejercicioDataSet;
        private System.Windows.Forms.BindingSource linqDatosBindingSource;
        private LinqDatos linqDatos;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private LinqDatosTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipousuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource trabajadorBindingSource;
        private LinqDatosTableAdapters.trabajadorTableAdapter trabajadorTableAdapter;
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


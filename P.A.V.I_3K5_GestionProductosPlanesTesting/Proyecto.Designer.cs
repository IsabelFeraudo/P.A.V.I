namespace P.A.V.I_3K5_GestionProductosPlanesTesting
{
    partial class Proyecto
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
            this.label1 = new System.Windows.Forms.Label();
            this.DgvProyectos = new System.Windows.Forms.DataGridView();
            this.idproyectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alcanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idresponsableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proyectosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionProductosPlanesTestingDataSet6 = new P.A.V.I_3K5_GestionProductosPlanesTesting.GestionProductosPlanesTestingDataSet6();
            this.gestionProductosPlanesTestingDataSet3 = new P.A.V.I_3K5_GestionProductosPlanesTesting.GestionProductosPlanesTestingDataSet3();
            this.gestionProductosPlanesTestingDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.proyectosTableAdapter = new P.A.V.I_3K5_GestionProductosPlanesTesting.GestionProductosPlanesTestingDataSet6TableAdapters.ProyectosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProyectos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionProductosPlanesTestingDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionProductosPlanesTestingDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionProductosPlanesTestingDataSet3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proyectos";
            // 
            // DgvProyectos
            // 
            this.DgvProyectos.AutoGenerateColumns = false;
            this.DgvProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProyectos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproyectoDataGridViewTextBoxColumn,
            this.idproductoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.versionDataGridViewTextBoxColumn,
            this.alcanceDataGridViewTextBoxColumn,
            this.idresponsableDataGridViewTextBoxColumn});
            this.DgvProyectos.DataSource = this.proyectosBindingSource;
            this.DgvProyectos.Location = new System.Drawing.Point(60, 117);
            this.DgvProyectos.Name = "DgvProyectos";
            this.DgvProyectos.Size = new System.Drawing.Size(645, 150);
            this.DgvProyectos.TabIndex = 1;
            // 
            // idproyectoDataGridViewTextBoxColumn
            // 
            this.idproyectoDataGridViewTextBoxColumn.DataPropertyName = "id_proyecto";
            this.idproyectoDataGridViewTextBoxColumn.HeaderText = "ID Proyecto";
            this.idproyectoDataGridViewTextBoxColumn.Name = "idproyectoDataGridViewTextBoxColumn";
            // 
            // idproductoDataGridViewTextBoxColumn
            // 
            this.idproductoDataGridViewTextBoxColumn.DataPropertyName = "id_producto";
            this.idproductoDataGridViewTextBoxColumn.HeaderText = "ID Producto";
            this.idproductoDataGridViewTextBoxColumn.Name = "idproductoDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // versionDataGridViewTextBoxColumn
            // 
            this.versionDataGridViewTextBoxColumn.DataPropertyName = "version";
            this.versionDataGridViewTextBoxColumn.HeaderText = "Version";
            this.versionDataGridViewTextBoxColumn.Name = "versionDataGridViewTextBoxColumn";
            // 
            // alcanceDataGridViewTextBoxColumn
            // 
            this.alcanceDataGridViewTextBoxColumn.DataPropertyName = "alcance";
            this.alcanceDataGridViewTextBoxColumn.HeaderText = "Alcance";
            this.alcanceDataGridViewTextBoxColumn.Name = "alcanceDataGridViewTextBoxColumn";
            // 
            // idresponsableDataGridViewTextBoxColumn
            // 
            this.idresponsableDataGridViewTextBoxColumn.DataPropertyName = "id_responsable";
            this.idresponsableDataGridViewTextBoxColumn.HeaderText = "ID Responsable";
            this.idresponsableDataGridViewTextBoxColumn.Name = "idresponsableDataGridViewTextBoxColumn";
            // 
            // proyectosBindingSource
            // 
            this.proyectosBindingSource.DataMember = "Proyectos";
            this.proyectosBindingSource.DataSource = this.gestionProductosPlanesTestingDataSet6;
            // 
            // gestionProductosPlanesTestingDataSet6
            // 
            this.gestionProductosPlanesTestingDataSet6.DataSetName = "GestionProductosPlanesTestingDataSet6";
            this.gestionProductosPlanesTestingDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestionProductosPlanesTestingDataSet3
            // 
            this.gestionProductosPlanesTestingDataSet3.DataSetName = "GestionProductosPlanesTestingDataSet3";
            this.gestionProductosPlanesTestingDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestionProductosPlanesTestingDataSet3BindingSource
            // 
            this.gestionProductosPlanesTestingDataSet3BindingSource.DataSource = this.gestionProductosPlanesTestingDataSet3;
            this.gestionProductosPlanesTestingDataSet3BindingSource.Position = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(60, 273);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(186, 38);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(293, 273);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(186, 38);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(519, 273);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(186, 38);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // proyectosTableAdapter
            // 
            this.proyectosTableAdapter.ClearBeforeFill = true;
            // 
            // Proyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.DgvProyectos);
            this.Controls.Add(this.label1);
            this.Name = "Proyecto";
            this.Text = "Proyecto";
            this.Load += new System.EventHandler(this.Proyecto_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProyectos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionProductosPlanesTestingDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionProductosPlanesTestingDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionProductosPlanesTestingDataSet3BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvProyectos;
        private System.Windows.Forms.BindingSource gestionProductosPlanesTestingDataSet3BindingSource;
        private GestionProductosPlanesTestingDataSet3 gestionProductosPlanesTestingDataSet3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.IO.Ports.SerialPort serialPort1;
        private GestionProductosPlanesTestingDataSet6 gestionProductosPlanesTestingDataSet6;
        private System.Windows.Forms.BindingSource proyectosBindingSource;
        private GestionProductosPlanesTestingDataSet6TableAdapters.ProyectosTableAdapter proyectosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproyectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alcanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idresponsableDataGridViewTextBoxColumn;
    }
}
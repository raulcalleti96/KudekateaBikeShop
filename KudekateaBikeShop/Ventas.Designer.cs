
namespace KudekateaBikeShop
{
    partial class Ventas
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
            System.Windows.Forms.Label fecha_ventaLabel;
            System.Windows.Forms.Label id_ventaLabel;
            System.Windows.Forms.Label id_empleadoLabel;
            System.Windows.Forms.Label nombre_clienteLabel;
            System.Windows.Forms.Label id_clienteLabel;
            System.Windows.Forms.Label dNI_clienteLabel;
            System.Windows.Forms.Label email_clienteLabel;
            System.Windows.Forms.Label id_ventaLabel1;
            System.Windows.Forms.Label id_bicicletaLabel;
            System.Windows.Forms.Label nombre_bicicletaLabel;
            System.Windows.Forms.Label categoriaLabel;
            System.Windows.Forms.Label fabricanteLabel;
            System.Windows.Forms.Label cantidad_vendidaLabel;
            System.Windows.Forms.Label precio_ventaLabel;
            System.Windows.Forms.Label descuentoLabel;
            System.Windows.Forms.Label total_lineaLabel;
            System.Windows.Forms.Label totalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnTerminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bBDDCiclismoDataSet = new KudekateaBikeShop.BBDDCiclismoDataSet();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventaTableAdapter = new KudekateaBikeShop.BBDDCiclismoDataSetTableAdapters.VentaTableAdapter();
            this.tableAdapterManager = new KudekateaBikeShop.BBDDCiclismoDataSetTableAdapters.TableAdapterManager();
            this.fecha_ventaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCancelarLinea = new System.Windows.Forms.Button();
            this.btnAceptarLinea = new System.Windows.Forms.Button();
            this.btnBorrarLinea = new System.Windows.Forms.Button();
            this.btnAnadirLinea = new System.Windows.Forms.Button();
            this.btnEditarLinea = new System.Windows.Forms.Button();
            this.btnAnteriorLinea = new System.Windows.Forms.Button();
            this.btnUltimoLinea = new System.Windows.Forms.Button();
            this.btnPrimeroLinea = new System.Windows.Forms.Button();
            this.btnSiguienteLinea = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnInforme = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.clientesTableAdapter = new KudekateaBikeShop.BBDDCiclismoDataSetTableAdapters.ClientesTableAdapter();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosTableAdapter = new KudekateaBikeShop.BBDDCiclismoDataSetTableAdapters.EmpleadosTableAdapter();
            this.bicicletasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bicicletasTableAdapter = new KudekateaBikeShop.BBDDCiclismoDataSetTableAdapters.BicicletasTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpStripToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.id_ventaLabel3 = new System.Windows.Forms.Label();
            this.nombre_clienteTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.id_empleadoComboBox = new System.Windows.Forms.ComboBox();
            this.email_clienteTextBox = new System.Windows.Forms.TextBox();
            this.dNI_clienteTextBox = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.id_clienteComboBox = new System.Windows.Forms.ComboBox();
            this.detalleVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalleVentaTableAdapter = new KudekateaBikeShop.BBDDCiclismoDataSetTableAdapters.DetalleVentaTableAdapter();
            this.id_ventaLabel2 = new System.Windows.Forms.Label();
            this.id_bicicletaComboBox = new System.Windows.Forms.ComboBox();
            this.nombre_bicicletaTextBox = new System.Windows.Forms.TextBox();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.fabricanteTextBox = new System.Windows.Forms.TextBox();
            this.cantidad_vendidaTextBox = new System.Windows.Forms.TextBox();
            this.precio_ventaTextBox = new System.Windows.Forms.TextBox();
            this.descuentoTextBox = new System.Windows.Forms.TextBox();
            this.total_lineaLabel1 = new System.Windows.Forms.Label();
            this.totalLabel1 = new System.Windows.Forms.Label();
            this.detalleVentaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            fecha_ventaLabel = new System.Windows.Forms.Label();
            id_ventaLabel = new System.Windows.Forms.Label();
            id_empleadoLabel = new System.Windows.Forms.Label();
            nombre_clienteLabel = new System.Windows.Forms.Label();
            id_clienteLabel = new System.Windows.Forms.Label();
            dNI_clienteLabel = new System.Windows.Forms.Label();
            email_clienteLabel = new System.Windows.Forms.Label();
            id_ventaLabel1 = new System.Windows.Forms.Label();
            id_bicicletaLabel = new System.Windows.Forms.Label();
            nombre_bicicletaLabel = new System.Windows.Forms.Label();
            categoriaLabel = new System.Windows.Forms.Label();
            fabricanteLabel = new System.Windows.Forms.Label();
            cantidad_vendidaLabel = new System.Windows.Forms.Label();
            precio_ventaLabel = new System.Windows.Forms.Label();
            descuentoLabel = new System.Windows.Forms.Label();
            total_lineaLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bBDDCiclismoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bicicletasBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fecha_ventaLabel
            // 
            fecha_ventaLabel.AutoSize = true;
            fecha_ventaLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fecha_ventaLabel.Location = new System.Drawing.Point(503, 163);
            fecha_ventaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fecha_ventaLabel.Name = "fecha_ventaLabel";
            fecha_ventaLabel.Size = new System.Drawing.Size(138, 23);
            fecha_ventaLabel.TabIndex = 33;
            fecha_ventaLabel.Text = "Fecha venta:";
            // 
            // id_ventaLabel
            // 
            id_ventaLabel.AutoSize = true;
            id_ventaLabel.Location = new System.Drawing.Point(142, 165);
            id_ventaLabel.Name = "id_ventaLabel";
            id_ventaLabel.Size = new System.Drawing.Size(96, 23);
            id_ventaLabel.TabIndex = 67;
            id_ventaLabel.Text = "Id venta:";
            // 
            // id_empleadoLabel
            // 
            id_empleadoLabel.AutoSize = true;
            id_empleadoLabel.Location = new System.Drawing.Point(107, 205);
            id_empleadoLabel.Name = "id_empleadoLabel";
            id_empleadoLabel.Size = new System.Drawing.Size(143, 23);
            id_empleadoLabel.TabIndex = 68;
            id_empleadoLabel.Text = "Id empleado:";
            // 
            // nombre_clienteLabel
            // 
            nombre_clienteLabel.AutoSize = true;
            nombre_clienteLabel.Location = new System.Drawing.Point(519, 205);
            nombre_clienteLabel.Name = "nombre_clienteLabel";
            nombre_clienteLabel.Size = new System.Drawing.Size(168, 23);
            nombre_clienteLabel.TabIndex = 69;
            nombre_clienteLabel.Text = "Nombre cliente:";
            nombre_clienteLabel.Visible = false;
            // 
            // id_clienteLabel
            // 
            id_clienteLabel.AutoSize = true;
            id_clienteLabel.Location = new System.Drawing.Point(73, 46);
            id_clienteLabel.Name = "id_clienteLabel";
            id_clienteLabel.Size = new System.Drawing.Size(108, 23);
            id_clienteLabel.TabIndex = 69;
            id_clienteLabel.Text = "Id cliente:";
            // 
            // dNI_clienteLabel
            // 
            dNI_clienteLabel.AutoSize = true;
            dNI_clienteLabel.Location = new System.Drawing.Point(597, 40);
            dNI_clienteLabel.Name = "dNI_clienteLabel";
            dNI_clienteLabel.Size = new System.Drawing.Size(124, 23);
            dNI_clienteLabel.TabIndex = 70;
            dNI_clienteLabel.Text = "DNI cliente:";
            // 
            // email_clienteLabel
            // 
            email_clienteLabel.AutoSize = true;
            email_clienteLabel.Location = new System.Drawing.Point(312, 134);
            email_clienteLabel.Name = "email_clienteLabel";
            email_clienteLabel.Size = new System.Drawing.Size(141, 23);
            email_clienteLabel.TabIndex = 70;
            email_clienteLabel.Text = "Email cliente:";
            // 
            // id_ventaLabel1
            // 
            id_ventaLabel1.AutoSize = true;
            id_ventaLabel1.Location = new System.Drawing.Point(99, 596);
            id_ventaLabel1.Name = "id_ventaLabel1";
            id_ventaLabel1.Size = new System.Drawing.Size(96, 23);
            id_ventaLabel1.TabIndex = 73;
            id_ventaLabel1.Text = "Id venta:";
            // 
            // id_bicicletaLabel
            // 
            id_bicicletaLabel.AutoSize = true;
            id_bicicletaLabel.Location = new System.Drawing.Point(72, 640);
            id_bicicletaLabel.Name = "id_bicicletaLabel";
            id_bicicletaLabel.Size = new System.Drawing.Size(127, 23);
            id_bicicletaLabel.TabIndex = 74;
            id_bicicletaLabel.Text = "Id bicicleta:";
            // 
            // nombre_bicicletaLabel
            // 
            nombre_bicicletaLabel.AutoSize = true;
            nombre_bicicletaLabel.Location = new System.Drawing.Point(445, 572);
            nombre_bicicletaLabel.Name = "nombre_bicicletaLabel";
            nombre_bicicletaLabel.Size = new System.Drawing.Size(187, 23);
            nombre_bicicletaLabel.TabIndex = 75;
            nombre_bicicletaLabel.Text = "Nombre bicicleta:";
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Location = new System.Drawing.Point(82, 689);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(114, 23);
            categoriaLabel.TabIndex = 76;
            categoriaLabel.Text = "Categoria:";
            // 
            // fabricanteLabel
            // 
            fabricanteLabel.AutoSize = true;
            fabricanteLabel.Location = new System.Drawing.Point(78, 736);
            fabricanteLabel.Name = "fabricanteLabel";
            fabricanteLabel.Size = new System.Drawing.Size(120, 23);
            fabricanteLabel.TabIndex = 77;
            fabricanteLabel.Text = "Fabricante:";
            // 
            // cantidad_vendidaLabel
            // 
            cantidad_vendidaLabel.AutoSize = true;
            cantidad_vendidaLabel.Location = new System.Drawing.Point(624, 637);
            cantidad_vendidaLabel.Name = "cantidad_vendidaLabel";
            cantidad_vendidaLabel.Size = new System.Drawing.Size(193, 23);
            cantidad_vendidaLabel.TabIndex = 78;
            cantidad_vendidaLabel.Text = "Cantidad vendida:";
            // 
            // precio_ventaLabel
            // 
            precio_ventaLabel.AutoSize = true;
            precio_ventaLabel.Location = new System.Drawing.Point(660, 686);
            precio_ventaLabel.Name = "precio_ventaLabel";
            precio_ventaLabel.Size = new System.Drawing.Size(138, 23);
            precio_ventaLabel.TabIndex = 79;
            precio_ventaLabel.Text = "Precio venta:";
            // 
            // descuentoLabel
            // 
            descuentoLabel.AutoSize = true;
            descuentoLabel.Location = new System.Drawing.Point(672, 733);
            descuentoLabel.Name = "descuentoLabel";
            descuentoLabel.Size = new System.Drawing.Size(121, 23);
            descuentoLabel.TabIndex = 80;
            descuentoLabel.Text = "Descuento:";
            // 
            // total_lineaLabel
            // 
            total_lineaLabel.AutoSize = true;
            total_lineaLabel.Location = new System.Drawing.Point(672, 781);
            total_lineaLabel.Name = "total_lineaLabel";
            total_lineaLabel.Size = new System.Drawing.Size(115, 23);
            total_lineaLabel.TabIndex = 81;
            total_lineaLabel.Text = "Total linea:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(945, 830);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(61, 23);
            totalLabel.TabIndex = 82;
            totalLabel.Text = "Total:";
            // 
            // btnTerminar
            // 
            this.btnTerminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTerminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTerminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTerminar.FlatAppearance.BorderSize = 0;
            this.btnTerminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerminar.Image = ((System.Drawing.Image)(resources.GetObject("btnTerminar.Image")));
            this.btnTerminar.Location = new System.Drawing.Point(28, 17);
            this.btnTerminar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(100, 83);
            this.btnTerminar.TabIndex = 63;
            this.toolTip1.SetToolTip(this.btnTerminar, "Terminar con las lineas");
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Línea";
            // 
            // bBDDCiclismoDataSet
            // 
            this.bBDDCiclismoDataSet.DataSetName = "BBDDCiclismoDataSet";
            this.bBDDCiclismoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataMember = "Venta";
            this.ventaBindingSource.DataSource = this.bBDDCiclismoDataSet;
            this.ventaBindingSource.PositionChanged += new System.EventHandler(this.ventaBindingSource_PositionChanged);
            // 
            // ventaTableAdapter
            // 
            this.ventaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BicicletasTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.ComprasTableAdapter = null;
            this.tableAdapterManager.DetalleComprasTableAdapter = null;
            this.tableAdapterManager.DetalleVentaTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.ProveedorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KudekateaBikeShop.BBDDCiclismoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentaTableAdapter = this.ventaTableAdapter;
            // 
            // fecha_ventaDateTimePicker
            // 
            this.fecha_ventaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ventaBindingSource, "Fecha_venta", true));
            this.fecha_ventaDateTimePicker.Location = new System.Drawing.Point(649, 156);
            this.fecha_ventaDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fecha_ventaDateTimePicker.Name = "fecha_ventaDateTimePicker";
            this.fecha_ventaDateTimePicker.Size = new System.Drawing.Size(431, 32);
            this.fecha_ventaDateTimePicker.TabIndex = 34;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.bBDDCiclismoDataSet;
            // 
            // btnCancelarLinea
            // 
            this.btnCancelarLinea.FlatAppearance.BorderSize = 0;
            this.btnCancelarLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarLinea.Image = global::KudekateaBikeShop.Properties.Resources.icons8_eliminar_481;
            this.btnCancelarLinea.Location = new System.Drawing.Point(32, 271);
            this.btnCancelarLinea.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelarLinea.Name = "btnCancelarLinea";
            this.btnCancelarLinea.Size = new System.Drawing.Size(100, 68);
            this.btnCancelarLinea.TabIndex = 37;
            this.btnCancelarLinea.UseVisualStyleBackColor = true;
            this.btnCancelarLinea.Click += new System.EventHandler(this.btnCancelarLinea_Click);
            // 
            // btnAceptarLinea
            // 
            this.btnAceptarLinea.FlatAppearance.BorderSize = 0;
            this.btnAceptarLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarLinea.Image = global::KudekateaBikeShop.Properties.Resources.icons8_marca_de_verificación_48;
            this.btnAceptarLinea.Location = new System.Drawing.Point(32, 142);
            this.btnAceptarLinea.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAceptarLinea.Name = "btnAceptarLinea";
            this.btnAceptarLinea.Size = new System.Drawing.Size(100, 83);
            this.btnAceptarLinea.TabIndex = 36;
            this.btnAceptarLinea.UseVisualStyleBackColor = true;
            this.btnAceptarLinea.Click += new System.EventHandler(this.btnAceptarLinea_Click);
            // 
            // btnBorrarLinea
            // 
            this.btnBorrarLinea.FlatAppearance.BorderSize = 0;
            this.btnBorrarLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarLinea.Image = global::KudekateaBikeShop.Properties.Resources.icons8_eliminar_48__1_;
            this.btnBorrarLinea.Location = new System.Drawing.Point(916, 16);
            this.btnBorrarLinea.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBorrarLinea.Name = "btnBorrarLinea";
            this.btnBorrarLinea.Size = new System.Drawing.Size(108, 75);
            this.btnBorrarLinea.TabIndex = 19;
            this.btnBorrarLinea.UseVisualStyleBackColor = true;
            this.btnBorrarLinea.Click += new System.EventHandler(this.btnBorrarLinea_Click);
            // 
            // btnAnadirLinea
            // 
            this.btnAnadirLinea.FlatAppearance.BorderSize = 0;
            this.btnAnadirLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnadirLinea.Image = global::KudekateaBikeShop.Properties.Resources.icons8_añadir_48;
            this.btnAnadirLinea.Location = new System.Drawing.Point(676, 15);
            this.btnAnadirLinea.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAnadirLinea.Name = "btnAnadirLinea";
            this.btnAnadirLinea.Size = new System.Drawing.Size(103, 76);
            this.btnAnadirLinea.TabIndex = 17;
            this.btnAnadirLinea.UseVisualStyleBackColor = true;
            this.btnAnadirLinea.Click += new System.EventHandler(this.btnAnadirLinea_Click);
            // 
            // btnEditarLinea
            // 
            this.btnEditarLinea.FlatAppearance.BorderSize = 0;
            this.btnEditarLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarLinea.Image = global::KudekateaBikeShop.Properties.Resources.icons8_editar_48;
            this.btnEditarLinea.Location = new System.Drawing.Point(808, 18);
            this.btnEditarLinea.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditarLinea.Name = "btnEditarLinea";
            this.btnEditarLinea.Size = new System.Drawing.Size(100, 72);
            this.btnEditarLinea.TabIndex = 16;
            this.btnEditarLinea.UseVisualStyleBackColor = true;
            this.btnEditarLinea.Click += new System.EventHandler(this.btnEditarLinea_Click);
            // 
            // btnAnteriorLinea
            // 
            this.btnAnteriorLinea.FlatAppearance.BorderSize = 0;
            this.btnAnteriorLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnteriorLinea.Image = global::KudekateaBikeShop.Properties.Resources.icons8_izquierda_48;
            this.btnAnteriorLinea.Location = new System.Drawing.Point(193, 17);
            this.btnAnteriorLinea.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAnteriorLinea.Name = "btnAnteriorLinea";
            this.btnAnteriorLinea.Size = new System.Drawing.Size(92, 61);
            this.btnAnteriorLinea.TabIndex = 15;
            this.btnAnteriorLinea.UseVisualStyleBackColor = true;
            this.btnAnteriorLinea.Click += new System.EventHandler(this.btnAnteriorLinea_Click);
            // 
            // btnUltimoLinea
            // 
            this.btnUltimoLinea.FlatAppearance.BorderSize = 0;
            this.btnUltimoLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimoLinea.Image = global::KudekateaBikeShop.Properties.Resources.icons8_doble_derecha_48;
            this.btnUltimoLinea.Location = new System.Drawing.Point(539, 15);
            this.btnUltimoLinea.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUltimoLinea.Name = "btnUltimoLinea";
            this.btnUltimoLinea.Size = new System.Drawing.Size(87, 61);
            this.btnUltimoLinea.TabIndex = 14;
            this.btnUltimoLinea.UseVisualStyleBackColor = true;
            this.btnUltimoLinea.Click += new System.EventHandler(this.btnUltimoLinea_Click);
            // 
            // btnPrimeroLinea
            // 
            this.btnPrimeroLinea.FlatAppearance.BorderSize = 0;
            this.btnPrimeroLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimeroLinea.Image = global::KudekateaBikeShop.Properties.Resources.icons8_doble_izquierda_48;
            this.btnPrimeroLinea.Location = new System.Drawing.Point(67, 17);
            this.btnPrimeroLinea.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrimeroLinea.Name = "btnPrimeroLinea";
            this.btnPrimeroLinea.Size = new System.Drawing.Size(95, 55);
            this.btnPrimeroLinea.TabIndex = 13;
            this.btnPrimeroLinea.UseVisualStyleBackColor = true;
            this.btnPrimeroLinea.Click += new System.EventHandler(this.btnPrimeroLinea_Click);
            // 
            // btnSiguienteLinea
            // 
            this.btnSiguienteLinea.FlatAppearance.BorderSize = 0;
            this.btnSiguienteLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguienteLinea.Image = global::KudekateaBikeShop.Properties.Resources.icons8_flecha_48;
            this.btnSiguienteLinea.Location = new System.Drawing.Point(448, 15);
            this.btnSiguienteLinea.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSiguienteLinea.Name = "btnSiguienteLinea";
            this.btnSiguienteLinea.Size = new System.Drawing.Size(83, 60);
            this.btnSiguienteLinea.TabIndex = 12;
            this.btnSiguienteLinea.UseVisualStyleBackColor = true;
            this.btnSiguienteLinea.Click += new System.EventHandler(this.btnSiguienteLinea_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Image = global::KudekateaBikeShop.Properties.Resources.icons8_retire_hombre_usuario_48;
            this.btnBorrar.Location = new System.Drawing.Point(1009, 21);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(100, 83);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnInforme
            // 
            this.btnInforme.FlatAppearance.BorderSize = 0;
            this.btnInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInforme.Image = global::KudekateaBikeShop.Properties.Resources.icons8_reporte_de_negocios_48;
            this.btnInforme.Location = new System.Drawing.Point(16, 33);
            this.btnInforme.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(100, 60);
            this.btnInforme.TabIndex = 9;
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = global::KudekateaBikeShop.Properties.Resources.icons8_guardar_48;
            this.btnGuardar.Location = new System.Drawing.Point(27, 143);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 67);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAnadir
            // 
            this.btnAnadir.FlatAppearance.BorderSize = 0;
            this.btnAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnadir.Image = global::KudekateaBikeShop.Properties.Resources.icons8_añadir_usuario_masculino_48;
            this.btnAnadir.Location = new System.Drawing.Point(763, 21);
            this.btnAnadir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(108, 84);
            this.btnAnadir.TabIndex = 7;
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = global::KudekateaBikeShop.Properties.Resources.icons8_editar_48;
            this.btnEditar.Location = new System.Drawing.Point(893, 29);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(108, 78);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Image = global::KudekateaBikeShop.Properties.Resources.icons8_izquierda_48;
            this.btnAnterior.Location = new System.Drawing.Point(304, 32);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(105, 72);
            this.btnAnterior.TabIndex = 5;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.FlatAppearance.BorderSize = 0;
            this.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimo.Image = global::KudekateaBikeShop.Properties.Resources.icons8_doble_derecha_48;
            this.btnUltimo.Location = new System.Drawing.Point(663, 26);
            this.btnUltimo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(100, 85);
            this.btnUltimo.TabIndex = 4;
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.FlatAppearance.BorderSize = 0;
            this.btnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimero.Image = global::KudekateaBikeShop.Properties.Resources.icons8_doble_izquierda_48;
            this.btnPrimero.Location = new System.Drawing.Point(139, 29);
            this.btnPrimero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(124, 75);
            this.btnPrimero.TabIndex = 3;
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Image = global::KudekateaBikeShop.Properties.Resources.icons8_flecha_48;
            this.btnSiguiente.Location = new System.Drawing.Point(559, 30);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(96, 82);
            this.btnSiguiente.TabIndex = 1;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.bBDDCiclismoDataSet;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // bicicletasBindingSource
            // 
            this.bicicletasBindingSource.DataMember = "Bicicletas";
            this.bicicletasBindingSource.DataSource = this.bBDDCiclismoDataSet;
            this.bicicletasBindingSource.CurrentChanged += new System.EventHandler(this.bicicletasBindingSource_CurrentChanged);
            // 
            // bicicletasTableAdapter
            // 
            this.bicicletasTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1301, 35);
            this.menuStrip1.TabIndex = 60;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.borrarToolStripMenuItem1,
            this.informeToolStripMenuItem,
            this.helpStripToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.Image = global::KudekateaBikeShop.Properties.Resources.icons8_añadir_usuario_masculino_48;
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.añadirToolStripMenuItem.Text = "Añadir";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Image = global::KudekateaBikeShop.Properties.Resources.icons8_editar_48;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // borrarToolStripMenuItem1
            // 
            this.borrarToolStripMenuItem1.Image = global::KudekateaBikeShop.Properties.Resources.icons8_eliminar_48;
            this.borrarToolStripMenuItem1.Name = "borrarToolStripMenuItem1";
            this.borrarToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.borrarToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.borrarToolStripMenuItem1.Text = "Borrar";
            this.borrarToolStripMenuItem1.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // informeToolStripMenuItem
            // 
            this.informeToolStripMenuItem.Image = global::KudekateaBikeShop.Properties.Resources.icons8_reporte_de_negocios_48;
            this.informeToolStripMenuItem.Name = "informeToolStripMenuItem";
            this.informeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.informeToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.informeToolStripMenuItem.Text = "Informe";
            this.informeToolStripMenuItem.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // helpStripToolStripMenuItem
            // 
            this.helpStripToolStripMenuItem.Image = global::KudekateaBikeShop.Properties.Resources.icons8_ayuda_48;
            this.helpStripToolStripMenuItem.Name = "helpStripToolStripMenuItem";
            this.helpStripToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.helpStripToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.helpStripToolStripMenuItem.Text = "Ayuda";
            this.helpStripToolStripMenuItem.Click += new System.EventHandler(this.helpStripToolStripMenuItem_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::KudekateaBikeShop.Properties.Resources.icons8_eliminar_481;
            this.btnCancelar.Location = new System.Drawing.Point(27, 324);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 67);
            this.btnCancelar.TabIndex = 62;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Image = global::KudekateaBikeShop.Properties.Resources.icons8_marca_de_verificación_48;
            this.btnAceptar.Location = new System.Drawing.Point(27, 236);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 82);
            this.btnAceptar.TabIndex = 61;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnBorrarLinea);
            this.panel1.Controls.Add(this.btnAnadirLinea);
            this.panel1.Controls.Add(this.btnEditarLinea);
            this.panel1.Controls.Add(this.btnAnteriorLinea);
            this.panel1.Controls.Add(this.btnUltimoLinea);
            this.panel1.Controls.Add(this.btnPrimeroLinea);
            this.panel1.Controls.Add(this.btnSiguienteLinea);
            this.panel1.Location = new System.Drawing.Point(0, 465);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 93);
            this.panel1.TabIndex = 64;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Salmon;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnBorrar);
            this.panel2.Controls.Add(this.btnAnadir);
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.btnAnterior);
            this.panel2.Controls.Add(this.btnUltimo);
            this.panel2.Controls.Add(this.btnPrimero);
            this.panel2.Controls.Add(this.btnSiguiente);
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1145, 110);
            this.panel2.TabIndex = 65;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Salmon;
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Controls.Add(this.btnAceptar);
            this.panel3.Controls.Add(this.btnInforme);
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Location = new System.Drawing.Point(1144, 37);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(137, 429);
            this.panel3.TabIndex = 66;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSalmon;
            this.panel4.Controls.Add(this.btnTerminar);
            this.panel4.Controls.Add(this.btnCancelarLinea);
            this.panel4.Controls.Add(this.btnAceptarLinea);
            this.panel4.Location = new System.Drawing.Point(1144, 465);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(137, 382);
            this.panel4.TabIndex = 67;
            // 
            // id_ventaLabel3
            // 
            this.id_ventaLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "Id_venta", true));
            this.id_ventaLabel3.Location = new System.Drawing.Point(244, 165);
            this.id_ventaLabel3.Name = "id_ventaLabel3";
            this.id_ventaLabel3.Size = new System.Drawing.Size(100, 23);
            this.id_ventaLabel3.TabIndex = 68;
            this.id_ventaLabel3.Text = "label3";
            // 
            // nombre_clienteTextBox
            // 
            this.nombre_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "Nombre_cliente", true));
            this.nombre_clienteTextBox.Location = new System.Drawing.Point(695, 199);
            this.nombre_clienteTextBox.Name = "nombre_clienteTextBox";
            this.nombre_clienteTextBox.Size = new System.Drawing.Size(265, 32);
            this.nombre_clienteTextBox.TabIndex = 70;
            this.nombre_clienteTextBox.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.id_empleadoComboBox);
            this.groupBox1.Controls.Add(email_clienteLabel);
            this.groupBox1.Controls.Add(dNI_clienteLabel);
            this.groupBox1.Controls.Add(this.email_clienteTextBox);
            this.groupBox1.Controls.Add(id_clienteLabel);
            this.groupBox1.Controls.Add(this.dNI_clienteTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(57, 239);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1052, 218);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // id_empleadoComboBox
            // 
            this.id_empleadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ventaBindingSource, "Id_cliente", true));
            this.id_empleadoComboBox.DataSource = this.clientesBindingSource;
            this.id_empleadoComboBox.DisplayMember = "Nombre";
            this.id_empleadoComboBox.FormattingEnabled = true;
            this.id_empleadoComboBox.Location = new System.Drawing.Point(187, 40);
            this.id_empleadoComboBox.Name = "id_empleadoComboBox";
            this.id_empleadoComboBox.Size = new System.Drawing.Size(265, 31);
            this.id_empleadoComboBox.TabIndex = 74;
            this.id_empleadoComboBox.ValueMember = "Id";
            this.id_empleadoComboBox.SelectedIndexChanged += new System.EventHandler(this.id_empleadoComboBox_SelectedIndexChanged);
            // 
            // email_clienteTextBox
            // 
            this.email_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "Email_cliente", true));
            this.email_clienteTextBox.Location = new System.Drawing.Point(459, 131);
            this.email_clienteTextBox.Name = "email_clienteTextBox";
            this.email_clienteTextBox.Size = new System.Drawing.Size(265, 32);
            this.email_clienteTextBox.TabIndex = 71;
            // 
            // dNI_clienteTextBox
            // 
            this.dNI_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "DNI_cliente", true));
            this.dNI_clienteTextBox.Location = new System.Drawing.Point(727, 37);
            this.dNI_clienteTextBox.Name = "dNI_clienteTextBox";
            this.dNI_clienteTextBox.Size = new System.Drawing.Size(265, 32);
            this.dNI_clienteTextBox.TabIndex = 71;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "./Kudekatea.chm";
            // 
            // id_clienteComboBox
            // 
            this.id_clienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ventaBindingSource, "Id_empleado", true));
            this.id_clienteComboBox.DataSource = this.empleadosBindingSource;
            this.id_clienteComboBox.DisplayMember = "Nombre";
            this.id_clienteComboBox.FormattingEnabled = true;
            this.id_clienteComboBox.Location = new System.Drawing.Point(274, 202);
            this.id_clienteComboBox.Name = "id_clienteComboBox";
            this.id_clienteComboBox.Size = new System.Drawing.Size(217, 31);
            this.id_clienteComboBox.TabIndex = 73;
            this.id_clienteComboBox.ValueMember = "Id";
            // 
            // detalleVentaBindingSource
            // 
            this.detalleVentaBindingSource.DataMember = "Venta_DetalleVenta";
            this.detalleVentaBindingSource.DataSource = this.ventaBindingSource;
            // 
            // detalleVentaTableAdapter
            // 
            this.detalleVentaTableAdapter.ClearBeforeFill = true;
            // 
            // id_ventaLabel2
            // 
            this.id_ventaLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleVentaBindingSource, "Id_venta", true));
            this.id_ventaLabel2.Location = new System.Drawing.Point(201, 596);
            this.id_ventaLabel2.Name = "id_ventaLabel2";
            this.id_ventaLabel2.Size = new System.Drawing.Size(100, 23);
            this.id_ventaLabel2.TabIndex = 74;
            this.id_ventaLabel2.Text = "label3";
            // 
            // id_bicicletaComboBox
            // 
            this.id_bicicletaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.detalleVentaBindingSource, "Id_bicicleta", true));
            this.id_bicicletaComboBox.DataSource = this.bicicletasBindingSource;
            this.id_bicicletaComboBox.DisplayMember = "Nombre";
            this.id_bicicletaComboBox.FormattingEnabled = true;
            this.id_bicicletaComboBox.Location = new System.Drawing.Point(205, 640);
            this.id_bicicletaComboBox.Name = "id_bicicletaComboBox";
            this.id_bicicletaComboBox.Size = new System.Drawing.Size(156, 31);
            this.id_bicicletaComboBox.TabIndex = 75;
            this.id_bicicletaComboBox.ValueMember = "Id";
            this.id_bicicletaComboBox.SelectedIndexChanged += new System.EventHandler(this.id_bicicletaComboBox_SelectedIndexChanged_1);
            // 
            // nombre_bicicletaTextBox
            // 
            this.nombre_bicicletaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleVentaBindingSource, "Nombre_bicicleta", true));
            this.nombre_bicicletaTextBox.Enabled = false;
            this.nombre_bicicletaTextBox.Location = new System.Drawing.Point(638, 569);
            this.nombre_bicicletaTextBox.Name = "nombre_bicicletaTextBox";
            this.nombre_bicicletaTextBox.Size = new System.Drawing.Size(149, 32);
            this.nombre_bicicletaTextBox.TabIndex = 76;
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleVentaBindingSource, "Categoria", true));
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Items.AddRange(new object[] {
            "Seleccionar",
            "Carretera",
            "BMX",
            "Electrica"});
            this.categoriaComboBox.Location = new System.Drawing.Point(205, 683);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(156, 31);
            this.categoriaComboBox.TabIndex = 77;
            // 
            // fabricanteTextBox
            // 
            this.fabricanteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleVentaBindingSource, "Fabricante", true));
            this.fabricanteTextBox.Location = new System.Drawing.Point(205, 733);
            this.fabricanteTextBox.Name = "fabricanteTextBox";
            this.fabricanteTextBox.Size = new System.Drawing.Size(156, 32);
            this.fabricanteTextBox.TabIndex = 78;
            // 
            // cantidad_vendidaTextBox
            // 
            this.cantidad_vendidaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleVentaBindingSource, "Cantidad_vendida", true));
            this.cantidad_vendidaTextBox.Location = new System.Drawing.Point(823, 634);
            this.cantidad_vendidaTextBox.Name = "cantidad_vendidaTextBox";
            this.cantidad_vendidaTextBox.Size = new System.Drawing.Size(137, 32);
            this.cantidad_vendidaTextBox.TabIndex = 79;
            // 
            // precio_ventaTextBox
            // 
            this.precio_ventaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleVentaBindingSource, "Precio_venta", true));
            this.precio_ventaTextBox.Location = new System.Drawing.Point(823, 685);
            this.precio_ventaTextBox.Name = "precio_ventaTextBox";
            this.precio_ventaTextBox.Size = new System.Drawing.Size(137, 32);
            this.precio_ventaTextBox.TabIndex = 80;
            // 
            // descuentoTextBox
            // 
            this.descuentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleVentaBindingSource, "Descuento", true));
            this.descuentoTextBox.Location = new System.Drawing.Point(823, 730);
            this.descuentoTextBox.Name = "descuentoTextBox";
            this.descuentoTextBox.Size = new System.Drawing.Size(137, 32);
            this.descuentoTextBox.TabIndex = 81;
            // 
            // total_lineaLabel1
            // 
            this.total_lineaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleVentaBindingSource, "Total_linea", true));
            this.total_lineaLabel1.Location = new System.Drawing.Point(819, 781);
            this.total_lineaLabel1.Name = "total_lineaLabel1";
            this.total_lineaLabel1.Size = new System.Drawing.Size(100, 23);
            this.total_lineaLabel1.TabIndex = 82;
            this.total_lineaLabel1.Text = "label3";
            // 
            // totalLabel1
            // 
            this.totalLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleVentaBindingSource, "Total", true));
            this.totalLabel1.Location = new System.Drawing.Point(1009, 830);
            this.totalLabel1.Name = "totalLabel1";
            this.totalLabel1.Size = new System.Drawing.Size(100, 23);
            this.totalLabel1.TabIndex = 83;
            this.totalLabel1.Text = "label3";
            // 
            // detalleVentaDataGridView
            // 
            this.detalleVentaDataGridView.AutoGenerateColumns = false;
            this.detalleVentaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalleVentaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.detalleVentaDataGridView.DataSource = this.detalleVentaBindingSource;
            this.detalleVentaDataGridView.Location = new System.Drawing.Point(0, 885);
            this.detalleVentaDataGridView.Name = "detalleVentaDataGridView";
            this.detalleVentaDataGridView.RowHeadersWidth = 62;
            this.detalleVentaDataGridView.RowTemplate.Height = 28;
            this.detalleVentaDataGridView.Size = new System.Drawing.Size(1301, 220);
            this.detalleVentaDataGridView.TabIndex = 83;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_venta";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_venta";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id_bicicleta";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id_bicicleta";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nombre_bicicleta";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre_bicicleta";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Categoria";
            this.dataGridViewTextBoxColumn4.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Fabricante";
            this.dataGridViewTextBoxColumn5.HeaderText = "Fabricante";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Cantidad_vendida";
            this.dataGridViewTextBoxColumn6.HeaderText = "Cantidad_vendida";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Precio_venta";
            this.dataGridViewTextBoxColumn7.HeaderText = "Precio_venta";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Descuento";
            this.dataGridViewTextBoxColumn8.HeaderText = "Descuento";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Total_linea";
            this.dataGridViewTextBoxColumn9.HeaderText = "Total_linea";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn10.HeaderText = "Total";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1301, 1103);
            this.Controls.Add(this.detalleVentaDataGridView);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalLabel1);
            this.Controls.Add(total_lineaLabel);
            this.Controls.Add(this.total_lineaLabel1);
            this.Controls.Add(descuentoLabel);
            this.Controls.Add(this.descuentoTextBox);
            this.Controls.Add(precio_ventaLabel);
            this.Controls.Add(this.precio_ventaTextBox);
            this.Controls.Add(cantidad_vendidaLabel);
            this.Controls.Add(this.cantidad_vendidaTextBox);
            this.Controls.Add(fabricanteLabel);
            this.Controls.Add(this.fabricanteTextBox);
            this.Controls.Add(categoriaLabel);
            this.Controls.Add(this.categoriaComboBox);
            this.Controls.Add(nombre_bicicletaLabel);
            this.Controls.Add(this.nombre_bicicletaTextBox);
            this.Controls.Add(id_bicicletaLabel);
            this.Controls.Add(this.id_bicicletaComboBox);
            this.Controls.Add(id_ventaLabel1);
            this.Controls.Add(this.id_ventaLabel2);
            this.Controls.Add(this.id_clienteComboBox);
            this.Controls.Add(nombre_clienteLabel);
            this.Controls.Add(id_empleadoLabel);
            this.Controls.Add(this.nombre_clienteTextBox);
            this.Controls.Add(id_ventaLabel);
            this.Controls.Add(this.id_ventaLabel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(fecha_ventaLabel);
            this.Controls.Add(this.fecha_ventaDateTimePicker);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpKeyword(this, "10");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Ventas";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ventas_FormClosing);
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bBDDCiclismoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bicicletasBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBorrarLinea;
        private System.Windows.Forms.Button btnAnadirLinea;
        private System.Windows.Forms.Button btnEditarLinea;
        private System.Windows.Forms.Button btnAnteriorLinea;
        private System.Windows.Forms.Button btnUltimoLinea;
        private System.Windows.Forms.Button btnPrimeroLinea;
        private System.Windows.Forms.Button btnSiguienteLinea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private BBDDCiclismoDataSet bBDDCiclismoDataSet;
        private System.Windows.Forms.BindingSource ventaBindingSource;
        private BBDDCiclismoDataSetTableAdapters.VentaTableAdapter ventaTableAdapter;
        private BBDDCiclismoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker fecha_ventaDateTimePicker;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCancelarLinea;
        private System.Windows.Forms.Button btnAceptarLinea;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private BBDDCiclismoDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private BBDDCiclismoDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.BindingSource bicicletasBindingSource;
        private BBDDCiclismoDataSetTableAdapters.BicicletasTableAdapter bicicletasTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem informeToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nombre_clienteTextBox;
        private System.Windows.Forms.Label id_ventaLabel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox email_clienteTextBox;
        private System.Windows.Forms.TextBox dNI_clienteTextBox;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ComboBox id_clienteComboBox;
        private System.Windows.Forms.ComboBox id_empleadoComboBox;
        private System.Windows.Forms.BindingSource detalleVentaBindingSource;
        private BBDDCiclismoDataSetTableAdapters.DetalleVentaTableAdapter detalleVentaTableAdapter;
        private System.Windows.Forms.Label id_ventaLabel2;
        private System.Windows.Forms.Label totalLabel1;
        private System.Windows.Forms.Label total_lineaLabel1;
        private System.Windows.Forms.TextBox descuentoTextBox;
        private System.Windows.Forms.TextBox precio_ventaTextBox;
        private System.Windows.Forms.TextBox cantidad_vendidaTextBox;
        private System.Windows.Forms.TextBox fabricanteTextBox;
        private System.Windows.Forms.ComboBox categoriaComboBox;
        private System.Windows.Forms.TextBox nombre_bicicletaTextBox;
        private System.Windows.Forms.ComboBox id_bicicletaComboBox;
        private System.Windows.Forms.DataGridView detalleVentaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.ToolStripMenuItem helpStripToolStripMenuItem;
    }
}
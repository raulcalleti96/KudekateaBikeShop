
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
            System.Windows.Forms.Label id_ventaLabel;
            System.Windows.Forms.Label nombre_clienteLabel;
            System.Windows.Forms.Label dNI_clienteLabel;
            System.Windows.Forms.Label email_clienteLabel;
            System.Windows.Forms.Label fecha_ventaLabel;
            System.Windows.Forms.Label id_clienteLabel;
            System.Windows.Forms.Label id_empleadoLabel;
            System.Windows.Forms.Label id_ventaLabel1;
            System.Windows.Forms.Label id_bicicletaLabel;
            System.Windows.Forms.Label nombre_bicicletaLabel;
            System.Windows.Forms.Label categoriaLabel;
            System.Windows.Forms.Label fabricanteLabel;
            System.Windows.Forms.Label cantidad_vendidaLabel;
            System.Windows.Forms.Label precio_ventaLabel;
            System.Windows.Forms.Label descuentoLabel;
            System.Windows.Forms.Label total_lineaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bBDDCiclismoDataSet = new KudekateaBikeShop.BBDDCiclismoDataSet();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventaTableAdapter = new KudekateaBikeShop.BBDDCiclismoDataSetTableAdapters.VentaTableAdapter();
            this.tableAdapterManager = new KudekateaBikeShop.BBDDCiclismoDataSetTableAdapters.TableAdapterManager();
            this.id_ventaTextBox = new System.Windows.Forms.TextBox();
            this.nombre_clienteTextBox = new System.Windows.Forms.TextBox();
            this.dNI_clienteTextBox = new System.Windows.Forms.TextBox();
            this.email_clienteTextBox = new System.Windows.Forms.TextBox();
            this.fecha_ventaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.id_clienteComboBox = new System.Windows.Forms.ComboBox();
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
            this.detalleVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalleVentaTableAdapter = new KudekateaBikeShop.BBDDCiclismoDataSetTableAdapters.DetalleVentaTableAdapter();
            this.clientesTableAdapter = new KudekateaBikeShop.BBDDCiclismoDataSetTableAdapters.ClientesTableAdapter();
            this.id_empleadoComboBox = new System.Windows.Forms.ComboBox();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosTableAdapter = new KudekateaBikeShop.BBDDCiclismoDataSetTableAdapters.EmpleadosTableAdapter();
            this.id_ventaLabel2 = new System.Windows.Forms.Label();
            this.bicicletasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bicicletasTableAdapter = new KudekateaBikeShop.BBDDCiclismoDataSetTableAdapters.BicicletasTableAdapter();
            this.detalleComprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalleComprasTableAdapter = new KudekateaBikeShop.BBDDCiclismoDataSetTableAdapters.DetalleComprasTableAdapter();
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
            this.id_bicicletaComboBox = new System.Windows.Forms.ComboBox();
            this.nombre_bicicletaTextBox = new System.Windows.Forms.TextBox();
            this.categoriaTextBox = new System.Windows.Forms.TextBox();
            this.fabricanteTextBox = new System.Windows.Forms.TextBox();
            this.cantidad_vendidaTextBox = new System.Windows.Forms.TextBox();
            this.precio_ventaTextBox = new System.Windows.Forms.TextBox();
            this.descuentoTextBox = new System.Windows.Forms.TextBox();
            this.total_lineaLabel1 = new System.Windows.Forms.Label();
            this.totalLabel1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            id_ventaLabel = new System.Windows.Forms.Label();
            nombre_clienteLabel = new System.Windows.Forms.Label();
            dNI_clienteLabel = new System.Windows.Forms.Label();
            email_clienteLabel = new System.Windows.Forms.Label();
            fecha_ventaLabel = new System.Windows.Forms.Label();
            id_clienteLabel = new System.Windows.Forms.Label();
            id_empleadoLabel = new System.Windows.Forms.Label();
            id_ventaLabel1 = new System.Windows.Forms.Label();
            id_bicicletaLabel = new System.Windows.Forms.Label();
            nombre_bicicletaLabel = new System.Windows.Forms.Label();
            categoriaLabel = new System.Windows.Forms.Label();
            fabricanteLabel = new System.Windows.Forms.Label();
            cantidad_vendidaLabel = new System.Windows.Forms.Label();
            precio_ventaLabel = new System.Windows.Forms.Label();
            descuentoLabel = new System.Windows.Forms.Label();
            total_lineaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bBDDCiclismoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bicicletasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleComprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_ventaLabel
            // 
            id_ventaLabel.AutoSize = true;
            id_ventaLabel.Location = new System.Drawing.Point(127, 138);
            id_ventaLabel.Name = "id_ventaLabel";
            id_ventaLabel.Size = new System.Drawing.Size(70, 20);
            id_ventaLabel.TabIndex = 21;
            id_ventaLabel.Text = "Id venta:";
            // 
            // nombre_clienteLabel
            // 
            nombre_clienteLabel.AutoSize = true;
            nombre_clienteLabel.Location = new System.Drawing.Point(16, 75);
            nombre_clienteLabel.Name = "nombre_clienteLabel";
            nombre_clienteLabel.Size = new System.Drawing.Size(119, 20);
            nombre_clienteLabel.TabIndex = 27;
            nombre_clienteLabel.Text = "Nombre cliente:";
            // 
            // dNI_clienteLabel
            // 
            dNI_clienteLabel.AutoSize = true;
            dNI_clienteLabel.Location = new System.Drawing.Point(16, 107);
            dNI_clienteLabel.Name = "dNI_clienteLabel";
            dNI_clienteLabel.Size = new System.Drawing.Size(91, 20);
            dNI_clienteLabel.TabIndex = 29;
            dNI_clienteLabel.Text = "DNI cliente:";
            // 
            // email_clienteLabel
            // 
            email_clienteLabel.AutoSize = true;
            email_clienteLabel.Location = new System.Drawing.Point(16, 139);
            email_clienteLabel.Name = "email_clienteLabel";
            email_clienteLabel.Size = new System.Drawing.Size(102, 20);
            email_clienteLabel.TabIndex = 31;
            email_clienteLabel.Text = "Email cliente:";
            // 
            // fecha_ventaLabel
            // 
            fecha_ventaLabel.AutoSize = true;
            fecha_ventaLabel.Location = new System.Drawing.Point(508, 141);
            fecha_ventaLabel.Name = "fecha_ventaLabel";
            fecha_ventaLabel.Size = new System.Drawing.Size(101, 20);
            fecha_ventaLabel.TabIndex = 33;
            fecha_ventaLabel.Text = "Fecha venta:";
            // 
            // id_clienteLabel
            // 
            id_clienteLabel.AutoSize = true;
            id_clienteLabel.Location = new System.Drawing.Point(58, 37);
            id_clienteLabel.Name = "id_clienteLabel";
            id_clienteLabel.Size = new System.Drawing.Size(77, 20);
            id_clienteLabel.TabIndex = 37;
            id_clienteLabel.Text = "Id cliente:";
            // 
            // id_empleadoLabel
            // 
            id_empleadoLabel.AutoSize = true;
            id_empleadoLabel.Location = new System.Drawing.Point(144, 175);
            id_empleadoLabel.Name = "id_empleadoLabel";
            id_empleadoLabel.Size = new System.Drawing.Size(101, 20);
            id_empleadoLabel.TabIndex = 37;
            id_empleadoLabel.Text = "Id empleado:";
            // 
            // id_ventaLabel1
            // 
            id_ventaLabel1.AutoSize = true;
            id_ventaLabel1.Location = new System.Drawing.Point(52, 482);
            id_ventaLabel1.Name = "id_ventaLabel1";
            id_ventaLabel1.Size = new System.Drawing.Size(70, 20);
            id_ventaLabel1.TabIndex = 38;
            id_ventaLabel1.Text = "Id venta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
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
            // id_ventaTextBox
            // 
            this.id_ventaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "Id_venta", true));
            this.id_ventaTextBox.Location = new System.Drawing.Point(252, 135);
            this.id_ventaTextBox.Name = "id_ventaTextBox";
            this.id_ventaTextBox.Size = new System.Drawing.Size(200, 26);
            this.id_ventaTextBox.TabIndex = 22;
            // 
            // nombre_clienteTextBox
            // 
            this.nombre_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "Nombre_cliente", true));
            this.nombre_clienteTextBox.Location = new System.Drawing.Point(141, 72);
            this.nombre_clienteTextBox.Name = "nombre_clienteTextBox";
            this.nombre_clienteTextBox.Size = new System.Drawing.Size(200, 26);
            this.nombre_clienteTextBox.TabIndex = 28;
            // 
            // dNI_clienteTextBox
            // 
            this.dNI_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "DNI_cliente", true));
            this.dNI_clienteTextBox.Location = new System.Drawing.Point(141, 104);
            this.dNI_clienteTextBox.Name = "dNI_clienteTextBox";
            this.dNI_clienteTextBox.Size = new System.Drawing.Size(200, 26);
            this.dNI_clienteTextBox.TabIndex = 30;
            this.dNI_clienteTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.dNI_clienteTextBox_Validating);
            // 
            // email_clienteTextBox
            // 
            this.email_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "Email_cliente", true));
            this.email_clienteTextBox.Location = new System.Drawing.Point(141, 136);
            this.email_clienteTextBox.Name = "email_clienteTextBox";
            this.email_clienteTextBox.Size = new System.Drawing.Size(200, 26);
            this.email_clienteTextBox.TabIndex = 32;
            this.email_clienteTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.email_clienteTextBox_Validating);
            // 
            // fecha_ventaDateTimePicker
            // 
            this.fecha_ventaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ventaBindingSource, "Fecha_venta", true));
            this.fecha_ventaDateTimePicker.Location = new System.Drawing.Point(633, 137);
            this.fecha_ventaDateTimePicker.Name = "fecha_ventaDateTimePicker";
            this.fecha_ventaDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.fecha_ventaDateTimePicker.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(id_clienteLabel);
            this.groupBox1.Controls.Add(nombre_clienteLabel);
            this.groupBox1.Controls.Add(this.id_clienteComboBox);
            this.groupBox1.Controls.Add(this.nombre_clienteTextBox);
            this.groupBox1.Controls.Add(dNI_clienteLabel);
            this.groupBox1.Controls.Add(this.dNI_clienteTextBox);
            this.groupBox1.Controls.Add(email_clienteLabel);
            this.groupBox1.Controls.Add(this.email_clienteTextBox);
            this.groupBox1.Location = new System.Drawing.Point(104, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 190);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // id_clienteComboBox
            // 
            this.id_clienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "Id_cliente", true));
            this.id_clienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ventaBindingSource, "Id_cliente", true));
            this.id_clienteComboBox.DataSource = this.clientesBindingSource;
            this.id_clienteComboBox.DisplayMember = "Nombre";
            this.id_clienteComboBox.FormattingEnabled = true;
            this.id_clienteComboBox.Location = new System.Drawing.Point(141, 34);
            this.id_clienteComboBox.Name = "id_clienteComboBox";
            this.id_clienteComboBox.Size = new System.Drawing.Size(200, 28);
            this.id_clienteComboBox.TabIndex = 38;
            this.id_clienteComboBox.ValueMember = "Id";
            this.id_clienteComboBox.SelectedIndexChanged += new System.EventHandler(this.id_clienteComboBox_SelectedIndexChanged);
            this.id_clienteComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.id_clienteComboBox_Validating);
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
            this.btnCancelarLinea.Location = new System.Drawing.Point(778, 599);
            this.btnCancelarLinea.Name = "btnCancelarLinea";
            this.btnCancelarLinea.Size = new System.Drawing.Size(75, 48);
            this.btnCancelarLinea.TabIndex = 37;
            this.btnCancelarLinea.UseVisualStyleBackColor = true;
            this.btnCancelarLinea.Click += new System.EventHandler(this.btnCancelarLinea_Click);
            // 
            // btnAceptarLinea
            // 
            this.btnAceptarLinea.FlatAppearance.BorderSize = 0;
            this.btnAceptarLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarLinea.Image = global::KudekateaBikeShop.Properties.Resources.icons8_marca_de_verificación_48;
            this.btnAceptarLinea.Location = new System.Drawing.Point(778, 521);
            this.btnAceptarLinea.Name = "btnAceptarLinea";
            this.btnAceptarLinea.Size = new System.Drawing.Size(75, 46);
            this.btnAceptarLinea.TabIndex = 36;
            this.btnAceptarLinea.UseVisualStyleBackColor = true;
            this.btnAceptarLinea.Click += new System.EventHandler(this.btnAceptarLinea_Click);
            // 
            // btnBorrarLinea
            // 
            this.btnBorrarLinea.FlatAppearance.BorderSize = 0;
            this.btnBorrarLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarLinea.Image = global::KudekateaBikeShop.Properties.Resources.icons8_eliminar_48__1_;
            this.btnBorrarLinea.Location = new System.Drawing.Point(687, 418);
            this.btnBorrarLinea.Name = "btnBorrarLinea";
            this.btnBorrarLinea.Size = new System.Drawing.Size(81, 65);
            this.btnBorrarLinea.TabIndex = 19;
            this.btnBorrarLinea.UseVisualStyleBackColor = true;
            this.btnBorrarLinea.Click += new System.EventHandler(this.btnBorrarLinea_Click);
            // 
            // btnAnadirLinea
            // 
            this.btnAnadirLinea.FlatAppearance.BorderSize = 0;
            this.btnAnadirLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnadirLinea.Image = global::KudekateaBikeShop.Properties.Resources.icons8_añadir_48;
            this.btnAnadirLinea.Location = new System.Drawing.Point(507, 417);
            this.btnAnadirLinea.Name = "btnAnadirLinea";
            this.btnAnadirLinea.Size = new System.Drawing.Size(77, 66);
            this.btnAnadirLinea.TabIndex = 17;
            this.btnAnadirLinea.UseVisualStyleBackColor = true;
            this.btnAnadirLinea.Click += new System.EventHandler(this.btnAnadirLinea_Click);
            // 
            // btnEditarLinea
            // 
            this.btnEditarLinea.FlatAppearance.BorderSize = 0;
            this.btnEditarLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarLinea.Image = global::KudekateaBikeShop.Properties.Resources.icons8_editar_48;
            this.btnEditarLinea.Location = new System.Drawing.Point(606, 420);
            this.btnEditarLinea.Name = "btnEditarLinea";
            this.btnEditarLinea.Size = new System.Drawing.Size(75, 63);
            this.btnEditarLinea.TabIndex = 16;
            this.btnEditarLinea.UseVisualStyleBackColor = true;
            this.btnEditarLinea.Click += new System.EventHandler(this.btnEditarLinea_Click);
            // 
            // btnAnteriorLinea
            // 
            this.btnAnteriorLinea.FlatAppearance.BorderSize = 0;
            this.btnAnteriorLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnteriorLinea.Image = global::KudekateaBikeShop.Properties.Resources.icons8_izquierda_48;
            this.btnAnteriorLinea.Location = new System.Drawing.Point(145, 419);
            this.btnAnteriorLinea.Name = "btnAnteriorLinea";
            this.btnAnteriorLinea.Size = new System.Drawing.Size(69, 53);
            this.btnAnteriorLinea.TabIndex = 15;
            this.btnAnteriorLinea.UseVisualStyleBackColor = true;
            this.btnAnteriorLinea.Click += new System.EventHandler(this.btnAnteriorLinea_Click);
            // 
            // btnUltimoLinea
            // 
            this.btnUltimoLinea.FlatAppearance.BorderSize = 0;
            this.btnUltimoLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimoLinea.Image = global::KudekateaBikeShop.Properties.Resources.icons8_doble_derecha_48;
            this.btnUltimoLinea.Location = new System.Drawing.Point(404, 417);
            this.btnUltimoLinea.Name = "btnUltimoLinea";
            this.btnUltimoLinea.Size = new System.Drawing.Size(65, 53);
            this.btnUltimoLinea.TabIndex = 14;
            this.btnUltimoLinea.UseVisualStyleBackColor = true;
            this.btnUltimoLinea.Click += new System.EventHandler(this.btnUltimoLinea_Click);
            // 
            // btnPrimeroLinea
            // 
            this.btnPrimeroLinea.FlatAppearance.BorderSize = 0;
            this.btnPrimeroLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimeroLinea.Image = global::KudekateaBikeShop.Properties.Resources.icons8_doble_izquierda_48;
            this.btnPrimeroLinea.Location = new System.Drawing.Point(50, 419);
            this.btnPrimeroLinea.Name = "btnPrimeroLinea";
            this.btnPrimeroLinea.Size = new System.Drawing.Size(71, 48);
            this.btnPrimeroLinea.TabIndex = 13;
            this.btnPrimeroLinea.UseVisualStyleBackColor = true;
            this.btnPrimeroLinea.Click += new System.EventHandler(this.btnPrimeroLinea_Click);
            // 
            // btnSiguienteLinea
            // 
            this.btnSiguienteLinea.FlatAppearance.BorderSize = 0;
            this.btnSiguienteLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguienteLinea.Image = global::KudekateaBikeShop.Properties.Resources.icons8_flecha_48;
            this.btnSiguienteLinea.Location = new System.Drawing.Point(336, 417);
            this.btnSiguienteLinea.Name = "btnSiguienteLinea";
            this.btnSiguienteLinea.Size = new System.Drawing.Size(62, 52);
            this.btnSiguienteLinea.TabIndex = 12;
            this.btnSiguienteLinea.UseVisualStyleBackColor = true;
            this.btnSiguienteLinea.Click += new System.EventHandler(this.btnSiguienteLinea_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Image = global::KudekateaBikeShop.Properties.Resources.icons8_retire_hombre_usuario_48;
            this.btnBorrar.Location = new System.Drawing.Point(764, 50);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 72);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnInforme
            // 
            this.btnInforme.FlatAppearance.BorderSize = 0;
            this.btnInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInforme.Image = global::KudekateaBikeShop.Properties.Resources.icons8_reporte_de_negocios_48;
            this.btnInforme.Location = new System.Drawing.Point(50, 56);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(75, 52);
            this.btnInforme.TabIndex = 9;
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = global::KudekateaBikeShop.Properties.Resources.icons8_guardar_48;
            this.btnGuardar.Location = new System.Drawing.Point(850, 314);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 58);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAnadir
            // 
            this.btnAnadir.FlatAppearance.BorderSize = 0;
            this.btnAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnadir.Image = global::KudekateaBikeShop.Properties.Resources.icons8_añadir_usuario_masculino_48;
            this.btnAnadir.Location = new System.Drawing.Point(600, 50);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(81, 73);
            this.btnAnadir.TabIndex = 7;
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = global::KudekateaBikeShop.Properties.Resources.icons8_editar_48;
            this.btnEditar.Location = new System.Drawing.Point(677, 52);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(81, 68);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Image = global::KudekateaBikeShop.Properties.Resources.icons8_izquierda_48;
            this.btnAnterior.Location = new System.Drawing.Point(238, 60);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(69, 53);
            this.btnAnterior.TabIndex = 5;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.FlatAppearance.BorderSize = 0;
            this.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimo.Image = global::KudekateaBikeShop.Properties.Resources.icons8_doble_derecha_48;
            this.btnUltimo.Location = new System.Drawing.Point(497, 58);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(65, 53);
            this.btnUltimo.TabIndex = 4;
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.FlatAppearance.BorderSize = 0;
            this.btnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimero.Image = global::KudekateaBikeShop.Properties.Resources.icons8_doble_izquierda_48;
            this.btnPrimero.Location = new System.Drawing.Point(143, 60);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(71, 48);
            this.btnPrimero.TabIndex = 3;
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Image = global::KudekateaBikeShop.Properties.Resources.icons8_flecha_48;
            this.btnSiguiente.Location = new System.Drawing.Point(429, 58);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(62, 52);
            this.btnSiguiente.TabIndex = 1;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // detalleVentaBindingSource
            // 
            this.detalleVentaBindingSource.DataMember = "DetalleVenta";
            this.detalleVentaBindingSource.DataSource = this.bBDDCiclismoDataSet;
            this.detalleVentaBindingSource.PositionChanged += new System.EventHandler(this.detalleVentaBindingSource_PositionChanged);
            // 
            // detalleVentaTableAdapter
            // 
            this.detalleVentaTableAdapter.ClearBeforeFill = true;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // id_empleadoComboBox
            // 
            this.id_empleadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "Id_empleado", true));
            this.id_empleadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ventaBindingSource, "Id_empleado", true));
            this.id_empleadoComboBox.DataSource = this.empleadosBindingSource;
            this.id_empleadoComboBox.DisplayMember = "Nombre";
            this.id_empleadoComboBox.FormattingEnabled = true;
            this.id_empleadoComboBox.Location = new System.Drawing.Point(251, 172);
            this.id_empleadoComboBox.Name = "id_empleadoComboBox";
            this.id_empleadoComboBox.Size = new System.Drawing.Size(201, 28);
            this.id_empleadoComboBox.TabIndex = 38;
            this.id_empleadoComboBox.ValueMember = "Id";
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
            // id_ventaLabel2
            // 
            this.id_ventaLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleVentaBindingSource, "Id_venta", true));
            this.id_ventaLabel2.Location = new System.Drawing.Point(128, 482);
            this.id_ventaLabel2.Name = "id_ventaLabel2";
            this.id_ventaLabel2.Size = new System.Drawing.Size(100, 23);
            this.id_ventaLabel2.TabIndex = 39;
            this.id_ventaLabel2.Text = "label3";
            // 
            // bicicletasBindingSource
            // 
            this.bicicletasBindingSource.DataMember = "Bicicletas";
            this.bicicletasBindingSource.DataSource = this.bBDDCiclismoDataSet;
            // 
            // bicicletasTableAdapter
            // 
            this.bicicletasTableAdapter.ClearBeforeFill = true;
            // 
            // detalleComprasBindingSource
            // 
            this.detalleComprasBindingSource.DataMember = "DetalleCompras";
            this.detalleComprasBindingSource.DataSource = this.bBDDCiclismoDataSet;
            // 
            // detalleComprasTableAdapter
            // 
            this.detalleComprasTableAdapter.ClearBeforeFill = true;
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
            this.detalleVentaDataGridView.Location = new System.Drawing.Point(0, 740);
            this.detalleVentaDataGridView.Name = "detalleVentaDataGridView";
            this.detalleVentaDataGridView.RowHeadersWidth = 62;
            this.detalleVentaDataGridView.RowTemplate.Height = 28;
            this.detalleVentaDataGridView.Size = new System.Drawing.Size(945, 220);
            this.detalleVentaDataGridView.TabIndex = 47;
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
            // id_bicicletaLabel
            // 
            id_bicicletaLabel.AutoSize = true;
            id_bicicletaLabel.Location = new System.Drawing.Point(37, 524);
            id_bicicletaLabel.Name = "id_bicicletaLabel";
            id_bicicletaLabel.Size = new System.Drawing.Size(88, 20);
            id_bicicletaLabel.TabIndex = 47;
            id_bicicletaLabel.Text = "Id bicicleta:";
            // 
            // id_bicicletaComboBox
            // 
            this.id_bicicletaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleVentaBindingSource, "Id_bicicleta", true));
            this.id_bicicletaComboBox.DataSource = this.bicicletasBindingSource;
            this.id_bicicletaComboBox.DisplayMember = "Nombre";
            this.id_bicicletaComboBox.FormattingEnabled = true;
            this.id_bicicletaComboBox.Location = new System.Drawing.Point(131, 521);
            this.id_bicicletaComboBox.Name = "id_bicicletaComboBox";
            this.id_bicicletaComboBox.Size = new System.Drawing.Size(121, 28);
            this.id_bicicletaComboBox.TabIndex = 48;
            this.id_bicicletaComboBox.SelectedIndexChanged += new System.EventHandler(this.id_bicicletaComboBox_SelectedIndexChanged);
            this.id_bicicletaComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.id_bicicletaComboBox_Validating);
            // 
            // nombre_bicicletaLabel
            // 
            nombre_bicicletaLabel.AutoSize = true;
            nombre_bicicletaLabel.Location = new System.Drawing.Point(12, 570);
            nombre_bicicletaLabel.Name = "nombre_bicicletaLabel";
            nombre_bicicletaLabel.Size = new System.Drawing.Size(130, 20);
            nombre_bicicletaLabel.TabIndex = 48;
            nombre_bicicletaLabel.Text = "Nombre bicicleta:";
            // 
            // nombre_bicicletaTextBox
            // 
            this.nombre_bicicletaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleVentaBindingSource, "Nombre_bicicleta", true));
            this.nombre_bicicletaTextBox.Location = new System.Drawing.Point(148, 567);
            this.nombre_bicicletaTextBox.Name = "nombre_bicicletaTextBox";
            this.nombre_bicicletaTextBox.Size = new System.Drawing.Size(115, 26);
            this.nombre_bicicletaTextBox.TabIndex = 49;
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Location = new System.Drawing.Point(46, 613);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(82, 20);
            categoriaLabel.TabIndex = 49;
            categoriaLabel.Text = "Categoria:";
            // 
            // categoriaTextBox
            // 
            this.categoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleVentaBindingSource, "Categoria", true));
            this.categoriaTextBox.Location = new System.Drawing.Point(134, 610);
            this.categoriaTextBox.Name = "categoriaTextBox";
            this.categoriaTextBox.Size = new System.Drawing.Size(100, 26);
            this.categoriaTextBox.TabIndex = 50;
            this.categoriaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.categoriaTextBox_Validating);
            // 
            // fabricanteLabel
            // 
            fabricanteLabel.AutoSize = true;
            fabricanteLabel.Location = new System.Drawing.Point(39, 660);
            fabricanteLabel.Name = "fabricanteLabel";
            fabricanteLabel.Size = new System.Drawing.Size(89, 20);
            fabricanteLabel.TabIndex = 50;
            fabricanteLabel.Text = "Fabricante:";
            // 
            // fabricanteTextBox
            // 
            this.fabricanteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleVentaBindingSource, "Fabricante", true));
            this.fabricanteTextBox.Location = new System.Drawing.Point(134, 657);
            this.fabricanteTextBox.Name = "fabricanteTextBox";
            this.fabricanteTextBox.Size = new System.Drawing.Size(100, 26);
            this.fabricanteTextBox.TabIndex = 51;
            this.fabricanteTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.fabricanteTextBox_Validating);
            // 
            // cantidad_vendidaLabel
            // 
            cantidad_vendidaLabel.AutoSize = true;
            cantidad_vendidaLabel.Location = new System.Drawing.Point(425, 521);
            cantidad_vendidaLabel.Name = "cantidad_vendidaLabel";
            cantidad_vendidaLabel.Size = new System.Drawing.Size(136, 20);
            cantidad_vendidaLabel.TabIndex = 51;
            cantidad_vendidaLabel.Text = "Cantidad vendida:";
            // 
            // cantidad_vendidaTextBox
            // 
            this.cantidad_vendidaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleVentaBindingSource, "Cantidad_vendida", true));
            this.cantidad_vendidaTextBox.Location = new System.Drawing.Point(567, 518);
            this.cantidad_vendidaTextBox.Name = "cantidad_vendidaTextBox";
            this.cantidad_vendidaTextBox.Size = new System.Drawing.Size(100, 26);
            this.cantidad_vendidaTextBox.TabIndex = 52;
            this.cantidad_vendidaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cantidad_vendidaTextBox_Validating);
            // 
            // precio_ventaLabel
            // 
            precio_ventaLabel.AutoSize = true;
            precio_ventaLabel.Location = new System.Drawing.Point(461, 570);
            precio_ventaLabel.Name = "precio_ventaLabel";
            precio_ventaLabel.Size = new System.Drawing.Size(100, 20);
            precio_ventaLabel.TabIndex = 52;
            precio_ventaLabel.Text = "Precio venta:";
            // 
            // precio_ventaTextBox
            // 
            this.precio_ventaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleVentaBindingSource, "Precio_venta", true));
            this.precio_ventaTextBox.Location = new System.Drawing.Point(567, 567);
            this.precio_ventaTextBox.Name = "precio_ventaTextBox";
            this.precio_ventaTextBox.Size = new System.Drawing.Size(100, 26);
            this.precio_ventaTextBox.TabIndex = 53;
            this.precio_ventaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.precio_ventaTextBox_Validating);
            // 
            // descuentoLabel
            // 
            descuentoLabel.AutoSize = true;
            descuentoLabel.Location = new System.Drawing.Point(470, 616);
            descuentoLabel.Name = "descuentoLabel";
            descuentoLabel.Size = new System.Drawing.Size(91, 20);
            descuentoLabel.TabIndex = 53;
            descuentoLabel.Text = "Descuento:";
            // 
            // descuentoTextBox
            // 
            this.descuentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleVentaBindingSource, "Descuento", true));
            this.descuentoTextBox.Location = new System.Drawing.Point(567, 613);
            this.descuentoTextBox.Name = "descuentoTextBox";
            this.descuentoTextBox.Size = new System.Drawing.Size(100, 26);
            this.descuentoTextBox.TabIndex = 54;
            this.descuentoTextBox.TextChanged += new System.EventHandler(this.descuentoTextBox_TextChanged);
            this.descuentoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.descuentoTextBox_Validating);
            // 
            // total_lineaLabel
            // 
            total_lineaLabel.AutoSize = true;
            total_lineaLabel.Location = new System.Drawing.Point(477, 660);
            total_lineaLabel.Name = "total_lineaLabel";
            total_lineaLabel.Size = new System.Drawing.Size(85, 20);
            total_lineaLabel.TabIndex = 56;
            total_lineaLabel.Text = "Total linea:";
            // 
            // total_lineaLabel1
            // 
            this.total_lineaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleVentaBindingSource, "Total_linea", true));
            this.total_lineaLabel1.Location = new System.Drawing.Point(568, 660);
            this.total_lineaLabel1.Name = "total_lineaLabel1";
            this.total_lineaLabel1.Size = new System.Drawing.Size(100, 23);
            this.total_lineaLabel1.TabIndex = 57;
            this.total_lineaLabel1.Text = "label3";
            // 
            // totalLabel1
            // 
            this.totalLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleVentaBindingSource, "Total", true));
            this.totalLabel1.Location = new System.Drawing.Point(753, 680);
            this.totalLabel1.Name = "totalLabel1";
            this.totalLabel1.Size = new System.Drawing.Size(100, 23);
            this.totalLabel1.TabIndex = 58;
            this.totalLabel1.Text = "label3";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(965, 33);
            this.menuStrip1.TabIndex = 60;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::KudekateaBikeShop.Properties.Resources.icons8_eliminar_481;
            this.btnCancelar.Location = new System.Drawing.Point(677, 317);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 48);
            this.btnCancelar.TabIndex = 62;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Image = global::KudekateaBikeShop.Properties.Resources.icons8_marca_de_verificación_48;
            this.btnAceptar.Location = new System.Drawing.Point(596, 311);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 46);
            this.btnAceptar.TabIndex = 61;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnTerminar
            // 
            this.btnTerminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTerminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTerminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTerminar.FlatAppearance.BorderSize = 0;
            this.btnTerminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerminar.Image = ((System.Drawing.Image)(resources.GetObject("btnTerminar.Image")));
            this.btnTerminar.Location = new System.Drawing.Point(867, 400);
            this.btnTerminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(58, 72);
            this.btnTerminar.TabIndex = 63;
            this.toolTip1.SetToolTip(this.btnTerminar, "Terminar con las lineas");
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 980);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
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
            this.Controls.Add(this.categoriaTextBox);
            this.Controls.Add(nombre_bicicletaLabel);
            this.Controls.Add(this.nombre_bicicletaTextBox);
            this.Controls.Add(id_bicicletaLabel);
            this.Controls.Add(this.id_bicicletaComboBox);
            this.Controls.Add(this.detalleVentaDataGridView);
            this.Controls.Add(id_ventaLabel1);
            this.Controls.Add(this.id_ventaLabel2);
            this.Controls.Add(id_empleadoLabel);
            this.Controls.Add(this.id_empleadoComboBox);
            this.Controls.Add(this.btnCancelarLinea);
            this.Controls.Add(this.btnAceptarLinea);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(id_ventaLabel);
            this.Controls.Add(this.id_ventaTextBox);
            this.Controls.Add(fecha_ventaLabel);
            this.Controls.Add(this.fecha_ventaDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBorrarLinea);
            this.Controls.Add(this.btnAnadirLinea);
            this.Controls.Add(this.btnEditarLinea);
            this.Controls.Add(this.btnAnteriorLinea);
            this.Controls.Add(this.btnUltimoLinea);
            this.Controls.Add(this.btnPrimeroLinea);
            this.Controls.Add(this.btnSiguienteLinea);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ventas_FormClosing);
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bBDDCiclismoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bicicletasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleComprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.TextBox id_ventaTextBox;
        private System.Windows.Forms.TextBox nombre_clienteTextBox;
        private System.Windows.Forms.TextBox dNI_clienteTextBox;
        private System.Windows.Forms.TextBox email_clienteTextBox;
        private System.Windows.Forms.DateTimePicker fecha_ventaDateTimePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCancelarLinea;
        private System.Windows.Forms.Button btnAceptarLinea;
        private System.Windows.Forms.BindingSource detalleVentaBindingSource;
        private BBDDCiclismoDataSetTableAdapters.DetalleVentaTableAdapter detalleVentaTableAdapter;
        private System.Windows.Forms.ComboBox id_clienteComboBox;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private BBDDCiclismoDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.ComboBox id_empleadoComboBox;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private BBDDCiclismoDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.Label id_ventaLabel2;
        private System.Windows.Forms.BindingSource bicicletasBindingSource;
        private BBDDCiclismoDataSetTableAdapters.BicicletasTableAdapter bicicletasTableAdapter;
        private System.Windows.Forms.BindingSource detalleComprasBindingSource;
        private BBDDCiclismoDataSetTableAdapters.DetalleComprasTableAdapter detalleComprasTableAdapter;
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
        private System.Windows.Forms.ComboBox id_bicicletaComboBox;
        private System.Windows.Forms.TextBox nombre_bicicletaTextBox;
        private System.Windows.Forms.TextBox categoriaTextBox;
        private System.Windows.Forms.TextBox fabricanteTextBox;
        private System.Windows.Forms.TextBox cantidad_vendidaTextBox;
        private System.Windows.Forms.TextBox precio_ventaTextBox;
        private System.Windows.Forms.TextBox descuentoTextBox;
        private System.Windows.Forms.Label total_lineaLabel1;
        private System.Windows.Forms.Label totalLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
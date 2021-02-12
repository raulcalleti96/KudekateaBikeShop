
namespace KudekateaBikeShop
{
    partial class Catalogo
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label categoriaLabel;
            System.Windows.Forms.Label fabricanteLabel;
            System.Windows.Forms.Label stockLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label fotoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalogo));
            this.label1 = new System.Windows.Forms.Label();
            this.bBDDCiclismoDataSet = new KudekateaBikeShop.BBDDCiclismoDataSet();
            this.bicicletasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bicicletasTableAdapter = new KudekateaBikeShop.BBDDCiclismoDataSetTableAdapters.BicicletasTableAdapter();
            this.tableAdapterManager = new KudekateaBikeShop.BBDDCiclismoDataSetTableAdapters.TableAdapterManager();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.fabricanteTextBox = new System.Windows.Forms.TextBox();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.buscarTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInforme = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.añadirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudatoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            categoriaLabel = new System.Windows.Forms.Label();
            fabricanteLabel = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            fotoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bBDDCiclismoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bicicletasBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(66, 303);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(32, 22);
            idLabel.TabIndex = 140;
            idLabel.Text = "Id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(51, 368);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(87, 22);
            nombreLabel.TabIndex = 141;
            nombreLabel.Text = "Nombre:";
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoriaLabel.Location = new System.Drawing.Point(28, 415);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(104, 22);
            categoriaLabel.TabIndex = 142;
            categoriaLabel.Text = "Categoría:";
            // 
            // fabricanteLabel
            // 
            fabricanteLabel.AutoSize = true;
            fabricanteLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fabricanteLabel.Location = new System.Drawing.Point(27, 469);
            fabricanteLabel.Name = "fabricanteLabel";
            fabricanteLabel.Size = new System.Drawing.Size(110, 22);
            fabricanteLabel.TabIndex = 143;
            fabricanteLabel.Text = "Fabricante:";
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stockLabel.Location = new System.Drawing.Point(66, 514);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(63, 22);
            stockLabel.TabIndex = 144;
            stockLabel.Text = "Stock:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precioLabel.Location = new System.Drawing.Point(66, 577);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(71, 22);
            precioLabel.TabIndex = 145;
            precioLabel.Text = "Precio:";
            // 
            // fotoLabel
            // 
            fotoLabel.AutoSize = true;
            fotoLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fotoLabel.Location = new System.Drawing.Point(498, 303);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(53, 22);
            fotoLabel.TabIndex = 146;
            fotoLabel.Text = "Foto:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.Location = new System.Drawing.Point(464, 552);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(121, 22);
            descripcionLabel.TabIndex = 147;
            descripcionLabel.Text = "Descripción:";
            descripcionLabel.Click += new System.EventHandler(this.descripcionLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 139;
            this.label1.Text = "Producto";
            // 
            // bBDDCiclismoDataSet
            // 
            this.bBDDCiclismoDataSet.DataSetName = "BBDDCiclismoDataSet";
            this.bBDDCiclismoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bicicletasBindingSource
            // 
            this.bicicletasBindingSource.DataMember = "Bicicletas";
            this.bicicletasBindingSource.DataSource = this.bBDDCiclismoDataSet;
            this.bicicletasBindingSource.PositionChanged += new System.EventHandler(this.bicicletasBindingSource_PositionChanged);
            // 
            // bicicletasTableAdapter
            // 
            this.bicicletasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BicicletasTableAdapter = this.bicicletasTableAdapter;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.ComprasTableAdapter = null;
            this.tableAdapterManager.DetalleComprasTableAdapter = null;
            this.tableAdapterManager.DetalleVentaTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.ProveedorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KudekateaBikeShop.BBDDCiclismoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentaTableAdapter = null;
            // 
            // idLabel1
            // 
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bicicletasBindingSource, "Id", true));
            this.idLabel1.Location = new System.Drawing.Point(99, 303);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(100, 23);
            this.idLabel1.TabIndex = 141;
            this.idLabel1.Text = "label2";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bicicletasBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(140, 363);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(164, 26);
            this.nombreTextBox.TabIndex = 142;
            this.nombreTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nombreTextBox_Validating);
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bicicletasBindingSource, "Categoria", true));
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Items.AddRange(new object[] {
            "Carretera",
            "BMX",
            "Electrica",
            "Niño"});
            this.categoriaComboBox.Location = new System.Drawing.Point(140, 415);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(164, 28);
            this.categoriaComboBox.TabIndex = 143;
            this.categoriaComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.categoriaComboBox_Validating);
            // 
            // fabricanteTextBox
            // 
            this.fabricanteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bicicletasBindingSource, "Fabricante", true));
            this.fabricanteTextBox.Location = new System.Drawing.Point(140, 465);
            this.fabricanteTextBox.Name = "fabricanteTextBox";
            this.fabricanteTextBox.Size = new System.Drawing.Size(164, 26);
            this.fabricanteTextBox.TabIndex = 144;
            this.fabricanteTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.fabricanteTextBox_Validating);
            // 
            // stockTextBox
            // 
            this.stockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bicicletasBindingSource, "Stock", true));
            this.stockTextBox.Location = new System.Drawing.Point(140, 512);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(164, 26);
            this.stockTextBox.TabIndex = 145;
            this.stockTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.stockTextBox_Validating);
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bicicletasBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(140, 575);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(164, 26);
            this.precioTextBox.TabIndex = 146;
            this.precioTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.precioTextBox_Validating);
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bicicletasBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(591, 549);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(223, 26);
            this.descripcionTextBox.TabIndex = 148;
            this.descripcionTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.descripcionTextBox_Validating);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(592, 174);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 35);
            this.btnBuscar.TabIndex = 150;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
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
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 33);
            this.menuStrip1.TabIndex = 159;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirToolStripMenuItem1,
            this.editarToolStripMenuItem1,
            this.borrarToolStripMenuItem1,
            this.guardarToolStripMenuItem1,
            this.informeToolStripMenuItem1,
            this.ayudatoolStripMenuItem1});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.opcionesToolStripMenuItem.Text = "Menu";
            this.opcionesToolStripMenuItem.Click += new System.EventHandler(this.opcionesToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAnterior);
            this.panel1.Controls.Add(this.btnUltimo);
            this.panel1.Controls.Add(this.btnPrimero);
            this.panel1.Controls.Add(this.btnSiguiente);
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 105);
            this.panel1.TabIndex = 160;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Salmon;
            this.panel2.Controls.Add(this.btnInforme);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.btnAceptar);
            this.panel2.Controls.Add(this.btnBorrar);
            this.panel2.Controls.Add(this.btnAnadir);
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Location = new System.Drawing.Point(882, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(116, 675);
            this.panel2.TabIndex = 161;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "./Kudekatea.chm";
            // 
            // buscarTextBox
            // 
            this.buscarTextBox.Location = new System.Drawing.Point(339, 174);
            this.buscarTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buscarTextBox.Name = "buscarTextBox";
            this.buscarTextBox.Size = new System.Drawing.Size(244, 26);
            this.buscarTextBox.TabIndex = 162;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Id",
            "Nombre",
            "Fabricante"});
            this.comboBox1.Location = new System.Drawing.Point(151, 174);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 28);
            this.comboBox1.TabIndex = 163;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(66, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 164;
            this.label2.Text = "Buscar:";
            // 
            // btnInforme
            // 
            this.btnInforme.FlatAppearance.BorderSize = 0;
            this.btnInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInforme.Image = global::KudekateaBikeShop.Properties.Resources.icons8_reporte_de_negocios_48;
            this.btnInforme.Location = new System.Drawing.Point(6, 15);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(87, 71);
            this.btnInforme.TabIndex = 137;
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = global::KudekateaBikeShop.Properties.Resources.icons8_guardar_48;
            this.btnGuardar.Location = new System.Drawing.Point(12, 375);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 58);
            this.btnGuardar.TabIndex = 153;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Image = global::KudekateaBikeShop.Properties.Resources.icons8_marca_de_verificación_48;
            this.btnAceptar.Location = new System.Drawing.Point(18, 451);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(69, 69);
            this.btnAceptar.TabIndex = 151;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Image = global::KudekateaBikeShop.Properties.Resources.icons8_retire_hombre_usuario_48;
            this.btnBorrar.Location = new System.Drawing.Point(18, 263);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 72);
            this.btnBorrar.TabIndex = 138;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAnadir
            // 
            this.btnAnadir.FlatAppearance.BorderSize = 0;
            this.btnAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnadir.Image = global::KudekateaBikeShop.Properties.Resources.icons8_añadir_usuario_masculino_48;
            this.btnAnadir.Location = new System.Drawing.Point(6, 92);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(81, 72);
            this.btnAnadir.TabIndex = 136;
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = global::KudekateaBikeShop.Properties.Resources.icons8_editar_48;
            this.btnEditar.Location = new System.Drawing.Point(12, 172);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(81, 68);
            this.btnEditar.TabIndex = 135;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::KudekateaBikeShop.Properties.Resources.icons8_eliminar_481;
            this.btnCancelar.Location = new System.Drawing.Point(18, 565);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 48);
            this.btnCancelar.TabIndex = 152;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Image = global::KudekateaBikeShop.Properties.Resources.icons8_izquierda_48;
            this.btnAnterior.Location = new System.Drawing.Point(260, 12);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(90, 74);
            this.btnAnterior.TabIndex = 134;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.FlatAppearance.BorderSize = 0;
            this.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimo.Image = global::KudekateaBikeShop.Properties.Resources.icons8_doble_derecha_48;
            this.btnUltimo.Location = new System.Drawing.Point(679, 12);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(82, 74);
            this.btnUltimo.TabIndex = 133;
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.FlatAppearance.BorderSize = 0;
            this.btnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimero.Image = global::KudekateaBikeShop.Properties.Resources.icons8_doble_izquierda_48;
            this.btnPrimero.Location = new System.Drawing.Point(151, 12);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(92, 75);
            this.btnPrimero.TabIndex = 132;
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Image = global::KudekateaBikeShop.Properties.Resources.icons8_flecha_48;
            this.btnSiguiente.Location = new System.Drawing.Point(543, 12);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(80, 74);
            this.btnSiguiente.TabIndex = 131;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // añadirToolStripMenuItem1
            // 
            this.añadirToolStripMenuItem1.Image = global::KudekateaBikeShop.Properties.Resources.icons8_añadir_usuario_masculino_48;
            this.añadirToolStripMenuItem1.Name = "añadirToolStripMenuItem1";
            this.añadirToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.añadirToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.añadirToolStripMenuItem1.Text = "&Añadir";
            this.añadirToolStripMenuItem1.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // editarToolStripMenuItem1
            // 
            this.editarToolStripMenuItem1.Image = global::KudekateaBikeShop.Properties.Resources.icons8_editar_48;
            this.editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            this.editarToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.editarToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.editarToolStripMenuItem1.Text = "&Editar";
            this.editarToolStripMenuItem1.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // borrarToolStripMenuItem1
            // 
            this.borrarToolStripMenuItem1.Image = global::KudekateaBikeShop.Properties.Resources.icons8_retire_hombre_usuario_48;
            this.borrarToolStripMenuItem1.Name = "borrarToolStripMenuItem1";
            this.borrarToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.borrarToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.borrarToolStripMenuItem1.Text = "&Borrar";
            this.borrarToolStripMenuItem1.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // guardarToolStripMenuItem1
            // 
            this.guardarToolStripMenuItem1.Image = global::KudekateaBikeShop.Properties.Resources.icons8_guardar_48;
            this.guardarToolStripMenuItem1.Name = "guardarToolStripMenuItem1";
            this.guardarToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.guardarToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.guardarToolStripMenuItem1.Text = "&Guardar";
            this.guardarToolStripMenuItem1.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // informeToolStripMenuItem1
            // 
            this.informeToolStripMenuItem1.Image = global::KudekateaBikeShop.Properties.Resources.icons8_reporte_de_negocios_48;
            this.informeToolStripMenuItem1.Name = "informeToolStripMenuItem1";
            this.informeToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.informeToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.informeToolStripMenuItem1.Text = "&Informe";
            this.informeToolStripMenuItem1.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // ayudatoolStripMenuItem1
            // 
            this.ayudatoolStripMenuItem1.Image = global::KudekateaBikeShop.Properties.Resources.icons8_ayuda_48;
            this.ayudatoolStripMenuItem1.Name = "ayudatoolStripMenuItem1";
            this.ayudatoolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.ayudatoolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.ayudatoolStripMenuItem1.Text = "Ayuda";
            this.ayudatoolStripMenuItem1.Click += new System.EventHandler(this.ayudatoolStripMenuItem1_Click);
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BackgroundImage = global::KudekateaBikeShop.Properties.Resources.Imagen_no_disponible_svg;
            this.fotoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bicicletasBindingSource, "Foto", true));
            this.fotoPictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("fotoPictureBox.ErrorImage")));
            this.fotoPictureBox.Image = global::KudekateaBikeShop.Properties.Resources.Imagen_no_disponible_svg;
            this.fotoPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("fotoPictureBox.InitialImage")));
            this.fotoPictureBox.Location = new System.Drawing.Point(556, 303);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(248, 206);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 147;
            this.fotoPictureBox.TabStop = false;
            this.fotoPictureBox.Click += new System.EventHandler(this.fotoPictureBox_Click);
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 678);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buscarTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(fotoLabel);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(stockLabel);
            this.Controls.Add(this.stockTextBox);
            this.Controls.Add(fabricanteLabel);
            this.Controls.Add(this.fabricanteTextBox);
            this.Controls.Add(categoriaLabel);
            this.Controls.Add(this.categoriaComboBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idLabel1);
            this.helpProvider1.SetHelpKeyword(this, "12");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Catalogo";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Catalogo_FormClosing);
            this.Load += new System.EventHandler(this.Catalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bBDDCiclismoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bicicletasBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnSiguiente;
        private BBDDCiclismoDataSet bBDDCiclismoDataSet;
        private System.Windows.Forms.BindingSource bicicletasBindingSource;
        private BBDDCiclismoDataSetTableAdapters.BicicletasTableAdapter bicicletasTableAdapter;
        private BBDDCiclismoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.ComboBox categoriaComboBox;
        private System.Windows.Forms.TextBox fabricanteTextBox;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem informeToolStripMenuItem1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox buscarTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem ayudatoolStripMenuItem1;
    }
}
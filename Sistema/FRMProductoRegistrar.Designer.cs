namespace Sistema
{
    partial class FRMProductoRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMProductoRegistrar));
            this.GBDatos = new System.Windows.Forms.GroupBox();
            this.CBCategoria = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.SWBEstado = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.TXTDescripcion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.OFDElegirImagen = new System.Windows.Forms.OpenFileDialog();
            this.BTNAbrirFoto = new DevComponents.DotNetBar.ButtonX();
            this.BTNLimpiarFoto = new DevComponents.DotNetBar.ButtonX();
            this.BTNCapturarFoto = new DevComponents.DotNetBar.ButtonX();
            this.PBPrevi = new System.Windows.Forms.PictureBox();
            this.PBCaptura = new System.Windows.Forms.PictureBox();
            this.BTNSalir = new DevComponents.DotNetBar.ButtonX();
            this.BTNLimpiar = new DevComponents.DotNetBar.ButtonX();
            this.BTNGuardar = new DevComponents.DotNetBar.ButtonX();
            this.TXTBarcode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.CBModelo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.CBGenero = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.CBNombreProducto = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.CBMarca = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.CBColor = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.CBTalla = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.IIPPrecio = new DevComponents.Editors.IntegerInput();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.IIPPrecioMin = new DevComponents.Editors.IntegerInput();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.IIPStock = new DevComponents.Editors.IntegerInput();
            this.GBDatos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBPrevi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCaptura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IIPPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IIPPrecioMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IIPStock)).BeginInit();
            this.SuspendLayout();
            // 
            // GBDatos
            // 
            this.GBDatos.Controls.Add(this.labelX4);
            this.GBDatos.Controls.Add(this.IIPStock);
            this.GBDatos.Controls.Add(this.labelX3);
            this.GBDatos.Controls.Add(this.IIPPrecioMin);
            this.GBDatos.Controls.Add(this.labelX2);
            this.GBDatos.Controls.Add(this.IIPPrecio);
            this.GBDatos.Controls.Add(this.CBTalla);
            this.GBDatos.Controls.Add(this.CBColor);
            this.GBDatos.Controls.Add(this.comboBoxEx1);
            this.GBDatos.Controls.Add(this.CBMarca);
            this.GBDatos.Controls.Add(this.CBNombreProducto);
            this.GBDatos.Controls.Add(this.CBGenero);
            this.GBDatos.Controls.Add(this.CBModelo);
            this.GBDatos.Controls.Add(this.buttonX1);
            this.GBDatos.Controls.Add(this.TXTBarcode);
            this.GBDatos.Controls.Add(this.CBCategoria);
            this.GBDatos.Controls.Add(this.SWBEstado);
            this.GBDatos.Controls.Add(this.TXTDescripcion);
            this.GBDatos.Location = new System.Drawing.Point(12, 32);
            this.GBDatos.Name = "GBDatos";
            this.GBDatos.Size = new System.Drawing.Size(282, 376);
            this.GBDatos.TabIndex = 25;
            this.GBDatos.TabStop = false;
            this.GBDatos.Text = "Datos del Producto";
            // 
            // CBCategoria
            // 
            this.CBCategoria.DisplayMember = "Text";
            this.CBCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCategoria.FormattingEnabled = true;
            this.CBCategoria.ItemHeight = 14;
            this.CBCategoria.Location = new System.Drawing.Point(6, 95);
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(252, 20);
            this.CBCategoria.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CBCategoria.TabIndex = 10;
            this.CBCategoria.WatermarkText = "Categoria";
            // 
            // SWBEstado
            // 
            // 
            // 
            // 
            this.SWBEstado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SWBEstado.Location = new System.Drawing.Point(6, 40);
            this.SWBEstado.Name = "SWBEstado";
            this.SWBEstado.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SWBEstado.OffText = "Inhabilitado";
            this.SWBEstado.OffTextColor = System.Drawing.Color.White;
            this.SWBEstado.OnBackColor = System.Drawing.Color.LimeGreen;
            this.SWBEstado.OnText = "Habilitado";
            this.SWBEstado.OnTextColor = System.Drawing.Color.White;
            this.SWBEstado.Size = new System.Drawing.Size(121, 22);
            this.SWBEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SWBEstado.TabIndex = 0;
            this.SWBEstado.TabStop = false;
            this.SWBEstado.Value = true;
            this.SWBEstado.ValueObject = "Y";
            // 
            // TXTDescripcion
            // 
            // 
            // 
            // 
            this.TXTDescripcion.Border.Class = "TextBoxBorder";
            this.TXTDescripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTDescripcion.Location = new System.Drawing.Point(6, 291);
            this.TXTDescripcion.Multiline = true;
            this.TXTDescripcion.Name = "TXTDescripcion";
            this.TXTDescripcion.PreventEnterBeep = true;
            this.TXTDescripcion.Size = new System.Drawing.Size(252, 79);
            this.TXTDescripcion.TabIndex = 9;
            this.TXTDescripcion.TabStop = false;
            this.TXTDescripcion.WatermarkText = "Descripcion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTNAbrirFoto);
            this.groupBox1.Controls.Add(this.BTNLimpiarFoto);
            this.groupBox1.Controls.Add(this.BTNCapturarFoto);
            this.groupBox1.Controls.Add(this.PBPrevi);
            this.groupBox1.Controls.Add(this.PBCaptura);
            this.groupBox1.Location = new System.Drawing.Point(311, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(294, 257);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fotografia";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(287, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 20;
            this.labelX1.Text = "Producto";
            // 
            // OFDElegirImagen
            // 
            this.OFDElegirImagen.Filter = "Elegir Imagen|*.jpeg;*.jpg;*.png";
            // 
            // BTNAbrirFoto
            // 
            this.BTNAbrirFoto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNAbrirFoto.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNAbrirFoto.Image = global::Sistema.Properties.Resources.ImgUsuarioAbrirFoto;
            this.BTNAbrirFoto.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNAbrirFoto.Location = new System.Drawing.Point(198, 207);
            this.BTNAbrirFoto.Name = "BTNAbrirFoto";
            this.BTNAbrirFoto.Size = new System.Drawing.Size(90, 41);
            this.BTNAbrirFoto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNAbrirFoto.TabIndex = 18;
            this.BTNAbrirFoto.Text = "&Abrir";
            this.BTNAbrirFoto.Click += new System.EventHandler(this.BTNAbrirFoto_Click);
            // 
            // BTNLimpiarFoto
            // 
            this.BTNLimpiarFoto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNLimpiarFoto.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNLimpiarFoto.Image = global::Sistema.Properties.Resources.ImgUsuarioLimpiarFoto;
            this.BTNLimpiarFoto.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNLimpiarFoto.Location = new System.Drawing.Point(102, 207);
            this.BTNLimpiarFoto.Name = "BTNLimpiarFoto";
            this.BTNLimpiarFoto.Size = new System.Drawing.Size(90, 41);
            this.BTNLimpiarFoto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNLimpiarFoto.TabIndex = 17;
            this.BTNLimpiarFoto.Text = "&Limpiar";
            // 
            // BTNCapturarFoto
            // 
            this.BTNCapturarFoto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNCapturarFoto.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNCapturarFoto.Image = global::Sistema.Properties.Resources.ImgUsuarioCapturar;
            this.BTNCapturarFoto.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNCapturarFoto.Location = new System.Drawing.Point(6, 207);
            this.BTNCapturarFoto.Name = "BTNCapturarFoto";
            this.BTNCapturarFoto.Size = new System.Drawing.Size(90, 41);
            this.BTNCapturarFoto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNCapturarFoto.TabIndex = 16;
            this.BTNCapturarFoto.Text = "&Capturar";
            this.BTNCapturarFoto.Click += new System.EventHandler(this.BTNCapturarFoto_Click);
            // 
            // PBPrevi
            // 
            this.PBPrevi.Image = ((System.Drawing.Image)(resources.GetObject("PBPrevi.Image")));
            this.PBPrevi.Location = new System.Drawing.Point(147, 55);
            this.PBPrevi.Name = "PBPrevi";
            this.PBPrevi.Size = new System.Drawing.Size(141, 131);
            this.PBPrevi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBPrevi.TabIndex = 1;
            this.PBPrevi.TabStop = false;
            // 
            // PBCaptura
            // 
            this.PBCaptura.Image = ((System.Drawing.Image)(resources.GetObject("PBCaptura.Image")));
            this.PBCaptura.Location = new System.Drawing.Point(6, 55);
            this.PBCaptura.Name = "PBCaptura";
            this.PBCaptura.Size = new System.Drawing.Size(135, 131);
            this.PBCaptura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBCaptura.TabIndex = 0;
            this.PBCaptura.TabStop = false;
            // 
            // BTNSalir
            // 
            this.BTNSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNSalir.Image = global::Sistema.Properties.Resources.ImgUsuarioSalir;
            this.BTNSalir.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNSalir.Location = new System.Drawing.Point(521, 363);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(84, 39);
            this.BTNSalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNSalir.TabIndex = 23;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNLimpiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNLimpiar.Image = global::Sistema.Properties.Resources.ImgUsuarioLimpiar;
            this.BTNLimpiar.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNLimpiar.Location = new System.Drawing.Point(402, 363);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(88, 39);
            this.BTNLimpiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNLimpiar.TabIndex = 22;
            this.BTNLimpiar.Text = "Limpiar";
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNGuardar.Image = global::Sistema.Properties.Resources.ImgUsuarioGuardar;
            this.BTNGuardar.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNGuardar.Location = new System.Drawing.Point(287, 363);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(90, 41);
            this.BTNGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNGuardar.TabIndex = 21;
            this.BTNGuardar.Text = "&Guardar";
            this.BTNGuardar.Click += new System.EventHandler(this.BTNGuardar_Click);
            // 
            // TXTBarcode
            // 
            // 
            // 
            // 
            this.TXTBarcode.Border.Class = "TextBoxBorder";
            this.TXTBarcode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTBarcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTBarcode.Location = new System.Drawing.Point(133, 37);
            this.TXTBarcode.Name = "TXTBarcode";
            this.TXTBarcode.PreventEnterBeep = true;
            this.TXTBarcode.Size = new System.Drawing.Size(96, 23);
            this.TXTBarcode.TabIndex = 19;
            this.TXTBarcode.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBarcode.WatermarkText = "Codigo de Barra";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = global::Sistema.Properties.Resources.iconobarcode;
            this.buttonX1.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.buttonX1.Location = new System.Drawing.Point(222, 38);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(36, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 22;
            // 
            // CBModelo
            // 
            this.CBModelo.DisplayMember = "Text";
            this.CBModelo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBModelo.FormattingEnabled = true;
            this.CBModelo.ItemHeight = 17;
            this.CBModelo.Location = new System.Drawing.Point(6, 66);
            this.CBModelo.Name = "CBModelo";
            this.CBModelo.Size = new System.Drawing.Size(121, 23);
            this.CBModelo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CBModelo.TabIndex = 23;
            this.CBModelo.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBModelo.WatermarkText = "Modelo";
            // 
            // CBGenero
            // 
            this.CBGenero.DisplayMember = "Text";
            this.CBGenero.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBGenero.FormattingEnabled = true;
            this.CBGenero.ItemHeight = 14;
            this.CBGenero.Location = new System.Drawing.Point(133, 68);
            this.CBGenero.Name = "CBGenero";
            this.CBGenero.Size = new System.Drawing.Size(125, 20);
            this.CBGenero.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CBGenero.TabIndex = 24;
            this.CBGenero.WatermarkText = "Genero";
            // 
            // CBNombreProducto
            // 
            this.CBNombreProducto.DisplayMember = "Text";
            this.CBNombreProducto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBNombreProducto.FormattingEnabled = true;
            this.CBNombreProducto.ItemHeight = 14;
            this.CBNombreProducto.Location = new System.Drawing.Point(6, 121);
            this.CBNombreProducto.Name = "CBNombreProducto";
            this.CBNombreProducto.Size = new System.Drawing.Size(252, 20);
            this.CBNombreProducto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CBNombreProducto.TabIndex = 25;
            this.CBNombreProducto.WatermarkText = "Nombre del Producto";
            // 
            // CBMarca
            // 
            this.CBMarca.DisplayMember = "Text";
            this.CBMarca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMarca.FormattingEnabled = true;
            this.CBMarca.ItemHeight = 14;
            this.CBMarca.Location = new System.Drawing.Point(6, 148);
            this.CBMarca.Name = "CBMarca";
            this.CBMarca.Size = new System.Drawing.Size(252, 20);
            this.CBMarca.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CBMarca.TabIndex = 26;
            this.CBMarca.WatermarkText = "Marca";
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 14;
            this.comboBoxEx1.Location = new System.Drawing.Point(5, 174);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(252, 20);
            this.comboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx1.TabIndex = 27;
            this.comboBoxEx1.WatermarkText = "Material";
            // 
            // CBColor
            // 
            this.CBColor.DisplayMember = "Text";
            this.CBColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBColor.FormattingEnabled = true;
            this.CBColor.ItemHeight = 14;
            this.CBColor.Location = new System.Drawing.Point(6, 200);
            this.CBColor.Name = "CBColor";
            this.CBColor.Size = new System.Drawing.Size(121, 20);
            this.CBColor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CBColor.TabIndex = 28;
            this.CBColor.WatermarkText = "Color";
            // 
            // CBTalla
            // 
            this.CBTalla.DisplayMember = "Text";
            this.CBTalla.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBTalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBTalla.FormattingEnabled = true;
            this.CBTalla.ItemHeight = 14;
            this.CBTalla.Location = new System.Drawing.Point(133, 200);
            this.CBTalla.Name = "CBTalla";
            this.CBTalla.Size = new System.Drawing.Size(121, 20);
            this.CBTalla.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CBTalla.TabIndex = 29;
            this.CBTalla.WatermarkText = "Talla";
            // 
            // IIPPrecio
            // 
            // 
            // 
            // 
            this.IIPPrecio.BackgroundStyle.Class = "DateTimeInputBackground";
            this.IIPPrecio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IIPPrecio.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.IIPPrecio.Location = new System.Drawing.Point(47, 226);
            this.IIPPrecio.Name = "IIPPrecio";
            this.IIPPrecio.ShowUpDown = true;
            this.IIPPrecio.Size = new System.Drawing.Size(80, 23);
            this.IIPPrecio.TabIndex = 30;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(7, 224);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(42, 23);
            this.labelX2.TabIndex = 31;
            this.labelX2.Text = "Precio";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(134, 226);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(42, 23);
            this.labelX3.TabIndex = 33;
            this.labelX3.Text = "Precio \r\nMin";
            // 
            // IIPPrecioMin
            // 
            // 
            // 
            // 
            this.IIPPrecioMin.BackgroundStyle.Class = "DateTimeInputBackground";
            this.IIPPrecioMin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IIPPrecioMin.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.IIPPrecioMin.Location = new System.Drawing.Point(174, 226);
            this.IIPPrecioMin.Name = "IIPPrecioMin";
            this.IIPPrecioMin.ShowUpDown = true;
            this.IIPPrecioMin.Size = new System.Drawing.Size(80, 23);
            this.IIPPrecioMin.TabIndex = 32;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(80, 251);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(42, 34);
            this.labelX4.TabIndex = 35;
            this.labelX4.Text = "Stock\r\nActual";
            // 
            // IIPStock
            // 
            // 
            // 
            // 
            this.IIPStock.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IIPStock.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.IIPStock.Location = new System.Drawing.Point(120, 256);
            this.IIPStock.Name = "IIPStock";
            this.IIPStock.ShowUpDown = true;
            this.IIPStock.Size = new System.Drawing.Size(80, 23);
            this.IIPStock.TabIndex = 34;
            // 
            // FRMProductoRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 418);
            this.Controls.Add(this.GBDatos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTNSalir);
            this.Controls.Add(this.BTNLimpiar);
            this.Controls.Add(this.BTNGuardar);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMProductoRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMProductoRegistrar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMProductoRegistrar_FormClosing);
            this.Load += new System.EventHandler(this.FRMProductoRegistrar_Load);
            this.GBDatos.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBPrevi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCaptura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IIPPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IIPPrecioMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IIPStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBDatos;
        private DevComponents.DotNetBar.Controls.SwitchButton SWBEstado;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTDescripcion;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX BTNAbrirFoto;
        private DevComponents.DotNetBar.ButtonX BTNLimpiarFoto;
        private DevComponents.DotNetBar.ButtonX BTNCapturarFoto;
        private System.Windows.Forms.PictureBox PBPrevi;
        private System.Windows.Forms.PictureBox PBCaptura;
        private DevComponents.DotNetBar.ButtonX BTNSalir;
        private DevComponents.DotNetBar.ButtonX BTNLimpiar;
        private DevComponents.DotNetBar.ButtonX BTNGuardar;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CBCategoria;
        private System.Windows.Forms.OpenFileDialog OFDElegirImagen;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTBarcode;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CBGenero;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CBModelo;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CBTalla;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CBColor;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CBMarca;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CBNombreProducto;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.Editors.IntegerInput IIPStock;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.Editors.IntegerInput IIPPrecioMin;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.Editors.IntegerInput IIPPrecio;
    }
}
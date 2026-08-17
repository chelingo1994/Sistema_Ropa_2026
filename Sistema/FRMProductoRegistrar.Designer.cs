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
            this.TXTModelo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXTStock = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXTPrecioMin = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXTPrecio = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXTalla = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SWBSexo = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.TXTMarca = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.CBCategoria = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.SWBEstado = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.TXTMaterial = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXTNombre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXTColor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXTDescripcion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTNAbrirFoto = new DevComponents.DotNetBar.ButtonX();
            this.BTNLimpiarFoto = new DevComponents.DotNetBar.ButtonX();
            this.BTNCapturarFoto = new DevComponents.DotNetBar.ButtonX();
            this.PBPrevi = new System.Windows.Forms.PictureBox();
            this.PBCaptura = new System.Windows.Forms.PictureBox();
            this.BTNSalir = new DevComponents.DotNetBar.ButtonX();
            this.BTNLimpiar = new DevComponents.DotNetBar.ButtonX();
            this.BTNGuardar = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.OFDElegirImagen = new System.Windows.Forms.OpenFileDialog();
            this.GBDatos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBPrevi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCaptura)).BeginInit();
            this.SuspendLayout();
            // 
            // GBDatos
            // 
            this.GBDatos.Controls.Add(this.TXTModelo);
            this.GBDatos.Controls.Add(this.TXTStock);
            this.GBDatos.Controls.Add(this.TXTPrecioMin);
            this.GBDatos.Controls.Add(this.TXTPrecio);
            this.GBDatos.Controls.Add(this.TXTalla);
            this.GBDatos.Controls.Add(this.SWBSexo);
            this.GBDatos.Controls.Add(this.TXTMarca);
            this.GBDatos.Controls.Add(this.CBCategoria);
            this.GBDatos.Controls.Add(this.SWBEstado);
            this.GBDatos.Controls.Add(this.TXTMaterial);
            this.GBDatos.Controls.Add(this.TXTNombre);
            this.GBDatos.Controls.Add(this.TXTColor);
            this.GBDatos.Controls.Add(this.TXTDescripcion);
            this.GBDatos.Location = new System.Drawing.Point(38, 32);
            this.GBDatos.Name = "GBDatos";
            this.GBDatos.Size = new System.Drawing.Size(273, 330);
            this.GBDatos.TabIndex = 25;
            this.GBDatos.TabStop = false;
            this.GBDatos.Text = "Datos del Producto";
            // 
            // TXTModelo
            // 
            // 
            // 
            // 
            this.TXTModelo.Border.Class = "TextBoxBorder";
            this.TXTModelo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTModelo.Location = new System.Drawing.Point(155, 96);
            this.TXTModelo.Name = "TXTModelo";
            this.TXTModelo.PreventEnterBeep = true;
            this.TXTModelo.Size = new System.Drawing.Size(103, 23);
            this.TXTModelo.TabIndex = 17;
            this.TXTModelo.WatermarkText = "Modelo";
            this.TXTModelo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTModelo_KeyDown);
            // 
            // TXTStock
            // 
            // 
            // 
            // 
            this.TXTStock.Border.Class = "TextBoxBorder";
            this.TXTStock.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTStock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTStock.Location = new System.Drawing.Point(80, 210);
            this.TXTStock.Name = "TXTStock";
            this.TXTStock.PreventEnterBeep = true;
            this.TXTStock.Size = new System.Drawing.Size(103, 23);
            this.TXTStock.TabIndex = 16;
            this.TXTStock.WatermarkText = "Stock";
            this.TXTStock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTStock_KeyDown);
            // 
            // TXTPrecioMin
            // 
            // 
            // 
            // 
            this.TXTPrecioMin.Border.Class = "TextBoxBorder";
            this.TXTPrecioMin.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTPrecioMin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTPrecioMin.Location = new System.Drawing.Point(155, 184);
            this.TXTPrecioMin.Name = "TXTPrecioMin";
            this.TXTPrecioMin.PreventEnterBeep = true;
            this.TXTPrecioMin.Size = new System.Drawing.Size(103, 23);
            this.TXTPrecioMin.TabIndex = 15;
            this.TXTPrecioMin.WatermarkText = "Precio Min";
            this.TXTPrecioMin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTPrecioMin_KeyDown);
            // 
            // TXTPrecio
            // 
            // 
            // 
            // 
            this.TXTPrecio.Border.Class = "TextBoxBorder";
            this.TXTPrecio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTPrecio.Location = new System.Drawing.Point(6, 184);
            this.TXTPrecio.Name = "TXTPrecio";
            this.TXTPrecio.PreventEnterBeep = true;
            this.TXTPrecio.Size = new System.Drawing.Size(103, 23);
            this.TXTPrecio.TabIndex = 14;
            this.TXTPrecio.WatermarkText = "Precio";
            this.TXTPrecio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTPrecio_KeyDown);
            // 
            // TXTalla
            // 
            // 
            // 
            // 
            this.TXTalla.Border.Class = "TextBoxBorder";
            this.TXTalla.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTalla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTalla.Location = new System.Drawing.Point(6, 96);
            this.TXTalla.Name = "TXTalla";
            this.TXTalla.PreventEnterBeep = true;
            this.TXTalla.Size = new System.Drawing.Size(103, 23);
            this.TXTalla.TabIndex = 13;
            this.TXTalla.WatermarkText = "Talla";
            this.TXTalla.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTalla_KeyDown);
            // 
            // SWBSexo
            // 
            // 
            // 
            // 
            this.SWBSexo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SWBSexo.Location = new System.Drawing.Point(155, 40);
            this.SWBSexo.Name = "SWBSexo";
            this.SWBSexo.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SWBSexo.OffText = "Femenino";
            this.SWBSexo.OffTextColor = System.Drawing.Color.White;
            this.SWBSexo.OnBackColor = System.Drawing.Color.RoyalBlue;
            this.SWBSexo.OnText = "Masculino";
            this.SWBSexo.OnTextColor = System.Drawing.Color.White;
            this.SWBSexo.Size = new System.Drawing.Size(103, 22);
            this.SWBSexo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SWBSexo.TabIndex = 12;
            this.SWBSexo.Value = true;
            this.SWBSexo.ValueObject = "Y";
            // 
            // TXTMarca
            // 
            // 
            // 
            // 
            this.TXTMarca.Border.Class = "TextBoxBorder";
            this.TXTMarca.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTMarca.Location = new System.Drawing.Point(155, 68);
            this.TXTMarca.Name = "TXTMarca";
            this.TXTMarca.PreventEnterBeep = true;
            this.TXTMarca.Size = new System.Drawing.Size(103, 23);
            this.TXTMarca.TabIndex = 11;
            this.TXTMarca.WatermarkText = "Marca";
            this.TXTMarca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTMarca_KeyDown);
            // 
            // CBCategoria
            // 
            this.CBCategoria.DisplayMember = "Text";
            this.CBCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCategoria.FormattingEnabled = true;
            this.CBCategoria.ItemHeight = 14;
            this.CBCategoria.Location = new System.Drawing.Point(6, 71);
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(103, 20);
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
            this.SWBEstado.Size = new System.Drawing.Size(103, 22);
            this.SWBEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SWBEstado.TabIndex = 0;
            this.SWBEstado.TabStop = false;
            this.SWBEstado.Value = true;
            this.SWBEstado.ValueObject = "Y";
            // 
            // TXTMaterial
            // 
            // 
            // 
            // 
            this.TXTMaterial.Border.Class = "TextBoxBorder";
            this.TXTMaterial.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTMaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTMaterial.Location = new System.Drawing.Point(155, 154);
            this.TXTMaterial.Name = "TXTMaterial";
            this.TXTMaterial.PreventEnterBeep = true;
            this.TXTMaterial.Size = new System.Drawing.Size(103, 23);
            this.TXTMaterial.TabIndex = 5;
            this.TXTMaterial.WatermarkText = "Material";
            this.TXTMaterial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTMaterial_KeyDown);
            // 
            // TXTNombre
            // 
            // 
            // 
            // 
            this.TXTNombre.Border.Class = "TextBoxBorder";
            this.TXTNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTNombre.Location = new System.Drawing.Point(6, 125);
            this.TXTNombre.Name = "TXTNombre";
            this.TXTNombre.PreventEnterBeep = true;
            this.TXTNombre.Size = new System.Drawing.Size(252, 23);
            this.TXTNombre.TabIndex = 6;
            this.TXTNombre.WatermarkText = "Nombre";
            this.TXTNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTNombre_KeyDown);
            // 
            // TXTColor
            // 
            // 
            // 
            // 
            this.TXTColor.Border.Class = "TextBoxBorder";
            this.TXTColor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTColor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTColor.Location = new System.Drawing.Point(6, 154);
            this.TXTColor.Name = "TXTColor";
            this.TXTColor.PreventEnterBeep = true;
            this.TXTColor.Size = new System.Drawing.Size(103, 23);
            this.TXTColor.TabIndex = 4;
            this.TXTColor.WatermarkText = "Color";
            this.TXTColor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTColor_KeyDown);
            // 
            // TXTDescripcion
            // 
            // 
            // 
            // 
            this.TXTDescripcion.Border.Class = "TextBoxBorder";
            this.TXTDescripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTDescripcion.Location = new System.Drawing.Point(6, 239);
            this.TXTDescripcion.Multiline = true;
            this.TXTDescripcion.Name = "TXTDescripcion";
            this.TXTDescripcion.PreventEnterBeep = true;
            this.TXTDescripcion.Size = new System.Drawing.Size(252, 91);
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
            this.BTNSalir.Location = new System.Drawing.Point(393, 368);
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
            this.BTNLimpiar.Location = new System.Drawing.Point(253, 368);
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
            this.BTNGuardar.Location = new System.Drawing.Point(118, 368);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(90, 41);
            this.BTNGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNGuardar.TabIndex = 21;
            this.BTNGuardar.Text = "&Guardar";
            this.BTNGuardar.Click += new System.EventHandler(this.BTNGuardar_Click);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBDatos;
        private DevComponents.DotNetBar.Controls.SwitchButton SWBEstado;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTMaterial;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTNombre;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTColor;
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
        private DevComponents.DotNetBar.Controls.TextBoxX TXTMarca;
        private DevComponents.DotNetBar.Controls.SwitchButton SWBSexo;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTalla;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTStock;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTPrecioMin;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTPrecio;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTModelo;
        private System.Windows.Forms.OpenFileDialog OFDElegirImagen;
    }
}
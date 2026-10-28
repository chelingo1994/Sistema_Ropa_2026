namespace Sistema
{
    partial class FRMVenta_Registrar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMVenta_Registrar));
            this.DIPPrecio = new DevComponents.Editors.DoubleInput();
            this.LBLCodigoDeBarras = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.IIPStock = new DevComponents.Editors.IntegerInput();
            this.label23 = new DevComponents.DotNetBar.LabelX();
            this.SWBEstado = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.TXTNitCi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXTNombreCliente = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.DTGLista = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMSMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TXTDescripcion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.LBTotal = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.LBTotalLiteral = new DevComponents.DotNetBar.LabelX();
            this.BTNLimpiarProducto = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.BTNLimpiar = new DevComponents.DotNetBar.ButtonX();
            this.BTNGuardar = new DevComponents.DotNetBar.ButtonX();
            this.btn_buscar_producto = new DevComponents.DotNetBar.ButtonX();
            this.BTNModificar = new DevComponents.DotNetBar.ButtonX();
            this.BTNSalir = new DevComponents.DotNetBar.ButtonX();
            this.PBCaptura = new System.Windows.Forms.PictureBox();
            this.BTNBuscar = new DevComponents.DotNetBar.ButtonX();
            this.BTNCodigoDeBarras = new DevComponents.DotNetBar.ButtonX();
            this.TXTObservaciones = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.DIPPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IIPStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGLista)).BeginInit();
            this.CMSMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBCaptura)).BeginInit();
            this.SuspendLayout();
            // 
            // DIPPrecio
            // 
            // 
            // 
            // 
            this.DIPPrecio.BackgroundStyle.Class = "DateTimeInputBackground";
            this.DIPPrecio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DIPPrecio.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.DIPPrecio.Increment = 1D;
            this.DIPPrecio.Location = new System.Drawing.Point(568, 126);
            this.DIPPrecio.Name = "DIPPrecio";
            this.DIPPrecio.ShowUpDown = true;
            this.DIPPrecio.Size = new System.Drawing.Size(80, 23);
            this.DIPPrecio.TabIndex = 44;
            // 
            // LBLCodigoDeBarras
            // 
            this.LBLCodigoDeBarras.BackColor = System.Drawing.Color.Chartreuse;
            // 
            // 
            // 
            this.LBLCodigoDeBarras.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBLCodigoDeBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLCodigoDeBarras.Location = new System.Drawing.Point(94, 69);
            this.LBLCodigoDeBarras.Name = "LBLCodigoDeBarras";
            this.LBLCodigoDeBarras.Size = new System.Drawing.Size(95, 23);
            this.LBLCodigoDeBarras.TabIndex = 43;
            this.LBLCodigoDeBarras.Text = "NO CODIGO ";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(520, 86);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(42, 34);
            this.labelX4.TabIndex = 42;
            this.labelX4.Text = "Stock\r\nActual";
            // 
            // IIPStock
            // 
            // 
            // 
            // 
            this.IIPStock.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IIPStock.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.IIPStock.Location = new System.Drawing.Point(568, 97);
            this.IIPStock.Name = "IIPStock";
            this.IIPStock.ShowUpDown = true;
            this.IIPStock.Size = new System.Drawing.Size(80, 23);
            this.IIPStock.TabIndex = 41;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.label23.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label23.Location = new System.Drawing.Point(520, 125);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(42, 23);
            this.label23.TabIndex = 40;
            this.label23.Text = "Precio";
            // 
            // SWBEstado
            // 
            // 
            // 
            // 
            this.SWBEstado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SWBEstado.Location = new System.Drawing.Point(6, 15);
            this.SWBEstado.Name = "SWBEstado";
            this.SWBEstado.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SWBEstado.OffText = "Inhabilitado";
            this.SWBEstado.OffTextColor = System.Drawing.Color.White;
            this.SWBEstado.OnBackColor = System.Drawing.Color.LimeGreen;
            this.SWBEstado.OnText = "Habilitado";
            this.SWBEstado.OnTextColor = System.Drawing.Color.White;
            this.SWBEstado.Size = new System.Drawing.Size(121, 22);
            this.SWBEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SWBEstado.TabIndex = 38;
            this.SWBEstado.TabStop = false;
            this.SWBEstado.Value = true;
            this.SWBEstado.ValueObject = "Y";
            // 
            // TXTNitCi
            // 
            // 
            // 
            // 
            this.TXTNitCi.Border.Class = "TextBoxBorder";
            this.TXTNitCi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTNitCi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTNitCi.Location = new System.Drawing.Point(133, 14);
            this.TXTNitCi.Name = "TXTNitCi";
            this.TXTNitCi.PreventEnterBeep = true;
            this.TXTNitCi.Size = new System.Drawing.Size(156, 23);
            this.TXTNitCi.TabIndex = 46;
            this.TXTNitCi.WatermarkText = "Nit / Ci";
            this.TXTNitCi.Leave += new System.EventHandler(this.TXTNitCi_Leave);
            // 
            // TXTNombreCliente
            // 
            // 
            // 
            // 
            this.TXTNombreCliente.Border.Class = "TextBoxBorder";
            this.TXTNombreCliente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTNombreCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTNombreCliente.Location = new System.Drawing.Point(295, 14);
            this.TXTNombreCliente.Name = "TXTNombreCliente";
            this.TXTNombreCliente.PreventEnterBeep = true;
            this.TXTNombreCliente.ReadOnly = true;
            this.TXTNombreCliente.Size = new System.Drawing.Size(233, 23);
            this.TXTNombreCliente.TabIndex = 45;
            this.TXTNombreCliente.WatermarkText = "Razon Social / Nombre";
            // 
            // DTGLista
            // 
            this.DTGLista.AllowUserToAddRows = false;
            this.DTGLista.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTGLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DTGLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column5,
            this.Column2,
            this.Column9,
            this.Column3,
            this.Column1,
            this.Column4,
            this.Column6,
            this.Column8});
            this.DTGLista.ContextMenuStrip = this.CMSMenu;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTGLista.DefaultCellStyle = dataGridViewCellStyle3;
            this.DTGLista.EnableHeadersVisualStyles = false;
            this.DTGLista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DTGLista.Location = new System.Drawing.Point(6, 172);
            this.DTGLista.Margin = new System.Windows.Forms.Padding(4);
            this.DTGLista.MultiSelect = false;
            this.DTGLista.Name = "DTGLista";
            this.DTGLista.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTGLista.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DTGLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTGLista.Size = new System.Drawing.Size(737, 225);
            this.DTGLista.TabIndex = 51;
            this.DTGLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGLista_CellDoubleClick);
            this.DTGLista.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DTGLista_KeyDown);
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Codigo Producto";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            this.Column7.Width = 80;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Modelo";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "CB";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Producto";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Talla";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Descripcion";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Precio";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            // 
            // Column8
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column8.HeaderText = "Subtotal";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 80;
            // 
            // CMSMenu
            // 
            this.CMSMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.CMSMenu.Name = "CMSMenu";
            this.CMSMenu.Size = new System.Drawing.Size(126, 48);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "&Modificar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.eliminarToolStripMenuItem.Text = "&Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // TXTDescripcion
            // 
            // 
            // 
            // 
            this.TXTDescripcion.Border.Class = "TextBoxBorder";
            this.TXTDescripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTDescripcion.Enabled = false;
            this.TXTDescripcion.Location = new System.Drawing.Point(90, 97);
            this.TXTDescripcion.Multiline = true;
            this.TXTDescripcion.Name = "TXTDescripcion";
            this.TXTDescripcion.PreventEnterBeep = true;
            this.TXTDescripcion.Size = new System.Drawing.Size(424, 44);
            this.TXTDescripcion.TabIndex = 55;
            this.TXTDescripcion.WatermarkText = "Descripcion del Producto";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(324, 152);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(96, 20);
            this.labelX1.TabIndex = 57;
            this.labelX1.Text = "Detalle Venta";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(381, 43);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(96, 20);
            this.labelX3.TabIndex = 58;
            this.labelX3.Text = "Producto";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(520, 397);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(104, 23);
            this.labelX5.TabIndex = 64;
            this.labelX5.Text = "TOTAL Bs";
            // 
            // LBTotal
            // 
            // 
            // 
            // 
            this.LBTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTotal.Location = new System.Drawing.Point(630, 397);
            this.LBTotal.Name = "LBTotal";
            this.LBTotal.Size = new System.Drawing.Size(95, 23);
            this.LBTotal.TabIndex = 65;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(6, 397);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(49, 23);
            this.labelX6.TabIndex = 66;
            this.labelX6.Text = "Son:";
            // 
            // LBTotalLiteral
            // 
            // 
            // 
            // 
            this.LBTotalLiteral.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBTotalLiteral.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTotalLiteral.Location = new System.Drawing.Point(52, 397);
            this.LBTotalLiteral.Name = "LBTotalLiteral";
            this.LBTotalLiteral.Size = new System.Drawing.Size(462, 23);
            this.LBTotalLiteral.TabIndex = 67;
            // 
            // BTNLimpiarProducto
            // 
            this.BTNLimpiarProducto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNLimpiarProducto.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNLimpiarProducto.Image = global::Sistema.Properties.Resources.borrador;
            this.BTNLimpiarProducto.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNLimpiarProducto.Location = new System.Drawing.Point(654, 121);
            this.BTNLimpiarProducto.Name = "BTNLimpiarProducto";
            this.BTNLimpiarProducto.Size = new System.Drawing.Size(94, 31);
            this.BTNLimpiarProducto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNLimpiarProducto.TabIndex = 69;
            this.BTNLimpiarProducto.Text = "Limpiar";
            this.BTNLimpiarProducto.Click += new System.EventHandler(this.BTNLimpiarProducto_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonX2.Image = global::Sistema.Properties.Resources.ImgUsuarioSalir;
            this.buttonX2.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.buttonX2.Location = new System.Drawing.Point(654, 428);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(95, 37);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 63;
            this.buttonX2.Text = "Salir";
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNLimpiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNLimpiar.Image = global::Sistema.Properties.Resources.ImgUsuarioLimpiar;
            this.BTNLimpiar.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNLimpiar.Location = new System.Drawing.Point(560, 426);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(88, 39);
            this.BTNLimpiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNLimpiar.TabIndex = 62;
            this.BTNLimpiar.Text = "Limpiar";
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNGuardar.Image = global::Sistema.Properties.Resources.ImgUsuarioGuardar;
            this.BTNGuardar.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNGuardar.Location = new System.Drawing.Point(464, 426);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(90, 41);
            this.BTNGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNGuardar.TabIndex = 61;
            this.BTNGuardar.Text = "&Guardar";
            this.BTNGuardar.Click += new System.EventHandler(this.BTNGuardar_Click);
            // 
            // btn_buscar_producto
            // 
            this.btn_buscar_producto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_buscar_producto.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_buscar_producto.Image = global::Sistema.Properties.Resources.iconos_buscar_producto;
            this.btn_buscar_producto.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btn_buscar_producto.Location = new System.Drawing.Point(237, 66);
            this.btn_buscar_producto.Name = "btn_buscar_producto";
            this.btn_buscar_producto.Size = new System.Drawing.Size(36, 23);
            this.btn_buscar_producto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_buscar_producto.TabIndex = 59;
            this.btn_buscar_producto.Click += new System.EventHandler(this.btn_buscar_producto_Click);
            // 
            // BTNModificar
            // 
            this.BTNModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNModificar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNModificar.Image = global::Sistema.Properties.Resources.imgproductoeditar;
            this.BTNModificar.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNModificar.Location = new System.Drawing.Point(654, 86);
            this.BTNModificar.Name = "BTNModificar";
            this.BTNModificar.Size = new System.Drawing.Size(94, 34);
            this.BTNModificar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNModificar.TabIndex = 56;
            this.BTNModificar.Text = "Modificar";
            this.BTNModificar.Click += new System.EventHandler(this.BTNModificar_Click);
            // 
            // BTNSalir
            // 
            this.BTNSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNSalir.Image = global::Sistema.Properties.Resources.ImgUsuarioSalir;
            this.BTNSalir.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNSalir.Location = new System.Drawing.Point(759, 381);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(33, 10);
            this.BTNSalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNSalir.TabIndex = 54;
            this.BTNSalir.Text = "Salir";
            // 
            // PBCaptura
            // 
            this.PBCaptura.Image = ((System.Drawing.Image)(resources.GetObject("PBCaptura.Image")));
            this.PBCaptura.Location = new System.Drawing.Point(6, 66);
            this.PBCaptura.Name = "PBCaptura";
            this.PBCaptura.Size = new System.Drawing.Size(84, 75);
            this.PBCaptura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBCaptura.TabIndex = 53;
            this.PBCaptura.TabStop = false;
            // 
            // BTNBuscar
            // 
            this.BTNBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNBuscar.Image = global::Sistema.Properties.Resources.ImgUsuarioBuscar;
            this.BTNBuscar.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BTNBuscar.Location = new System.Drawing.Point(534, 14);
            this.BTNBuscar.Name = "BTNBuscar";
            this.BTNBuscar.Size = new System.Drawing.Size(32, 23);
            this.BTNBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNBuscar.TabIndex = 52;
            this.BTNBuscar.Click += new System.EventHandler(this.BTNBuscar_Click);
            // 
            // BTNCodigoDeBarras
            // 
            this.BTNCodigoDeBarras.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNCodigoDeBarras.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNCodigoDeBarras.Image = global::Sistema.Properties.Resources.iconobarcode;
            this.BTNCodigoDeBarras.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.BTNCodigoDeBarras.Location = new System.Drawing.Point(195, 66);
            this.BTNCodigoDeBarras.Name = "BTNCodigoDeBarras";
            this.BTNCodigoDeBarras.Size = new System.Drawing.Size(36, 23);
            this.BTNCodigoDeBarras.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNCodigoDeBarras.TabIndex = 39;
            this.BTNCodigoDeBarras.Click += new System.EventHandler(this.BTNCodigoDeBarras_Click);
            this.BTNCodigoDeBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BTNCodigoDeBarras_KeyPress);
            this.BTNCodigoDeBarras.Leave += new System.EventHandler(this.BTNCodigoDeBarras_Leave);
            // 
            // TXTObservaciones
            // 
            // 
            // 
            // 
            this.TXTObservaciones.Border.Class = "TextBoxBorder";
            this.TXTObservaciones.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTObservaciones.Location = new System.Drawing.Point(6, 423);
            this.TXTObservaciones.Multiline = true;
            this.TXTObservaciones.Name = "TXTObservaciones";
            this.TXTObservaciones.PreventEnterBeep = true;
            this.TXTObservaciones.Size = new System.Drawing.Size(424, 44);
            this.TXTObservaciones.TabIndex = 71;
            this.TXTObservaciones.WatermarkText = "Observaciones de la Venta";
            // 
            // FRMVenta_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 465);
            this.Controls.Add(this.TXTObservaciones);
            this.Controls.Add(this.BTNLimpiarProducto);
            this.Controls.Add(this.LBTotalLiteral);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.LBTotal);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.BTNLimpiar);
            this.Controls.Add(this.BTNGuardar);
            this.Controls.Add(this.btn_buscar_producto);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.BTNModificar);
            this.Controls.Add(this.TXTDescripcion);
            this.Controls.Add(this.BTNSalir);
            this.Controls.Add(this.PBCaptura);
            this.Controls.Add(this.BTNBuscar);
            this.Controls.Add(this.DTGLista);
            this.Controls.Add(this.TXTNitCi);
            this.Controls.Add(this.TXTNombreCliente);
            this.Controls.Add(this.DIPPrecio);
            this.Controls.Add(this.LBLCodigoDeBarras);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.IIPStock);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.BTNCodigoDeBarras);
            this.Controls.Add(this.SWBEstado);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMVenta_Registrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMVenta_Registrar";
            this.Load += new System.EventHandler(this.FRMVenta_Registrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DIPPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IIPStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGLista)).EndInit();
            this.CMSMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBCaptura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.Editors.DoubleInput DIPPrecio;
        private DevComponents.DotNetBar.LabelX LBLCodigoDeBarras;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.Editors.IntegerInput IIPStock;
        private DevComponents.DotNetBar.LabelX label23;
        private DevComponents.DotNetBar.ButtonX BTNCodigoDeBarras;
        private DevComponents.DotNetBar.Controls.SwitchButton SWBEstado;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTNitCi;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTNombreCliente;
        private DevComponents.DotNetBar.Controls.DataGridViewX DTGLista;
        private DevComponents.DotNetBar.ButtonX BTNBuscar;
        private DevComponents.DotNetBar.ButtonX BTNSalir;
        private System.Windows.Forms.PictureBox PBCaptura;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTDescripcion;
        private DevComponents.DotNetBar.ButtonX BTNModificar;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private DevComponents.DotNetBar.ButtonX btn_buscar_producto;
        private System.Windows.Forms.ContextMenuStrip CMSMenu;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX BTNLimpiar;
        private DevComponents.DotNetBar.ButtonX BTNGuardar;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX LBTotal;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX LBTotalLiteral;
        private DevComponents.DotNetBar.ButtonX BTNLimpiarProducto;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTObservaciones;
    }
}
namespace Sistema
{
    partial class FRM_Persona_Registrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Persona_Registrar));
            this.SWBEstado = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.SWBSexo = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.DTINacimiento = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.TXTApMa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXTNombre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXTCelular = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXTCorreo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXTDireccion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXTCi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXTApPa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTNAbrirFoto = new DevComponents.DotNetBar.ButtonX();
            this.BTNLimpiarFoto = new DevComponents.DotNetBar.ButtonX();
            this.BTNCapturarFoto = new DevComponents.DotNetBar.ButtonX();
            this.PBPrevi = new System.Windows.Forms.PictureBox();
            this.PBCaptura = new System.Windows.Forms.PictureBox();
            this.GBDatos = new System.Windows.Forms.GroupBox();
            this.BLTAyuda = new DevComponents.DotNetBar.BalloonTip();
            this.OFDElegirImagen = new System.Windows.Forms.OpenFileDialog();
            this.BTNGuardar = new DevComponents.DotNetBar.ButtonX();
            this.BTNSalir = new DevComponents.DotNetBar.ButtonX();
            this.BTNLimpiar = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.DTINacimiento)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBPrevi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCaptura)).BeginInit();
            this.GBDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // SWBEstado
            // 
            // 
            // 
            // 
            this.SWBEstado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.BLTAyuda.SetBalloonCaption(this.SWBEstado, "Ayuda");
            this.BLTAyuda.SetBalloonText(this.SWBEstado, "Estado de la Persona");
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
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(267, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "Persona";
            // 
            // SWBSexo
            // 
            // 
            // 
            // 
            this.SWBSexo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.BLTAyuda.SetBalloonCaption(this.SWBSexo, "Ayuda");
            this.BLTAyuda.SetBalloonText(this.SWBSexo, "Sexo de la Persona");
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
            this.SWBSexo.TabIndex = 1;
            this.SWBSexo.Value = true;
            this.SWBSexo.ValueObject = "Y";
            // 
            // DTINacimiento
            // 
            // 
            // 
            // 
            this.DTINacimiento.BackgroundStyle.Class = "DateTimeInputBackground";
            this.DTINacimiento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.BLTAyuda.SetBalloonCaption(this.DTINacimiento, "Ayuda");
            this.BLTAyuda.SetBalloonText(this.DTINacimiento, "Fecha de Nacimiento de la persona");
            this.DTINacimiento.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.DTINacimiento.ButtonDropDown.Visible = true;
            this.DTINacimiento.IsPopupCalendarOpen = false;
            this.DTINacimiento.Location = new System.Drawing.Point(155, 80);
            // 
            // 
            // 
            // 
            // 
            // 
            this.DTINacimiento.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTINacimiento.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.DTINacimiento.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.DTINacimiento.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.DTINacimiento.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.DTINacimiento.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.DTINacimiento.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.DTINacimiento.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.DTINacimiento.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.DTINacimiento.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTINacimiento.MonthCalendar.DisplayMonth = new System.DateTime(2026, 5, 1, 0, 0, 0, 0);
            this.DTINacimiento.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.DTINacimiento.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.DTINacimiento.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.DTINacimiento.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.DTINacimiento.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTINacimiento.MonthCalendar.TodayButtonVisible = true;
            this.DTINacimiento.Name = "DTINacimiento";
            this.DTINacimiento.Size = new System.Drawing.Size(103, 20);
            this.DTINacimiento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.DTINacimiento.TabIndex = 3;
            this.DTINacimiento.WatermarkText = "Nacimiento";
            // 
            // TXTApMa
            // 
            this.BLTAyuda.SetBalloonCaption(this.TXTApMa, "Ayuda");
            this.BLTAyuda.SetBalloonText(this.TXTApMa, "Apellido Materno de la Persona");
            // 
            // 
            // 
            this.TXTApMa.Border.Class = "TextBoxBorder";
            this.TXTApMa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTApMa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTApMa.Location = new System.Drawing.Point(155, 116);
            this.TXTApMa.Name = "TXTApMa";
            this.TXTApMa.PreventEnterBeep = true;
            this.TXTApMa.Size = new System.Drawing.Size(103, 20);
            this.TXTApMa.TabIndex = 5;
            this.TXTApMa.WatermarkText = "Apellido Materno";
            this.TXTApMa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTApMa_KeyDown);
            // 
            // TXTNombre
            // 
            this.BLTAyuda.SetBalloonCaption(this.TXTNombre, "Ayuda");
            this.BLTAyuda.SetBalloonText(this.TXTNombre, "Nombres de la Persona");
            // 
            // 
            // 
            this.TXTNombre.Border.Class = "TextBoxBorder";
            this.TXTNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTNombre.Location = new System.Drawing.Point(6, 153);
            this.TXTNombre.Name = "TXTNombre";
            this.TXTNombre.PreventEnterBeep = true;
            this.TXTNombre.Size = new System.Drawing.Size(252, 20);
            this.TXTNombre.TabIndex = 6;
            this.TXTNombre.WatermarkText = "Nombres";
            this.TXTNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTNombre_KeyDown);
            // 
            // TXTCelular
            // 
            this.BLTAyuda.SetBalloonCaption(this.TXTCelular, "Ayuda");
            this.BLTAyuda.SetBalloonText(this.TXTCelular, "Celular de la Persona");
            // 
            // 
            // 
            this.TXTCelular.Border.Class = "TextBoxBorder";
            this.TXTCelular.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTCelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTCelular.Location = new System.Drawing.Point(6, 183);
            this.TXTCelular.Name = "TXTCelular";
            this.TXTCelular.PreventEnterBeep = true;
            this.TXTCelular.Size = new System.Drawing.Size(103, 20);
            this.TXTCelular.TabIndex = 7;
            this.TXTCelular.WatermarkText = "Celular";
            this.TXTCelular.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTCelular_KeyDown);
            // 
            // TXTCorreo
            // 
            this.BLTAyuda.SetBalloonCaption(this.TXTCorreo, "Ayuda");
            this.BLTAyuda.SetBalloonText(this.TXTCorreo, "Correo Electronico de la Persona");
            // 
            // 
            // 
            this.TXTCorreo.Border.Class = "TextBoxBorder";
            this.TXTCorreo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTCorreo.Location = new System.Drawing.Point(155, 183);
            this.TXTCorreo.Name = "TXTCorreo";
            this.TXTCorreo.PreventEnterBeep = true;
            this.TXTCorreo.Size = new System.Drawing.Size(103, 20);
            this.TXTCorreo.TabIndex = 8;
            this.TXTCorreo.WatermarkText = "Correo";
            this.TXTCorreo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTCorreo_KeyDown);
            // 
            // TXTDireccion
            // 
            this.BLTAyuda.SetBalloonCaption(this.TXTDireccion, "Ayuda");
            this.BLTAyuda.SetBalloonText(this.TXTDireccion, "Direccion de la Persona");
            // 
            // 
            // 
            this.TXTDireccion.Border.Class = "TextBoxBorder";
            this.TXTDireccion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTDireccion.Location = new System.Drawing.Point(6, 223);
            this.TXTDireccion.Multiline = true;
            this.TXTDireccion.Name = "TXTDireccion";
            this.TXTDireccion.PreventEnterBeep = true;
            this.TXTDireccion.Size = new System.Drawing.Size(252, 86);
            this.TXTDireccion.TabIndex = 9;
            this.TXTDireccion.TabStop = false;
            this.TXTDireccion.WatermarkText = "Direccion";
            // 
            // TXTCi
            // 
            this.BLTAyuda.SetBalloonCaption(this.TXTCi, "Ayuda");
            this.BLTAyuda.SetBalloonText(this.TXTCi, "Numero de Documento de Identidad de la Persona");
            // 
            // 
            // 
            this.TXTCi.Border.Class = "TextBoxBorder";
            this.TXTCi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTCi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTCi.Location = new System.Drawing.Point(6, 80);
            this.TXTCi.Name = "TXTCi";
            this.TXTCi.PreventEnterBeep = true;
            this.TXTCi.Size = new System.Drawing.Size(103, 20);
            this.TXTCi.TabIndex = 2;
            this.TXTCi.WatermarkText = "CI";
            this.TXTCi.Enter += new System.EventHandler(this.TXTCi_Enter);
            this.TXTCi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTCi_KeyDown);
            // 
            // TXTApPa
            // 
            this.BLTAyuda.SetBalloonCaption(this.TXTApPa, "Ayuda");
            this.BLTAyuda.SetBalloonText(this.TXTApPa, "Apellido Paterno de la Persona");
            // 
            // 
            // 
            this.TXTApPa.Border.Class = "TextBoxBorder";
            this.TXTApPa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTApPa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTApPa.Location = new System.Drawing.Point(6, 116);
            this.TXTApPa.Name = "TXTApPa";
            this.TXTApPa.PreventEnterBeep = true;
            this.TXTApPa.Size = new System.Drawing.Size(103, 20);
            this.TXTApPa.TabIndex = 4;
            this.TXTApPa.WatermarkText = "Apellido Paterno";
            this.TXTApPa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTApPa_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTNAbrirFoto);
            this.groupBox1.Controls.Add(this.BTNLimpiarFoto);
            this.groupBox1.Controls.Add(this.BTNCapturarFoto);
            this.groupBox1.Controls.Add(this.PBPrevi);
            this.groupBox1.Controls.Add(this.PBCaptura);
            this.groupBox1.Location = new System.Drawing.Point(291, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(294, 257);
            this.groupBox1.TabIndex = 18;
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
            this.BTNLimpiarFoto.Click += new System.EventHandler(this.BTNLimpiarFoto_Click);
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
            // GBDatos
            // 
            this.GBDatos.Controls.Add(this.SWBEstado);
            this.GBDatos.Controls.Add(this.SWBSexo);
            this.GBDatos.Controls.Add(this.DTINacimiento);
            this.GBDatos.Controls.Add(this.TXTApMa);
            this.GBDatos.Controls.Add(this.TXTNombre);
            this.GBDatos.Controls.Add(this.TXTApPa);
            this.GBDatos.Controls.Add(this.TXTCelular);
            this.GBDatos.Controls.Add(this.TXTCi);
            this.GBDatos.Controls.Add(this.TXTCorreo);
            this.GBDatos.Controls.Add(this.TXTDireccion);
            this.GBDatos.Location = new System.Drawing.Point(18, 32);
            this.GBDatos.Name = "GBDatos";
            this.GBDatos.Size = new System.Drawing.Size(273, 330);
            this.GBDatos.TabIndex = 19;
            this.GBDatos.TabStop = false;
            this.GBDatos.Text = "Datos de Persona";
            // 
            // OFDElegirImagen
            // 
            this.OFDElegirImagen.Filter = "Elegir Imagen|*.jpeg;*.jpg;*.png";
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNGuardar.Image = global::Sistema.Properties.Resources.ImgUsuarioGuardar;
            this.BTNGuardar.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNGuardar.Location = new System.Drawing.Point(98, 368);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(90, 41);
            this.BTNGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNGuardar.TabIndex = 15;
            this.BTNGuardar.Text = "&Guardar";
            this.BTNGuardar.Click += new System.EventHandler(this.BTNGuardar_Click);
            // 
            // BTNSalir
            // 
            this.BTNSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNSalir.Image = global::Sistema.Properties.Resources.ImgUsuarioSalir;
            this.BTNSalir.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNSalir.Location = new System.Drawing.Point(373, 368);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(84, 39);
            this.BTNSalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNSalir.TabIndex = 17;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNLimpiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNLimpiar.Image = global::Sistema.Properties.Resources.ImgUsuarioLimpiar;
            this.BTNLimpiar.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNLimpiar.Location = new System.Drawing.Point(233, 368);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(88, 39);
            this.BTNLimpiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNLimpiar.TabIndex = 16;
            this.BTNLimpiar.Text = "Limpiar";
            // 
            // FRM_Persona_Registrar
            // 
            this.AcceptButton = this.BTNGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTNSalir;
            this.ClientSize = new System.Drawing.Size(599, 426);
            this.Controls.Add(this.GBDatos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTNSalir);
            this.Controls.Add(this.BTNLimpiar);
            this.Controls.Add(this.BTNGuardar);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Name = "FRM_Persona_Registrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_Persona_Registrar_FormClosing);
            this.Load += new System.EventHandler(this.FRM_Persona_Registrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTINacimiento)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBPrevi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCaptura)).EndInit();
            this.GBDatos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.SwitchButton SWBEstado;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.SwitchButton SWBSexo;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput DTINacimiento;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTApMa;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTNombre;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTCelular;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTCorreo;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTDireccion;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTCi;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTApPa;
        private DevComponents.DotNetBar.ButtonX BTNGuardar;
        private DevComponents.DotNetBar.ButtonX BTNLimpiar;
        private DevComponents.DotNetBar.ButtonX BTNSalir;
        private System.Windows.Forms.PictureBox PBCaptura;
        private System.Windows.Forms.PictureBox PBPrevi;
        private DevComponents.DotNetBar.ButtonX BTNCapturarFoto;
        private DevComponents.DotNetBar.ButtonX BTNLimpiarFoto;
        private DevComponents.DotNetBar.ButtonX BTNAbrirFoto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox GBDatos;
        private DevComponents.DotNetBar.BalloonTip BLTAyuda;
        private System.Windows.Forms.OpenFileDialog OFDElegirImagen;
    }
}
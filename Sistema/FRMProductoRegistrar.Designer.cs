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
            this.SWBEstado = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.TXTModelo = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.TXTApMa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXTNombre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXTApPa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXTCelular = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXTCategoria = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXTCorreo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXTDireccion = new DevComponents.DotNetBar.Controls.TextBoxX();
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
            this.GBDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXTModelo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBPrevi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCaptura)).BeginInit();
            this.SuspendLayout();
            // 
            // GBDatos
            // 
            this.GBDatos.Controls.Add(this.SWBEstado);
            this.GBDatos.Controls.Add(this.TXTModelo);
            this.GBDatos.Controls.Add(this.TXTApMa);
            this.GBDatos.Controls.Add(this.TXTNombre);
            this.GBDatos.Controls.Add(this.TXTApPa);
            this.GBDatos.Controls.Add(this.TXTCelular);
            this.GBDatos.Controls.Add(this.TXTCategoria);
            this.GBDatos.Controls.Add(this.TXTCorreo);
            this.GBDatos.Controls.Add(this.TXTDireccion);
            this.GBDatos.Location = new System.Drawing.Point(38, 32);
            this.GBDatos.Name = "GBDatos";
            this.GBDatos.Size = new System.Drawing.Size(273, 330);
            this.GBDatos.TabIndex = 25;
            this.GBDatos.TabStop = false;
            this.GBDatos.Text = "Datos del Producto";
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
            // TXTModelo
            // 
            // 
            // 
            // 
            this.TXTModelo.BackgroundStyle.Class = "DateTimeInputBackground";
            this.TXTModelo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTModelo.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.TXTModelo.ButtonDropDown.Visible = true;
            this.TXTModelo.IsPopupCalendarOpen = false;
            this.TXTModelo.Location = new System.Drawing.Point(155, 80);
            // 
            // 
            // 
            // 
            // 
            // 
            this.TXTModelo.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTModelo.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.TXTModelo.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.TXTModelo.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.TXTModelo.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.TXTModelo.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.TXTModelo.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TXTModelo.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.TXTModelo.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.TXTModelo.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTModelo.MonthCalendar.DisplayMonth = new System.DateTime(2026, 5, 1, 0, 0, 0, 0);
            this.TXTModelo.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.TXTModelo.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.TXTModelo.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.TXTModelo.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.TXTModelo.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTModelo.MonthCalendar.TodayButtonVisible = true;
            this.TXTModelo.Name = "TXTModelo";
            this.TXTModelo.Size = new System.Drawing.Size(103, 23);
            this.TXTModelo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.TXTModelo.TabIndex = 3;
            this.TXTModelo.WatermarkText = "Modelo";
            // 
            // TXTApMa
            // 
            // 
            // 
            // 
            this.TXTApMa.Border.Class = "TextBoxBorder";
            this.TXTApMa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTApMa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTApMa.Location = new System.Drawing.Point(155, 154);
            this.TXTApMa.Name = "TXTApMa";
            this.TXTApMa.PreventEnterBeep = true;
            this.TXTApMa.Size = new System.Drawing.Size(103, 23);
            this.TXTApMa.TabIndex = 5;
            this.TXTApMa.WatermarkText = "Apellido Materno";
            // 
            // TXTNombre
            // 
            // 
            // 
            // 
            this.TXTNombre.Border.Class = "TextBoxBorder";
            this.TXTNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTNombre.Location = new System.Drawing.Point(6, 109);
            this.TXTNombre.Name = "TXTNombre";
            this.TXTNombre.PreventEnterBeep = true;
            this.TXTNombre.Size = new System.Drawing.Size(252, 23);
            this.TXTNombre.TabIndex = 6;
            this.TXTNombre.WatermarkText = "Nombre";
            // 
            // TXTApPa
            // 
            // 
            // 
            // 
            this.TXTApPa.Border.Class = "TextBoxBorder";
            this.TXTApPa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTApPa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTApPa.Location = new System.Drawing.Point(6, 74);
            this.TXTApPa.Name = "TXTApPa";
            this.TXTApPa.PreventEnterBeep = true;
            this.TXTApPa.Size = new System.Drawing.Size(103, 23);
            this.TXTApPa.TabIndex = 4;
            this.TXTApPa.WatermarkText = "Apellido Paterno";
            // 
            // TXTCelular
            // 
            // 
            // 
            // 
            this.TXTCelular.Border.Class = "TextBoxBorder";
            this.TXTCelular.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTCelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTCelular.Location = new System.Drawing.Point(6, 183);
            this.TXTCelular.Name = "TXTCelular";
            this.TXTCelular.PreventEnterBeep = true;
            this.TXTCelular.Size = new System.Drawing.Size(103, 23);
            this.TXTCelular.TabIndex = 7;
            this.TXTCelular.WatermarkText = "Celular";
            // 
            // TXTCategoria
            // 
            // 
            // 
            // 
            this.TXTCategoria.Border.Class = "TextBoxBorder";
            this.TXTCategoria.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTCategoria.Location = new System.Drawing.Point(155, 39);
            this.TXTCategoria.Name = "TXTCategoria";
            this.TXTCategoria.PreventEnterBeep = true;
            this.TXTCategoria.Size = new System.Drawing.Size(103, 23);
            this.TXTCategoria.TabIndex = 2;
            this.TXTCategoria.WatermarkText = "Categoria";
            // 
            // TXTCorreo
            // 
            // 
            // 
            // 
            this.TXTCorreo.Border.Class = "TextBoxBorder";
            this.TXTCorreo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTCorreo.Location = new System.Drawing.Point(155, 183);
            this.TXTCorreo.Name = "TXTCorreo";
            this.TXTCorreo.PreventEnterBeep = true;
            this.TXTCorreo.Size = new System.Drawing.Size(103, 23);
            this.TXTCorreo.TabIndex = 8;
            this.TXTCorreo.WatermarkText = "Correo";
            // 
            // TXTDireccion
            // 
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FRMProductoRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMProductoRegistrar";
            this.GBDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TXTModelo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBPrevi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCaptura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBDatos;
        private DevComponents.DotNetBar.Controls.SwitchButton SWBEstado;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput TXTModelo;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTApMa;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTNombre;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTApPa;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTCelular;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTCategoria;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTCorreo;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTDireccion;
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
    }
}
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
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.PBPrevi = new System.Windows.Forms.PictureBox();
            this.PBCaptura = new System.Windows.Forms.PictureBox();
            this.BTNSalir = new DevComponents.DotNetBar.ButtonX();
            this.BTNLimpiar = new DevComponents.DotNetBar.ButtonX();
            this.BTNGuardar = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.DTINacimiento)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBPrevi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCaptura)).BeginInit();
            this.SuspendLayout();
            // 
            // SWBEstado
            // 
            // 
            // 
            // 
            this.SWBEstado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SWBEstado.Location = new System.Drawing.Point(30, 56);
            this.SWBEstado.Name = "SWBEstado";
            this.SWBEstado.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SWBEstado.OffText = "Inhabilitado";
            this.SWBEstado.OffTextColor = System.Drawing.Color.White;
            this.SWBEstado.OnBackColor = System.Drawing.Color.LimeGreen;
            this.SWBEstado.OnText = "Habilitado";
            this.SWBEstado.OnTextColor = System.Drawing.Color.White;
            this.SWBEstado.Size = new System.Drawing.Size(103, 22);
            this.SWBEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SWBEstado.TabIndex = 4;
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
            this.SWBSexo.Location = new System.Drawing.Point(179, 56);
            this.SWBSexo.Name = "SWBSexo";
            this.SWBSexo.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SWBSexo.OffText = "Femenino";
            this.SWBSexo.OffTextColor = System.Drawing.Color.White;
            this.SWBSexo.OnBackColor = System.Drawing.Color.RoyalBlue;
            this.SWBSexo.OnText = "Masculino";
            this.SWBSexo.OnTextColor = System.Drawing.Color.White;
            this.SWBSexo.Size = new System.Drawing.Size(103, 22);
            this.SWBSexo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SWBSexo.TabIndex = 6;
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
            this.DTINacimiento.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.DTINacimiento.ButtonDropDown.Visible = true;
            this.DTINacimiento.IsPopupCalendarOpen = false;
            this.DTINacimiento.Location = new System.Drawing.Point(179, 96);
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
            this.DTINacimiento.TabIndex = 7;
            this.DTINacimiento.WatermarkText = "Nacimiento";
            // 
            // TXTApMa
            // 
            // 
            // 
            // 
            this.TXTApMa.Border.Class = "TextBoxBorder";
            this.TXTApMa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTApMa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTApMa.Location = new System.Drawing.Point(179, 132);
            this.TXTApMa.Name = "TXTApMa";
            this.TXTApMa.PreventEnterBeep = true;
            this.TXTApMa.Size = new System.Drawing.Size(103, 20);
            this.TXTApMa.TabIndex = 8;
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
            this.TXTNombre.Location = new System.Drawing.Point(30, 169);
            this.TXTNombre.Name = "TXTNombre";
            this.TXTNombre.PreventEnterBeep = true;
            this.TXTNombre.Size = new System.Drawing.Size(252, 20);
            this.TXTNombre.TabIndex = 9;
            this.TXTNombre.WatermarkText = "Nombres";
            // 
            // TXTCelular
            // 
            // 
            // 
            // 
            this.TXTCelular.Border.Class = "TextBoxBorder";
            this.TXTCelular.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTCelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTCelular.Location = new System.Drawing.Point(30, 199);
            this.TXTCelular.Name = "TXTCelular";
            this.TXTCelular.PreventEnterBeep = true;
            this.TXTCelular.Size = new System.Drawing.Size(103, 20);
            this.TXTCelular.TabIndex = 10;
            this.TXTCelular.WatermarkText = "Celular";
            // 
            // TXTCorreo
            // 
            // 
            // 
            // 
            this.TXTCorreo.Border.Class = "TextBoxBorder";
            this.TXTCorreo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTCorreo.Location = new System.Drawing.Point(179, 199);
            this.TXTCorreo.Name = "TXTCorreo";
            this.TXTCorreo.PreventEnterBeep = true;
            this.TXTCorreo.Size = new System.Drawing.Size(103, 20);
            this.TXTCorreo.TabIndex = 11;
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
            this.TXTDireccion.Location = new System.Drawing.Point(30, 239);
            this.TXTDireccion.Multiline = true;
            this.TXTDireccion.Name = "TXTDireccion";
            this.TXTDireccion.PreventEnterBeep = true;
            this.TXTDireccion.Size = new System.Drawing.Size(252, 86);
            this.TXTDireccion.TabIndex = 12;
            this.TXTDireccion.TabStop = false;
            this.TXTDireccion.WatermarkText = "Direccion";
            // 
            // TXTCi
            // 
            // 
            // 
            // 
            this.TXTCi.Border.Class = "TextBoxBorder";
            this.TXTCi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTCi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTCi.Location = new System.Drawing.Point(30, 96);
            this.TXTCi.Name = "TXTCi";
            this.TXTCi.PreventEnterBeep = true;
            this.TXTCi.Size = new System.Drawing.Size(103, 20);
            this.TXTCi.TabIndex = 13;
            this.TXTCi.WatermarkText = "CI";
            // 
            // TXTApPa
            // 
            // 
            // 
            // 
            this.TXTApPa.Border.Class = "TextBoxBorder";
            this.TXTApPa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTApPa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTApPa.Location = new System.Drawing.Point(30, 132);
            this.TXTApPa.Name = "TXTApPa";
            this.TXTApPa.PreventEnterBeep = true;
            this.TXTApPa.Size = new System.Drawing.Size(103, 20);
            this.TXTApPa.TabIndex = 14;
            this.TXTApPa.WatermarkText = "Apellido Paterno";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonX3);
            this.groupBox1.Controls.Add(this.buttonX2);
            this.groupBox1.Controls.Add(this.buttonX1);
            this.groupBox1.Controls.Add(this.PBPrevi);
            this.groupBox1.Controls.Add(this.PBCaptura);
            this.groupBox1.Location = new System.Drawing.Point(291, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(294, 248);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fotografia";
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Image = global::Sistema.Properties.Resources.ImgUsuarioAbrirFoto;
            this.buttonX3.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.buttonX3.Location = new System.Drawing.Point(198, 207);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(90, 41);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.TabIndex = 18;
            this.buttonX3.Text = "&Abrir";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Image = global::Sistema.Properties.Resources.ImgUsuarioLimpiarFoto;
            this.buttonX2.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.buttonX2.Location = new System.Drawing.Point(102, 207);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(90, 41);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 17;
            this.buttonX2.Text = "&Limpiar";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = global::Sistema.Properties.Resources.ImgUsuarioCapturar;
            this.buttonX1.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.buttonX1.Location = new System.Drawing.Point(6, 207);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(90, 41);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 16;
            this.buttonX1.Text = "&Capturar";
            // 
            // PBPrevi
            // 
            this.PBPrevi.Location = new System.Drawing.Point(147, 55);
            this.PBPrevi.Name = "PBPrevi";
            this.PBPrevi.Size = new System.Drawing.Size(141, 131);
            this.PBPrevi.TabIndex = 1;
            this.PBPrevi.TabStop = false;
            // 
            // PBCaptura
            // 
            this.PBCaptura.Location = new System.Drawing.Point(6, 55);
            this.PBCaptura.Name = "PBCaptura";
            this.PBCaptura.Size = new System.Drawing.Size(135, 131);
            this.PBCaptura.TabIndex = 0;
            this.PBCaptura.TabStop = false;
            // 
            // BTNSalir
            // 
            this.BTNSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNSalir.Image = global::Sistema.Properties.Resources.ImgUsuarioSalir;
            this.BTNSalir.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNSalir.Location = new System.Drawing.Point(373, 368);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(84, 39);
            this.BTNSalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNSalir.TabIndex = 17;
            this.BTNSalir.Text = "Salir";
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
            // 
            // FRM_Persona_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTNSalir);
            this.Controls.Add(this.BTNLimpiar);
            this.Controls.Add(this.BTNGuardar);
            this.Controls.Add(this.TXTApPa);
            this.Controls.Add(this.TXTCi);
            this.Controls.Add(this.TXTDireccion);
            this.Controls.Add(this.TXTCorreo);
            this.Controls.Add(this.TXTCelular);
            this.Controls.Add(this.TXTNombre);
            this.Controls.Add(this.TXTApMa);
            this.Controls.Add(this.DTINacimiento);
            this.Controls.Add(this.SWBSexo);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.SWBEstado);
            this.DoubleBuffered = true;
            this.Name = "FRM_Persona_Registrar";
            this.Text = "FRMPersona_Registrar";
            ((System.ComponentModel.ISupportInitialize)(this.DTINacimiento)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBPrevi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCaptura)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.PictureBox PBPrevi;
        private System.Windows.Forms.PictureBox PBCaptura;
    }
}
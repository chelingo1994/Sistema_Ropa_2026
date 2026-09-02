namespace Sistema
{
    partial class FRMProveedor_Registrar
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.TXTDireccion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXTRazon = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.GBDatos = new System.Windows.Forms.GroupBox();
            this.SWBUsar = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.TXTTelefono = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXTNitCi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SWBEstado = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.BTNBuscar = new DevComponents.DotNetBar.ButtonX();
            this.BTNSalir = new DevComponents.DotNetBar.ButtonX();
            this.BTNLimpiar = new DevComponents.DotNetBar.ButtonX();
            this.BTNGuardar = new DevComponents.DotNetBar.ButtonX();
            this.GBDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(156, 42);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 32;
            this.labelX1.Text = "Proveedor";
            // 
            // TXTDireccion
            // 
            // 
            // 
            // 
            this.TXTDireccion.Border.Class = "TextBoxBorder";
            this.TXTDireccion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTDireccion.Location = new System.Drawing.Point(4, 184);
            this.TXTDireccion.Multiline = true;
            this.TXTDireccion.Name = "TXTDireccion";
            this.TXTDireccion.PreventEnterBeep = true;
            this.TXTDireccion.Size = new System.Drawing.Size(252, 86);
            this.TXTDireccion.TabIndex = 6;
            this.TXTDireccion.TabStop = false;
            this.TXTDireccion.WatermarkText = "Direccion";
            // 
            // TXTRazon
            // 
            // 
            // 
            // 
            this.TXTRazon.Border.Class = "TextBoxBorder";
            this.TXTRazon.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTRazon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTRazon.Location = new System.Drawing.Point(5, 86);
            this.TXTRazon.Name = "TXTRazon";
            this.TXTRazon.PreventEnterBeep = true;
            this.TXTRazon.Size = new System.Drawing.Size(252, 23);
            this.TXTRazon.TabIndex = 3;
            this.TXTRazon.WatermarkText = "Razon Social / Nombre";
            this.TXTRazon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTRazon_KeyDown);
            // 
            // GBDatos
            // 
            this.GBDatos.Controls.Add(this.BTNBuscar);
            this.GBDatos.Controls.Add(this.SWBUsar);
            this.GBDatos.Controls.Add(this.TXTTelefono);
            this.GBDatos.Controls.Add(this.TXTNitCi);
            this.GBDatos.Controls.Add(this.TXTDireccion);
            this.GBDatos.Controls.Add(this.SWBEstado);
            this.GBDatos.Controls.Add(this.TXTRazon);
            this.GBDatos.Location = new System.Drawing.Point(45, 113);
            this.GBDatos.Name = "GBDatos";
            this.GBDatos.Size = new System.Drawing.Size(273, 287);
            this.GBDatos.TabIndex = 36;
            this.GBDatos.TabStop = false;
            this.GBDatos.Text = "Datos del Proveedor";
            // 
            // SWBUsar
            // 
            // 
            // 
            // 
            this.SWBUsar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SWBUsar.Location = new System.Drawing.Point(131, 41);
            this.SWBUsar.Name = "SWBUsar";
            this.SWBUsar.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SWBUsar.OffText = "No Usar Datos";
            this.SWBUsar.OffTextColor = System.Drawing.Color.White;
            this.SWBUsar.OnBackColor = System.Drawing.Color.LimeGreen;
            this.SWBUsar.OnText = "Usar Datos";
            this.SWBUsar.OnTextColor = System.Drawing.Color.White;
            this.SWBUsar.Size = new System.Drawing.Size(118, 22);
            this.SWBUsar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SWBUsar.TabIndex = 2;
            this.SWBUsar.TabStop = false;
            this.SWBUsar.ValueChanged += new System.EventHandler(this.SWBUsar_ValueChanged);
            // 
            // TXTTelefono
            // 
            // 
            // 
            // 
            this.TXTTelefono.Border.Class = "TextBoxBorder";
            this.TXTTelefono.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTTelefono.Location = new System.Drawing.Point(3, 144);
            this.TXTTelefono.Name = "TXTTelefono";
            this.TXTTelefono.PreventEnterBeep = true;
            this.TXTTelefono.Size = new System.Drawing.Size(252, 23);
            this.TXTTelefono.TabIndex = 5;
            this.TXTTelefono.WatermarkText = "Telefono";
            // 
            // TXTNitCi
            // 
            // 
            // 
            // 
            this.TXTNitCi.Border.Class = "TextBoxBorder";
            this.TXTNitCi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTNitCi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTNitCi.Location = new System.Drawing.Point(5, 115);
            this.TXTNitCi.Name = "TXTNitCi";
            this.TXTNitCi.PreventEnterBeep = true;
            this.TXTNitCi.Size = new System.Drawing.Size(252, 23);
            this.TXTNitCi.TabIndex = 4;
            this.TXTNitCi.WatermarkText = "Nit / Ci";
            this.TXTNitCi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTNitCi_KeyDown);
            // 
            // SWBEstado
            // 
            // 
            // 
            // 
            this.SWBEstado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SWBEstado.Location = new System.Drawing.Point(-4, 41);
            this.SWBEstado.Name = "SWBEstado";
            this.SWBEstado.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SWBEstado.OffText = "Inhabilitado";
            this.SWBEstado.OffTextColor = System.Drawing.Color.White;
            this.SWBEstado.OnBackColor = System.Drawing.Color.LimeGreen;
            this.SWBEstado.OnText = "Habilitado";
            this.SWBEstado.OnTextColor = System.Drawing.Color.White;
            this.SWBEstado.Size = new System.Drawing.Size(103, 22);
            this.SWBEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SWBEstado.TabIndex = 1;
            this.SWBEstado.TabStop = false;
            this.SWBEstado.Value = true;
            this.SWBEstado.ValueObject = "Y";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(222, 73);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(96, 23);
            this.labelX2.TabIndex = 37;
            this.labelX2.Text = "Buscar Persona";
            // 
            // BTNBuscar
            // 
            this.BTNBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNBuscar.Image = global::Sistema.Properties.Resources.ImgUsuarioBuscar;
            this.BTNBuscar.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BTNBuscar.Location = new System.Drawing.Point(202, 4);
            this.BTNBuscar.Name = "BTNBuscar";
            this.BTNBuscar.Size = new System.Drawing.Size(36, 22);
            this.BTNBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNBuscar.TabIndex = 23;
            this.BTNBuscar.Click += new System.EventHandler(this.BTNBuscar_Click);
            // 
            // BTNSalir
            // 
            this.BTNSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNSalir.Image = global::Sistema.Properties.Resources.ImgUsuarioSalir;
            this.BTNSalir.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNSalir.Location = new System.Drawing.Point(216, 409);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(95, 37);
            this.BTNSalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNSalir.TabIndex = 35;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNLimpiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNLimpiar.Image = global::Sistema.Properties.Resources.ImgUsuarioLimpiar;
            this.BTNLimpiar.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNLimpiar.Location = new System.Drawing.Point(122, 407);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(88, 39);
            this.BTNLimpiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNLimpiar.TabIndex = 34;
            this.BTNLimpiar.Text = "Limpiar";
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNGuardar.Image = global::Sistema.Properties.Resources.ImgUsuarioGuardar;
            this.BTNGuardar.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNGuardar.Location = new System.Drawing.Point(26, 407);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(90, 41);
            this.BTNGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNGuardar.TabIndex = 33;
            this.BTNGuardar.Text = "&Guardar";
            this.BTNGuardar.Click += new System.EventHandler(this.BTNGuardar_Click);
            // 
            // FRMProveedor_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 491);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.GBDatos);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.BTNSalir);
            this.Controls.Add(this.BTNLimpiar);
            this.Controls.Add(this.BTNGuardar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FRMProveedor_Registrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMProveedor_Registrar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMProveedor_Registrar_FormClosing);
            this.Load += new System.EventHandler(this.FRMProveedor_Registrar_Load);
            this.GBDatos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTDireccion;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTRazon;
        private System.Windows.Forms.GroupBox GBDatos;
        private DevComponents.DotNetBar.ButtonX BTNBuscar;
        private DevComponents.DotNetBar.Controls.SwitchButton SWBUsar;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTTelefono;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTNitCi;
        private DevComponents.DotNetBar.Controls.SwitchButton SWBEstado;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX BTNSalir;
        private DevComponents.DotNetBar.ButtonX BTNLimpiar;
        private DevComponents.DotNetBar.ButtonX BTNGuardar;
    }
}
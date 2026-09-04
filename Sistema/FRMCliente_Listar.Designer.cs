namespace Sistema
{
    partial class FRMCliente_Listar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EPNLOpciones = new DevComponents.DotNetBar.ExpandablePanel();
            this.BTNClienteReporte = new DevComponents.DotNetBar.ButtonX();
            this.BTNClienteModificar = new DevComponents.DotNetBar.ButtonX();
            this.BTNNuevoCliente = new DevComponents.DotNetBar.ButtonX();
            this.EPNLFiltrar = new DevComponents.DotNetBar.ExpandablePanel();
            this.BTNBuscar = new DevComponents.DotNetBar.ButtonX();
            this.TXTFiltrar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.IINFilas = new DevComponents.Editors.IntegerInput();
            this.DTGLista = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.CMSMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inhabilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EPNLOpciones.SuspendLayout();
            this.EPNLFiltrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IINFilas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGLista)).BeginInit();
            this.CMSMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // EPNLOpciones
            // 
            this.EPNLOpciones.CanvasColor = System.Drawing.SystemColors.Control;
            this.EPNLOpciones.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.EPNLOpciones.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.EPNLOpciones.Controls.Add(this.BTNClienteReporte);
            this.EPNLOpciones.Controls.Add(this.BTNClienteModificar);
            this.EPNLOpciones.Controls.Add(this.BTNNuevoCliente);
            this.EPNLOpciones.DisabledBackColor = System.Drawing.Color.Empty;
            this.EPNLOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.EPNLOpciones.HideControlsWhenCollapsed = true;
            this.EPNLOpciones.Location = new System.Drawing.Point(0, 0);
            this.EPNLOpciones.Margin = new System.Windows.Forms.Padding(5);
            this.EPNLOpciones.Name = "EPNLOpciones";
            this.EPNLOpciones.Size = new System.Drawing.Size(144, 554);
            this.EPNLOpciones.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.EPNLOpciones.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.EPNLOpciones.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.EPNLOpciones.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.EPNLOpciones.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.EPNLOpciones.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.EPNLOpciones.Style.GradientAngle = 90;
            this.EPNLOpciones.TabIndex = 38;
            this.EPNLOpciones.TitleHeight = 44;
            this.EPNLOpciones.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.EPNLOpciones.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.EPNLOpciones.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.EPNLOpciones.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.EPNLOpciones.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.EPNLOpciones.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.EPNLOpciones.TitleStyle.GradientAngle = 90;
            this.EPNLOpciones.TitleText = "Opciones";
            this.EPNLOpciones.Click += new System.EventHandler(this.EPNLOpciones_Click);
            // 
            // BTNClienteReporte
            // 
            this.BTNClienteReporte.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNClienteReporte.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNClienteReporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNClienteReporte.Image = global::Sistema.Properties.Resources.cliente_repo;
            this.BTNClienteReporte.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.BTNClienteReporte.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTNClienteReporte.Location = new System.Drawing.Point(0, 272);
            this.BTNClienteReporte.Margin = new System.Windows.Forms.Padding(5);
            this.BTNClienteReporte.Name = "BTNClienteReporte";
            this.BTNClienteReporte.Size = new System.Drawing.Size(144, 114);
            this.BTNClienteReporte.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNClienteReporte.TabIndex = 6;
            this.BTNClienteReporte.Text = "Reporte Cliente";
            // 
            // BTNClienteModificar
            // 
            this.BTNClienteModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNClienteModificar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNClienteModificar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNClienteModificar.Image = global::Sistema.Properties.Resources.cliente_mod;
            this.BTNClienteModificar.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.BTNClienteModificar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTNClienteModificar.Location = new System.Drawing.Point(0, 158);
            this.BTNClienteModificar.Margin = new System.Windows.Forms.Padding(5);
            this.BTNClienteModificar.Name = "BTNClienteModificar";
            this.BTNClienteModificar.Size = new System.Drawing.Size(144, 114);
            this.BTNClienteModificar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNClienteModificar.TabIndex = 5;
            this.BTNClienteModificar.Text = "Modificar Cliente";
            this.BTNClienteModificar.Click += new System.EventHandler(this.BTNClienteModificar_Click);
            // 
            // BTNNuevoCliente
            // 
            this.BTNNuevoCliente.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNNuevoCliente.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNNuevoCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNNuevoCliente.Image = global::Sistema.Properties.Resources.cliente_add;
            this.BTNNuevoCliente.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.BTNNuevoCliente.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTNNuevoCliente.Location = new System.Drawing.Point(0, 44);
            this.BTNNuevoCliente.Margin = new System.Windows.Forms.Padding(5);
            this.BTNNuevoCliente.Name = "BTNNuevoCliente";
            this.BTNNuevoCliente.Size = new System.Drawing.Size(144, 114);
            this.BTNNuevoCliente.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNNuevoCliente.TabIndex = 4;
            this.BTNNuevoCliente.Text = "Nuevo Cliente";
            this.BTNNuevoCliente.Click += new System.EventHandler(this.BTNNuevoCliente_Click);
            // 
            // EPNLFiltrar
            // 
            this.EPNLFiltrar.CanvasColor = System.Drawing.SystemColors.Control;
            this.EPNLFiltrar.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.EPNLFiltrar.Controls.Add(this.BTNBuscar);
            this.EPNLFiltrar.Controls.Add(this.TXTFiltrar);
            this.EPNLFiltrar.Controls.Add(this.labelX1);
            this.EPNLFiltrar.Controls.Add(this.IINFilas);
            this.EPNLFiltrar.DisabledBackColor = System.Drawing.Color.Empty;
            this.EPNLFiltrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.EPNLFiltrar.HideControlsWhenCollapsed = true;
            this.EPNLFiltrar.Location = new System.Drawing.Point(144, 0);
            this.EPNLFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.EPNLFiltrar.Name = "EPNLFiltrar";
            this.EPNLFiltrar.Size = new System.Drawing.Size(923, 93);
            this.EPNLFiltrar.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.EPNLFiltrar.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.EPNLFiltrar.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.EPNLFiltrar.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.EPNLFiltrar.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.EPNLFiltrar.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.EPNLFiltrar.Style.GradientAngle = 90;
            this.EPNLFiltrar.TabIndex = 49;
            this.EPNLFiltrar.TitleHeight = 36;
            this.EPNLFiltrar.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.EPNLFiltrar.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.EPNLFiltrar.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.EPNLFiltrar.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.EPNLFiltrar.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.EPNLFiltrar.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.EPNLFiltrar.TitleStyle.GradientAngle = 90;
            this.EPNLFiltrar.TitleText = "Filtrar";
            // 
            // BTNBuscar
            // 
            this.BTNBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNBuscar.Image = global::Sistema.Properties.Resources.ImgUsuarioBuscar;
            this.BTNBuscar.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BTNBuscar.Location = new System.Drawing.Point(420, 57);
            this.BTNBuscar.Name = "BTNBuscar";
            this.BTNBuscar.Size = new System.Drawing.Size(32, 23);
            this.BTNBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNBuscar.TabIndex = 7;
            this.BTNBuscar.Click += new System.EventHandler(this.BTNBuscar_Click);
            // 
            // TXTFiltrar
            // 
            // 
            // 
            // 
            this.TXTFiltrar.Border.Class = "TextBoxBorder";
            this.TXTFiltrar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTFiltrar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTFiltrar.Location = new System.Drawing.Point(159, 57);
            this.TXTFiltrar.Name = "TXTFiltrar";
            this.TXTFiltrar.PreventEnterBeep = true;
            this.TXTFiltrar.Size = new System.Drawing.Size(255, 23);
            this.TXTFiltrar.TabIndex = 6;
            this.TXTFiltrar.WatermarkText = "TEXTO A BUSCAR..";
            this.TXTFiltrar.Enter += new System.EventHandler(this.TXTFiltrar_Enter);
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(33, 56);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(31, 18);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "Filas";
            // 
            // IINFilas
            // 
            // 
            // 
            // 
            this.IINFilas.BackgroundStyle.Class = "DateTimeInputBackground";
            this.IINFilas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IINFilas.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.IINFilas.Increment = 10;
            this.IINFilas.Location = new System.Drawing.Point(73, 56);
            this.IINFilas.MinValue = 0;
            this.IINFilas.Name = "IINFilas";
            this.IINFilas.ShowUpDown = true;
            this.IINFilas.Size = new System.Drawing.Size(80, 23);
            this.IINFilas.TabIndex = 4;
            this.IINFilas.Value = 20;
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
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DTGLista.DefaultCellStyle = dataGridViewCellStyle2;
            this.DTGLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTGLista.EnableHeadersVisualStyles = false;
            this.DTGLista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DTGLista.Location = new System.Drawing.Point(144, 93);
            this.DTGLista.Margin = new System.Windows.Forms.Padding(4);
            this.DTGLista.MultiSelect = false;
            this.DTGLista.Name = "DTGLista";
            this.DTGLista.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTGLista.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DTGLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTGLista.Size = new System.Drawing.Size(923, 461);
            this.DTGLista.TabIndex = 50;
            this.DTGLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGLista_CellDoubleClick);
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Codigo Cliente";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Razon Social";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nit / Ci";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.Checked = true;
            this.Column1.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.Column1.CheckValue = "N";
            this.Column1.HeaderText = "Estado";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // CMSMenu
            // 
            this.CMSMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem,
            this.inhabilitarToolStripMenuItem,
            this.habilitarToolStripMenuItem});
            this.CMSMenu.Name = "CMSMenu";
            this.CMSMenu.Size = new System.Drawing.Size(128, 70);
            this.CMSMenu.Opening += new System.ComponentModel.CancelEventHandler(this.CMSMenu_Opening);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.modificarToolStripMenuItem.Text = "&Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // inhabilitarToolStripMenuItem
            // 
            this.inhabilitarToolStripMenuItem.Name = "inhabilitarToolStripMenuItem";
            this.inhabilitarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.inhabilitarToolStripMenuItem.Text = "&Inhabilitar";
            this.inhabilitarToolStripMenuItem.Click += new System.EventHandler(this.inhabilitarToolStripMenuItem_Click);
            // 
            // habilitarToolStripMenuItem
            // 
            this.habilitarToolStripMenuItem.Name = "habilitarToolStripMenuItem";
            this.habilitarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.habilitarToolStripMenuItem.Text = "&Habilitar";
            this.habilitarToolStripMenuItem.Click += new System.EventHandler(this.habilitarToolStripMenuItem_Click);
            // 
            // FRMCliente_Listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.DTGLista);
            this.Controls.Add(this.EPNLFiltrar);
            this.Controls.Add(this.EPNLOpciones);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMCliente_Listar";
            this.Text = "FRMCliente_Listar";
            this.Load += new System.EventHandler(this.FRMCliente_Listar_Load);
            this.EPNLOpciones.ResumeLayout(false);
            this.EPNLFiltrar.ResumeLayout(false);
            this.EPNLFiltrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IINFilas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGLista)).EndInit();
            this.CMSMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.ExpandablePanel EPNLOpciones;
        private DevComponents.DotNetBar.ButtonX BTNClienteReporte;
        private DevComponents.DotNetBar.ButtonX BTNClienteModificar;
        private DevComponents.DotNetBar.ButtonX BTNNuevoCliente;
        private DevComponents.DotNetBar.ExpandablePanel EPNLFiltrar;
        private DevComponents.DotNetBar.ButtonX BTNBuscar;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTFiltrar;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.IntegerInput IINFilas;
        private DevComponents.DotNetBar.Controls.DataGridViewX DTGLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn Column1;
        private System.Windows.Forms.ContextMenuStrip CMSMenu;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inhabilitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habilitarToolStripMenuItem;
    }
}
namespace Sistema
{
    partial class FRMProveedor_Listar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BTNReporteProveedor = new DevComponents.DotNetBar.ButtonX();
            this.BTNNuevoProveedor = new DevComponents.DotNetBar.ButtonX();
            this.BTNBuscar = new DevComponents.DotNetBar.ButtonX();
            this.habilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inhabilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CMSMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BTNModificarProveedor = new DevComponents.DotNetBar.ButtonX();
            this.TXTFiltrar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.IINFilas = new DevComponents.Editors.IntegerInput();
            this.EPNLFiltrar = new DevComponents.DotNetBar.ExpandablePanel();
            this.EPNLOpciones = new DevComponents.DotNetBar.ExpandablePanel();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.DTGLista = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.CMSMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IINFilas)).BeginInit();
            this.EPNLFiltrar.SuspendLayout();
            this.EPNLOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGLista)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNReporteProveedor
            // 
            this.BTNReporteProveedor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNReporteProveedor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNReporteProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNReporteProveedor.Image = global::Sistema.Properties.Resources.proveedor_repo;
            this.BTNReporteProveedor.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.BTNReporteProveedor.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTNReporteProveedor.Location = new System.Drawing.Point(0, 222);
            this.BTNReporteProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.BTNReporteProveedor.Name = "BTNReporteProveedor";
            this.BTNReporteProveedor.Size = new System.Drawing.Size(137, 93);
            this.BTNReporteProveedor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNReporteProveedor.TabIndex = 6;
            this.BTNReporteProveedor.Text = "Reporte Proveedor";
            // 
            // BTNNuevoProveedor
            // 
            this.BTNNuevoProveedor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNNuevoProveedor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNNuevoProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNNuevoProveedor.Image = global::Sistema.Properties.Resources.proveedor_add;
            this.BTNNuevoProveedor.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.BTNNuevoProveedor.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTNNuevoProveedor.Location = new System.Drawing.Point(0, 36);
            this.BTNNuevoProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.BTNNuevoProveedor.Name = "BTNNuevoProveedor";
            this.BTNNuevoProveedor.Size = new System.Drawing.Size(137, 93);
            this.BTNNuevoProveedor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNNuevoProveedor.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.BTNNuevoProveedor.TabIndex = 4;
            this.BTNNuevoProveedor.Text = "Nuevo Proveedor";
            this.BTNNuevoProveedor.Click += new System.EventHandler(this.BTNNuevoProveedor_Click);
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
            // habilitarToolStripMenuItem
            // 
            this.habilitarToolStripMenuItem.Name = "habilitarToolStripMenuItem";
            this.habilitarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.habilitarToolStripMenuItem.Text = "&Habilitar";
            this.habilitarToolStripMenuItem.Click += new System.EventHandler(this.habilitarToolStripMenuItem_Click);
            // 
            // inhabilitarToolStripMenuItem
            // 
            this.inhabilitarToolStripMenuItem.Name = "inhabilitarToolStripMenuItem";
            this.inhabilitarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inhabilitarToolStripMenuItem.Text = "&Inhabilitar";
            this.inhabilitarToolStripMenuItem.Click += new System.EventHandler(this.inhabilitarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarToolStripMenuItem.Text = "&Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
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
            // BTNModificarProveedor
            // 
            this.BTNModificarProveedor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNModificarProveedor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNModificarProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNModificarProveedor.Image = global::Sistema.Properties.Resources.proveedor_mod;
            this.BTNModificarProveedor.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.BTNModificarProveedor.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTNModificarProveedor.Location = new System.Drawing.Point(0, 129);
            this.BTNModificarProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.BTNModificarProveedor.Name = "BTNModificarProveedor";
            this.BTNModificarProveedor.Size = new System.Drawing.Size(137, 93);
            this.BTNModificarProveedor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNModificarProveedor.TabIndex = 5;
            this.BTNModificarProveedor.Text = "Modificar Proveedor";
            this.BTNModificarProveedor.Click += new System.EventHandler(this.BTNModificarProveedor_Click);
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
            this.EPNLFiltrar.Location = new System.Drawing.Point(137, 0);
            this.EPNLFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.EPNLFiltrar.Name = "EPNLFiltrar";
            this.EPNLFiltrar.Size = new System.Drawing.Size(919, 129);
            this.EPNLFiltrar.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.EPNLFiltrar.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.EPNLFiltrar.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.EPNLFiltrar.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.EPNLFiltrar.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.EPNLFiltrar.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.EPNLFiltrar.Style.GradientAngle = 90;
            this.EPNLFiltrar.TabIndex = 12;
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
            // EPNLOpciones
            // 
            this.EPNLOpciones.CanvasColor = System.Drawing.SystemColors.Control;
            this.EPNLOpciones.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.EPNLOpciones.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.EPNLOpciones.Controls.Add(this.BTNReporteProveedor);
            this.EPNLOpciones.Controls.Add(this.BTNModificarProveedor);
            this.EPNLOpciones.Controls.Add(this.BTNNuevoProveedor);
            this.EPNLOpciones.DisabledBackColor = System.Drawing.Color.Empty;
            this.EPNLOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.EPNLOpciones.HideControlsWhenCollapsed = true;
            this.EPNLOpciones.Location = new System.Drawing.Point(0, 0);
            this.EPNLOpciones.Margin = new System.Windows.Forms.Padding(4);
            this.EPNLOpciones.Name = "EPNLOpciones";
            this.EPNLOpciones.Size = new System.Drawing.Size(137, 554);
            this.EPNLOpciones.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.EPNLOpciones.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.EPNLOpciones.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.EPNLOpciones.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.EPNLOpciones.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.EPNLOpciones.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.EPNLOpciones.Style.GradientAngle = 90;
            this.EPNLOpciones.TabIndex = 11;
            this.EPNLOpciones.TitleHeight = 36;
            this.EPNLOpciones.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.EPNLOpciones.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.EPNLOpciones.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.EPNLOpciones.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.EPNLOpciones.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.EPNLOpciones.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.EPNLOpciones.TitleStyle.GradientAngle = 90;
            this.EPNLOpciones.TitleText = "Opciones";
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.Name = "itemContainer1";
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // DTGLista
            // 
            this.DTGLista.AllowUserToAddRows = false;
            this.DTGLista.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTGLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.DTGLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column5,
            this.Column2,
            this.Column1});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DTGLista.DefaultCellStyle = dataGridViewCellStyle14;
            this.DTGLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTGLista.EnableHeadersVisualStyles = false;
            this.DTGLista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.DTGLista.Location = new System.Drawing.Point(137, 129);
            this.DTGLista.Margin = new System.Windows.Forms.Padding(4);
            this.DTGLista.MultiSelect = false;
            this.DTGLista.Name = "DTGLista";
            this.DTGLista.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTGLista.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.DTGLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTGLista.Size = new System.Drawing.Size(919, 425);
            this.DTGLista.TabIndex = 51;
            this.DTGLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGLista_CellDoubleClick);
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Codigo Proveedor";
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
            // FRMProveedor_Listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 554);
            this.Controls.Add(this.DTGLista);
            this.Controls.Add(this.EPNLFiltrar);
            this.Controls.Add(this.EPNLOpciones);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FRMProveedor_Listar";
            this.Text = "FRMProveedor_Listar";
            this.Load += new System.EventHandler(this.FRMProveedor_Listar_Load);
            this.CMSMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IINFilas)).EndInit();
            this.EPNLFiltrar.ResumeLayout(false);
            this.EPNLFiltrar.PerformLayout();
            this.EPNLOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTGLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX BTNReporteProveedor;
        private DevComponents.DotNetBar.ButtonX BTNNuevoProveedor;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.ButtonX BTNBuscar;
        private System.Windows.Forms.ToolStripMenuItem habilitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inhabilitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CMSMenu;
        private DevComponents.DotNetBar.ButtonX BTNModificarProveedor;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTFiltrar;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.IntegerInput IINFilas;
        private DevComponents.DotNetBar.ExpandablePanel EPNLFiltrar;
        private DevComponents.DotNetBar.ExpandablePanel EPNLOpciones;
        private DevComponents.DotNetBar.Controls.DataGridViewX DTGLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn Column1;
    }
}
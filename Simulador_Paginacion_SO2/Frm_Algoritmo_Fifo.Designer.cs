namespace Simulador_Paginacion_SO2
{
    partial class Frm_Algoritmo_Fifo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Algoritmo_Fifo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTamanio = new DevExpress.XtraEditors.SimpleButton();
            this.btnIntercambiarPaginas = new DevExpress.XtraEditors.SimpleButton();
            this.btnCargarProcesos = new DevExpress.XtraEditors.SimpleButton();
            this.gcProcesos = new DevExpress.XtraGrid.GridControl();
            this.gvProcesos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbTamanioPagina = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroProcesos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gcDiscoDuro = new DevExpress.XtraEditors.GroupControl();
            this.pnlDiscoDuro = new System.Windows.Forms.Panel();
            this.gcTablaPaginas = new DevExpress.XtraEditors.GroupControl();
            this.pnlTablaPaginas = new System.Windows.Forms.Panel();
            this.gcRam = new DevExpress.XtraEditors.GroupControl();
            this.pnlMarcos = new System.Windows.Forms.Panel();
            this.gcEstados = new DevExpress.XtraEditors.GroupControl();
            this.lbProcEjecucion = new System.Windows.Forms.ListBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbProcEspera = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProcesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProcesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTamanioPagina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDiscoDuro)).BeginInit();
            this.gcDiscoDuro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTablaPaginas)).BeginInit();
            this.gcTablaPaginas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcRam)).BeginInit();
            this.gcRam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcEstados)).BeginInit();
            this.gcEstados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnTamanio);
            this.groupBox1.Controls.Add(this.btnIntercambiarPaginas);
            this.groupBox1.Controls.Add(this.btnCargarProcesos);
            this.groupBox1.Controls.Add(this.gcProcesos);
            this.groupBox1.Controls.Add(this.cbTamanioPagina);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNumeroProcesos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(247, 622);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametrización";
            // 
            // btnTamanio
            // 
            this.btnTamanio.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTamanio.ImageOptions.Image")));
            this.btnTamanio.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnTamanio.Location = new System.Drawing.Point(16, 101);
            this.btnTamanio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTamanio.Name = "btnTamanio";
            this.btnTamanio.Size = new System.Drawing.Size(210, 50);
            this.btnTamanio.TabIndex = 3;
            this.btnTamanio.Text = "Definir tamaño de procesos";
            this.btnTamanio.Click += new System.EventHandler(this.btnTamanio_Click);
            // 
            // btnIntercambiarPaginas
            // 
            this.btnIntercambiarPaginas.Enabled = false;
            this.btnIntercambiarPaginas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIntercambiarPaginas.ImageOptions.Image")));
            this.btnIntercambiarPaginas.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnIntercambiarPaginas.Location = new System.Drawing.Point(16, 439);
            this.btnIntercambiarPaginas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIntercambiarPaginas.Name = "btnIntercambiarPaginas";
            this.btnIntercambiarPaginas.Size = new System.Drawing.Size(210, 50);
            this.btnIntercambiarPaginas.TabIndex = 6;
            this.btnIntercambiarPaginas.Text = "Intercambiar páginas...";
            this.btnIntercambiarPaginas.Visible = false;
            this.btnIntercambiarPaginas.Click += new System.EventHandler(this.btnIntercambiarPaginas_Click);
            // 
            // btnCargarProcesos
            // 
            this.btnCargarProcesos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarProcesos.ImageOptions.Image")));
            this.btnCargarProcesos.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCargarProcesos.Location = new System.Drawing.Point(16, 384);
            this.btnCargarProcesos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCargarProcesos.Name = "btnCargarProcesos";
            this.btnCargarProcesos.Size = new System.Drawing.Size(210, 50);
            this.btnCargarProcesos.TabIndex = 5;
            this.btnCargarProcesos.Text = "Cargar procesos...";
            this.btnCargarProcesos.Visible = false;
            this.btnCargarProcesos.Click += new System.EventHandler(this.btnCargarProcesos_Click);
            // 
            // gcProcesos
            // 
            this.gcProcesos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcProcesos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gcProcesos.Location = new System.Drawing.Point(5, 179);
            this.gcProcesos.MainView = this.gvProcesos;
            this.gcProcesos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gcProcesos.Name = "gcProcesos";
            this.gcProcesos.Size = new System.Drawing.Size(237, 181);
            this.gcProcesos.TabIndex = 4;
            this.gcProcesos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProcesos});
            this.gcProcesos.Visible = false;
            // 
            // gvProcesos
            // 
            this.gvProcesos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gvProcesos.DetailHeight = 284;
            this.gvProcesos.GridControl = this.gcProcesos;
            this.gvProcesos.Name = "gvProcesos";
            this.gvProcesos.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gvProcesos.OptionsCustomization.AllowGroup = false;
            this.gvProcesos.OptionsEditForm.EditFormColumnCount = 1;
            this.gvProcesos.OptionsEditForm.PopupEditFormWidth = 400;
            this.gvProcesos.OptionsView.ShowGroupPanel = false;
            this.gvProcesos.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvProcesos_ValidateRow);
            this.gvProcesos.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gvProcesos_ValidatingEditor);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id";
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.MinWidth = 15;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowMove = false;
            this.gridColumn1.OptionsColumn.AllowShowHide = false;
            this.gridColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Width = 56;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nombre de proceso";
            this.gridColumn2.FieldName = "nombre_proceso";
            this.gridColumn2.MinWidth = 15;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 56;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tamaño de proceso";
            this.gridColumn3.FieldName = "tamanio_proceso";
            this.gridColumn3.MinWidth = 15;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 56;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Color";
            this.gridColumn4.FieldName = "color_proceso";
            this.gridColumn4.MinWidth = 15;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Width = 56;
            // 
            // cbTamanioPagina
            // 
            this.cbTamanioPagina.Location = new System.Drawing.Point(166, 67);
            this.cbTamanioPagina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTamanioPagina.Name = "cbTamanioPagina";
            this.cbTamanioPagina.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTamanioPagina.Properties.Appearance.Options.UseFont = true;
            this.cbTamanioPagina.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTamanioPagina.Properties.Items.AddRange(new object[] {
            "8 KB",
            "10 KB",
            "12 KB",
            "14 KB",
            "16 KB"});
            this.cbTamanioPagina.Size = new System.Drawing.Size(75, 26);
            this.cbTamanioPagina.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tamaño de página:";
            // 
            // txtNumeroProcesos
            // 
            this.txtNumeroProcesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroProcesos.Location = new System.Drawing.Point(166, 29);
            this.txtNumeroProcesos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumeroProcesos.Name = "txtNumeroProcesos";
            this.txtNumeroProcesos.Size = new System.Drawing.Size(76, 26);
            this.txtNumeroProcesos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de procesos:";
            // 
            // gcDiscoDuro
            // 
            this.gcDiscoDuro.Controls.Add(this.pnlDiscoDuro);
            this.gcDiscoDuro.Location = new System.Drawing.Point(260, 18);
            this.gcDiscoDuro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gcDiscoDuro.Name = "gcDiscoDuro";
            this.gcDiscoDuro.Size = new System.Drawing.Size(220, 482);
            this.gcDiscoDuro.TabIndex = 1;
            this.gcDiscoDuro.Text = "Disco Duro (Páginas)";
            // 
            // pnlDiscoDuro
            // 
            this.pnlDiscoDuro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDiscoDuro.Location = new System.Drawing.Point(2, 23);
            this.pnlDiscoDuro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlDiscoDuro.Name = "pnlDiscoDuro";
            this.pnlDiscoDuro.Size = new System.Drawing.Size(216, 457);
            this.pnlDiscoDuro.TabIndex = 0;
            // 
            // gcTablaPaginas
            // 
            this.gcTablaPaginas.Controls.Add(this.pnlTablaPaginas);
            this.gcTablaPaginas.Location = new System.Drawing.Point(496, 18);
            this.gcTablaPaginas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gcTablaPaginas.Name = "gcTablaPaginas";
            this.gcTablaPaginas.Size = new System.Drawing.Size(220, 482);
            this.gcTablaPaginas.TabIndex = 2;
            this.gcTablaPaginas.Text = "Tabla de páginas";
            // 
            // pnlTablaPaginas
            // 
            this.pnlTablaPaginas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTablaPaginas.Location = new System.Drawing.Point(2, 23);
            this.pnlTablaPaginas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTablaPaginas.Name = "pnlTablaPaginas";
            this.pnlTablaPaginas.Size = new System.Drawing.Size(216, 457);
            this.pnlTablaPaginas.TabIndex = 0;
            // 
            // gcRam
            // 
            this.gcRam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gcRam.Controls.Add(this.pnlMarcos);
            this.gcRam.Location = new System.Drawing.Point(729, 18);
            this.gcRam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gcRam.Name = "gcRam";
            this.gcRam.Size = new System.Drawing.Size(220, 613);
            this.gcRam.TabIndex = 3;
            this.gcRam.Text = "Memoria RAM 240 KB (Marcos de páginas)";
            // 
            // pnlMarcos
            // 
            this.pnlMarcos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMarcos.Location = new System.Drawing.Point(2, 23);
            this.pnlMarcos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMarcos.Name = "pnlMarcos";
            this.pnlMarcos.Size = new System.Drawing.Size(216, 588);
            this.pnlMarcos.TabIndex = 0;
            // 
            // gcEstados
            // 
            this.gcEstados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gcEstados.Controls.Add(this.lbProcEjecucion);
            this.gcEstados.Location = new System.Drawing.Point(261, 515);
            this.gcEstados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gcEstados.Name = "gcEstados";
            this.gcEstados.Size = new System.Drawing.Size(219, 117);
            this.gcEstados.TabIndex = 4;
            this.gcEstados.Text = "Procesos en ejecución";
            // 
            // lbProcEjecucion
            // 
            this.lbProcEjecucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbProcEjecucion.DisplayMember = "Nombre_proceso";
            this.lbProcEjecucion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbProcEjecucion.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbProcEjecucion.FormattingEnabled = true;
            this.lbProcEjecucion.ItemHeight = 19;
            this.lbProcEjecucion.Location = new System.Drawing.Point(2, 23);
            this.lbProcEjecucion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbProcEjecucion.Name = "lbProcEjecucion";
            this.lbProcEjecucion.Size = new System.Drawing.Size(215, 92);
            this.lbProcEjecucion.TabIndex = 0;
            this.lbProcEjecucion.ValueMember = "Id_proceso";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.Controls.Add(this.lbProcEspera);
            this.groupControl1.Location = new System.Drawing.Point(495, 515);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(219, 117);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Procesos en espera";
            // 
            // lbProcEspera
            // 
            this.lbProcEspera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbProcEspera.DisplayMember = "nombre_proceso";
            this.lbProcEspera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbProcEspera.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbProcEspera.FormattingEnabled = true;
            this.lbProcEspera.ItemHeight = 19;
            this.lbProcEspera.Location = new System.Drawing.Point(2, 23);
            this.lbProcEspera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbProcEspera.Name = "lbProcEspera";
            this.lbProcEspera.Size = new System.Drawing.Size(215, 92);
            this.lbProcEspera.TabIndex = 1;
            this.lbProcEspera.ValueMember = "id_proceso";
            // 
            // Frm_Algoritmo_Fifo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 641);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcEstados);
            this.Controls.Add(this.gcRam);
            this.Controls.Add(this.gcTablaPaginas);
            this.Controls.Add(this.gcDiscoDuro);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_Algoritmo_Fifo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algoritmo FIFO";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProcesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProcesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTamanioPagina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDiscoDuro)).EndInit();
            this.gcDiscoDuro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcTablaPaginas)).EndInit();
            this.gcTablaPaginas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcRam)).EndInit();
            this.gcRam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcEstados)).EndInit();
            this.gcEstados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ComboBoxEdit cbTamanioPagina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroProcesos;
        private DevExpress.XtraGrid.GridControl gcProcesos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProcesos;
        private DevExpress.XtraEditors.GroupControl gcDiscoDuro;
        private DevExpress.XtraEditors.GroupControl gcTablaPaginas;
        private DevExpress.XtraEditors.GroupControl gcRam;
        private DevExpress.XtraEditors.GroupControl gcEstados;
        private System.Windows.Forms.Panel pnlDiscoDuro;
        private System.Windows.Forms.Panel pnlTablaPaginas;
        private System.Windows.Forms.Panel pnlMarcos;
        private DevExpress.XtraEditors.SimpleButton btnCargarProcesos;
        private DevExpress.XtraEditors.SimpleButton btnIntercambiarPaginas;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ListBox lbProcEjecucion;
        private System.Windows.Forms.ListBox lbProcEspera;
        private DevExpress.XtraEditors.SimpleButton btnTamanio;
    }
}
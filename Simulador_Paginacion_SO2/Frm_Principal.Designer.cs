namespace Simulador_Paginacion_SO2
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.miArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.miAlgoritmo = new System.Windows.Forms.ToolStripMenuItem();
            this.miiFifo = new System.Windows.Forms.ToolStripMenuItem();
            this.miiReloj = new System.Windows.Forms.ToolStripMenuItem();
            this.miiNru = new System.Windows.Forms.ToolStripMenuItem();
            this.miiLru = new System.Windows.Forms.ToolStripMenuItem();
            this.miiNfu = new System.Windows.Forms.ToolStripMenuItem();
            this.miAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miArchivo,
            this.miAlgoritmo,
            this.miAyuda});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1155, 28);
            this.menu.TabIndex = 0;
            this.menu.Text = "Menu";
            // 
            // miArchivo
            // 
            this.miArchivo.Name = "miArchivo";
            this.miArchivo.Size = new System.Drawing.Size(71, 24);
            this.miArchivo.Text = "Archivo";
            // 
            // miAlgoritmo
            // 
            this.miAlgoritmo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miiFifo,
            this.miiReloj,
            this.miiNru,
            this.miiLru,
            this.miiNfu});
            this.miAlgoritmo.Name = "miAlgoritmo";
            this.miAlgoritmo.Size = new System.Drawing.Size(89, 24);
            this.miAlgoritmo.Text = "Algoritmo";
            // 
            // miiFifo
            // 
            this.miiFifo.Image = ((System.Drawing.Image)(resources.GetObject("miiFifo.Image")));
            this.miiFifo.Name = "miiFifo";
            this.miiFifo.Size = new System.Drawing.Size(181, 26);
            this.miiFifo.Text = "FIFO";
            this.miiFifo.Click += new System.EventHandler(this.miiFifo_Click);
            // 
            // miiReloj
            // 
            this.miiReloj.Image = ((System.Drawing.Image)(resources.GetObject("miiReloj.Image")));
            this.miiReloj.Name = "miiReloj";
            this.miiReloj.Size = new System.Drawing.Size(181, 26);
            this.miiReloj.Text = "Reloj";
            // 
            // miiNru
            // 
            this.miiNru.Name = "miiNru";
            this.miiNru.Size = new System.Drawing.Size(181, 26);
            this.miiNru.Text = "NRU";
            // 
            // miiLru
            // 
            this.miiLru.Name = "miiLru";
            this.miiLru.Size = new System.Drawing.Size(181, 26);
            this.miiLru.Text = "LRU";
            // 
            // miiNfu
            // 
            this.miiNfu.Name = "miiNfu";
            this.miiNfu.Size = new System.Drawing.Size(181, 26);
            this.miiNfu.Text = "NFU";
            // 
            // miAyuda
            // 
            this.miAyuda.Name = "miAyuda";
            this.miAyuda.Size = new System.Drawing.Size(63, 24);
            this.miAyuda.Text = "Ayuda";
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 718);
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "Frm_Principal";
            this.Text = "Simulador de reemplazo de páginas Sistemas Operativos II";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem miArchivo;
        private System.Windows.Forms.ToolStripMenuItem miAlgoritmo;
        private System.Windows.Forms.ToolStripMenuItem miiFifo;
        private System.Windows.Forms.ToolStripMenuItem miiReloj;
        private System.Windows.Forms.ToolStripMenuItem miiNru;
        private System.Windows.Forms.ToolStripMenuItem miiLru;
        private System.Windows.Forms.ToolStripMenuItem miiNfu;
        private System.Windows.Forms.ToolStripMenuItem miAyuda;
    }
}


namespace WallPaperDynamic
{
    partial class Frm_Wall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Wall));
            this.tmr_atualizador = new System.Windows.Forms.Timer(this.components);
            this.ntf_application = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarClimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausarTrocaDinamicaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tmr_weather = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmr_atualizador
            // 
            this.tmr_atualizador.Interval = 1000;
            this.tmr_atualizador.Tick += new System.EventHandler(this.tmr_atualizador_Tick);
            // 
            // ntf_application
            // 
            this.ntf_application.ContextMenuStrip = this.contextMenuStrip1;
            this.ntf_application.Icon = ((System.Drawing.Icon)(resources.GetObject("ntf_application.Icon")));
            this.ntf_application.Text = "WallPaper Dynamic";
            this.ntf_application.Visible = true;
            this.ntf_application.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ntf_application_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarClimaToolStripMenuItem,
            this.pausarTrocaDinamicaToolStripMenuItem1,
            this.sairToolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(197, 70);
            // 
            // mostrarClimaToolStripMenuItem
            // 
            this.mostrarClimaToolStripMenuItem.Name = "mostrarClimaToolStripMenuItem";
            this.mostrarClimaToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.mostrarClimaToolStripMenuItem.Text = "Show weather";
            this.mostrarClimaToolStripMenuItem.Click += new System.EventHandler(this.mostrarClimaToolStripMenuItem_Click);
            // 
            // pausarTrocaDinamicaToolStripMenuItem1
            // 
            this.pausarTrocaDinamicaToolStripMenuItem1.Name = "pausarTrocaDinamicaToolStripMenuItem1";
            this.pausarTrocaDinamicaToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.pausarTrocaDinamicaToolStripMenuItem1.Text = "Pause dynamic change";
            this.pausarTrocaDinamicaToolStripMenuItem1.Click += new System.EventHandler(this.pausarTrocaDinamicaToolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem2
            // 
            this.sairToolStripMenuItem2.Name = "sairToolStripMenuItem2";
            this.sairToolStripMenuItem2.Size = new System.Drawing.Size(196, 22);
            this.sairToolStripMenuItem2.Text = "Exit";
            this.sairToolStripMenuItem2.Click += new System.EventHandler(this.sairToolStripMenuItem2_Click);
            // 
            // tmr_weather
            // 
            this.tmr_weather.Enabled = true;
            this.tmr_weather.Interval = 600000;
            this.tmr_weather.Tick += new System.EventHandler(this.tmr_weather_Tick);
            // 
            // Frm_Wall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 262);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Wall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WallPaper Dynamic";
            this.Load += new System.EventHandler(this.Frm_Wall_Load);
            this.Resize += new System.EventHandler(this.Frm_Wall_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon ntf_application;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pausarTrocaDinamicaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem2;
        private System.Windows.Forms.Timer tmr_weather;
        private System.Windows.Forms.ToolStripMenuItem mostrarClimaToolStripMenuItem;
        private System.Windows.Forms.Timer tmr_atualizador;
    }
}


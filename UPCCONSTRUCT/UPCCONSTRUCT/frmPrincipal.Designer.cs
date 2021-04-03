namespace UPCCONSTRUCT
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarTareasPorProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeTareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeTareassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(389, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoDeTareasToolStripMenuItem,
            this.ingresoDeTareassToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarTareasPorProyectoToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // consultarTareasPorProyectoToolStripMenuItem
            // 
            this.consultarTareasPorProyectoToolStripMenuItem.Name = "consultarTareasPorProyectoToolStripMenuItem";
            this.consultarTareasPorProyectoToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.consultarTareasPorProyectoToolStripMenuItem.Text = "consultar tareas por proyecto";
            this.consultarTareasPorProyectoToolStripMenuItem.Click += new System.EventHandler(this.consultarTareasPorProyectoToolStripMenuItem_Click);
            // 
            // ingresoDeTareasToolStripMenuItem
            // 
            this.ingresoDeTareasToolStripMenuItem.Name = "ingresoDeTareasToolStripMenuItem";
            this.ingresoDeTareasToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.ingresoDeTareasToolStripMenuItem.Text = "ingreso de tareas";
            this.ingresoDeTareasToolStripMenuItem.Click += new System.EventHandler(this.ingresoDeTareasToolStripMenuItem_Click);
            // 
            // ingresoDeTareassToolStripMenuItem
            // 
            this.ingresoDeTareassToolStripMenuItem.Name = "ingresoDeTareassToolStripMenuItem";
            this.ingresoDeTareassToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.ingresoDeTareassToolStripMenuItem.Text = "ingreso de proyectos";
            this.ingresoDeTareassToolStripMenuItem.Click += new System.EventHandler(this.ingresoDeTareassToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 347);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeTareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeTareassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarTareasPorProyectoToolStripMenuItem;
    }
}
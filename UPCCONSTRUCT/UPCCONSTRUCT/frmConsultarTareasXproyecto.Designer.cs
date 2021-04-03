namespace UPCCONSTRUCT
{
    partial class frmConsultarTareasXproyecto
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
            this.lbProyectos = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRegistraProy = new System.Windows.Forms.Button();
            this.lbTareas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbProyectos
            // 
            this.lbProyectos.FormattingEnabled = true;
            this.lbProyectos.Location = new System.Drawing.Point(12, 39);
            this.lbProyectos.Name = "lbProyectos";
            this.lbProyectos.Size = new System.Drawing.Size(180, 199);
            this.lbProyectos.TabIndex = 15;
            this.lbProyectos.SelectedIndexChanged += new System.EventHandler(this.lbProyectos_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegistraProy
            // 
            this.btnRegistraProy.Location = new System.Drawing.Point(28, 299);
            this.btnRegistraProy.Name = "btnRegistraProy";
            this.btnRegistraProy.Size = new System.Drawing.Size(75, 23);
            this.btnRegistraProy.TabIndex = 13;
            this.btnRegistraProy.Text = "registrar";
            this.btnRegistraProy.UseVisualStyleBackColor = true;
            // 
            // lbTareas
            // 
            this.lbTareas.FormattingEnabled = true;
            this.lbTareas.Location = new System.Drawing.Point(262, 39);
            this.lbTareas.Name = "lbTareas";
            this.lbTareas.Size = new System.Drawing.Size(155, 199);
            this.lbTareas.TabIndex = 16;
            // 
            // frmConsultarTareasXproyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 384);
            this.Controls.Add(this.lbTareas);
            this.Controls.Add(this.lbProyectos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRegistraProy);
            this.Name = "frmConsultarTareasXproyecto";
            this.Text = "frmConsultarTareasXproyecto";
            this.Load += new System.EventHandler(this.frmConsultarTareasXproyecto_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbProyectos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRegistraProy;
        private System.Windows.Forms.ListBox lbTareas;
    }
}
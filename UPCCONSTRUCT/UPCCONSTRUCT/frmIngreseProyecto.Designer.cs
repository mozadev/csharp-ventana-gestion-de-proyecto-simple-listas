namespace UPCCONSTRUCT
{
    partial class frmIngreseProyecto
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
            this.txtcodProyecto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombProye = new System.Windows.Forms.TextBox();
            this.btnRegistraProy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcodProyecto
            // 
            this.txtcodProyecto.Location = new System.Drawing.Point(95, 22);
            this.txtcodProyecto.Name = "txtcodProyecto";
            this.txtcodProyecto.Size = new System.Drawing.Size(100, 20);
            this.txtcodProyecto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "nombre";
            // 
            // txtNombProye
            // 
            this.txtNombProye.Location = new System.Drawing.Point(95, 67);
            this.txtNombProye.Name = "txtNombProye";
            this.txtNombProye.Size = new System.Drawing.Size(100, 20);
            this.txtNombProye.TabIndex = 2;
            // 
            // btnRegistraProy
            // 
            this.btnRegistraProy.Location = new System.Drawing.Point(43, 121);
            this.btnRegistraProy.Name = "btnRegistraProy";
            this.btnRegistraProy.Size = new System.Drawing.Size(75, 23);
            this.btnRegistraProy.TabIndex = 4;
            this.btnRegistraProy.Text = "registrar";
            this.btnRegistraProy.UseVisualStyleBackColor = true;
            this.btnRegistraProy.Click += new System.EventHandler(this.btnRegistraProy_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmIngreseProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 178);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRegistraProy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombProye);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcodProyecto);
            this.Name = "frmIngreseProyecto";
            this.Text = "frmIngreseProyecto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodProyecto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombProye;
        private System.Windows.Forms.Button btnRegistraProy;
        private System.Windows.Forms.Button button1;
    }
}
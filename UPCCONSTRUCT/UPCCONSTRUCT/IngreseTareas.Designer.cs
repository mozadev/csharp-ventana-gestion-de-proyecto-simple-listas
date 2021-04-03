namespace UPCCONSTRUCT
{
    partial class IngreseTareas
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnRegistraProy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomtarea = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodtarea = new System.Windows.Forms.TextBox();
            this.lbProyectos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegistraProy
            // 
            this.btnRegistraProy.Location = new System.Drawing.Point(57, 149);
            this.btnRegistraProy.Name = "btnRegistraProy";
            this.btnRegistraProy.Size = new System.Drawing.Size(75, 23);
            this.btnRegistraProy.TabIndex = 10;
            this.btnRegistraProy.Text = "registrar";
            this.btnRegistraProy.UseVisualStyleBackColor = true;
            this.btnRegistraProy.Click += new System.EventHandler(this.btnRegistraProy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "nombre";
            // 
            // txtNomtarea
            // 
            this.txtNomtarea.Location = new System.Drawing.Point(109, 95);
            this.txtNomtarea.Name = "txtNomtarea";
            this.txtNomtarea.Size = new System.Drawing.Size(100, 20);
            this.txtNomtarea.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "codigo";
            // 
            // txtcodtarea
            // 
            this.txtcodtarea.Location = new System.Drawing.Point(109, 50);
            this.txtcodtarea.Name = "txtcodtarea";
            this.txtcodtarea.Size = new System.Drawing.Size(100, 20);
            this.txtcodtarea.TabIndex = 6;
            // 
            // lbProyectos
            // 
            this.lbProyectos.FormattingEnabled = true;
            this.lbProyectos.Location = new System.Drawing.Point(257, 29);
            this.lbProyectos.Name = "lbProyectos";
            this.lbProyectos.Size = new System.Drawing.Size(199, 199);
            this.lbProyectos.TabIndex = 12;
            // 
            // IngreseTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 402);
            this.Controls.Add(this.lbProyectos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRegistraProy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomtarea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcodtarea);
            this.Name = "IngreseTareas";
            this.Text = "IngreseTareas";
            this.Load += new System.EventHandler(this.IngreseTareas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRegistraProy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomtarea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodtarea;
        private System.Windows.Forms.ListBox lbProyectos;
    }
}
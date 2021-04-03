using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPCCONSTRUCT
{
    public partial class frmIngreseProyecto : Form
    {
        CGestoraProyectos objGestoraProyecto = new CGestoraProyectos();
        public frmIngreseProyecto()
        {
            InitializeComponent();
        }

        private void btnRegistraProy_Click(object sender, EventArgs e)
        {
            CProyecto proyecto = new CProyecto();
            proyecto.Codigo = txtcodProyecto.Text;
            proyecto.Nombre = txtNombProye.Text;
            objGestoraProyecto.RegistrarProyecto(proyecto);

            MessageBox.Show("ok");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}

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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

      

        private void ingresoDeTareassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngreseProyecto frm = new frmIngreseProyecto();
            frm.ShowDialog();
        }

        private void ingresoDeTareasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            IngreseTareas frm = new IngreseTareas();
            frm.ShowDialog();
        }

        private void consultarTareasPorProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarTareasXproyecto frm = new frmConsultarTareasXproyecto();
            frm.ShowDialog();
        }
    }
}

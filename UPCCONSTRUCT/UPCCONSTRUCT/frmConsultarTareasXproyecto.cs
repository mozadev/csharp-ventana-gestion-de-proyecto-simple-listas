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
    public partial class frmConsultarTareasXproyecto : Form
    {

        CGestoraProyectos objGestoraProyecto = new CGestoraProyectos();
        public frmConsultarTareasXproyecto()
        {
            InitializeComponent();
        }

        private void frmConsultarTareasXproyecto_Load(object sender, EventArgs e)
        {
            lbProyectos.DisplayMember = "Nombre";
            lbProyectos.ValueMember = "Codigo";
            lbProyectos.DataSource = CGestoraProyectos.Proyectos;
        }

        private void lbProyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CProyecto proyecto = (CProyecto)lbProyectos.SelectedItem;
            lbProyectos.DisplayMember = "nombre";
            lbProyectos.ValueMember = "codigo";
            lbTareas.DataSource = proyecto.Tareas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}

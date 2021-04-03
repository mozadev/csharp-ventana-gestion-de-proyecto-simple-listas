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
    public partial class IngreseTareas : Form
    {

        CGestoraProyectos objGestoraProyecto = new CGestoraProyectos();
        public IngreseTareas()
        {
            InitializeComponent();
        }

        private void IngreseTareas_Load(object sender, EventArgs e)
        {
            lbProyectos.DisplayMember = "codigo";
            lbProyectos.ValueMember = "nombre";
            lbProyectos.DataSource = CGestoraProyectos.Proyectos;
        }

        private void btnRegistraProy_Click(object sender, EventArgs e)
        {
            CTareas tareas = new CTareas();
            tareas.nombre = txtNomtarea.Text;
            tareas.codigo = txtcodtarea.Text;
            
            foreach (CProyecto proyecto in lbProyectos .SelectedItems  )
            {
                objGestoraProyecto.RegistrarTareasEnProyecto(proyecto.Codigo, tareas);
            }
            MessageBox.Show("ok");
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}

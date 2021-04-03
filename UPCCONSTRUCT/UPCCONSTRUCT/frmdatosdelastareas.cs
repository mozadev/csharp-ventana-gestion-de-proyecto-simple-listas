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
    public partial class frmdatosdelastareas : Form
    {
        public frmdatosdelastareas()
        {
            InitializeComponent();
            llenarListView();
        }

        private void lstDatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void llenarListView()
        {
            lstDatos.View = View.Details;
            lstDatos.GridLines = true;
            lstDatos.Columns.Add("Codigo", 80);
            lstDatos.Columns.Add("Nombre", 80);
            lstDatos.Columns.Add("Creditos", 80);
            lstDatos.View = View.Details;
            lstDatos.GridLines = true;
            lstDatos.Columns.Add("Codigo", 80);
            lstDatos.Columns.Add("Nombre", 80);
            lstDatos.Columns.Add("Edad", 80);
        }

        void actualizarListas()
        {
            lstCursos.Clear();
            lstDocentes.Clear();
            llenarListView();
            List<Curso> aux = objeC.arrCursos;
            for (int i = 0; i < aux.Count(); i++)
            {
                ListViewItem fila = new ListViewItem(aux[i].codigocurso.ToString());
                fila.SubItems.Add(aux[i].nombrecurso);
                fila.SubItems.Add(aux[i].creditos.ToString());
                lstCursos.Items.Add(fila);
            }


            List<Docente> aux2 = objeD.arrDocente;
            for (int i = 0; i < aux2.Count(); i++)
            {
                ListViewItem fila2 = new ListViewItem(aux2[i].codigodocente.ToString());
                fila2.SubItems.Add(aux2[i].nombredocente);
                fila2.SubItems.Add(aux2[i].edad.ToString());
                lstDocentes.Items.Add(fila2);
            }


        }
    }
}
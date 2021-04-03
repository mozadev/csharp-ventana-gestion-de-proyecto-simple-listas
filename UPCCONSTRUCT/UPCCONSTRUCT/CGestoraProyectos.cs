using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPCCONSTRUCT
{
   public  class CGestoraProyectos
    {

        public static List <CProyecto > Proyectos { get; set; }

        public CGestoraProyectos()
        {
            if (Proyectos ==null )
            {
                Proyectos = new List<CProyecto>();
            }
        }

        public void RegistrarProyecto(CProyecto proyectos)
        {
            Proyectos.Add(proyectos);
        }

        public void RegistrarTareasEnProyecto( string codigoProyecto,CTareas tareas )
        {
            CProyecto  proyectoEncontrado = Proyectos.Find(x => x.Codigo == codigoProyecto);
            if (proyectoEncontrado != null)
            {
                proyectoEncontrado.Tareas.Add(tareas);
            }
        }

        public List <CTareas > ConsultarTareasPorProyecto(string codigoProyecto)
        {
            CProyecto proyectoEncontrado = Proyectos.Find(x => x.Codigo == codigoProyecto);
            if (proyectoEncontrado != null)
            {
                return proyectoEncontrado.Tareas;
            }
            else
            {
                return null;
            }
         
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPCCONSTRUCT
{
    public  class CProyecto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }

        public List <CTareas> Tareas { get; set; }

        public CProyecto()
        {
            Tareas = new List<CTareas>();
        }
    }
}

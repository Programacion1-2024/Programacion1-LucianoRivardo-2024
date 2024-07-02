using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class CopiaLibro
    {
        public int IdCopiaLibro { get; set; }
        public string Comentario { get; set; }
        public float PrecioCopia { get; set; }
        public int CantidadCopias { get; set; }
    }
}

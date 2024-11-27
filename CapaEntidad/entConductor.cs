using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entConductor
    {
        public int ConductorID { get; set; }

        public entCategoria CategoriaID { get; set; }

        public string nombre_conductor { get; set; }

        public int dni { get; set; }

        public string estado { get; set; }

    }
}

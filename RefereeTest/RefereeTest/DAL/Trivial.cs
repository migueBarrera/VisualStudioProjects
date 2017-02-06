using RefereeTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefereeTest.DAL
{
    class Trivial
    {
        public int id { get; set; }
        public string version { get; set; }
        public string idioma { get; set; }
        public string descripcion { get; set; }
        public List<Regla> reglas { get; set; }
    }
}

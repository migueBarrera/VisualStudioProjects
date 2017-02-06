using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefereeTest.Model
{
    class Regla
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public List<Pregunta> preguntas { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefereeTest.Model
{
    class Pregunta
    {
        public int id { get; set; }
        public int regla_id { get; set; }
        public string contenido { get; set; }
        public string anotacion { get; set; }
        public List<Respuesta> respuestas { get; set; }
    }
}

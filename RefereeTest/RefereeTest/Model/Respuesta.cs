using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefereeTest.Model
{
    class Respuesta
    {
        public int id { get; set; }
        public int pregunta_id { get; set; }
        public string contenido { get; set; }
        public string correcta { get; set; }
    }
}

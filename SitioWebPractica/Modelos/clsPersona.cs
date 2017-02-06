using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class clsPersona
    {
        //Propiedades
        [Required]
        public int id { set; get; }
        [Required]
        public String nombre { set; get; }
        [Required]
        public String apellidos { set; get; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true , DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime fechaNac { set; get; }
        [Required]
        public String direccion { set; get; }
        [Required]
        public String telefono { set; get; }


        //Constructores

        public clsPersona()
        {
            id = 0;
            nombre = "";
            apellidos = "";
            fechaNac = DateTime.Today;
            telefono = "";
            direccion = "";
        }

        public clsPersona(int id, String nombre, String apellidos, string telefono,DateTime fehcaNac,string direccion)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNac = fechaNac;
            this.telefono = telefono;
            this.direccion = direccion;
        }


        public String toString() { return this.nombre + "" + this.apellidos; }
    }
}

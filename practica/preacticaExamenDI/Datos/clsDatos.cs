using preacticaExamenDI.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preacticaExamenDI.Datos
{
    class clsDatos
    {
        public ObservableCollection<clsCoche> obtenerListadoCoches()
        {
            ObservableCollection<clsCoche> lista = new ObservableCollection<clsCoche>();
            clsCoche coche = new clsCoche("Audi", "Cabrio", "A3", "gasolina", 125);
            clsCoche coche1 = new clsCoche("Audi", "Cabrio", "A3", "diesel", 110);
            clsCoche coche2 = new clsCoche("Audi", "Cabrio", "A", "diesel", 150);
            clsCoche coche3 = new clsCoche("Audi", "Cabrio", "A5", "diesel", 190);
            clsCoche coche4 = new clsCoche("Audi", "Cabrio", "A5", "diesel", 163);
            clsCoche coche5 = new clsCoche("Audi", "Cabrio", "A5", "diesel", 177);
            clsCoche coch6e = new clsCoche("Audi", "Cabrio", "R8", "gasolina", 430);
            clsCoche coche7 = new clsCoche("Audi", "Todoterreno", "A4", "diesel", 177);
            clsCoche coche8 = new clsCoche("Bentley", "Cabrio", "Continental GT", "gasolina", 590);
            clsCoche coche10 = new clsCoche("Audi", "Cabrio", "A5", "diesel", 163);
            clsCoche coche9 = new clsCoche("Bentley", "Sedan", "Mulsanne", "gasolina", 512);
            clsCoche coche0 = new clsCoche("Bentley", "Sedan", "Flying Spur", "gasolina", 524);
            clsCoche coche00 = new clsCoche("Bentley", "Coupe", "Continental GTC", "gasolina", 645);

            lista.Add(coche);
            lista.Add(coche0);
            lista.Add(coche00);
            lista.Add(coche1);
            lista.Add(coche3);
            lista.Add(coche4);
            lista.Add(coche5);
            lista.Add(coche7);
            lista.Add(coche9);
            lista.Add(coche10);
            lista.Add(coch6e);
            lista.Add(coche9);

            return lista;

        }
    }
}

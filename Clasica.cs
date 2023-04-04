using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chimichanga
{
    public class Clasica : Hamburgesa
    {
        public Clasica(string _Pan, string _Carne, decimal _Precio) : base(_Pan, _Carne, _Precio)
        {
        }
        string[] ingredientes = new string[] { "N/A", "Lechuga", "Tomate", "Bacon", "Pepino" };
        int[] Precios = new int[] { 0, 15, 20, 25, 10 };
        public override string PrecioHamburguesa()
        {           
            return "La clasica cuesta 250 pesos";
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chimichanga
{
    internal class Premium : Hamburgesa
    {
        public Premium (string _Pan, string _Carne, decimal _Precio) : base (_Pan, _Carne, _Precio) 
        { 
        }
        public override string PrecioHamburguesa()
        {
            return "La hamburguesa premium cuesta 500 pesos";
        }
        public void Orden()
        {
            Console.WriteLine("Su hamburguesa premium esta lista. \nPrecio: 500");
        }
    }
}

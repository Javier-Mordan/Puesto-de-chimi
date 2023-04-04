using Chimichanga;
using System;

namespace Chimi
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1)Observar precios \n2) Ordenar Pedido");
            int Select = Convert.ToInt32(Console.ReadLine());
            if (Select == 1) 
            {
                Clasica clasica = new Clasica("Normal","Cerdo", 250);
                Saludable saludable = new Saludable("integral", "Cerdo", 350);
                Premium premium = new Premium("Normal", "Cerdo", 500);

                Console.WriteLine($"{clasica.PrecioHamburguesa()} {saludable.PrecioHamburguesa()} {premium.PrecioHamburguesa()}");
            }
            Console.WriteLine("Seleccione su orden: \n1) Hamburguesa clasica \n 2) Hamburguesa Saludable \n3) Hamburguesa Premium");
            int opcion = Convert.ToInt32(Console.ReadLine());
            if (opcion == 1)
            {
                Clasica clasica = new Clasica("Normal", "Cerdo", 250);
                clasica.Ingredientes();                
            } else if (opcion == 2)
            {
                Saludable saludable = new Saludable("Integral", "Cerdo", 350);
                saludable.Ingredientes();
            } else
            {
                Premium premium = new Premium("Normal", "Cerdo", 500);
                premium.Ingredientes();
            }

            Console.WriteLine("Gracias por realizar su orden.");
        }
    } 
}

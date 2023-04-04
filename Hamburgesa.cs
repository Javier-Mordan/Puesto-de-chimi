using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Chimichanga
{
    public abstract class Hamburgesa
    {
        public string Pan { get; set; }
        public string Carne { get; set; }
        public decimal Precio { get; set; }

        public Hamburgesa (string _Pan , string _Carne , decimal _Precio)
        {
            Pan = _Pan;
            Carne = _Carne;
            Precio = _Precio;
            
        }
        string[] ingredientes = new string[] { "N/A", "Lechuga", "Tomate", "Bacon", "Pepino" };
        int[] Precios = new int[] { 0, 15, 20, 25, 10 };
        public virtual string PrecioHamburguesa()
        {
            Console.WriteLine("Precio de cada ingrediente adicional:");
            for (int x = 1; x < Precios.Length; x++)
            {
                Console.WriteLine($"{ingredientes[x]} = {Precios[x]}");
            }
            return "La hamburguesa cuesta 200 pesos";
        }
        
        public virtual void Ingredientes()
        {            
            Console.WriteLine($"Seleccione algun ingrediente extra? \n1) Lechuga \n2) Tomate \n3) bacon \n4) Pepinillo \n0) N/A");
            string eleccion = Console.ReadLine();

            List<char> list = new List<char>(eleccion);
            
            int Ptotal = 0;
            Console.WriteLine("Sus Le agregaste  los siguientes ingredientes:");
            foreach (char x in list)
            {
                Console.WriteLine(ingredientes[(int)Char.GetNumericValue(x)]);
                Ptotal += Precios[(int)Char.GetNumericValue(x)];
            }
            Console.WriteLine($"Con un costo tatal de: {Ptotal + Precio}" );
        }

    }
}

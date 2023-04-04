using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chimichanga
{
    public class Saludable : Hamburgesa
    {
        public Saludable(string _Pan, string _Carne, decimal _Precio) : base(_Pan, _Carne, _Precio)
        {
        }
        public override string PrecioHamburguesa()
        {
            Console.WriteLine("Precio de cada ingrediente adicional:");
            for (int x = 1; x < Precios.Length; x++)
            {
                Console.WriteLine($"{ingredientes[x]} = {Precios[x]}");
            }
            return "La saludable cuesta 350 pesos";
        }
        string[] ingredientes = new string[] { "N/A", "Lechuga", "Tomate", "Bacon", "Pepino", "Papas", "Queso" };
        int[] Precios = new int[] { 0, 15, 20, 25, 10, 40, 50 };
        public override void Ingredientes()
        {
            
            Console.WriteLine($"Seleccione algun ingrediente extra? \n1) Lechuga \n2) Tomate \n3) bacon \n4) Pepinillo \n5) Papas \n6) Queso \n0) N/A");
            string eleccion = Console.ReadLine();

            List<char> list = new List<char>(eleccion);
            
            int Ptotal = 0;
            Console.WriteLine("Sus ingredientes adicionales son:");
            foreach (char x in list)
            {
                Console.WriteLine(ingredientes[(int)Char.GetNumericValue(x)]);
                Ptotal += Precios[(int)Char.GetNumericValue(x)];
            }
            Console.WriteLine($"Con un costo tatal de: {Ptotal + Precio}");
        }
    }
}

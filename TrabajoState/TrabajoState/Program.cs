using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoState
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo ve = new Vehiculo(1000);
            string opcion;
            do
            {
                Console.WriteLine("\n1.-Encender\n" +
                    "2.- Acelerar\n" +
                    "3.- Frenar\n" +
                    "4.-Salir\n");
                opcion = Console.ReadLine();

                ve.Acelerar();
                if (opcion == "1") { ve.Encender(); }
                if (opcion == "2") { ve.Acelerar(); }
                if (opcion == "3") { ve.Frenar(); }

            } while (opcion != "4");
        }
    }
}

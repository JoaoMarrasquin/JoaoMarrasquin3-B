using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoState
{
    public class SinCombustible: IEstado
    {
        // Referencia a la clase de contexto
        Vehiculo v;


        // Constructor que inyecta la dependencia en la clase actual
        public SinCombustible(Vehiculo v)
        {
            this.v = v;
        }

        public void Acelerar()
        {
            Console.WriteLine("ERROR: El vehiculo se encuentra sin combustible");
        }

        public void Frenar()
        {
            Console.WriteLine("ERROR: El vehiculo se encuentra sin combustible");
        }

        public void Encender()
        {
            Console.WriteLine("ERROR: El vehiculo se encuentra sin combustible");
        }

    }
}

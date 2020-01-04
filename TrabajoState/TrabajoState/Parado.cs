using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoState
{
    public class Parado : IEstado
    {
        Vehiculo v;

        public Parado(Vehiculo v)
        {
            this.v = v;
        }
        public void Acelerar()
        {
            if (v.CombustibleActual > 0)
            {
                v.Estado = new EnMarcha(v);
                Console.WriteLine("El vehiculo se encuentra ahora EN MARCHA");


                v.ModificarVelocidad(10);
                v.ModificarCombustible(-10);
            }
            else
            {
                v.Estado = new SinCombustible(v);
                Console.WriteLine("El vehiculo se encuentra ahora SIN COMBUSTIBLE");
            }
        }

        public void Frenar()
        {
            Console.WriteLine("ERROR: El vehiculo ya se encuentra detenido");
        }

        public void Encender()
        {
            v.Estado = new Apagado(v);
            Console.WriteLine("El vehiculo se encuentra ahora APAGADO");
        }

    }
}
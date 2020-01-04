using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoState
{
    public class EnMarcha : IEstado
    {
        int velocidadmax = 100;
        Vehiculo v;

        public EnMarcha(Vehiculo v)
        {
            this.v = v;
        }

        public void Acelerar()
        {
            Console.WriteLine("Velocidad actual: " + v.VelocidadActual + ". Combustible restante: " + v.CombustibleActual);

            if (v.CombustibleActual > 0)
            {
                if (v.VelocidadActual >= velocidadmax)
                {
                    Console.WriteLine("ERROR: El coche ha alcanzado su velocidad maxima");
                    v.ModificarCombustible(-10);
                }
                else
                {
                    v.ModificarVelocidad(10);
                    v.ModificarCombustible(-10);
                }
            }
            else
            {
                v.Estado = new SinCombustible(v);
                Console.WriteLine("El vehiculo se ha quedado sin combustible");
            }
        }

        public void Frenar()
        {
            v.ModificarVelocidad(-10);
            if (v.VelocidadActual <= 0)
                {
                v.Estado = new Parado(v);
                Console.WriteLine("El vehiculo se encuentra ahora PARADO");
                }                       
        }
        public void Encender()
        {
            Console.WriteLine("El vehículo ya está encendido");
        }
    }
}
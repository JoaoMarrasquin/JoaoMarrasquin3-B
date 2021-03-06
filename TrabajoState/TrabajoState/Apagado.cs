﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoState
{
    public class Apagado: IEstado
    {
        Vehiculo v;
        public Apagado(Vehiculo apagado)
        {
            v = apagado;
        }

        public void Acelerar()
        {
            Console.WriteLine("ERROR: El vehiculo esta apagado. Efectue el contacto para iniciar");
        }

        public void Frenar()
        {
            Console.WriteLine("ERROR: El vehiculo esta apagado. Efectue el contacto para iniciar");
        }

        public void Encender()
        {
            if (v.CombustibleActual > 0)
            {
                v.Estado = new Parado(v);
                Console.WriteLine("El vehiculo se encuentra ahora PARADO");
                v.VelocidadActual = 0;
            }
            else
            {
                v.Estado = new SinCombustible(v);
                Console.WriteLine("El vehiculo se encuentra sin combustible");
            }
        }
        public override string ToString()
        {
            return string.Format("En marcha - Velocidad {0}, Combustible {1}", v.VelocidadActual, v.CombustibleActual);
        }
    }
}

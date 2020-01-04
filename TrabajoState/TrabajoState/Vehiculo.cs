using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoState
{
    public class Vehiculo : IEstado
    {
        private IEstado estado;
        private int velocidadActual = 0;
        private int combustibleActual = 0;

        public IEstado Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public int VelocidadActual
        {
            get { return velocidadActual; }
            set { velocidadActual = value; }
        }
        public int CombustibleActual
        {
            get { return combustibleActual; }
            set { velocidadActual = value; }

        }
        public Vehiculo(int combustible)
        {
            this.combustibleActual = combustible;
            estado = new Apagado(this);
        }
        public void Acelerar()
        {
            estado.Acelerar();
        }

        public void Frenar()
        {
            estado.Frenar();
        }

        public void Encender()
        {
            estado.Encender();
        }

        public void ModificarVelocidad(int kmh)
        {
            int velocidadreducida=0;
            velocidadActual += kmh;
            kmh = velocidadreducida;
        }

        public void ModificarCombustible(int decilitros)
        {
            combustibleActual += decilitros;
        }
    }
}
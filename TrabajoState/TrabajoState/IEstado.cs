using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoState
{
    public interface IEstado
    {
        void Acelerar();
        void Frenar();
        void Encender();

    }
}

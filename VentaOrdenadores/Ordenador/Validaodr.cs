using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaOrdenadores.Ordenador
{
    public class Validador
    {
        public bool ValidarOrdenador(IOrdenador ordenador)
        {
            return ordenador.Precio > 0 && ordenador.Garantia > 0;
        }
    }
}

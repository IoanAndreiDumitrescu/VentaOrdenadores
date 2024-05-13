using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaOrdenadores.Ordenador
{
    public class FabricaOrdenador
    {
        private Validador validador;

        public FabricaOrdenador(Validador validador)
        {
            this.validador = validador;
        }

        public IOrdenador CrearOrdenador(int tipo) 
        {
            IOrdenador ordenador = null;
            switch (tipo)
            {
                case 1:
                    ordenador = new OrdenadorLentorro();
                    break;
                case 2:
                    ordenador = new OrdenadorNormal();
                    break;
                case 3:
                    ordenador = new OrdenadorGamer();
                    break;
            }

            if (validador.ValidarOrdenador(ordenador))
            {
                return ordenador;
            }
            else
            {
                return null;
            }
        }
    }
}
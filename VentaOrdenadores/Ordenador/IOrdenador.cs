using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaOrdenadores.Ordenador
{
    public interface IOrdenador
    {
        double Precio { get; }
        int Garantia { get; }
        double CalcularTiempoMedio();
    }
}

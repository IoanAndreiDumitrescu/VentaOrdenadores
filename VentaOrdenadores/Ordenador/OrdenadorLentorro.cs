using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaOrdenadores.Ordenador
{
    public class OrdenadorLentorro : IOrdenador
    {
        public double Precio { get; set; } = 100;
        public int Garantia { get; set; } = 2;

        public double CalcularTiempoMedio()
        {
            return Precio / Garantia;
        }

        public override string ToString()
        {
            return $"Lentorro, Precio: {Precio}, Garantia: {Garantia}, Tiempo medio: {CalcularTiempoMedio()}";
        }
    }
}

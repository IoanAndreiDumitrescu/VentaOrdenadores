using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaOrdenadores.Ordenador
{
    public class OrdenadorGamer : IOrdenador
    {
        public double Precio { get; set; } = 1000;
        public int Garantia { get; set; } = 4;

        public double CalcularTiempoMedio()
        {
            return Precio / Garantia;
        }

        public override string ToString()
        {
            return $"Gamer, Precio: {Precio}, Garantia: {Garantia}, Tiempo medio: {CalcularTiempoMedio()}";
        }
    }
}

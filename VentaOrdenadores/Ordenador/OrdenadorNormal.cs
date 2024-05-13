using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaOrdenadores.Ordenador
{
    public class OrdenadorNormal : IOrdenador
    {
        public double Precio { get; set; } = 300;
        public int Garantia { get; set; } = 3;

        public double CalcularTiempoMedio()
        {
            return Precio / Garantia;
        }

        public override string ToString()
        {
            return $"Normal, Precio: {Precio}, Garantia:  {Garantia} , Tiempo medio: {CalcularTiempoMedio()}";
        }
    }
}

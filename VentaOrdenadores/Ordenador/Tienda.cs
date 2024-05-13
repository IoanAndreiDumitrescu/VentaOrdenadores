using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaOrdenadores.Ordenador
{
    public class Tienda
    {
        private List<IOrdenador> Ordenadores { get; set; }

        public Tienda()
        {
            Ordenadores = new List<IOrdenador>();
        }

        public void AgregarOrdenador(IOrdenador ordenador)
        {
            this.Ordenadores.Add(ordenador);
        }

        public double TotalFacturado()
        {
            return Ordenadores.Sum(precio => precio.Precio);
        }

        public int NumeroOrdenadoresVendidos()
        {
            return Ordenadores.Count;
        }

        public IOrdenador OrdenadorMasBarato()
        {
            return Ordenadores.OrderBy(precio => precio.Precio).FirstOrDefault();
        }

        public IOrdenador OrdenadorMasCaro()
        {
            return Ordenadores.OrderByDescending(precio => precio.Precio).FirstOrDefault();
        }

        public double PrecioMedioPorOrdenador()
        {
            return TotalFacturado() / NumeroOrdenadoresVendidos();
        }

        public int NumeroOrdenadoresPrecioSuperiorA125()
        {
            return Ordenadores.Count(precio => precio.Precio > 125);
        }


        public void Listado()
        {
            Parallel.ForEach(Ordenadores, (ordenador) =>
            {
                Console.WriteLine(ordenador);
            });
        }

    }
}

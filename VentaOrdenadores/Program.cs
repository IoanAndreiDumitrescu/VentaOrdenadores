using VentaOrdenadores.Ordenador;

Validador validador = new Validador();
FabricaOrdenador fabrica = new FabricaOrdenador(validador);
Tienda tienda = new Tienda();

bool exit = false;
while (!exit)
{
    Console.WriteLine("Introduce el tipo de ordenador que has vendido (1: Lentorro, 2: Normal, 3: Gamer) o 0 para salir:");
    var input = Console.ReadLine();

    switch (input)
    {
        case "1":
            tienda.AgregarOrdenador(fabrica.CrearOrdenador(1));
            Console.WriteLine("Se ha añadido un ordenador Lentorro");
            break;
        case "2":
            tienda.AgregarOrdenador(fabrica.CrearOrdenador(2));
            Console.WriteLine("Se ha añadido un ordenador Normal");
            break;
        case "3":
            tienda.AgregarOrdenador(fabrica.CrearOrdenador(3));
            Console.WriteLine("Se ha añadido un ordenador Gamer");
            break;
        case "0":
            exit = true;
            break;
        default:
            Console.WriteLine("Entrada no reconocida");
            break;
    }
}

Console.WriteLine("Aquí están los ordenadores vendidos:");
tienda.Listado();
Console.WriteLine($"Aqui es el precio medio de los ordenadores vendidos: {tienda.PrecioMedioPorOrdenador().ToString()} ");
Console.WriteLine($"El total facturado : {tienda.TotalFacturado().ToString()}");
Console.WriteLine($"Numero ordenadores con precio superior a 125: {tienda.NumeroOrdenadoresPrecioSuperiorA125().ToString()}");
Console.WriteLine($"El ordenador mas caro: {tienda.OrdenadorMasCaro().ToString()}");
Console.WriteLine($"El ordenador mas barato: {tienda.OrdenadorMasBarato().ToString()}");
Console.WriteLine($"Numero de ordenadores vendidos: {tienda.NumeroOrdenadoresVendidos().ToString()}");
    
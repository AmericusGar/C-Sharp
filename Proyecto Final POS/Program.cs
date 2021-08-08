using System;

namespace POS
{
    class Program
    {
       
        
             static void Main(string[] args)
        {
            ReporteVentas reporte = new ReporteVentas();
            string opcion = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Sistema de Ventas");
                Console.WriteLine("*****************");
                Console.WriteLine("");
                Console.WriteLine("1 - Productos Disponibles");
                Console.WriteLine("2 - Realizar Venta");
                Console.WriteLine("3 - Lista de Clientes");
                Console.WriteLine("4 - Reporte de Ventas");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        reporte.ListarProductos();
                        break;
                    case "2":
                        reporte.CrearVenta();
                        break;
                    case "3":
                        reporte.ListarClientes();
                        break;
                       
                    case "4":
                        reporte.ListarVentas();
                        break;                                          
                    default:
                        break;
                }

                if (opcion == "0") {
                    break;
                }
            }
        }
    }
}
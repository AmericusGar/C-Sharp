using System;
using System.Collections.Generic;
public class ReporteVentas
{
    public List<Producto> ListadeProductos { get; set; }
    public List<Cliente> ListadeClientes { get; set; }
    public List<Ventas> ListaVentas { get; set; }

    public ReporteVentas()
    {
        ListadeProductos = new List<Producto>();
        cargarProductos();

        ListadeClientes = new List<Cliente>();
        cargarClientes();


        ListaVentas = new List<Ventas>();
    }

    private void cargarProductos()
    {
        Producto p1 = new Producto(1, "Estufa", 6000);
        ListadeProductos.Add(p1);

        Producto p2 = new Producto(2, "Refrigerador", 10000);
        ListadeProductos.Add(p2);

        Producto p3 = new Producto(3, "Lavadora", 7500);
        ListadeProductos.Add(p3);

        Producto p4 = new Producto(4, "Ventilador", 700);
        ListadeProductos.Add(p4);
    }

    private void cargarClientes()
    {
        Cliente c1 = new Cliente(1, "Santiago", "31237856");
        ListadeClientes.Add(c1);

        Cliente c2 = new Cliente(2, "Daniel", "99987545");
        ListadeClientes.Add(c2);

         Cliente c3 = new Cliente(3, "Carlos", "99987235");
        ListadeClientes.Add(c3);
    }


    public void ListarProductos()
    {
        Console.Clear();
        Console.WriteLine("Productos Disponibles");
        Console.WriteLine("**********************");
        Console.WriteLine("");
        
        foreach (var producto in ListadeProductos)
        {
            Console.WriteLine(producto.Codigo + " | " + producto.Descripcion + " | " + producto.Precio);
        }

        Console.ReadLine();
    }

    public void ListarClientes()
    {
        Console.Clear();
        Console.WriteLine("Lista de Clientes");
        Console.WriteLine("******************");
        Console.WriteLine("");
        
        foreach (var cliente in ListadeClientes)
        {
            Console.WriteLine(cliente.Codigo + " | " + cliente.Nombre + " | " + cliente.Telefono);
        }

        Console.ReadLine();
    }


    public void CrearVenta()
    {
        Console.WriteLine("Venta");
        Console.WriteLine("******");
        Console.WriteLine("");

        Console.WriteLine("Ingrese el codigo del cliente: ");
        string codigoCliente = Console.ReadLine();

        Cliente cliente = ListadeClientes.Find(c => c.Codigo.ToString() == codigoCliente);        
        if (cliente == null)
        {
            Console.WriteLine("Cliente no encontrado");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Cliente: " + cliente.Nombre);
            Console.WriteLine("");
        }


        int nuevoCodigo = ListaVentas.Count + 1;

        Ventas nuevaVenta = new Ventas(nuevoCodigo, DateTime.Now, "SPS" + nuevoCodigo, cliente);
        ListaVentas.Add(nuevaVenta);

        while(true)
        {
            Console.WriteLine("Ingrese el producto: ");
            string codigoProducto = Console.ReadLine();
            Producto producto = ListadeProductos.Find(p => p.Codigo.ToString() == codigoProducto);        
            if (producto == null)
            {
                Console.WriteLine("Producto no encontrado");
                Console.ReadLine();
            } else {
                Console.WriteLine("Producto agregado: " + producto.Descripcion + " con precio de: " + producto.Precio);
                nuevaVenta.AgregarProducto(producto);
            }

            Console.WriteLine("Desea continuar? s/n");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "n") {
                break;
            }
        }

        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("***************************************");
        Console.WriteLine("Subtotal: "                   + nuevaVenta.Subtotal);
        Console.WriteLine("Impuesto sobre venta (15%): " + nuevaVenta.Impuesto);
        Console.WriteLine("Total de la orden es de: "    + nuevaVenta.Total);
        Console.WriteLine("***************************************");
        Console.ReadLine();

    }


    public void ListarVentas()
    {
        Console.Clear();
        Console.WriteLine("Reporte de Venta");
        Console.WriteLine("*****************");
        Console.WriteLine("");  
        Console.WriteLine("Codigo | Fecha ");
        Console.WriteLine("Cliente");
        Console.WriteLine("*******");
        Console.WriteLine("");  

        foreach (var venta in ListaVentas)
        {
            Console.WriteLine(venta.Codigo + " | " + venta.Fecha + " | " );
            Console.WriteLine(venta.Cliente.Nombre);
            
            foreach (var detalle in venta.ListaVentaDetalle)
            {
                Console.WriteLine("     " + detalle.Producto.Descripcion + " | " + detalle.Cantidad + " | " + detalle.Precio);
                    }
            Console.WriteLine("");  

            Console.WriteLine("Subtotal = "  + venta.Subtotal);
            Console.WriteLine("Impuesto = "  + venta.Impuesto);
            Console.WriteLine("Total = " + venta.Total);

            Console.ReadLine();
        }

    }
}
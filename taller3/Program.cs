
using System;
using System.Collections.Generic;
using taller3.Models;

class Program
{
	private static ClienteContext context;

	static void Main(string[] args)
	{
		//guardarCliente();
		//consultarClientes();
		//consultarCliente();
		//modificarCliente();
		//eliminarCliente();
		consultarClientesFunciones();
	}

	public static void agregarCliente()
	{
		Console.WriteLine("Metodo agregar cliente");
		ClienteContext context = new ClienteContext();
		{
			Cliente cliente = new Cliente();
			cliente.Nombre = "Juan";
			cliente.Apellido = "Perez";
			cliente.Direccion = "Calle 123";
			cliente.Telefono = "123456789";
			cliente.FechaNacimiento = new DateTime(1990, 1, 1);
			cliente.Estado = "Activo";

			context.Clientes.Add(cliente);
			context.SaveChanges();

			Console.WriteLine("Id: " + cliente.Id + ", Nombre: " + cliente.Nombre);
		}
	}

	public static void consultarClientes()
	{
		Console.WriteLine("Metodo consultar clientes");
		var context = new ClienteContext();
		{
			List<Cliente> listClientes = context.Clientes.ToList();

			foreach (var cliente in listClientes)
			{
				Console.WriteLine("Id: " + cliente.Id + ", Nombre: " + cliente.Nombre);
			}
		}
	}

	public static void consultarCliente()
	{
		Console.WriteLine("Metodo consultar cliente por Id");
		context = new ClienteContext();
		
			Cliente cliente = context.Clientes.Find(1);

			Console.WriteLine("Id: " + cliente.Id + ", Nombre: " + cliente.Nombre);
		
	}

	public static void modificarCliente()
	{
		Console.WriteLine("Metodo modificar cliente");
	ClienteContext context = new ClienteContext();
	
		Cliente cliente = new Cliente();
		cliente = context.Clientes.Find(1);
	

	cliente.Nombre = "Jose";
	context.SaveChanges();
	Console.WriteLine("Id: " + cliente.Id + ", Nombre: " + cliente.Nombre);
		
	}

	public static void eliminarCliente()
	{
		Console.WriteLine("Metodo eliminar cliente");
		var context = new ClienteContext();
		{
			Cliente cliente = context.Clientes.Find(1);
			context.Remove(cliente);
			context.SaveChanges();

			Console.WriteLine("Id: " + cliente.Id + ", Nombre: " + cliente.Nombre);
		}
	}

	public static void consultarClientesFunciones()
	{
		Console.WriteLine("Metodo consultar clientes con el uso de funciones");
		var context = new ClienteContext();
		
			Console.WriteLine("Cantidad de registros: " + context.Clientes.Count());
			Cliente cliente = context.Clientes.First();

			Console.WriteLine("Primer elemento de la tabla: " + cliente.Id + "-" + cliente.Nombre);

			List<Cliente> listClientes;

			//listClientes = context.Clientes.Where(c => c.Id > 2 && c.Nombre == "Ana").ToList();

			//listClientes = context.Clientes.Where(c => c.Nombre == "Pedro" || c.Nombre == "Ana").ToList();

			listClientes = context.Clientes.Where(c => c.Nombre.StartsWith("A")).ToList();

			/*
            var query = context.Clientes.GroupBy(c => c.Nombre)
                .Select(g => new
                {
                    Nombre = g.Key,
                    Cantidad = g.Count()
                }).ToList();

            foreach (var result in query)
            {
                Console.WriteLine($"Nombre: {result.Nombre}, Cantidad: {result.Cantidad}");
            }
            */

			foreach (var Cliente in listClientes)
				{
					Console.WriteLine("Id: " + cliente.Id + ", Nombre: " + cliente.Nombre);
				}
		
	}
}

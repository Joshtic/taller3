using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller3.Models
{
	public class Cliente
	{
		public int ClientetId { get; set; }
		public string Nombre { get; internal set; }
		public string Apellido { get; internal set; }
		public string Direccion { get; internal set; }
		public string Telefono { get; internal set; }
		public DateTime FechaNacimiento { get; internal set; }
		public string Estado { get; internal set; }
		public string Id { get; internal set; }
	}
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller3.Models
{
	public class ClienteContext : DbContext
	{
		public DbSet<Cliente> Clientes { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=localhost;Database=taller3;Trusted_Connection=True;");
		}

		internal void Remove(Cliente? cliente)
		{
			throw new NotImplementedException();
		}

		internal void SaveChanges()
		{
			throw new NotImplementedException();
		}
	}
}

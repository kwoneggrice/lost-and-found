using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostAndFound.Models
{
	public class LostAndFoundContext : DbContext
	{
		#region PROPERTIES

		public DbSet<LostInfo> LostInfos { get; set; }

		#endregion

		#region METHODS

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=X;Database=lost_and_found;User Id=kwoneggrice;Password=kwoneggrice;TrustServerCertificate=True;");
		}

		#endregion
	}
}

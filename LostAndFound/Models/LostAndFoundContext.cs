using Microsoft.EntityFrameworkCore;

namespace LostAndFound.Models
{
	/// <summary>
	/// Entity와 데이터베이스를 매핑하는 DBContext
	/// </summary>
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

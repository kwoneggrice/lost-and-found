using System.ComponentModel.DataAnnotations;

namespace LostAndFound.Models
{
	/// <summary>
	/// 데이터베이스 테이블과 매핑할 Entity
	/// </summary>
	public class LostInfo
	{
		#region PROPERTIES

		[Key]
		public long Id { get; set; }

		[Required]
		public string? LostItem { get; set; }

		[Required]
		public string? LostLocation { get; set; }

		[Required]
		public string? AcquirerName { get; set; }

		[Required]
		public DateTime LostDate { get; set; }

		public string? OwnerName { get; set; }

		public DateTime? FoundDate { get; set; }

		#endregion
	}
}

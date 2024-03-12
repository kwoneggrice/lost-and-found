using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Models
{
	/// <summary>
	/// 데이터베이스 테이블과 매핑할 Entity
	/// </summary>
	[Table("lost_infos")]
	public class LostInfo
	{
		#region PROPERTIES

		[Key]
		[Column("id")]
		public long Id { get; set; }

		[Required]
		[Column("lost_item")]
		public string? LostItem { get; set; }

		[Required]
		[Column("lost_location")]
		public string? LostLocation { get; set; }

		[Required]
		[Column("acquirer_name")]
		public string? AcquirerName { get; set; }

		[Required]
		[Column("lost_date")]
		public DateTime LostDate { get; set; }

		[Column("owner_name")]
		public string? OwnerName { get; set; }

		[Column("found_date")]
		public DateTime? FoundDate { get; set; }

		#endregion
	}
}

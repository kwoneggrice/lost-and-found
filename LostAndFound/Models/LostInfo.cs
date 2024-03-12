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
		[Column(name: "id")]
		public long Id { get; set; }

		[Required]
		[Column(name: "lost_item")]
		public string? LostItem { get; set; }

		[Required]
		[Column(name: "lost_location")]
		public string? LostLocation { get; set; }

		[Required]
		[Column(name: "acquirer_name")]
		public string? AcquirerName { get; set; }

		[Required]
		[Column(name: "lost_date")]
		public DateTime LostDate { get; set; }

		[Column(name: "owner_name")]
		public string? OwnerName { get; set; }

		[Column(name: "found_date")]
		public DateTime? FoundDate { get; set; }

		#endregion
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostAndFound.Models
{
	/// <summary>
	/// 데이터베이스 테이블과 매핑할 Entity
	/// </summary>
	public class LostInfo
	{
		[Key]
		public long Id { get; set; }

		[Required]
		public string? LostItem { get; set; }

		[Required]
		public string? Location { get; set; }

		[Required]
		public DateTime LostDate { get; set; }

		public DateTime FoundDate { get; set; }
	}
}

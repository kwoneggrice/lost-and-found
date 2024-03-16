using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Models
{
	[Table(name: "users")]
	[Index(nameof(UserId), IsUnique = true)]
	public class User
	{
		#region PROPERTIES

		[Key]
		[Column(name: "id")]
		public long Id { get; set; }

		[Required]
		[Column(name: "user_id")]
		public string UserId { get; set; }

		[Required]
		[Column(name: "password")]
		public string Password { get; set; }

		#endregion
	}
}

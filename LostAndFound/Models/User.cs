using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

using System.Security.Cryptography;
using System.Text;

namespace LostAndFound.Utils
{
	public class PasswordUtil
	{
		#region METHODS

		public static string HasingPassword(string password)
		{
			using (SHA256 hash = SHA256.Create())
			{
				StringBuilder sb = new StringBuilder();

				byte[] bytes = hash.ComputeHash(Encoding.UTF8.GetBytes(password));

				for (int i = 0; i < bytes.Length; i++)
				{
					sb.Append(bytes[i].ToString("x2"));
				}

				return sb.ToString();
			}
		}

		#endregion
	}
}

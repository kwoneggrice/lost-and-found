using LostAndFound.Interfaces;
using LostAndFound.Models;

namespace LostAndFound.Services
{
	public class UserService : IUserService<User>
	{
		#region FIELDS

		private readonly LostAndFoundContext _lostAndFoundContext;

		#endregion

		#region CONSTRUCTOR

		public UserService(LostAndFoundContext lostAndFoundContext)
		{
			_lostAndFoundContext = lostAndFoundContext;
		}

		#endregion

		#region METHODS

		/// <summary>
		/// 유저정보를 users 테이블에 추가
		/// </summary>
		/// <param name="entity"></param>
		public void CreateUser(User entity)
		{
			_lostAndFoundContext.Users.Add(entity);
			_lostAndFoundContext.SaveChanges();
		}

		/// <summary>
		/// users 테이블에서 특정 userId와 일치하는 데이터 조회
		/// </summary>
		/// <param name="userId"></param>
		/// <returns></returns>
		public User GetUser(string userId)
		{
			return _lostAndFoundContext.Users.FirstOrDefault(x => x.UserId == userId);
		}

		#endregion
	}
}

namespace LostAndFound.Interfaces
{
	public interface IUserService<T>
	{
		#region METHODS

		/// <summary>
		/// 회원가입을 통해 유저정보를 DB에 저장
		/// </summary>
		/// <param name="entity">저장할 유저정보</param>
		public void CreateUser(T entity);

		/// <summary>
		/// users 테이블에서 특정 userId와 일치하는 정보 조회
		/// </summary>
		/// <param name="userId">조회할 userId</param>
		/// <returns></returns>
		public T GetUser(string userId);

		#endregion
	}
}

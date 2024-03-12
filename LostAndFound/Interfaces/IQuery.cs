namespace LostAndFound.Interfaces
{
	public interface IQuery<T>
	{
		#region METHODS

		/// <summary>
		/// 데이터베이스 테이블에서 전체 데이터 조회
		/// </summary>
		/// <returns></returns>
		List<T> GetAll();

		/// <summary>
		/// 데이터베이스 테이블에서 특정 데이터 조회
		/// </summary>
		/// <param name="id">조회할 행의 id</param>
		/// <returns></returns>
		T GetDetail(long? id);

		/// <summary>
		/// 데이터베이스 테이블의 행 삽입
		/// </summary>
		/// <param name="entity">삽입할 행의 entity</param>
		void Create(T entity);

		/// <summary>
		/// 데이터베이스 테이블의 행 수정
		/// </summary>
		/// <param name="entity">수정된 행의 entity</param>
		void Update(T entity);

		/// <summary>
		/// 데이터베이스 테이블의 행 삭제
		/// </summary>
		/// <param name="id">삭제할 행의 id</param>
		void Delete(long? id);

		/// <summary>
		/// 데이터베이스 테이블에서 특정 날짜 데이터 조회
		/// </summary>
		/// <param name="dateTime">조회할 날짜</param>
		/// <returns></returns>
		List<T> GetAllByDateTime(DateTime dateTime);

		#endregion
	}
}

using LostAndFound.Interfaces;
using LostAndFound.Models;

namespace LostAndFound.Services
{
	public class LostInfoService : ILostInfoService<LostInfo>
	{
		#region FIELDS

		private readonly LostAndFoundContext _lostAndFoundContext;

		#endregion

		#region CONSTRUCTOR

		public LostInfoService(LostAndFoundContext lostAndFoundContext)
		{
			_lostAndFoundContext = lostAndFoundContext;
		}

		#endregion

		#region METHODS

		/// <summary>
		/// LostInfos 테이블에 행 삽입
		/// </summary>
		/// <param name="entity">테이블에 추가할 entity</param>
		public void Create(LostInfo entity)
		{
			_lostAndFoundContext.LostInfos.Add(entity);
			_lostAndFoundContext.SaveChanges();
		}

		/// <summary>
		/// LostInfos 테이블의 행 삭제
		/// </summary>
		/// <param name="id">삭제할 행의 id</param>
		/// <exception cref="InvalidOperationException"></exception>
		public void Delete(long? id)
		{
			var data = _lostAndFoundContext.LostInfos.FirstOrDefault(x => x.Id == id);

			if (data != null)
			{
				_lostAndFoundContext.LostInfos.Remove(data);
				_lostAndFoundContext.SaveChanges();
			}
			else
			{
				throw new InvalidOperationException();
			}
		}

		/// <summary>
		/// LostInfos 테이블에서 전체 행 조회
		/// </summary>
		/// <returns></returns>
		public List<LostInfo> GetAll()
		{
			return _lostAndFoundContext.LostInfos.ToList();
		}

		/// <summary>
		/// LostInfos 테이블에서 특정 행 조회
		/// </summary>
		/// <param name="id">LostInfos 테이블에서 가져올 데이터의 id</param>
		/// <returns></returns>
		/// <exception cref="InvalidOperationException"></exception>
		public LostInfo GetDetail(long? id)
		{
			var data = _lostAndFoundContext.LostInfos.FirstOrDefault(x => x.Id == id);

			if (data != null)
			{
				return data;
			}
			else
			{
				throw new InvalidOperationException();
			}
		}

		/// <summary>
		/// LostInfos 테이블의 행 수정
		/// </summary>
		/// <param name="entity">수정된 정보를 가지고 있는 entity</param>
		public void Update(LostInfo entity)
		{
			_lostAndFoundContext.LostInfos.Update(entity);
			_lostAndFoundContext.SaveChanges();
		}

		public List<LostInfo> GetAllByDateTime(DateTime dateTime)
		{
			return _lostAndFoundContext.LostInfos.Where(x => x.LostDate.Date == dateTime.Date).ToList();
		}

		#endregion
	}
}

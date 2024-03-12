using LostAndFound.Interfaces;
using LostAndFound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostAndFound.Services
{
	public class LostInfoService : IQuery<LostInfo>
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
		/// LostInfos 테이블에 데이터 추가하는 메소드
		/// </summary>
		/// <param name="entity">테이블에 추가할 entity</param>
		public void Create(LostInfo entity)
		{
			_lostAndFoundContext.LostInfos.Add(entity);
			_lostAndFoundContext.SaveChanges();
		}

		/// <summary>
		/// LostInfos 테이블에서 id 값과 일치하는 행을 삭제하는 메소드
		/// </summary>
		/// <param name="id">삭제할 행의 id</param>
		/// <exception cref="InvalidOperationException"></exception>
		public void Delete(long id)
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
		/// LostInfos 테이블에서 전체 행을 가져오는 메소드
		/// </summary>
		/// <returns></returns>
		public List<LostInfo> GetAll()
		{
			return _lostAndFoundContext.LostInfos.ToList();
		}

		/// <summary>
		/// LostInfos 테이블에서 id 값과 일치하는 행을 가져오는 메소드
		/// </summary>
		/// <param name="id">LostInfos 테이블에서 가져올 데이터의 id</param>
		/// <returns></returns>
		/// <exception cref="InvalidOperationException"></exception>
		public LostInfo GetDetail(long id)
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
		/// LostInfos 테이블에서 행을 수정하는 메소드
		/// </summary>
		/// <param name="entity">수정된 정보를 가지고 있는 entity</param>
		public void Update(LostInfo entity)
		{
			_lostAndFoundContext.LostInfos.Update(entity);
			_lostAndFoundContext.SaveChanges();
		}

		#endregion
	}
}

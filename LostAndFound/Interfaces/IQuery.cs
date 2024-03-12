using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostAndFound.Interfaces
{
	public interface IQuery<T>
	{
		#region METHODS

		// 전체 조회
		List<T> GetAll();

		// 선택 조회
		T GetDetail(long id);

		// CREATE
		void Create(T entity);

		// Update
		void Update(T entity);

		// Delete
		void Delete(long id);

		#endregion
	}
}

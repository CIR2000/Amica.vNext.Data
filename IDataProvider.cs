using System.Collections.Generic;

namespace Amica.vNext.Data
{
	public interface IDataProvider
	{
		List<T> Get<T> () where T: class, new();

		T Get<T> (object id) where T: class, new();

		void Update (object item);

		void Insert (object item);

		void Delete (object item);

		void Delete<T> (object id);
	}
}


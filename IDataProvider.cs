using System;
using System.Collections.Generic;

// TODO split to a separate Project and repository.

namespace Amica.vNext.Data
{
	public interface IDataProvider
	{
		List<T> Get<T> () where T: new();

		T Get<T> (object id) where T: new();

		void Update (object item);

		void Insert (object item);

		void Delete (object item);

		void Delete<T> (object id);
	}
}


using System;
using System.Collections.Generic;
using Amica.vNext.Models;

// TODO split to a separate Project and repository.

namespace Amica.vNext.Data
{
	public interface IDataProvider
	{
		List<T> GetItems<T> () where T: new();

		T GetItem<T> (object id) where T: new();

		void Update (object item);

		void Insert (object item);

		void Delete (object item);

		void Delete<T> (object id);
	}
}


using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Amica.vNext.Models;

namespace Amica.vNext.Data
{
	public interface IDataProviderAsync
	{
		Task<List<T>> GetItemsAsync<T> () where T: new();

		Task<T> GetItemAsync<T> (object id) where T: new();

		Task UpdateAsync (object item);

		Task InsertAsync (object item);

		Task DeleteAsync (object item);

		Task DeleteAsync<T> (object id);
	}
}


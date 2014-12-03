using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Amica.vNext.Models;

namespace Amica.vNext.Data
{
	public interface IDataProviderAsync
	{
		Task<List<T>> GetAsync<T> () where T: new();

		Task<T> GetAsync<T> (object id) where T: new();

		Task UpdateAsync (object item);

		Task InsertAsync (object item);

		Task DeleteAsync (object item);

		Task DeleteAsync<T> (object id);
	}
}


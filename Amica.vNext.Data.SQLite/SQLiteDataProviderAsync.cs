using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using Amica.vNext.Models;
using SQLite.Net.Async;

namespace Amica.vNext.Data.SQLite
{
	public class SQLiteDataProviderAsync : IDataProviderAsync
	{
		readonly SQLiteAsyncConnection _database;

		public SQLiteDataProviderAsync (SQLiteAsyncConnection connection)
		{
			_database = connection;

			// create the tables
			_database.CreateTableAsync<Company> ().ContinueWith ((t) => {
			});
		}


		public async Task<List<T>> GetAsync<T> () where T: new()
		{
			return await _database.Table<T> ().ToListAsync ();
		}

		public async Task<T> GetAsync<T> (object id) where T: new()
		{
			return await _database.GetAsync<T> (id);
		}

		public async Task UpdateAsync (object item)
		{
			await _database.UpdateAsync (item);
		}

		public async Task InsertAsync (object item)
		{
			await _database.InsertAsync (item);
		}

		public async Task DeleteAsync (object item)
		{
			await _database.DeleteAsync (item);
		}

		public async Task DeleteAsync<T> (object id)
		{
			await _database.DeleteAsync<T> (id);
		}
	}
}


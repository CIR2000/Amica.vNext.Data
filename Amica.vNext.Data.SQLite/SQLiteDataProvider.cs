using System;
using System.Collections.Generic;
using System.Linq;
using Amica.vNext.Models;
using SQLite.Net;

namespace Amica.vNext.Data.SQLite
{
	public class SQLiteDataProvider : IDataProvider
	{
		static readonly object Locker = new object ();
		readonly SQLiteConnection _database;

		public SQLiteDataProvider (SQLiteConnection connection)
		{
			_database = connection;

			// create the tables
			_database.CreateTable<Company> ();
		}

		public List<T> GetItems<T> () where T: new()
		{
			lock (Locker) {
				return (from i in _database.Table<T> ()
				        select i).ToList ();
			}
		}

		public T GetItem<T> (object id) where T: new()
		{
			lock (Locker) {
				return _database.Get<T> (id);
			}
		}

		public void Update (object item)
		{
			lock (Locker) {
				_database.Update (item);
			}
		}

		public void Insert (object item)
		{
			lock (Locker) {
				_database.Insert (item);
			}
		}

		public void Delete (object item)
		{
			lock (Locker) {
				_database.Delete (item);
			}
		}

		public void Delete<T> (object id)
		{
			lock (Locker) {
				_database.Delete<T> (id);
			}
		}
	}
}


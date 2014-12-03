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

		public List<Company> GetCompanies ()
		{
			lock (Locker) {
				return (from i in _database.Table<Company> ()
				        select i).ToList ();
			}
		}
	}
}


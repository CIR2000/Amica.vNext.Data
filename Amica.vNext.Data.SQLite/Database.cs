using System;
using System.Collections.Generic;
using System.Linq;
using SQLite.Net;
using Amica.vNext.Models;

namespace Amica.vNext.Data.SQLite
{
	public class Database : IDatabase
	{
		static object locker = new object ();
		SQLiteConnection database;

		public Database (SQLiteConnection connection)
		{
			database = connection;

			// create the tables
			database.CreateTable<Company> ();
		}

		public List<Company> GetCompanies ()
		{
			lock (locker) {
				return (from i in database.Table<Company> ()
				        select i).ToList ();
			}
		}
	}
}


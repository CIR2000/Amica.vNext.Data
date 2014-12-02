using System;
using SQLite.Net;

namespace Amica.vNext.Data.SQLite
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection ();
	}
}


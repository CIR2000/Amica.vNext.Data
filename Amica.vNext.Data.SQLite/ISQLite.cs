using SQLite.Net;

namespace Amica.vNext.Data.SQLite
{
    // ReSharper disable once InconsistentNaming
	public interface ISQLite
	{
		SQLiteConnection GetConnection ();
	}
}


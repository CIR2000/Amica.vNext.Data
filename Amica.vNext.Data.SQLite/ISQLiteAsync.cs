using SQLite.Net.Async;

namespace Amica.vNext.Data.SQLite
{
	public interface ISQLiteAsync
	{
		SQLiteAsyncConnection GetConnection ();
	}
}


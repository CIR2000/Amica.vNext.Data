using SQLite.Net.Async;

namespace Amica.vNext.Data.SQLite
{
    // ReSharper disable once InconsistentNaming
	public interface ISQLiteAsync
	{
		SQLiteAsyncConnection GetConnection ();
	}
}


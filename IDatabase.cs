using System;
using System.Collections.Generic;
using Amica.vNext.Objects;

namespace Amica.vNext.Data
{
	public interface IDatabase
	{
		List<Company> GetCompanies ();
	}
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedPsnWrapper
{
	public partial class PsnApi
	{
		/// <summary>
		/// Get an individual game's data.
		/// </summary>
		/// <param name="gameId">Id of the game to query.</param>
		/// <returns>String of data for the game.</returns>
		public string GetGame(string gameId)
		{
			var parameters = string.Format("npwr={0}", gameId);
			return ApiRequest("getGames", parameters);
		}
	}
}

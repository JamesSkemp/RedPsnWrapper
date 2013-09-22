using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedPsnWrapper
{
	/// <summary>
	/// Functionality to connect to the xxredxiiixx.com API.
	/// </summary>
	public partial class PsnApi
	{
		#region
		/// <summary>
		/// Base URL of the API, ready for String.Format (passing method then query parameters).
		/// </summary>
		private const string apiUrl = "http://xxredxiiixx.com/psnapi/functions/{0}?{1}";
		#endregion
		/// <summary>
		/// Timeout (in milliseconds) to use when making a request.
		/// </summary>
		public int Timeout { get; set; }
		/// <summary>
		/// Browser user-agent to use when requesting data.
		/// </summary>
		public string UserAgent { get; set; }

		/// <summary>
		/// Initialize a new instances of the API.
		/// </summary>
		public PsnApi()
		{
			this.Timeout = 15000;
			this.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/27.0.1453.116 Safari/537.36";
		}
	}
}

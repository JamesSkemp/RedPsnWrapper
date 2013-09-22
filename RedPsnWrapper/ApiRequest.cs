using System.IO;
using System.Net;
using System.Text;

namespace RedPsnWrapper
{
	public partial class PsnApi
	{
		/// <summary>
		/// Helper to make a request to the API.
		/// </summary>
		/// <param name="methodPath">Path to the method to call.</param>
		/// <param name="parameters">Parameters to use.</param>
		/// <returns>API response.</returns>
		private string ApiRequest(string methodPath, string parameters)
		{
			var requestUrl = string.Format(PsnApi.apiUrl, methodPath, parameters);

			var request = WebRequest.CreateHttp(requestUrl);
			request.UserAgent = this.UserAgent;
			request.Timeout = this.Timeout;

			using (var response = request.GetResponse())
			{
				StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
				return reader.ReadToEnd();
			}
		}
	}
}

using Newtonsoft.Json;

namespace NanopoolApi.Response
{
	public class Response
	{
		[JsonProperty("error")]
		public string Error { get; set; }

		[JsonProperty("status")]
		public bool Status { get; set; }
	}
}
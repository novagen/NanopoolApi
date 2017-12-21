using Newtonsoft.Json;

namespace NanopoolApi.Response
{
	public class StringValue : Response
	{
		[JsonProperty("data")]
		public string Data { get; set; }
	}
}
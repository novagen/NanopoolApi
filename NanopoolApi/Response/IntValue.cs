using Newtonsoft.Json;

namespace NanopoolApi.Response
{
	public class IntValue : Response
	{
		[JsonProperty("data")]
		public int Data { get; set; }
	}
}
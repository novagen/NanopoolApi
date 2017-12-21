using Newtonsoft.Json;

namespace NanopoolApi.Response
{
	public class TopMiners : Response
	{
		[JsonProperty("data")]
		public Data.TopMiners[] Data { get; set; }
	}
}
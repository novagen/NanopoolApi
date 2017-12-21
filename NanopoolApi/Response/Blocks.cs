using Newtonsoft.Json;

namespace NanopoolApi.Response
{
	public class Blocks : Response
	{
		[JsonProperty("data")]
		public Data.Blocks[] Data { get; set; }
	}
}
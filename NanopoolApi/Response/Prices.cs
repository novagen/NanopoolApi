using Newtonsoft.Json;

namespace NanopoolApi.Response
{
	public class Prices : Response
	{
		[JsonProperty("data")]
		public Data.Prices Data { get; set; }
	}
}
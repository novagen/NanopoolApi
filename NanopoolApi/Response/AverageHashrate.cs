using Newtonsoft.Json;

namespace NanopoolApi.Response
{
	public class AverageHashrate : Response
	{
		[JsonProperty("data")]
		public Data.AverageHashrate Data { get; set; }
	}
}
using Newtonsoft.Json;

namespace NanopoolApi.Response
{
	public class WorkersAverageHashrate : Response
	{
		[JsonProperty("data")]
		public Data.WorkersAverageHashrate Data { get; set; }
	}
}
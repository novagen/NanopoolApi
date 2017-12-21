using Newtonsoft.Json;

namespace NanopoolApi.Response
{
	public class ChartData : Response
	{
		[JsonProperty("data")]
		public Data.ChartData[] Data { get; set; }
	}
}
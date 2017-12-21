using Newtonsoft.Json;

namespace NanopoolApi.Data
{
	public class ChartData
	{
		[JsonProperty("date")]
		public int Date { get; set; }

		[JsonProperty("shares")]
		public int Shares { get; set; }

		[JsonProperty("hashrate")]
		public int Hashrate { get; set; }
	}
}
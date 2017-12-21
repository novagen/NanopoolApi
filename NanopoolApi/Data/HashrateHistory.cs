using Newtonsoft.Json;

namespace NanopoolApi.Data
{
	public class HashrateHistory
	{
		[JsonProperty("date")]
		public int Date { get; set; }

		[JsonProperty("hashrate")]
		public int Hashrate { get; set; }
	}
}
using Newtonsoft.Json;

namespace NanopoolApi.Data
{
	public class TopMiners
	{
		[JsonProperty("hashrate")]
		public int Hashrate { get; set; }

		[JsonProperty("address")]
		public string Address { get; set; }
	}
}
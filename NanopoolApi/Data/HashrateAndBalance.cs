using Newtonsoft.Json;

namespace NanopoolApi.Data
{
	public class HashrateAndBalance
	{
		[JsonProperty("hashrate")]
		public int Hashrate { get; set; }

		[JsonProperty("balance")]
		public float Balance { get; set; }
	}
}
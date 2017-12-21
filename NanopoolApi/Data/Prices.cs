using Newtonsoft.Json;

namespace NanopoolApi.Data
{
	public class Prices
	{
		[JsonProperty("price_btc")]
		public float Btc { get; set; }

		[JsonProperty("price_usd")]
		public float Usd { get; set; }

		[JsonProperty("price_eur")]
		public float Eur { get; set; }

		[JsonProperty("price_rur")]
		public float Rur { get; set; }

		[JsonProperty("price_cny")]
		public float Cny { get; set; }
	}
}
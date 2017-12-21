using Newtonsoft.Json;

namespace NanopoolApi.Data
{
	public class Payment
	{
		[JsonProperty("date")]
		public int Date { get; set; }

		[JsonProperty("txHash")]
		public string TxHash { get; set; }

		[JsonProperty("amount")]
		public float Amount { get; set; }

		[JsonProperty("confirmed")]
		public bool Confirmed { get; set; }
	}
}
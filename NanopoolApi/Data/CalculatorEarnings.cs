using Newtonsoft.Json;

namespace NanopoolApi.Data
{
	public class CalculatorEarnings
	{
		[JsonProperty("coins")]
		public float Coins { get; set; }

		[JsonProperty("dollars")]
		public float Dollars { get; set; }

		[JsonProperty("yuan")]
		public float Yuan { get; set; }

		[JsonProperty("euros")]
		public float Euros { get; set; }

		[JsonProperty("rubles")]
		public float Rubles { get; set; }

		[JsonProperty("bitcoins")]
		public float Bitcoins { get; set; }
	}
}
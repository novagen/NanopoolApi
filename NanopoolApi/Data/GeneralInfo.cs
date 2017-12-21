using Newtonsoft.Json;
using System.Collections.Generic;

namespace NanopoolApi.Data
{
	public class GeneralInfo
	{
		[JsonProperty("account")]
		public string Account { get; set; }

		[JsonProperty("unconfirmed_balance")]
		public string UnconfirmedBalance { get; set; }

		[JsonProperty("balance")]
		public string Balance { get; set; }

		[JsonProperty("hashrate")]
		public string Hashrate { get; set; }

		[JsonProperty("avgHashrate")]
		public AvgHashrate AvgHashrate { get; set; }

		[JsonProperty("workers")]
		public List<Worker> Workers { get; set; }

		public GeneralInfo()
		{
			Workers = new List<Worker>();
		}
	}
}
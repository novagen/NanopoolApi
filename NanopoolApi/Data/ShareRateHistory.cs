using Newtonsoft.Json;

namespace NanopoolApi.Data
{
	public class ShareRateHistory
	{
		[JsonProperty("date")]
		public int Date { get; set; }

		[JsonProperty("shares")]
		public int Shares { get; set; }
	}
}
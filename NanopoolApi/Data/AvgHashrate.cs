using Newtonsoft.Json;

namespace NanopoolApi.Data
{
	public class AvgHashrate
	{
		[JsonProperty("h1")]
		public string H1 { get; set; }

		[JsonProperty("h3")]
		public string H3 { get; set; }

		[JsonProperty("h6")]
		public string H6 { get; set; }

		[JsonProperty("h12")]
		public string H12 { get; set; }

		[JsonProperty("h24")]
		public string H24 { get; set; }
	}
}
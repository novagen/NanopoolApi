using Newtonsoft.Json;

namespace NanopoolApi.Data
{
	public class AverageHashrate
	{
		[JsonProperty("h1")]
		public int H1 { get; set; }

		[JsonProperty("h3")]
		public int H3 { get; set; }

		[JsonProperty("h6")]
		public int H6 { get; set; }

		[JsonProperty("h12")]
		public int H12 { get; set; }

		[JsonProperty("h24")]
		public int H24 { get; set; }
	}
}
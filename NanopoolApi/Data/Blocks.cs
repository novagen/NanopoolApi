using Newtonsoft.Json;

namespace NanopoolApi.Data
{
	public class Blocks
	{
		[JsonProperty("number")]
		public int Number { get; set; }

		[JsonProperty("hash")]
		public string Hash { get; set; }

		[JsonProperty("date")]
		public int Date { get; set; }

		[JsonProperty("difficulty")]
		public long Difficulty { get; set; }

		[JsonProperty("miner")]
		public string Miner { get; set; }
	}
}
using Newtonsoft.Json;

namespace NanopoolApi.Data
{
	public class BlocksStats
	{
		[JsonProperty("date")]
		public int Date { get; set; }

		[JsonProperty("difficulty")]
		public float Difficulty { get; set; }

		[JsonProperty("block_time")]
		public float BlockTime { get; set; }
	}
}
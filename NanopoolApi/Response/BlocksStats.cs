using Newtonsoft.Json;

namespace NanopoolApi.Response
{
	public class BlocksStats : Response
	{
		[JsonProperty("data")]
		public Data.BlocksStats[] Data { get; set; }
	}
}
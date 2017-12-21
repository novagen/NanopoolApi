using Newtonsoft.Json;

namespace NanopoolApi.Response
{
	public class HashrateHistory : Response
	{
		[JsonProperty("data")]
		public Data.HashrateHistory[] Data { get; set; }
	}
}
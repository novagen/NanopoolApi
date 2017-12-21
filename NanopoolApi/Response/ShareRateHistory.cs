using Newtonsoft.Json;

namespace NanopoolApi.Response
{
	public class ShareRateHistory : Response
	{
		[JsonProperty("data")]
		public Data.ShareRateHistory[] Data { get; set; }
	}
}
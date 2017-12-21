using Newtonsoft.Json;

namespace NanopoolApi.Response
{
	public class HashrateAndBalance : Response
	{
		[JsonProperty("data")]
		public Data.HashrateAndBalance Data { get; set; }
	}
}
using Newtonsoft.Json;

namespace NanopoolApi.Response
{
	public class GeneralInfo : Response
	{
		[JsonProperty("data")]
		public Data.GeneralInfo Data { get; set; }
	}
}
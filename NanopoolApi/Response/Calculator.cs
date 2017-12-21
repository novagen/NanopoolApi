using Newtonsoft.Json;

namespace NanopoolApi.Response
{
	public class Calculator : Response
	{
		[JsonProperty("data")]
		public Data.Calculator Data { get; set; }
	}
}
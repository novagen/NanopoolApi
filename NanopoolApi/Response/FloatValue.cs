using Newtonsoft.Json;

namespace NanopoolApi.Response
{
	public class FloatValue : Response
	{
		[JsonProperty("data")]
		public float Data { get; set; }
	}
}
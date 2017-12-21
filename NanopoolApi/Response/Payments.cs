using NanopoolApi.Data;
using Newtonsoft.Json;

namespace NanopoolApi.Response
{
	public class Payments : Response
	{
		[JsonProperty("data")]
		public Payment[] Data { get; set; }
	}
}
using Newtonsoft.Json;

namespace NanopoolApi.Data
{
	public class WorkerHashrateValue
	{
		[JsonProperty("worker")]
		public string Worker { get; set; }

		[JsonProperty("hashrate")]
		public float Hashrate { get; set; }
	}
}
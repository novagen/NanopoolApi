using Newtonsoft.Json;

namespace NanopoolApi.Data
{
	public class WorkersAverageHashrate
	{
		[JsonProperty("h1")]
		public WorkerHashrateValue[] H1 { get; set; }

		[JsonProperty("h3")]
		public WorkerHashrateValue[] H3 { get; set; }

		[JsonProperty("h6")]
		public WorkerHashrateValue[] H6 { get; set; }

		[JsonProperty("h12")]
		public WorkerHashrateValue[] H12 { get; set; }

		[JsonProperty("h24")]
		public WorkerHashrateValue[] H24 { get; set; }
	}
}
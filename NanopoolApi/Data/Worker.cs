using Newtonsoft.Json;

namespace NanopoolApi.Data
{
	public class Worker
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("uid")]
		public int Uid { get; set; }

		[JsonProperty("hashrate")]
		public string Hashrate { get; set; }

		[JsonProperty("lastshare")]
		public int LastShare { get; set; }

		[JsonProperty("rating")]
		public int Rating { get; set; }

		[JsonProperty("h1")]
		public string H1 { get; set; }

		[JsonProperty("h3")]
		public string H3 { get; set; }

		[JsonProperty("h6")]
		public string H6 { get; set; }

		[JsonProperty("h12")]
		public string H12 { get; set; }

		[JsonProperty("h24")]
		public string H24 { get; set; }

		public void UpdateOther(Worker current)
		{
			current.H1 = H1;
			current.H3 = H3;
			current.H6 = H6;
			current.H12 = H12;
			current.H24 = H24;
			current.Hashrate = Hashrate;
			current.LastShare = LastShare;
			current.Rating = Rating;
		}
	}
}
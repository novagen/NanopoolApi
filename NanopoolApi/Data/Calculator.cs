using Newtonsoft.Json;

namespace NanopoolApi.Data
{
	public class Calculator
	{
		[JsonProperty("minute")]
		public CalculatorEarnings Minute { get; set; }

		[JsonProperty("hour")]
		public CalculatorEarnings Hour { get; set; }

		[JsonProperty("day")]
		public CalculatorEarnings Day { get; set; }

		[JsonProperty("week")]
		public CalculatorEarnings Week { get; set; }

		[JsonProperty("month")]
		public CalculatorEarnings Month { get; set; }
	}
}
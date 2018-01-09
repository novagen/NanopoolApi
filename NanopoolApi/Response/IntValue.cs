using Newtonsoft.Json;

namespace NanopoolApi.Response
{
	public class IntValue : Response
	{
		private int _data { get; set; }

		[JsonProperty("data")]
		public int Data
		{
			get
			{
				return _data;
			}

			set
			{
				if (_data == value) return;

				_data = value;
				OnPropertyChanged(nameof(Data));
			}
		}
	}
}
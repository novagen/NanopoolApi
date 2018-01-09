using Newtonsoft.Json;

namespace NanopoolApi.Response
{
	public class FloatValue : Response
	{
		private float _data { get; set; }

		[JsonProperty("data")]
		public float Data
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
using NanopoolApi.Response;
using Newtonsoft.Json;
using System;
using System.Net;

namespace NanopoolApi
{
	public class Nanopool
	{
		private Statics.PoolType Type { get; set; }
		public WebProxy Proxy { get; set; }

		private T LoadResponse<T>(string url, ref string error)
		{
			error = null;

			if (string.IsNullOrWhiteSpace(url))
			{
				throw new ArgumentNullException(nameof(url));
			}

			url = url.Replace(Statics.PoolTypeHolder, Enum.GetName(typeof(Statics.PoolType), Type).ToLower());

			try
			{
				using (var client = new WebClient())
				{
					if (Proxy != null)
					{
						WebRequest.DefaultWebProxy = Proxy;
						client.Proxy = Proxy;
					}

					var response = client.DownloadString(new Uri(url));

					if (!string.IsNullOrWhiteSpace(response))
					{
						return JsonConvert.DeserializeObject<T>(response);
					}
				}
			}
			catch (Exception e)
			{
				error = e.Message;
			}

			return default(T);
		}

		public Nanopool(Statics.PoolType type, WebProxy proxy = null)
		{
			Type = type;
			Proxy = proxy;
		}

		public FloatValue GetAccountBalance(string account)
		{
			var error = string.Empty;
			var result = LoadResponse<FloatValue>(string.Format(Statics.AccountBalance, account), ref error);

			if (!string.IsNullOrWhiteSpace(error) && result == null)
			{
				result = CastToChild<FloatValue>(GetErrorResponse(error));
			}

			return result;
		}

		public AverageHashrate GetAverageHashrate(string account, string worker = null)
		{
			var error = string.Empty;
			var result = LoadResponse<AverageHashrate>(string.Format(Statics.AverageHashrate, account, worker.UrlPart()), ref error);

			if (!string.IsNullOrWhiteSpace(error) && result == null)
			{
				result = CastToChild<AverageHashrate>(GetErrorResponse(error));
			}

			return result;
		}

		public FloatValue GetAverageHashrateLimited(string account, int hours, string worker = null)
		{
			var error = string.Empty;
			var result = LoadResponse<FloatValue>(string.Format(Statics.AverageHashrateLimited, account, worker.UrlPart(), hours), ref error);

			if (!string.IsNullOrWhiteSpace(error) && result == null)
			{
				result = CastToChild<FloatValue>(GetErrorResponse(error));
			}

			return result;
		}

		public ChartData GetChartData(string account, string worker = null)
		{
			var error = string.Empty;
			var result = LoadResponse<ChartData>(string.Format(Statics.ChartData, account, worker.UrlPart()), ref error);

			if (!string.IsNullOrWhiteSpace(error) && result == null)
			{
				result = CastToChild<ChartData>(GetErrorResponse(error));
			}

			return result;
		}

		public StringValue GetCheckMinerAccount(string account)
		{
			var error = string.Empty;
			var result = LoadResponse<StringValue>(string.Format(Statics.CheckMinerAccount, account), ref error);

			if (!string.IsNullOrWhiteSpace(error) && result == null)
			{
				result = CastToChild<StringValue>(GetErrorResponse(error));
			}

			return result;
		}

		public FloatValue GetCurrentHashrate(string account, string worker = null)
		{
			var error = string.Empty;
			var result = LoadResponse<FloatValue>(string.Format(Statics.CurrentHashrate, account, worker.UrlPart()), ref error);

			if (!string.IsNullOrWhiteSpace(error) && result == null)
			{
				result = CastToChild<FloatValue>(GetErrorResponse(error));
			}

			return result;
		}

		public GeneralInfo GetGeneralInfo(string account)
		{
			var error = string.Empty;
			var result = LoadResponse<GeneralInfo>(string.Format(Statics.GeneralInfo, account), ref error);

			if (!string.IsNullOrWhiteSpace(error) && result == null)
			{
				result = CastToChild<GeneralInfo>(GetErrorResponse(error));
			}

			return result;
		}

		public HashrateHistory GetHashrateHistory(string account, string worker = null)
		{
			var error = string.Empty;
			var result = LoadResponse<HashrateHistory>(string.Format(Statics.HashrateHistory, account, worker.UrlPart()), ref error);

			if (!string.IsNullOrWhiteSpace(error) && result == null)
			{
				result = CastToChild<HashrateHistory>(GetErrorResponse(error));
			}

			return result;
		}

		public HashrateAndBalance GetHashrateAndBalance(string account)
		{
			var error = string.Empty;
			var result = LoadResponse<HashrateAndBalance>(string.Format(Statics.HashrateAndBalance, account), ref error);

			if (!string.IsNullOrWhiteSpace(error) && result == null)
			{
				result = CastToChild<HashrateAndBalance>(GetErrorResponse(error));
			}

			return result;
		}

		public IntValue GetLastReportedHashrateForAccount(string account, string worker = null)
		{
			var error = string.Empty;
			var result = LoadResponse<IntValue>(string.Format(Statics.LastReportedHashrateForAccount, account, worker.UrlPart()), ref error);

			if (!string.IsNullOrWhiteSpace(error) && result == null)
			{
				result = CastToChild<IntValue>(GetErrorResponse(error));
			}

			return result;
		}

		public ListOfWorkers GetListOfWorkers(string account)
		{
			var error = string.Empty;
			var result = LoadResponse<ListOfWorkers>(string.Format(Statics.ListOfWorkers, account), ref error);

			if (!string.IsNullOrWhiteSpace(error) && result == null)
			{
				result = CastToChild<ListOfWorkers>(GetErrorResponse(error));
			}

			return result;
		}

		public Payments GetPayments(string account)
		{
			var error = string.Empty;
			var result = LoadResponse<Payments>(string.Format(Statics.Payments, account), ref error);

			if (!string.IsNullOrWhiteSpace(error) && result == null)
			{
				result = CastToChild<Payments>(GetErrorResponse(error));
			}

			return result;
		}

		public ShareRateHistory GetShareRateHistory(string account, string worker = null)
		{
			var error = string.Empty;
			var result = LoadResponse<ShareRateHistory>(string.Format(Statics.ShareRateHistory, account, worker.UrlPart()), ref error);

			if (!string.IsNullOrWhiteSpace(error) && result == null)
			{
				result = CastToChild<ShareRateHistory>(GetErrorResponse(error));
			}

			return result;
		}

		public WorkersAverageHashrate GetWorkersAverageHashrate(string account)
		{
			var error = string.Empty;
			var result = LoadResponse<WorkersAverageHashrate>(string.Format(Statics.WorkersAverageHashrate, account), ref error);

			if (!string.IsNullOrWhiteSpace(error) && result == null)
			{
				result = CastToChild<WorkersAverageHashrate>(GetErrorResponse(error));
			}

			return result;
		}

		public WorkersHashrate GetWorkersAverageHashrateLimited(string account, int hours)
		{
			var error = string.Empty;
			var result = LoadResponse<WorkersHashrate>(string.Format(Statics.WorkersAverageHashrateLimited, account, hours), ref error);

			if (!string.IsNullOrWhiteSpace(error) && result == null)
			{
				result = CastToChild<WorkersHashrate>(GetErrorResponse(error));
			}

			return result;
		}

		public WorkersHashrate GetWorkersLastReportedHashrate(string account)
		{
			var error = string.Empty;
			var result = LoadResponse<WorkersHashrate>(string.Format(Statics.WorkersLastReportedHashrate, account), ref error);

			if (!string.IsNullOrWhiteSpace(error) && result == null)
			{
				result = CastToChild<WorkersHashrate>(GetErrorResponse(error));
			}

			return result;
		}

		public FloatValue GetAverageBlockTime()
		{
			var error = string.Empty;
			var result = LoadResponse<FloatValue>(Statics.AverageBlockTime, ref error);

			if (!string.IsNullOrWhiteSpace(error) && result == null)
			{
				result = CastToChild<FloatValue>(GetErrorResponse(error));
			}

			return result;
		}

		public BlocksStats GetBlocksStats(int offset, int count)
		{
			var error = string.Empty;
			var result = LoadResponse<BlocksStats>(string.Format(Statics.BlocksStats, offset, count), ref error);

			if (!string.IsNullOrWhiteSpace(error) && result == null)
			{
				result = CastToChild<BlocksStats>(GetErrorResponse(error));
			}

			return result;
		}

		public Blocks GetBlocks(int offset, int count)
		{
			var error = string.Empty;
			var result = LoadResponse<Blocks>(string.Format(Statics.Blocks, offset, count), ref error);

			if (!string.IsNullOrWhiteSpace(error) && result == null)
			{
				result = CastToChild<Blocks>(GetErrorResponse(error));
			}

			return result;
		}

		public IntValue GetLastBlockNumber()
		{
			var error = string.Empty;
			var result = LoadResponse<IntValue>(Statics.LastBlockNumber, ref error);

			if (!string.IsNullOrWhiteSpace(error) && result == null)
			{
				result = CastToChild<IntValue>(GetErrorResponse(error));
			}

			return result;
		}

		public IntValue GetTimeToNextEpoch()
		{
			var error = string.Empty;
			var result = LoadResponse<IntValue>(Statics.TimeToNextEpoch, ref error);

			if (!string.IsNullOrWhiteSpace(error) && result == null)
			{
				result = CastToChild<IntValue>(GetErrorResponse(error));
			}

			return result;
		}

		public Calculator GetCalculator(int hashrate)
		{
			var error = string.Empty;
			var result = LoadResponse<Calculator>(string.Format(Statics.Calculator, hashrate), ref error);

			if (!string.IsNullOrWhiteSpace(error) && result == null)
			{
				result = CastToChild<Calculator>(GetErrorResponse(error));
			}

			return result;
		}

		public Prices GetPrices()
		{
			var error = string.Empty;
			var result = LoadResponse<Prices>(Statics.Prices, ref error);

			if (!string.IsNullOrWhiteSpace(error) && result == null)
			{
				result = CastToChild<Prices>(GetErrorResponse(error));
			}

			return result;
		}

		public IntValue GetNumberOfMiners()
		{
			var error = string.Empty;
			var result = LoadResponse<IntValue>(Statics.NumberOfMiners, ref error);

			if (!string.IsNullOrWhiteSpace(error) && result == null)
			{
				result = CastToChild<IntValue>(GetErrorResponse(error));
			}

			return result;
		}

		public IntValue GetNumberOfWorkers()
		{
			var error = string.Empty;
			var result = LoadResponse<IntValue>(Statics.NumberOfWorkers, ref error);

			if (!string.IsNullOrWhiteSpace(error) && result == null)
			{
				result = CastToChild<IntValue>(GetErrorResponse(error));
			}

			return result;
		}

		public IntValue GetPoolHashrate()
		{
			var error = string.Empty;
			var result = LoadResponse<IntValue>(Statics.PoolHashrate, ref error);

			if (!string.IsNullOrWhiteSpace(error) && result == null)
			{
				result = CastToChild<IntValue>(GetErrorResponse(error));
			}

			return result;
		}

		public TopMiners GetTopMiners()
		{
			var error = string.Empty;
			var result = LoadResponse<TopMiners>(Statics.TopMiners, ref error);

			if (!string.IsNullOrWhiteSpace(error) && result == null)
			{
				result = CastToChild<TopMiners>(GetErrorResponse(error));
			}

			return result;
		}

		private static T CastToChild<T>(Response.Response response)
		{
			var serializedParent = JsonConvert.SerializeObject(response);
			return JsonConvert.DeserializeObject<T>(serializedParent);
		}

		private static Response.Response GetErrorResponse(string error)
		{
			return new Response.Response
			{
				Status = false,
				Error = error
			};
		}
	}
}
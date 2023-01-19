using TSEAlert.Network;
using System;

namespace TSEAlert.Handler
{
    internal class StockTransactionInformation
    {
        private string _stockId { get; set; }

        public StockTransactionInformation(string stockId)
        {
            _stockId = stockId;
        }

        /// <summary>
        /// دریافت آخرین قیمت معامله شده
        /// </summary>
        /// <returns>قیمت</returns>
        internal int GetLastTransactionPrice()
        {
            try
            {
                var response = SendRequest();

                return DeserializeResponse(response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string SendRequest()
        {
            try
            {
                string url = string.Format(Address.GetStockTransactionInformation(), _stockId);

                var network = new Network.Network();
                network.SendRequest(url);

                if (network.ResponseStatus != "OK")
                    throw new Exception("TseTmc Dosn't Correct Response.");
                return network.ResponseResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int DeserializeResponse(string response)
        {
            try
            {
                var transactions = response.Split(',');
                return Convert.ToInt32(transactions[2]);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

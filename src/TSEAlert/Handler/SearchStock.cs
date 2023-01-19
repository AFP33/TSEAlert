using System.Collections.Generic;
using TSEAlert.Network;
using TSEAlert.Models;
using System;

namespace TSEAlert.Handler
{
    public class SearchStock
    {
        /// <summary>
        /// پیدا کردن یک سهم
        /// </summary>
        /// <param name="stockName">نام سهم، شامل نماد یا اسم کامل</param>
        /// <returns></returns>
        internal List<Stock> Find(string stockName)
        {
            try
            {
                if (stockName == string.Empty || string.IsNullOrEmpty(stockName))
                    throw new Exception("Stock Name Cann't be Empty.");

                var response = SendRequest(stockName);

                return DeserializeResponse(response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string SendRequest(string stockName)
        {
            try
            {
                string url = string.Format(Address.GetSearchStockAddress(), stockName);

                var network = new Network.Network();
                network.SendRequest(url);

                if (network.ResponseStatus != "OK")
                {
                    throw new Exception("TseTmc Dosn't Correct Response.");
                }
                return network.ResponseResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<Stock> DeserializeResponse(string response)
        {
            try
            {
                var firstSplit = response.Split(';');
                List<Stock> stocks = new List<Stock>();
                int counter = 0;
                foreach (var item in firstSplit)
                {
                    if (item == "") continue;
                    var splited = item.Split(',');
                    Stock stockFinded = new Stock();
                    if (splited[7] == "0") continue; // نماد غیرفعال شده
                    stockFinded.Symbol = splited[0];
                    stockFinded.Name = splited[1];
                    stockFinded.TseCode = splited[2].ToString();

                    // I don't know what is this data, but put these in list if you know and want to use them
                    stockFinded.OtherData = (new List<string> { splited[6], splited[7], splited[8], splited[9] }).ToArray();
                    stocks.Insert(counter, stockFinded);
                    counter++;
                }

                return stocks;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

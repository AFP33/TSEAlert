using System.Collections.Generic;
using TSEAlert.Network;
using TSEAlert.Models;
using System;
using Tse;

namespace TSEAlert.Handler
{
    public class SearchStock
    {
        /// <summary>
        /// پیدا کردن یک سهم
        /// </summary>
        /// <param name="stockName">نام سهم، شامل نماد یا اسم کامل</param>
        /// <returns></returns>
        internal IList<Tse.Entities.Stock> Find(string stockName)
        {
            try
            {
                if (stockName == string.Empty || string.IsNullOrEmpty(stockName))
                    throw new Exception("Stock Name Cann't be Empty.");

                return new TSE().GetMarketHandler().FindStock(stockName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

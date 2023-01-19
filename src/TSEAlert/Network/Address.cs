namespace TSEAlert.Network
{
    public static class Address
    {
        public static string GetSearchStockAddress()
        {
            return "http://www.tsetmc.com/tsev2/data/search.aspx?skey={0}";
        }

        public static string GetStockTransactionInformation()
        {
            return "http://www.tsetmc.com/tsev2/data/instinfodata.aspx?i={0}&c=27%21";
        }

        public static string GetTsetmcAddress()
        {
            return "http://www.tsetmc.com/Loader.aspx?ParTree=151311&i={0}";
        }

        public static string GetCodalAddress()
        {
            return "http://codal.ir/ReportList.aspx?search&Symbol={0}";
        }

        public static string GetMarketInfoAddress()
        {
            return "http://www.tsetmc.com/Loader.aspx?ParTree=15";
        }
    }
}

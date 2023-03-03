namespace TSEAlert.Network
{
    public static class Address
    {
        public static string GetTsetmcAddress()
        {
            return "http://www.tsetmc.com/Loader.aspx?ParTree=151311&i={0}";
        }

        public static string GetCodalAddress()
        {
            return "http://codal.ir/ReportList.aspx?search&Symbol={0}";
        }
    }
}

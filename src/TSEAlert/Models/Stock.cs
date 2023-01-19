namespace TSEAlert.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }
        public string TseCode { get; set; }
        public string[] OtherData { get; set; }
    }
}

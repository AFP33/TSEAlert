namespace TSEAlert.Models
{
    public class Alert
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string TseCode { get; set; }
        public AlertType? AlertType { get; set; }
        public string Price { get; set; }
        public bool Status { get; set; }
    }
}

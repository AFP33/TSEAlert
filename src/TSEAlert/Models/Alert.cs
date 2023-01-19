namespace TSEAlert.Models
{
    public class Alert
    {
        public int Id { get; set; }
        public int StockId { get; set; }
        public AlertType? AlertType { get; set; }
        public string Price { get; set; }
        public bool Status { get; set; }

        public virtual Stock Stock { get; set; }
    }
}

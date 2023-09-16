namespace StockManagementSystem.Models
{
    public class StockIn
    {
        public int stockIn { get; set; }
        public int AvailableQuantity { get; set; }  
        public Item? Quantity { get; set; }
        public int _ReOrderLevel { get; set; }
        public Item? ReOrderLevel { get; set; }
        public int CompanyId { get; set; }
        public Company? Company { get; set; }
        public int ItemId { get; set; }
        public Item? Item { get; set; }
    }
}

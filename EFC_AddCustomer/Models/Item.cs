using System.ComponentModel.DataAnnotations;

namespace EFC_AddCustomer.Models
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemPrice { get; set; }

        public int CustomerId { get; set; }
        public CustomerName CustomerName { get; set; }
    }
}

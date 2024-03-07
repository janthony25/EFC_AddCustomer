namespace EFC_AddCustomer.Models
{
    public class CustomerName
    {
        public int CustomerId { get; set; }
        public CustomerName Name { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}

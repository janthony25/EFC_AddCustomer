using System.ComponentModel.DataAnnotations;

namespace EFC_AddCustomer.Models
{
    public class CustomerName
    {
        [Key]
        public int CustomerId { get; set; }
        public string Name { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}

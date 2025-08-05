using System.ComponentModel.DataAnnotations;

namespace CodeFirstApp.Models
{
    public class Product
    {
        [Key]public int prodId { get; set; }
        public string prodName { get; set; }
        public double price { get; set; }
        public string category { get; set; }

    }
}

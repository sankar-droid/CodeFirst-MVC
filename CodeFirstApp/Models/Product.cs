using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApp.Models
{
    public class Product
    {
        [Key]public int prodId { get; set; }
        public string prodName { get; set; }
        public double price { get; set; }

        
        public int catid { get; set; }
        [ForeignKey("catid")]
        
        
        public Category Category { get; set; } // 1 category many products 1-many relationship 

    }
}

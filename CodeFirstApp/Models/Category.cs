using System.ComponentModel.DataAnnotations;

namespace CodeFirstApp.Models
{
    public class Category
    {
        [Key] 
        public int CategoryId { get; set; }
        public string ?CategoryName { get; set; }

        public IList<Product> Products { get; set; } //1-many 1 category many products


    }
}

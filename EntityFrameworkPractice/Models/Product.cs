using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Text;

namespace EntityFrameworkPractice.Models
{
    public class Product
    {
        [Key]
        public int ValueThatIsUniqueForThisItem { get; set; }   // default Id, ProductId; if you use default names [Key] tag is not needed.


        [Required]
        public string Name { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
    }
}

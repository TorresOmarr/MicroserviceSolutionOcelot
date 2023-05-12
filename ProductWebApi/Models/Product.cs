using MySqlX.XDevAPI;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductWebApi.Models
{
    [Table("Product", Schema = "dbo")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("product")]
        public int ProductId { get; set; }
        [Column("product_name")]
        public string ProductName { get; set; } = null!;
        [Column("product_cocd")]
        public string ProductCode { get; set; } = null!;
        [Column("product_price")]
        public decimal ProductPrice { get; set; }
    
    }
}

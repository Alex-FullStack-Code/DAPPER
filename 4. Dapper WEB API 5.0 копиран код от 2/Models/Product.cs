namespace TestDapper.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Product
    {
        [Key]
        [Column("product_id")]
        public int product_id { get; set; }

 
        [Column("product_name")]
        [StringLength(255)]
        public string product_name { get; set; }

        [Column("brand_id")]
        public int brand_id { get; set; }

        [Column("category_id")]
        public int category_id { get; set; }

        [Column("model_year")]
        public short model_year { get; set; }

        [Column("list_price", TypeName = "decimal(10, 2)")]
        public decimal list_price { get; set; }
    }
}

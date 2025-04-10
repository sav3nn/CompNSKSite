using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompNSKSite.Models
{
    [Table("Product")]
    public class Product
    {
        public int Id { get; set; }

        [Column("catalog_id")]
        public int Catalog_Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("description")]
        public string? Description { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("image")]
        public byte[]? Image { get; set; }

        [Column("processor")]
        public string Processor { get; set; }

        [Column("videocard")]
        public string Videocard { get; set; }

        [Column("ram")]
        public string Ram { get; set; }

        [Column("ssd")]
        public string Ssd { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace TerrariosFascinam.Model
{
    [Table("investment")]
    public class Investment
    {
        [Column("id")]
        public long Id { get; set; }

        [Column("value")]
        public string Value { get; set; }

        [Column("investment_date")]
        public string InvestmentDate { get; set; }

        [Column("product")]
        public string Product { get; set; }

        [Column("quantity")]
        public long Quantity { get; set; }
    }
}

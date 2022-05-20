using System.ComponentModel.DataAnnotations.Schema;

namespace TerrariosFascinam.Model
{
    [Table("client")]
    public class Client
    {
        [Column("id")]
        public long Id { get; set; }
        
        [Column("name")]
        public string Name { get; set; }
        
        [Column("born_date")]
        public string BornDate { get; set; }
        
        [Column("whatsapp")]
        public string Whatsapp { get; set; }
        
        [Column("cpf")]
        public string CPF { get; set; }
        
        [Column("address")]
        public string Address { get; set; }
    }
}

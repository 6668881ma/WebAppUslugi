using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppUslugi.Data.identity
{
    [Table("Services", Schema = "data")]
    public class Service

    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}

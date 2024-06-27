using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollabApi.Model
{
    public class Order{
        public int Id { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime Date { get; set; }

        [StringLength(255)]
        public string Description { get; set; } = string.Empty;

        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }

        [StringLength(30)]
        public string Status { get; set; } = string.Empty;

        [Column(TypeName = "decimal(11,2)")]
        public decimal Total {  get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace CollabApi.Model
{
    public class Item{
        public int Id { get; set; }

        [StringLength(255)]
        public string Description { get; set; } = string.Empty;

        [Column(TypeName ="decimal(11,2)")]
        public decimal Price { get; set; }

    }
}

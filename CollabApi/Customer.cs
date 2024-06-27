using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollabApi;

public class Customer {

    public int Id { get; set; }
    [StringLength(30)]
    public string Name { get; set; } = string.Empty;
    [StringLength(30)]
    public string City { get; set; } = string.Empty;
    [StringLength(30)]
    public string State { get; set; } = string.Empty;
    [Column("decimal(11,2)")]
    public decimal Sales { get; set; } 
    public bool Active { get; set; }

}

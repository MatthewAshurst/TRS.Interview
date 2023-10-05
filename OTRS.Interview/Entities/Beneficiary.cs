using OTRS.Interview.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OTRS.Interview.Entities;

public class Beneficiary : IEntity
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    public string City { get; set; } = string.Empty;

    public string State { get; set; } = string.Empty;

    public string PostalCode { get; set; } = string.Empty;

    public int ClientId { get; set; }

    [ForeignKey("ClientId")]
    public Client Client { get; set; }

    public DateTime CreatedDate { get; set; }
}

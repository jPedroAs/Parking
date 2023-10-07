using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Parking.Domain.Models;

public class BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Int32 Id { get; set; }

    [IgnoreDataMember]
    public DateTime? CreateAt { get; set; }

    [IgnoreDataMember]
    public DateTime? LastUpdateAt { get; set; }

    [IgnoreDataMember]
    public DateTime? DeleteAt { get; set; }

    [IgnoreDataMember]
    public bool Actived { get; set; }
}
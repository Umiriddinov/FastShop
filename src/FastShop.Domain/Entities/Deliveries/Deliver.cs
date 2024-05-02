using FastShop.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace FastShop.Domain.Entities.Deliveries;

public class Deliver : Human
{
    [MaxLength(13)]
    public string PhoneNumber { get; set; } = string.Empty;

    public bool PhoneNumberConfirmed { get; set; }

    public string PasswordHash { get; set; } = string.Empty;

    public string Salt { get; set; } = string.Empty;

}

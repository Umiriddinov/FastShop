using FastShop.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastShop.Domain.Entities.Users;

public class User : Human
{
    [MaxLength(13)]
    public string PhoneNumber { get; set; } = string.Empty;

    public bool PhoneNumberConfirmed { get; set; }

    public string PasswordHash { get; set; } = string.Empty;

    public string Salt { get; set; } = string.Empty;

    public DateTime LastActivity { get; set; }

    public IdentityRole Role { get; set; }
}

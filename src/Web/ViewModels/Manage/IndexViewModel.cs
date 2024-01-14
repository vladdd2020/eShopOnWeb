﻿using System.ComponentModel.DataAnnotations;

namespace Microsoft.eShopWeb.Web.ViewModels.Manage;

public class IndexViewModel
{
    public string? Username { get; set; }

    public bool IsEmailConfirmed { get; set; }

    [Required]
    [EmailAddress]
    public string? Email { get; set; }

    [Phone]
    [Display(Name = "Номер телефону")]
    public string? PhoneNumber { get; set; }

    public string? StatusMessage { get; set; }
}

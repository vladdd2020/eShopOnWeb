using System.ComponentModel.DataAnnotations;

namespace Microsoft.eShopWeb.Web.ViewModels.Account;

public class RegisterViewModel
{
    [Required]
    [EmailAddress]
    [Display(Name = "Email")]
    public string? Email { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "{0} повинно бути довжиною не менше {2} символів.", MinimumLength = 6)]
    [DataType(DataType.Password)]
    [Display(Name = "Пароль")]
    public string? Password { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Підтвердити пароль")]
    [Compare("Password", ErrorMessage = "Пароль та підтвердження паролю не збігаються.")]
    public string? ConfirmPassword { get; set; }
}

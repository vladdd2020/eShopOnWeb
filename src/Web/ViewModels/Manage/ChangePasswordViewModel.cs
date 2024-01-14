using System.ComponentModel.DataAnnotations;

namespace Microsoft.eShopWeb.Web.ViewModels.Manage;

public class ChangePasswordViewModel
{
    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Поточний пароль")]
    public string? OldPassword { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "{0} повинен бути від {2} до {1} символів у довжину.", MinimumLength = 6)]
    [DataType(DataType.Password)]
    [Display(Name = "Новий пароль")]
    public string? NewPassword { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Підтвердити новий пароль")]
    [Compare("NewPassword", ErrorMessage = "Новий пароль та підтвердження паролю не збігаються..")]
    public string? ConfirmPassword { get; set; }

    public string? StatusMessage { get; set; }
}

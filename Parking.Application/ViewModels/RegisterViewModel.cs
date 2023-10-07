using System.ComponentModel.DataAnnotations;

namespace Parking.Application.ViewModels;

public class RegisterViewModel
{
    [Required(ErrorMessage = "Obrigatório")]
    [MaxLength(255)]
    public string Name {get; set;}

    [Required(ErrorMessage = "Obrigatório")]
    [EmailAddress(ErrorMessage = "erro ai")]  
    public string Email {get; set;}
}
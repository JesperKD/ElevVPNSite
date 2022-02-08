using ElevVPNClassLibrary.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ElevVPNBlazorWebsite.Data.FormModels
{
    public class RequestModel : BaseModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email adresse er påkrævet.")]
        [StringLength(255, ErrorMessage = "Email er for lang (255 karakter begrænse.).")]
        [EmailAddress(ErrorMessage = "Indtast en gyldig email adresse.")]
        public string Email { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace ElevVPNBlazorWebsite.Data.FormModels
{
    public class RequestModel : BaseModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email er påkrævet.")]
        [EmailAddress(ErrorMessage = "Indtast en gyldig email adresse.")]
        public string Email { get; set; }
    }
}

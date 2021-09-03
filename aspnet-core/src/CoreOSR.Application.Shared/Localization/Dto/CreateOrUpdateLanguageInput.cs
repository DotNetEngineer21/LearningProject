using System.ComponentModel.DataAnnotations;

namespace CoreOSR.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace CoreOSR.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}

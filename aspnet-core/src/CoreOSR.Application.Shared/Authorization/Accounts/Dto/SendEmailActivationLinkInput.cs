using System.ComponentModel.DataAnnotations;

namespace CoreOSR.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}
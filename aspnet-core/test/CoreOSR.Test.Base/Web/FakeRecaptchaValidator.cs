using System.Threading.Tasks;
using CoreOSR.Security.Recaptcha;

namespace CoreOSR.Test.Base.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}

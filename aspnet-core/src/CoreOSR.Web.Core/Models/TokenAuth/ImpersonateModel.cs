using System.ComponentModel.DataAnnotations;

namespace CoreOSR.Web.Models.TokenAuth
{
    public class ImpersonateModel
    {
        public int? TenantId { get; set; }

        [Range(1, long.MaxValue)]
        public long UserId { get; set; }
    }
}
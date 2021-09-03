using System.Threading.Tasks;

namespace CoreOSR.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}
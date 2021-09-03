using System.Threading.Tasks;
using CoreOSR.Views;
using Xamarin.Forms;

namespace CoreOSR.Services.Modal
{
    public interface IModalService
    {
        Task ShowModalAsync(Page page);

        Task ShowModalAsync<TView>(object navigationParameter) where TView : IXamarinView;

        Task<Page> CloseModalAsync();
    }
}

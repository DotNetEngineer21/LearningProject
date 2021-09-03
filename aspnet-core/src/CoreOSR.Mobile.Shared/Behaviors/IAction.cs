using Xamarin.Forms.Internals;

namespace CoreOSR.Behaviors
{
    [Preserve(AllMembers = true)]
    public interface IAction
    {
        bool Execute(object sender, object parameter);
    }
}
using System.Collections.Generic;
using MvvmHelpers;
using CoreOSR.Models.NavigationMenu;

namespace CoreOSR.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}
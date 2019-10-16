using ReactiveUI;
using Splat;

namespace iCore.Client.WPF.ViewModels
{

    public class AboutViewModel : ReactiveObject, IRoutableViewModel
    {
        public string UrlPathSegment => "about";

        public IScreen HostScreen { get; }

        public AboutViewModel(IScreen screen = null)
        {
            HostScreen = screen ?? Locator.Current.GetService<IScreen>();
        }
    }
    
}
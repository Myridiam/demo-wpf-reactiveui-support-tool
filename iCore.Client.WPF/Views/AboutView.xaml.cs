using System.Reactive.Disposables;
using System.Windows.Input;
using iCore.Client.WPF.ViewModels;
using ReactiveUI;

namespace iCore.Client.WPF.Views
{
    public partial class AboutView : ReactiveUserControl<AboutViewModel>
    {
        public AboutView()
        {
            InitializeComponent();
            this.WhenActivated(disposables =>
            {
                this.OneWayBind(ViewModel, x => x.UrlPathSegment, x => x.TitleTextBlock.Text)
                    .DisposeWith(disposables);
            });
        }
        
    }
}
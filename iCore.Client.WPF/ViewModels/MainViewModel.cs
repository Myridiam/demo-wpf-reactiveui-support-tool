using System.Reactive;
using iCore.Client.WPF.Views;
using ReactiveUI;
using Splat;

namespace iCore.Client.WPF.ViewModels
{
    
    public class MainViewModel : ReactiveObject, IScreen
    {
        // The Router associated with this Screen.
        // Required by the IScreen interface.
        public RoutingState Router { get; }
        
        // The command that navigates a user to first view model.
        public ReactiveCommand<Unit, IRoutableViewModel> GoNext { get; }

        // The command that navigates a user back.
        public ReactiveCommand<Unit, Unit> GoBack { get; }

        public MainViewModel()
        {
            // Initialize the Router.
            Router = new RoutingState();

            // Router uses Splat.Locator to resolve views for
            // view models, so we need to register our views
            // using Locator.CurrentMutable.Register* methods.
            //
            // Instead of registering views manually, you 
            // can use custom IViewLocator implementation,
            // see "View Location" section for details.
            //
            Locator.CurrentMutable.Register(() => new AboutView(), typeof(IViewFor<AboutViewModel>));

            // Manage the routing state. Use the Router.Navigate.Execute
            // command to navigate to different view models. 
            //
            // Note, that the Navigate.Execute method accepts an instance 
            // of a view model, this allows you to pass parameters to 
            // your view models, or to reuse existing view models.
            //
            GoNext = ReactiveCommand.CreateFromObservable(() => Router.Navigate.Execute(new AboutViewModel()));

            // You can also ask the router to go back.
            GoBack = Router.NavigateBack;
        }
    }
    
}
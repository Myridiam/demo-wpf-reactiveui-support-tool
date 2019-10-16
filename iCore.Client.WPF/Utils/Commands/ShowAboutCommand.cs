using System;
using System.Windows;
using System.Windows.Input;
using iCore.Client.WPF.Views;
using iCore.Client.WPF.Windows;

namespace iCore.Client.WPF.Utils.Commands
{
    public class ShowAboutCommand : ICommand
    {

        private bool canExecute;

        public ShowAboutCommand()
        {
            canExecute = true;
        }
        
        public bool CanExecute(object parameter)
        {
            return canExecute;
        }

        public void Execute(object parameter)
        {
            canExecute = false;

            var aboutWindow = new ModalDialogWindow();
            aboutWindow.ShowDialog();

            canExecute = true;
        }

        public event EventHandler CanExecuteChanged;
    }
}
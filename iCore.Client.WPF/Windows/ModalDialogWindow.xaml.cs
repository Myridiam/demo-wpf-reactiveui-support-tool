using System.Windows;
using System.Windows.Input;

namespace iCore.Client.WPF.Windows
{
    public partial class ModalDialogWindow : Window
    {
        public ModalDialogWindow()
        {
            InitializeComponent();
        }
        
        private void CloseCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }
        
        private void CanExecuteHandler(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        
    }
}
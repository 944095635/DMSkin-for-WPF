using DMSkin.Core.MVVM;
using System.Windows;
using System.Windows.Input;

namespace DM_Studio.ViewModels
{
    public class MainWindowViewModel
    {
        public ICommand F1Command
        {
            get
            {
                return new DelegateCommand((obj) => {
                    MessageBox.Show("Test");
                });
            }
        }

    }
}

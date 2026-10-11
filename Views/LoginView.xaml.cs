using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UnderTheSea.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        private void OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            var model = DataContext as UnderTheSea.ViewModels.LoginViewModel;
            if (model != null) model.Password = ((PasswordBox)sender).Password;
        }

        public LoginView()
        {
            InitializeComponent();
        }
    }
}

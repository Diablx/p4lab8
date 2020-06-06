using p4lab8.Model;
using p4lab8.ViewModel;
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

namespace p4lab8
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private RegistrationViewModel _registrationViewModel { get; set; }
        private FakeDb _DbContext { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            _registrationViewModel = new RegistrationViewModel();
            this.DataContext = _registrationViewModel;
            _DbContext = new FakeDb();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (_registrationViewModel.RepeatedPassword != _registrationViewModel.Password)
            {
                MessageBox.Show("Passwords are different.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                   return;
            }
            if (_registrationViewModel.TermsAccepted != true)
            {
                MessageBox.Show("terms not accepted");
                return;
            }
            else
            {
                var newUser = new Model.UserAccount()
                {
                    Username = _registrationViewModel.Login,
                    PasswordHash = _registrationViewModel.Password.ToUpper(),
                    AccountCreationDate = _registrationViewModel.AccountCreated,
                    TermsAcceptanceDate = DateTime.Now,
                };
                MessageBox.Show("added user XDD");
            }
        }
    }
}

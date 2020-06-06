using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lab8.ViewModel
{
    public class RegistrationViewModel : INotifyPropertyChanged
    {
        private string _login;
        private string _password;
        private string _repeatedPassword;

        public string Login
        {
            get => _login;

            set
            {
                if (_login != value)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Login"));
                    _login = value;
                }
            }
        }
        public string Password { get => _password; set 
            {
                if (_password != value)
                {
                    _password = value;
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Password"));
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("PasswordsMatch"));
                }
            } }
        public string RepeatedPassword { get => _repeatedPassword; set
            {
                if (_repeatedPassword != value)
                {
                    _repeatedPassword = value;
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("RepeatedPassword"));
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("PasswordsMatch"));
                }
            } }
        public bool TermsAccepted { get; set; }
        public DateTime AccountCreated { get; set; }

        public bool PasswordsMatch
        {
            get
            {
                return Password == RepeatedPassword;
            }
        }
        public RegistrationViewModel()
        {
            AccountCreated = new DateTime(2012, 12, 12);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

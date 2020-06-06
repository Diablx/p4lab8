using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lab8.ViewModel
{
    public class RegistrationViewModel
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string RepeatedPassword { get; set; }
        public bool TermsAccepted { get; set; }
        public DateTime AccountCreated { get; set; }

        public RegistrationViewModel()
        {
            AccountCreated = new DateTime(2012, 12, 12);
        }
    }
}

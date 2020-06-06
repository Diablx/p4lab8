using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lab8.Model
{
    public class UserAccount
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public DateTime? TermsAcceptanceDate { get; set; }
        public DateTime AccountCreationDate { get; set; }
    }
}

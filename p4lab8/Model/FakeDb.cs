using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace p4lab8.Model
{
    public class FakeDb
    {
        public bool AddUser(UserAccount uacc)
        {
            MessageBox.Show($"User has been added to db.", "Success", MessageBoxButton.OK);
            return true;
        }
    }
}

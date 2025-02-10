using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp3.Commands;
using WpfApp3.Models;

namespace WpfApp3.ViewModel
{
    public class EditUserViewModel
    {

        
        public ICommand EditUserCommand { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        private User _user;

       
        public EditUserViewModel(User user)
        {
            _user = user;
            Name = user.Name;
            Email = user.Email;
            
            EditUserCommand = new RelayCommand(EditUser,CanEditUser);
        }

        private bool CanEditUser(object obj)
        {
            return true;
        }

        private void EditUser(object obj)
        {
            
            _user.Name = Name;
            _user.Email = Email;
        }
    }
}

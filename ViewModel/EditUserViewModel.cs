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

        private MainViewModel _mainViewModel;
        private User _userToEdit;
        public ICommand EditUserCommand { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public EditUserViewModel(MainViewModel mainViewModel,User userToEdit)
        {
            _mainViewModel = mainViewModel;
            _userToEdit = userToEdit; 
            Name = userToEdit.Name;
            Email = userToEdit.Email;
            
            EditUserCommand = new RelayCommand(EditUser,CanEditUser);
        }

        private bool CanEditUser(object obj)
        {
            return true;
        }

        private void EditUser(object obj)
        {
            //var existingUser = _mainViewModel.Users.FirstOrDefault(u=>u== _userToEdit);
            _userToEdit.Email = Email;
            _userToEdit.Name = Name;
        }
    }
}

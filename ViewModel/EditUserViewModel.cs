using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp3.Commands;

namespace WpfApp3.ViewModel
{
    public class EditUserViewModel
    {
        public ICommand EditUserCommand { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public EditUserViewModel()
        {
            EditUserCommand = new RelayCommand(EditUser,CanEditUser);
        }

        private bool CanEditUser(object obj)
        {
            throw new NotImplementedException();
        }

        private void EditUser(object obj)
        {
            throw new NotImplementedException();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp3.Commands;
using WpfApp3.Models;


namespace WpfApp3.ViewModel
{
    public class AddUserViewModel
    {   
        public ICommand AddUserCommand { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public AddUserViewModel() 
        {
            AddUserCommand = new RelayCommand(AddUser, CanAddUser);
        }

        private bool CanAddUser(object obj)
        {
            return true;
        }

        private void AddUser(object obj)
        {
            UserManager.AddUser(new User { Name = Name, Email = Email });
        }
    }
}

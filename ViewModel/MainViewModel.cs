using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp3.Commands;
using WpfApp3.Models;
using WpfApp3.Views;
using WpfApp3.ViewModel;
using System.Windows;
using System.ComponentModel;

namespace WpfApp3.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<User> Users { get; set; }

        public ICommand ShowWindowCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public ICommand ShowEditWindowCommand { get; set; }

        private User _selectedValue;

        

       
        public User SelectedValue
        {
            get
            {
                return _selectedValue;
            }
            set
            {
                _selectedValue = value;
                OnPropertyChanged(nameof(SelectedValue));
               
             
            }
        }

        public MainViewModel()
        {
            Users = UserManager.GetUsers();
            ShowWindowCommand = new RelayCommand(ShowWindow,CanShowWindow);
            DeleteCommand = new RelayCommand(Delete, CanDelete);
            ShowEditWindowCommand = new RelayCommand(ShowEditWindow, CanShowEditWindow);
        }

        private bool CanShowEditWindow(object obj)
        {
            return true;
        }

        private void ShowEditWindow(object obj)
        {
           
            if (SelectedValue != null)
            {
                EditUser editUserWin = new EditUser(SelectedValue);
                editUserWin.Show();
            }
            else
            {
                MessageBox.Show("No user selected for editing.");
            }
            
        }

        private bool CanDelete(object obj)
        {
            return true;
        }

        private void Delete(object obj)
        {
            if(obj is User contactToDelete && Users.Contains(contactToDelete))
            {
                Users.Remove(contactToDelete);
            }
        }

        private bool CanShowWindow(object obj)
        {
            return true;
        }

        private void ShowWindow(object obj)
        {
            AddUser addUserWin = new AddUser();
            addUserWin.Show();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

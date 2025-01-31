﻿using System;
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
using System.Windows.Shapes;
using WpfApp3.Models;
using WpfApp3.ViewModel;

namespace WpfApp3.Views
{
    /// <summary>
    /// Interaction logic for EditUser.xaml
    /// </summary>
    public partial class EditUser : Window
    {
        public EditUser(MainViewModel mainViewModel,User userToEdit)
        {
            InitializeComponent();
            EditUserViewModel editUser = new EditUserViewModel(mainViewModel, userToEdit);
            DataContext = editUser;

        }
    }
}

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
      
        public EditUser(User user)
        {
            try
            {
              
                InitializeComponent();
                EditUserViewModel editUserViewModel = new EditUserViewModel(user);
                this.DataContext = editUserViewModel;
               
                
            }
            catch(Exception ex){
                MessageBox.Show($"Error: {ex.Message}");
            }
           
        }
    }
}

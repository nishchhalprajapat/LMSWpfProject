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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LMS.Pages
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Page
    {
        public SignUp()
        {
            InitializeComponent();
        }
        private void go_to_book_Detail_page(object sender, RoutedEventArgs e)
        {
            HomePage homePage = new HomePage();
           
        }
    }
}

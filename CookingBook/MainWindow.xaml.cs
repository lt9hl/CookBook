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
using CookingBook.AppData;
using CookingBook.Pages;

namespace CookingBook
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppData.AppFrame.frMain = frMain;
            frMain.Navigate(new Pages.Authorize() );
            AppConnect.modelOdb = new BookEntitiesNw();
        }

        private void frMain_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}

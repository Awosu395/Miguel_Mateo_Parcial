using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MiguelMendoza_Parcial1
{
    /// <summary>
    /// Lógica de interacción para administrador.xaml
    /// </summary>
    public partial class administrador : Page
    {
        public administrador()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, RoutedEventArgs e)
        {
          MainWindow w = (MainWindow)  Window.GetWindow(this);
            w.Framemain.NavigationService.Navigate(new Page1());
        }

        private void btnEmple_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.Framemain.NavigationService.Navigate(new botonempleada());
        }
    }
}

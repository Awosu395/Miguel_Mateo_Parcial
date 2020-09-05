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
    /// Lógica de interacción para botonempleada.xaml
    /// </summary>
    public partial class botonempleada : Page
    {
        public botonempleada()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (us.Text == "empleado" && pw.Password == "1234")
            {
                MainWindow w = (MainWindow)Window.GetWindow(this);
                w.Framemain.NavigationService.Navigate(new empleada1());
            }
            else
                 {
                 MessageBox.Show("Invalid credentials");
                 }
            {
                
            }
        }  
    }
}

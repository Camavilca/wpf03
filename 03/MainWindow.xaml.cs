using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace _03
{

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void openPE(object sender, RoutedEventArgs e)
        {
            PrimerEjercicio form = new PrimerEjercicio();
            form.ShowDialog();
        }
        private void openSE(object sender, RoutedEventArgs e)
        {
            SegundoEjercicio form = new SegundoEjercicio();
            form.ShowDialog();
        }

        private void openLPaises(object sender, RoutedEventArgs e)
        {
            Paises form = new Paises();
            form.ShowDialog();
        }

        private void openLProve(object sender, RoutedEventArgs e)
        {
            Proveedores form = new Proveedores();
            form.ShowDialog();
        }

        private void openLogin(object sender, RoutedEventArgs e)
        {

            Login form = new Login();
            form.ShowDialog();
        }

    }


}

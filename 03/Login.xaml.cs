using _03.Models;
using System;
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

namespace _03
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        Usuario usuario = new Usuario();
        Datos obj = new Datos();
        public Login()
        {
            InitializeComponent();
        }


        private void btnLogin(object sender, RoutedEventArgs e)
        {
            usuario.Username = UsernameText.Text;
            usuario.Password = PasswordText.Text;
            if (obj.existUser(usuario) == true)
            {
                MessageBox.Show("Bienvenido a la Aplicacion" + UsernameText.Text);
            }
            else
            {
                MessageBox.Show("Error de Acceso");
            }

        }
    }
}

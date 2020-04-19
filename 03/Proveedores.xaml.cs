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
    /// Lógica de interacción para Proveedores.xaml
    /// </summary>
    public partial class Proveedores : Window
    {
        Datos obj = new Datos();
        public Proveedores()
        {
            InitializeComponent();
            List<Proveedor> proveedores = obj.ListarProveedores();
            Console.Write(proveedores);
            listViewProveedores.ItemsSource = proveedores;
        }
    }
}

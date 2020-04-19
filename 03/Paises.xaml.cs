using _03.Models;
using System.Collections.Generic;
using System.Windows;


namespace _03
{

    public partial class Paises : Window
    {
        Datos obj = new Datos();
        public Paises()
        {
            InitializeComponent();
            List<Pais> paises = obj.ListarPaises();
            System.Console.Write(paises);
            lbTodoList.ItemsSource = paises;
        }
    }

}

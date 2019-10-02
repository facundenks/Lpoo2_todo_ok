using System;
using System.Collections.Generic;
using System.Linq;
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
using ClasesBase;

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Usuario> usuarios = new List<Usuario>();
        private String rol;

        public String Rol
        {
            get { return rol; }
            set { rol = value; }
        }
        private String nombreApellido;

        public String NombreApellido
        {
            get { return nombreApellido; }
            set { nombreApellido = value; }
        }

        public List<Usuario> Usuarios
        {
            get { return usuarios; }
            set { usuarios = value; }
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            validar();
        }

        private void validar()
        {
            if (Rol == "administrador")
            {
                vent.Visibility = Visibility.Visible;
                ges.Visibility = Visibility.Hidden;
            }
            else {
                if (Rol == "operador")
                {
                    vent.Visibility = Visibility.Hidden;
                    ges.Visibility = Visibility.Visible;
                }
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void MenuItem_Cliente(object sender, RoutedEventArgs e)
        {
            formCliente cleinteForm = new formCliente();
            cleinteForm.Show();
        }

        private void MenuItem_Autobus(object sender, RoutedEventArgs e)
        {
            formAutobus autobusForm = new formAutobus();
            autobusForm.Show();
        }

        private void MenuItem_Pasaje(object sender, RoutedEventArgs e)
        {
            formVenta ventaForm = new formVenta();
            ventaForm.Show();
        }
    }
}

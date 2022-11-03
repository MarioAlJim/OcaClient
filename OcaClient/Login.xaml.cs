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

namespace OcaClient
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_inicioSesion_Click(object sender, RoutedEventArgs e)
        {
            OcaGameServices.AuthenticationClient autentication = new OcaGameServices.AuthenticationClient();
            String username = txt_usuario.Text;
            String password = txt_contrasenia.Password;
            bool exist;
            exist = autentication.login(username, password);
            if (exist == true)
            {
                MessageBox.Show("Bienvenido");
                //MainMenu mainMenu = new MainMenu();
                //mainMenu.Show();
            }
            else
            {
                MessageBox.Show("No se encontro el usuario");
            }
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            // SignUp signUp = new SignUp();
            //signUp.Show();
        }

        private void btn_contrasenia_Click(object sender, RoutedEventArgs e)
        {
            RestorePassword restore = new RestorePassword();            
            restore.Show();
            this.Close();
        }
    }
}

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
    /// Lógica de interacción para RestorePassword.xaml
    /// </summary>
    public partial class RestorePassword : Window
    {
        public RestorePassword()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, RoutedEventArgs e)
        {
            OcaGameLogic.SendEmail email = new OcaGameLogic.SendEmail();
            int number = email.send(txt_email.Text);
            if (number != 0)
            {
                Console.WriteLine("Correo enviado");
            }
            else
            {
                MessageBox.Show("¿Desea reenviar el correo?", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Information);
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

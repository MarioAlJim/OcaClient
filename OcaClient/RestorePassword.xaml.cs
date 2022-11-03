using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;

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
            DialogResult result = System.Windows.Forms.DialogResult.OK;
            do
            {
                OcaGameLogic.SendMail email = new OcaGameLogic.SendMail();
                int number = email.send(txt_email.Text);
                if (number != 0)
                {
                    Console.WriteLine("Correo enviado");
                }
                else
                {
                    result = System.Windows.Forms.MessageBox.Show("¿Desea reenviar el correo?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
            } while (result == System.Windows.Forms.DialogResult.Yes);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

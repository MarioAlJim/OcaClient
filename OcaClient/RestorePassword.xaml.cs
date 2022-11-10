using Microsoft.VisualBasic;
using System;
using System.Windows;
using System.Windows.Controls;



namespace OcaClient
{

    public partial class RestorePassword : Window
    {
        public RestorePassword()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBoxResult.No;
            do
            {
                OcaGameLogic.SendEmail email = new OcaGameLogic.SendEmail();
                int number = email.send(txt_email.Text);
                int code = 0;
                if (number != 0)
                {
                    try
                    {
                        code = Convert.ToInt32(Interaction.InputBox("Ingrese el codigo enviado a su correo", "Verificación"));
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Caracteres no validos");
                        result = MessageBox.Show("¿Desea reenviar el correo?", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Information);
                    }

                    if (number == code)
                    {
                        NewPassword newPassword = new NewPassword();
                        newPassword.Show();
                        result = MessageBoxResult.No;
                    }                    

                }
                else
                {
                   result = MessageBox.Show("¿Desea reenviar el correo?", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Information);
                  
                }
            } while (result == MessageBoxResult.Yes);
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

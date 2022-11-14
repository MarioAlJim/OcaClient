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
            OcaServices.EmailClient email = new OcaServices.EmailClient();
            OcaServices.User userAcount = new OcaServices.User();
            MessageBoxResult result = MessageBoxResult.No;
            userAcount = email.GetUserFromEmail(txt_email.Text);           
            if (userAcount.Email == txt_email.Text) 
            { 
                do
                {

                    int number = email.sendEmail(txt_email.Text);
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
                            newPassword.reciveUser(userAcount);
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
            else
            {
                MessageBox.Show("El correo no pertence a un usuario");
            }
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

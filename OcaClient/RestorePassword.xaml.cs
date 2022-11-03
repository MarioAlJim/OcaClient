using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
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
            DialogResult result = System.Windows.Forms.DialogResult.OK;
            do {
                OcaGameLogic.SendEmail email = new OcaGameLogic.SendEmail();
                int number = email.send(txt_email.Text);
                int code = 0;
                if (number != 0)
                {
                    try
                    {
                        code = Convert.ToInt32(Interaction.InputBox("Ingrese el codigo enviado a su correo", "Verificación"));
                    }
                    catch (Exception)
                    {
                        System.Windows.Forms.MessageBox.Show("Caracteres no validos");
                    }

                    if (number == code)
                    {
                        NewPassword newPassword = new NewPassword();
                        newPassword.Show();
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Los códigos no coinciden"); 
                    }

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

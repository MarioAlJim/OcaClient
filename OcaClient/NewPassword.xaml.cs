using OcaClient.OcaServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Lógica de interacción para NewPassword.xaml
    /// </summary>
    public partial class NewPassword : Window
    {
        private OcaServices.User activeUser;

        public NewPassword()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            String newPassword = txt_newPassword.Password;
            String confirmPasswrod = txt_ConfirmPassword.Password;
            bool result = false;

            if (newPassword == confirmPasswrod)
            {
                OcaServices.EmailClient email = new OcaServices.EmailClient();
                activeUser.Password = newPassword;
                result = email.UpdatePassword(activeUser);
                if (result == true)
                {
                    Console.WriteLine("SI SE LOGRO");
                }
                else
                {
                    Console.WriteLine("NO SE LOGRO");
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
        }

        public void reciveUser(User user)
        {
            activeUser = user;            
        }
    }
}

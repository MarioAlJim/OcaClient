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
    /// Lógica de interacción para SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)

        {
            // BussinesLogic Authentication autenti= new BussinesLogic  Authentication()
            String name = txt_Name.Text;
            String lastName = txt_LastName.Text;
            String email = txt_email.Text;
            String nickname = txt_username.Text;
            String password = txt_pwd.Password;

            //OcaBussinessLogic.UsersAdministration userAdd = new OcaBussinessLogic.UsersAdministration();
            //userAdd.SignUpUser(nickname, password);
        }
    }
}

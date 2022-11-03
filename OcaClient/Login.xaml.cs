using System;
using System.ServiceModel;
using System.Windows;


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
        private OcaServices.User userAcount = new OcaServices.User();

        private void btn_inicioSesion_Click(object sender, RoutedEventArgs e)
        {
            OcaServices.AuthenticationClient autentication = new OcaServices.AuthenticationClient();
            try
            {
                String username = txt_usuario.Text;
                String password = txt_contrasenia.Password;

                userAcount = autentication.login(username, password);
                if (userAcount.Nickname == username)
                {
                    MessageBox.Show("Bienvenido");
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se encontro el usuario");
                }
            }
            catch (TimeoutException timeProblem)
            {
                Console.WriteLine("The service operation timed out. " + timeProblem.Message);
                autentication.Abort();
                Console.ReadLine();
            }
            catch (FaultException faultEx)
            {
                Console.WriteLine("An unknown exception was received. " + faultEx.Message + faultEx.StackTrace);
                Console.Read();
                autentication.Abort();
            }
            catch (CommunicationException commProblem)
            {
                Console.WriteLine("There was a communication problem. " + commProblem.Message + commProblem.StackTrace);
                Console.Read();
                autentication.Abort();
            }
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            // SignUp signUp = new SignUp();
            //signUp.Show();
        }

        private void btn_contrasenia_Click(object sender, RoutedEventArgs e)
        {
          //  RestorePassword restore = new RestorePassword();
           // restore.Show();
        }
    }
}

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
    /// Lógica de interacción para Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void cbb_Lenguaje_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbb_Lenguaje.SelectedIndex == 0)
            {
                Properties.Settings.Default.lenguajeCode = "en-US";
            }
            else
            {
                Properties.Settings.Default.lenguajeCode = "es-MX";
            }
        }

        private void btn_SignOut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btn_SaveChanges_Click(object sender, RoutedEventArgs e)
        { 
            Properties.Settings.Default.Save();
        }
    }
}

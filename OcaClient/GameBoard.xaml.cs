using OcaClient.Properties;
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
    /// Lógica de interacción para GameBoard.xaml
    /// </summary>
    public partial class GameBoard : Window
    {
        public GameBoard()
        {
            InitializeComponent();
        }

       
        private void roll_Dice(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            BitmapImage bitmap = new BitmapImage();
            
            int diceNumber = random.Next(1, 7);       ;
            switch (diceNumber)
            {
                case 1:
                    bitmap.BeginInit();
                    bitmap.UriSource = new Uri("dice_one.PNG", UriKind.Relative);
                    bitmap.EndInit();
                    img_dice.Stretch = Stretch.Fill;
                    img_dice.Source = bitmap;                   
                    break;
                case 2:
                    bitmap.BeginInit();
                    bitmap.UriSource = new Uri("dice_two.PNG", UriKind.Relative);
                    bitmap.EndInit();
                    img_dice.Stretch = Stretch.Fill;
                    img_dice.Source = bitmap;                    
                    break;
                case 3:
                    bitmap.BeginInit();
                    bitmap.UriSource = new Uri("dice_three.PNG", UriKind.Relative);
                    bitmap.EndInit();
                    img_dice.Stretch = Stretch.Fill;
                    img_dice.Source = bitmap;                   
                    break;
                case 4:
                    bitmap.BeginInit();
                    bitmap.UriSource = new Uri("dice_four.PNG", UriKind.Relative);
                    bitmap.EndInit();
                    img_dice.Stretch = Stretch.Fill;
                    img_dice.Source = bitmap;                  
                    break;
                case 5:
                    bitmap.BeginInit();
                    bitmap.UriSource = new Uri("dice_five.PNG", UriKind.Relative);
                    bitmap.EndInit();
                    img_dice.Stretch = Stretch.Fill;
                    img_dice.Source = bitmap;                   
                    break;
                case 6:
                    bitmap.BeginInit();
                    bitmap.UriSource = new Uri("dice_six.PNG", UriKind.Relative);
                    bitmap.EndInit();
                    img_dice.Stretch = Stretch.Fill;
                    img_dice.Source= bitmap;                   
                    break;
            }
        }
    }
}

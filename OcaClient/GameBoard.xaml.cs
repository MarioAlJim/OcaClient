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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace OcaClient
{
    /// <summary>
    /// Lógica de interacción para GameBoard.xaml
    /// </summary>
    public partial class GameBoard : Window
    {
        private DispatcherTimer timer;
        public GameBoard()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += timer_tick;
            timer.Start();
        }

        private void timer_tick(object sender, EventArgs e)
        {
            
        }

        private void roll_Dice(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            BitmapImage bitmap = new BitmapImage();
            
            int diceNumber = random.Next(1,7);
            move(20);
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

        public void move(int pos)
        {

            int posX;
            int posY;
            int spaces = 65;
            if (pos > 0 && pos < 9)
            {
                posX = pos * spaces;
                posY = 415;              
                setPieces(posX, posY, 0);

            }
            else
            {
                if (pos < 18)
                {
                    posX = pos * spaces;
                    posY = 1;
                    //setPieces(posX, posY);
                }
                else
                {
                    if (pos > 18 && pos < 27)
                    {
                        posX = pos * spaces;
                        posY = 281;
                        setPieces(posX, posY, 0);
                    }
                    else 
                    {
                        if (pos < 36)
                        {
                            posX = pos * spaces;
                            posY = 3;
                            //setPieces(posX, posY);
                        }
                        else 
                        { 
                            if (pos < 45)
                            {
                                posX = pos * spaces;
                                posY = 4;
                                //setPieces(posX, posY);
                            }
                            else
                            {
                                if (pos < 54)
                                {
                                    posX = pos * spaces;
                                    posY = 5;
                                    //setPieces(posX, posY);
                                }
                                else
                                {
                                    if (pos < 60)
                                    {
                                        posX = pos * spaces;
                                        posY = 6;
                                        //setPieces(posX, posY);
                                    }
                                }
                            }   
                        }
                    }
                }
            }
        }



        public void setPieces(int x, int y, int z)
        {
            img_RedChip.Margin = new Thickness(x, y, 0, z);
               
        }



    }
}

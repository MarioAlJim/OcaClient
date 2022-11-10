using System;
using System.Windows;
using System.Windows.Controls;

namespace OcaClient
{
    /// <summary>
    /// Lógica de interacción para Lobby.xaml
    /// </summary>
    public partial class Lobby : Window
    {
        public Lobby()
        {
            InitializeComponent();
        }
        private OcaGameServices.Game game = new OcaGameServices.Game();

        private void btn_CreateGame_Click(object sender, RoutedEventArgs e)
        { 
            try
            {
                ComboBoxItem comboBoxItem;
                comboBoxItem = (ComboBoxItem)cbb_NumberofPlayers.SelectedItem;
                string numberPlayersC = comboBoxItem.Content.ToString();
                comboBoxItem = (ComboBoxItem)cbb_TurnTime.SelectedItem;
                string turnTimeC = comboBoxItem.Content.ToString();
                comboBoxItem = (ComboBoxItem)cbb_Background.SelectedItem;
                string backgroundC = comboBoxItem.Content.ToString();

                int numberPlayers = Int32.Parse(numberPlayersC);
                int background = Int32.Parse(backgroundC);
                game.NumberOfPlayers = numberPlayers;
                game.TurnTime = turnTimeC;
                game.Background = background;
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse");
            }
            OcaGameServices.GameClient gameClient = new OcaGameServices.GameClient();
            game = gameClient.CreateGame(game);
            cbb_Background.IsEnabled = false;
            cbb_NumberofPlayers.IsEnabled = false;
            cbb_TurnTime.IsEnabled = false;
            int code = game.Code;
            txt_Code.Text = "" + code;
            btn_StartGame.IsEnabled = true;
        }

        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            cbb_Background.IsEnabled = true;
            cbb_NumberofPlayers.IsEnabled = true;
            cbb_TurnTime.IsEnabled = true;
            txt_Code.Text = "";
            btn_StartGame.IsEnabled = false;
        }
    }
}

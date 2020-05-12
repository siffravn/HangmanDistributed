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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GameGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class GUI : Window
    {
        private GameController gameController = new GameController();

        public GUI()
        {
            InitializeComponent();
            UpdateView();
        }
        //TODO make individual button methods
        private async void Button_Letter_Click(object sender, RoutedEventArgs e)
            /// TODO: implement logic for button press (guess the letter)
        {
            Button B = (Button)sender;
            B.Visibility = Visibility.Hidden;
            await gameController.GuessAsync(B.Content.ToString());
            UpdateView();

        }

        private void Button_Guess_Word_Click(Object sender, RoutedEventArgs e)
        {
            GuessWordDialog guessWordDialog = new GuessWordDialog();
            guessWordDialog.gameController = gameController;
            guessWordDialog.Owner = this;
            guessWordDialog.Show();
        }
        

        public void UpdateView()
        {
            TB_visibleWord.Text = gameController.game.VisibleWord;


            
            switch (gameController.game.Lives)
            {
                case 6 :
                    GallowImage.Source = new BitmapImage(new Uri("/Images/galge.png", UriKind.Relative));
                    break;
                case 5:
                    GallowImage.Source = new BitmapImage(new Uri("/Images/forkert1.png", UriKind.Relative));
                    break;
                case 4:
                    GallowImage.Source = new BitmapImage(new Uri("/Images/forkert2.png", UriKind.Relative));
                    break;
                case 3:
                    GallowImage.Source = new BitmapImage(new Uri("/Images/forkert3.png", UriKind.Relative));
                    break;
                case 2:
                    GallowImage.Source = new BitmapImage(new Uri("/Images/forkert4.png", UriKind.Relative));
                    break;
                case 1:
                    GallowImage.Source = new BitmapImage(new Uri("/Images/forkert5.png", UriKind.Relative));
                    break;
                case 0:
                    GallowImage.Source = new BitmapImage(new Uri("/Images/forkert6.png", UriKind.Relative));
                    break;
            }
        }

    }
}

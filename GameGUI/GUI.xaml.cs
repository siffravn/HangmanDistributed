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
        public GUI()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
            /// TODO: implement logic for button press (guess the letter)
        {
            if (sender == Btn_openGuessDia)
            {
                GuessWordDialog guessWordDialog = new GuessWordDialog();
                guessWordDialog.Owner = this;
                guessWordDialog.Show();
            }
            Button B = (Button)sender;
            switch (B.Content)
            {
                case "Q":
                    MessageBox.Show(Btn_Q.Content.ToString());
                    TB_visibleWord.Text = Btn_Q.Content.ToString();
                    Btn_Q.Visibility = Visibility.Hidden;
                    break;
                case "W":
                    MessageBox.Show(Btn_W.Content.ToString());
                    break;
            }
        GallowImage.Source = new BitmapImage(new Uri("/Images/forkert1.png", UriKind.Relative));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GameGUI
{
    /// <summary>
    /// Interaction logic for GuessWordDialog.xaml
    /// </summary>
    public partial class GuessWordDialog : Window
    {
        public GameController gameController { get; set; }
        public GuessWordDialog()
        {
            InitializeComponent();
        }

        private void Btn_guessWord_Click(object sender, RoutedEventArgs e)
        {
            gameController.Guess(TB_guessInput.Text);
            guessWordDialog.Close();
            var gui = this.Owner as GUI;
            gui.UpdateView();
          
           
           
        }
    }
}

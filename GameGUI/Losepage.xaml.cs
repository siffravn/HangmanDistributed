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
    /// Interaction logic for Losepage.xaml
    /// </summary>

    public partial class Losepage : Window
    {
        public string ordet { get; set; }

        public Losepage()
        {
            InitializeComponent();
            Text_Block_Word.Text = ordet;
        }

        private void Btn_Replay_Game_Click(object sender, RoutedEventArgs e)
        {
            GUI gui = new GUI();
            gui.Show();
            this.Close();
        }
    }
}

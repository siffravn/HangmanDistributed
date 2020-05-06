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
    /// Interaction logic for Startpage.xaml
    /// </summary>
    public partial class Startpage : Window
    {
        public Startpage()
        {
            InitializeComponent();
        }

        private void Btn_startGame_Click(object sender, RoutedEventArgs e)
        {
            GUI gui = new GUI();
            gui.Show();
            this.Close();
        }
    }
}

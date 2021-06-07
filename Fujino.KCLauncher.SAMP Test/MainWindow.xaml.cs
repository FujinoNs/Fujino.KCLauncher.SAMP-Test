using Fujino.KCLauncher.SAMP;
using System;
using System.Windows;

namespace Fujino.KCLauncher.SAMP_Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        KC_SAMP _SAMP;
        public MainWindow()
        {
            InitializeComponent();
            _SAMP = new KC_SAMP("127.0.0.1", "7777", "");
            lbl_1.Content = "Player Name: " + _SAMP.PlayerName();
            lbl_2.Content = "Server Name: " + _SAMP.ServerName();
            lbl_3.Content = "Game Mode: " + _SAMP.GameMode();
            lbl_4.Content = "Player Count: " + _SAMP.PlayerCount();
            lbl_5.Content = "Player Max: " + _SAMP.PlayerMax();
            lbl_6.Content = "Map Name: " + _SAMP.MapName();
            lbl_7.Content = "Website: " + _SAMP.WebsiteUrl();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _SAMP.ConnectGame();
        }
    }
}

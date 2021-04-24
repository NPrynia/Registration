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
using Game.Window;
using System.IO;
using Registration;

namespace Game
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MenuWindow
    {
        public MenuWindow()
        {
            InitializeComponent();


            Path.PathSave = @"Game/RedHat/Save.txt";



        }
        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Game/RedHat/sounds\Button.wav");

            player.Play();
            GameWindow gameWindow = new GameWindow();
            this.Close();
            gameWindow.Show();

        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Game/RedHat/sounds\Button.wav");
            player.Play();

            using (StreamWriter sr = new StreamWriter(Path.PathSave, false))
            {
                sr.Write("");
            }


            GameWindow gameWindow = new GameWindow();
            this.Close();
            gameWindow.Show();

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {


            this.Close();
        }
    }
}

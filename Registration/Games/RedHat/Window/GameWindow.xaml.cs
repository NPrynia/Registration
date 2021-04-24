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
using Game.Page;
using System.Windows.Navigation;
using System.IO;
namespace Game.Window
{
    /// <summary>
    /// Логика взаимодействия для GameWindow.xaml
    /// </summary>
    /// 
    
    public partial class GameWindow
    {
        public GameWindow()
        {
            InitializeComponent();

            using (StreamReader sr = new StreamReader(Path.PathSave))
            {
                string a = sr.ReadToEnd();
                if (a == string.Empty)
                {
                    FrameMain.Navigate(new TitleScrin());
                }
            }

            using (StreamReader sr = new StreamReader(Path.PathSave))
            {



                string a = sr.ReadLine();
           
                int num = Convert.ToInt32(a);

                if (num == 1)
                {
                    FrameMain.Navigate(new Page1());
                }
                if (num == 2)
                {
                    FrameMain.Navigate(new Page2());
                }
                if (num == 3)
                {
                    FrameMain.Navigate(new Page3());
                }
                if (num == 4)
                {
                    FrameMain.Navigate(new Page4());
                }
                if (num == 5)
                {
                    FrameMain.Navigate(new Page5());

                }
                if (num == 6)
                {
                    FrameMain.Navigate(new Page6());
                }
                if (num == 7)
                {
                    FrameMain.Navigate(new Page7());
                }
                if (num == 8)
                {
                    FrameMain.Navigate(new Page8());
                }
                if (num == 9)
                {
                    FrameMain.Navigate(new Page9());
                }
                if (num == 10)
                {
                    FrameMain.Navigate(new Page10());
                }
                if (num == 11)
                {
                    FrameMain.Navigate(new Page11());
                }
                if (num == 12)
                {
                    FrameMain.Navigate(new Page12());
                }
                if (num == 13)
                {
                    FrameMain.Navigate(new Page13());
                }
                if (num == 14)
                {
                    FrameMain.Navigate(new Page14());
                }
                if (num == 15)
                {
                    FrameMain.Navigate(new Page15());
                }
                if (num == 16)
                {
                    FrameMain.Navigate(new Page16());
                }
                if (num == 17)
                {
                    FrameMain.Navigate(new Page17());
                }

                else
                {

                    //FrameMain.Navigate(new TitleScrin());
                }
            }
           
        }

        



        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"sounds\Button.wav");
            player.Play();
            MenuWindow main = new MenuWindow();
            this.Close();
            main.ShowDialog();
        }
    }
}

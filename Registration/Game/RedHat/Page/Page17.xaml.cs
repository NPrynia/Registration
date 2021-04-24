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
using System.IO;
namespace Game.Page
{
    /// <summary>
    /// Логика взаимодействия для Page17.xaml
    /// </summary>
    public partial class Page17 
    {
        public Page17()
        {
            InitializeComponent();
        }

        private void btnCLick1_Click(object sender, RoutedEventArgs e)
        {
            txtMain.Text = "— Это, внучка, чтобы получше тебя обнимать.";
        }

        private void btnCLick2_Click(object sender, RoutedEventArgs e)
        {
            
            txtMain.Text = "— Это, внучка, чтобы получше бегать.";
        }

        private void btnCLick3_Click(object sender, RoutedEventArgs e)
        {
            txtMain.Text = "— Это, внучка, чтобы получше тебя видеть.";
        }

        private void btnCLick4_Click(object sender, RoutedEventArgs e)
        {
            
            txtMain.Text = "— Это, внучка, чтобы получше тебя слышать.";
        }

        private void btnCLickEnd_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"sounds\Krik.wav");
            player.Play();
            MessageBox.Show("— Это, чтобы тебя съесть!");
            PageEnd pageEnd = new PageEnd();
            NavigationService.Navigate(pageEnd);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            using (StreamWriter sw = new StreamWriter(Path.PathSave, false))
            {
                sw.Write("17");
                MessageBox.Show("Вы сохранились!");
            }
        }
    }
}

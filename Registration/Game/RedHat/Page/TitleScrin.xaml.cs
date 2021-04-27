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
using Game.Page;


namespace Game.Page
{
    /// <summary>
    /// Логика взаимодействия для TitleScrin.xaml
    /// </summary>
    public partial class TitleScrin
    {
        public TitleScrin()
        {
            InitializeComponent();
        }

        private void btnNextPage_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Game/RedHat/sounds\forest.wav");
            player.Play();
            Page1 page1 = new  Page1();
            NavigationService.Navigate(page1);
        }
    }
}

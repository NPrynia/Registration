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
using Game;

namespace Registration.Windows
{
    /// <summary>
    /// Логика взаимодействия для WindowGames.xaml
    /// </summary>
    public partial class WindowGames : Window
    {
        public WindowGames()
        {
            InitializeComponent();
        }

        private void btnRedHat_Click(object sender, RoutedEventArgs e)
        {
            MenuWindow menuWindow = new MenuWindow();
            this.Close();
            menuWindow.Show();

        }
    }
}

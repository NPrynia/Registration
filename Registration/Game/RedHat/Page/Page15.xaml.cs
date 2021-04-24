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
    /// Логика взаимодействия для Page15.xaml
    /// </summary>
    public partial class Page15 
    {
        public Page15()
        {
            InitializeComponent();
        }

        private void btnCLick_Click(object sender, RoutedEventArgs e)
        {
            Page16 page16 = new Page16();
            NavigationService.Navigate(page16);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            using (StreamWriter sw = new StreamWriter(Path.PathSave, false))
            {
                sw.Write("15");
                MessageBox.Show("Вы сохранились!");
            }
        }
    }
}

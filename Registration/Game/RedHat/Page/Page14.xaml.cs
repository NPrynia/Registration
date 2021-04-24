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
    /// Логика взаимодействия для Page14.xaml
    /// </summary>
    public partial class Page14 
    {
        public Page14()
        {
            InitializeComponent();
        }

        private void btnCLick_Click(object sender, RoutedEventArgs e)
        {
            Page15 page15 = new Page15();
            NavigationService.Navigate(page15);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            using (StreamWriter sw = new StreamWriter(Path.PathSave, false))
            {
                sw.Write("14");
                MessageBox.Show("Вы сохранились!");
            }
        }
    }
}

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
    /// Логика взаимодействия для Page13.xaml
    /// </summary>
    public partial class Page13 
    {
        public Page13()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, RoutedEventArgs e)
        {
            Page14 page14 = new Page14();
            NavigationService.Navigate(page14);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(Path.PathSave, false))
            {
                sw.Write("13");
                MessageBox.Show("Вы сохранились!");
            }
        }
    }
}

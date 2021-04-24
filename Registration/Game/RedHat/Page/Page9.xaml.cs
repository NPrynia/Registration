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
    /// Логика взаимодействия для Page9.xaml
    /// </summary>
    public partial class Page9 
    {
        public Page9()
        {
            InitializeComponent();
        }

        private void BtnCLick_Click(object sender, RoutedEventArgs e)
        {

            Page10 page10 = new Page10();
            NavigationService.Navigate(page10);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            using (StreamWriter sw = new StreamWriter(Path.PathSave, false))
            {
                sw.Write("9");
                MessageBox.Show("Вы сохранились!");
            }
        }
    }
}

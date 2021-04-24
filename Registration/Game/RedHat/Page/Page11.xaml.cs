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
    /// Логика взаимодействия для Page11.xaml
    /// </summary>
    public partial class Page11 
    {
        public Page11()
        {
            InitializeComponent();
        }

        private void BtnClick_Click(object sender, RoutedEventArgs e)
        {
            {
                Page12 page12 = new Page12();
                NavigationService.Navigate(page12);
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            using (StreamWriter sw = new StreamWriter(Path.PathSave, false))
            {
                sw.Write("11");
                MessageBox.Show("Вы сохранились!");
            }
        }
    }
}

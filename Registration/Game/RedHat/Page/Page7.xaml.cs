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
    /// Логика взаимодействия для Page7.xaml
    /// </summary>
    public partial class Page7 
    {
        public Page7()
        {
            InitializeComponent();
        }

        private void BtnClick_Click(object sender, RoutedEventArgs e)
        {

            Page8 page8 = new Page8();
            NavigationService.Navigate(page8);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            using (StreamWriter sw = new StreamWriter(Path.PathSave, false))
            {
                sw.Write("7");
                MessageBox.Show("Вы сохранились!");
            }
        }
    }
}

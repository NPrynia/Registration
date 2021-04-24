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
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 
    {
        public Page5()
        {
            InitializeComponent();
        }

        private void BtnCLick_Click(object sender, RoutedEventArgs e)
        {
            Page6 page6 = new Page6();
            NavigationService.Navigate(page6);

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            using (StreamWriter sw = new StreamWriter(Path.PathSave, false))
            {
                sw.Write("5");
                MessageBox.Show("Вы сохранились!");
            }
        }
    }
}

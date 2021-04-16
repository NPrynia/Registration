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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void BtnCLick_Click(object sender, RoutedEventArgs e)
        {
            Page4 page4 = new Page4();
            NavigationService.Navigate(page4);
            MessageBox.Show("Где-то в этом лесу спрятался волк, найди его");
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            using (StreamWriter sw = new StreamWriter(Path.PathSave, false))
            {
                sw.Write("3");
                MessageBox.Show("Вы сохранились!");
            }
        }
    }
}

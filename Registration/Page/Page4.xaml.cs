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
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 
    {
        public Page4()
        {
            InitializeComponent();
            
        }

        private void BtnClick_Click(object sender, RoutedEventArgs e)
        {
           
            
            Page5 page5 = new Page5();
            NavigationService.Navigate(page5);

            
        }
    }
}

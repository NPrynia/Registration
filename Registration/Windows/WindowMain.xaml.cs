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
using System.IO;
using Registration;
using Game;
using Registration.Windows;
using Registration.EF;


namespace Authorization
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class WindowMain : Window
    {
        
        public WindowMain()
        {
            InitializeComponent();
            var user = Ent.Context.Users.ToList().FirstOrDefault();
            
            
            
        }
        private void btnGame_Click(object sender, RoutedEventArgs e)
        {
            WindowGames windowGames = new WindowGames();
            this.Close();
            windowGames.Show();
        }

        private void btnUsers_Click(object sender, RoutedEventArgs e)
        {
            WindowUsers windowUsers = new WindowUsers();
            windowUsers.Show();

        }
    }
}

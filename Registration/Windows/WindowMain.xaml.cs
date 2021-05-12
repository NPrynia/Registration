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
using Registration.PageMain;


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
            FrameMain.Navigate(new PageProfile());
            var user = Ent.Context.Users.ToList().FirstOrDefault();
            
            
           
        }
        private void btnGame_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.Navigate(new PageGame());
            var user = Ent.Context.Users.ToList().FirstOrDefault();

        }

        private void btnUsers_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.Navigate(new PageUsers());
            var user = Ent.Context.Users.ToList().FirstOrDefault();

        }

        private void btnProfile_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.Navigate(new PageProfile());
            var user = Ent.Context.Users.ToList().FirstOrDefault();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

      
   
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
           
            Environment.Exit(0);
        }
       
       
    }
}

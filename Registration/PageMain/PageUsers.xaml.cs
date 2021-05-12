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
using Registration.EF;
using Registration.Windows;

namespace Registration.PageMain
{
    /// <summary>
    /// Логика взаимодействия для PageUsers.xaml
    /// </summary>
    public partial class PageUsers : Page
    {
        public PageUsers()
        {
            InitializeComponent();
            if (User.IdRole == 1)
            {
                StackPanel.Visibility = Visibility.Visible;
            }
            LvUsers.ItemsSource = Ent.Context.Users.ToList();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            if (LvUsers.SelectedItems.Count > 0)
            {
                var result = MessageBox.Show("Удалить?", "Удаление клиента", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    if (LvUsers.SelectedItem is Users usersDel)
                    {
                        Ent.Context.Users.Remove(usersDel);
                        Ent.Context.SaveChanges();
                        LvUsers.ItemsSource = Ent.Context.Users.ToList();
                    }
                }
                else 
                {
                    return;
                }
            }

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowAddUser windowAddUser = new WindowAddUser();
            windowAddUser.ShowDialog();
            LvUsers.ItemsSource = Ent.Context.Users.ToList();

        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {

            if (LvUsers.SelectedItem is Users users)
            {
                WindowAddUser windowAddUser = new WindowAddUser(users);
                windowAddUser.ShowDialog();
                LvUsers.ItemsSource = Ent.Context.Users.ToList();
            }
            else
            {
                MessageBox.Show("Пользователь не выбран","Ошибка", MessageBoxButton.OK,MessageBoxImage.Error);
            }

        }
    }
}

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
using Registration.EF;
using Registration.Windows;

namespace Registration.Windows
{
    /// <summary>
    /// Логика взаимодействия для WindowUsers.xaml
    /// </summary>
    public partial class WindowUsers : Window
    {
        public WindowUsers()
        {
            InitializeComponent();
            
            if(User.IdRole == 1)
            {
                StackPanel.Visibility = Visibility.Visible;
            }
            LvUsers.ItemsSource = Ent.Context.Users.ToList();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            if(LvUsers.SelectedItems.Count>0)
            {
                var result = MessageBox.Show("Удалить?", "Удаление клиента", MessageBoxButton.YesNo);
                if(result ==MessageBoxResult.Yes)
                {
                    if(LvUsers.SelectedItem is Users users)
                    {
                        Ent.Context.Users.Remove(Ent.Context.Users.Where(i => i.ID == users.ID).FirstOrDefault());
                        Ent.Context.SaveChanges();
                        LvUsers.ItemsSource = Ent.Context.Users.ToList();
                    }
                }
            }

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowAddUser windowAddUser = new WindowAddUser();
            windowAddUser.ShowDialog();
            LvUsers.ItemsSource = Ent.Context.Users.ToList();

        }
    }
}

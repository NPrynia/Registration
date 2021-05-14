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
        private List<Role> roles = new List<Role>();
        private List<Gender> gender = new List<Gender>();
        private List<Users> Users = new List<Users>();
        public PageUsers()
        {
            InitializeComponent();
            roles = Ent.Context.Role.ToList();
            cbSortRole.ItemsSource = Ent.Context.Role.ToList();
            roles.Insert(0, new Role { Role1 = "Все роли"});
            cbSortRole.ItemsSource = roles;
            cbSortRole.DisplayMemberPath = "Role1";
            cbSortRole.SelectedIndex = 0;

            gender = Ent.Context.Gender.ToList();
            cbSortGender.ItemsSource = Ent.Context.Gender.ToList();
            gender.Insert(0, new Gender { Gender1 = "Любой" });
            cbSortGender.ItemsSource = gender;
            cbSortGender.DisplayMemberPath = "Gender1";
            cbSortGender.SelectedIndex = 0;

            if (User.IdRole == 1)
            {
                StackPanel.Visibility = Visibility.Visible;
            }
            LvUsers.ItemsSource = Ent.Context.Users.ToList();
        }


        private void Filter()
        {



            Users = Ent.Context.Users.ToList();


            if (cbSortGender.SelectedIndex != 0)
            {
                Users = Users.Where(i => i.IdGender == cbSortGender.SelectedIndex).ToList();
            }

            if (cbSortRole.SelectedIndex != 0)
            {
                Users = Users.Where(i => i.IdRole == cbSortRole.SelectedIndex).ToList();

            }

            Users = Users.Where(i => i.LName.Contains(LnameSearch.Text)).ToList();

            LvUsers.ItemsSource = Users;
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

        private void cbSortRole_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        private void LnameSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filter();
        }

        private void cbSortGender_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }
    }
}

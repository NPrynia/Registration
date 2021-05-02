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
    /// Логика взаимодействия для WindowAddUser.xaml
    /// </summary>
    public partial class WindowAddUser : Window
    {
        public WindowAddUser()
        {
            InitializeComponent();
            CbRole.ItemsSource = Ent.Context.Role.ToList();
            CbRole.DisplayMemberPath = "Role1";
            CbRole.SelectedIndex = 1;

            CbGender.ItemsSource = Ent.Context.Gender.ToList();
            CbGender.DisplayMemberPath = "Gender1";
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Ent.Context.Users.Add(new Users
            {

                LName = txtLName.Text,
                IdGender = CbGender.SelectedIndex+1,
                IdRole = CbRole.SelectedIndex + 1,
                Login = txtLog.Text,
                Password = txtPas.Text,
                Phone = txtPhone.Text,
            }

                );
            WindowUsers windowUsers = new WindowUsers();
         
            windowUsers.LvUsers.ItemsSource = Ent.Context.Users.ToList();
            MessageBox.Show("Пользователь добавлен");
            Ent.Context.SaveChanges();
           
        }
    }
}

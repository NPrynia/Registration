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
using System.IO;
using Microsoft.Win32;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Registration.EF;
using Authorization.Windows;
using Registration.PageMain;
namespace Registration.Windows
{
    /// <summary>
    /// Логика взаимодействия для WindowAddUser.xaml
    /// </summary>



    public partial class WindowAddUser : Window
    {
        private bool isEdit;
        private Users editUser;
        private string pathPhoto;

        public WindowAddUser(Users user)
        {

            InitializeComponent();
            CbRole.ItemsSource = Ent.Context.Role.ToList();
            CbRole.DisplayMemberPath = "Role1";
            CbRole.SelectedIndex = 1;

            CbGender.ItemsSource = Ent.Context.Gender.ToList();
            CbGender.DisplayMemberPath = "Gender1";
            title.Text = "Изменение пользователя";          
            txtLName.Text = user.LName;
            txtLog.Text = user.Login;
            txtPas.Text = user.Password;
            txtPhone.Text = user.Phone;
            CbGender.SelectedIndex = user.IdGender - 1;
            CbRole.SelectedIndex = user.IdRole - 1;
            editUser = user;
            isEdit = true;

        }


        public WindowAddUser()
        {
            InitializeComponent();
            CbRole.ItemsSource = Ent.Context.Role.ToList();
            CbRole.DisplayMemberPath = "Role1";
            CbRole.SelectedIndex = 1;
            CbGender.ItemsSource = Ent.Context.Gender.ToList();
            CbGender.DisplayMemberPath = "Gender1";
            isEdit = false;
        }




        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtLog.Text))
            {
                MessageBox.Show("Введите  Логин", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtLName.Text))
            {
                MessageBox.Show("Введите  Имя", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPas.Text))
            {
                MessageBox.Show("Введите пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (CbGender.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите гендер  ", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (isEdit == false)
            {
                var AddUser = Ent.Context.Users.ToList();
                var user = Ent.Context.Users.ToList().
                      Where(p => p.Login == txtLog.Text).FirstOrDefault();

                if (user != null)
                {
                    MessageBox.Show("Логин занят");
                    return;
                }
                else
                {
                    
                    var addUser = Ent.Context.Users.ToList().FirstOrDefault();
                    addUser.LName = txtLName.Text;
                    addUser.Login = txtLog.Text;
                    addUser.Password = txtPas.Text;
                    addUser.IdGender = CbGender.SelectedIndex + 1;
                    addUser.IdRole = CbRole.SelectedIndex + 1;
                    if(txtPhone != null)
                    {
                        addUser.Phone = txtPhone.Text;
                    }               
                   if(pathPhoto != null)
                    {
                        addUser.Photo = File.ReadAllBytes(pathPhoto);
                    }
                    Ent.Context.Users.Add(addUser);                                    
                    MessageBox.Show("Пользователь добавлен");
                    Ent.Context.SaveChanges();
                    PageUsers pageUsers = new PageUsers();
                    pageUsers.LvUsers.ItemsSource = Ent.Context.Users.ToList();
                }              
            }


            if (isEdit == true)
            {
                editUser.LName = txtLName.Text;
                editUser.IdGender = CbGender.SelectedIndex + 1;
                editUser.IdRole = CbRole.SelectedIndex + 1;
                editUser.Login = txtLog.Text;
                editUser.Password = txtPas.Text;
                editUser.Phone = txtPhone.Text;
                var resMess = MessageBox.Show("Подтвердите изменение", "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (resMess == MessageBoxResult.Yes)
                {
                    Ent.Context.SaveChanges();
                    MessageBox.Show("Пользователь изменен");
                    Close();
                }
            }


        }

        private void btnImg_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Файлы изображений (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png)";
            if (openFile.ShowDialog()==true)
            {
              
                pathPhoto = openFile.FileName;
                imgUser.Source = new BitmapImage(new Uri(openFile.FileName));
            }

        }
    }
}
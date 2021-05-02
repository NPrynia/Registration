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
using Registration.EF;
namespace Authorization.Windows
{
    /// <summary>
    /// Логика взаимодействия для RegistrWindow.xaml
    /// </summary>
    public partial class RegistrWindow : Window
    {
   

        public RegistrWindow()
        {

            InitializeComponent();

            CbGender.ItemsSource = Ent.Context.Gender.ToList();
            CbGender.DisplayMemberPath = "Gender1";

            Paths.PathUsers = @"Accounts\Users.txt";
            Paths.Pathsignup = @"Accounts\signup.txt";

            Captch.Text = Capthacs.Capcha();
        }
        private void btnCapth_Click(object sender, RoutedEventArgs e)
        {

            Captch.Text = Capthacs.Capcha();

        }

        private void btnSignin_Click(object sender, RoutedEventArgs e)
        {
            SignInWindow signInWindow = new SignInWindow();
            this.Close();
            signInWindow.ShowDialog();

        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            if (Captch.Text == txtCapth.Text)
            {
                if (txtLog.Text == "")
                {
                    MessageBox.Show("Введите логин");
                    return;
                }
                var user = Ent.Context.Users.ToList().
                    Where(p => p.Login == txtLog.Text).FirstOrDefault();

                if (user != null)
                {
                    {
                        MessageBox.Show("Введите имя");
                    }

                    if (txtNumber.Text == "")
                    {
                        MessageBox.Show("Введите номер ");
                    }
                    if (txtPass.Password == "")
                    {
                        MessageBox.Show("Введите пароль");
                    }
                    Ent.Context.Users.Add(new Users
                    {

                        LName = txtName.Text,
                        IdGender = CbGender.SelectedIndex + 1,
                        IdRole = 1,
                        Login = txtLog.Text,
                        Password = txtPass.Password,
                        Phone = txtNumber.Text,
                    }

                    );
                    MessageBox.Show("Регистрация прошла успешна");
                    Ent.Context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Неправильная капча");
                    Captch.Text = Capthacs.Capcha();
                }
            }


        }

        private void txtNumber_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int val;
            if (!int.TryParse(e.Text, out val))
            {
                e.Handled = true;
            }
        }

        private void txtCapth_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

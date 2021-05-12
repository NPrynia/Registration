using System;
using System.IO;
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
using Registration;
using Registration.EF;
using Registration.Windows;
using Authorization.Windows;

namespace Authorization
{
   
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class SignInWindow : Window
    {
        
        
        int a = 0;
       
        public SignInWindow()
        {
            InitializeComponent();
            Paths.Pathsignup = @"Accounts\signup.txt";


            using (StreamReader sr = new StreamReader(Paths.Pathsignup))
            {
                txtLog.Text = sr.ReadLine();
                txtPass.Password = sr.ReadLine();
            }


        }

        private void btnCapth_Click(object sender, RoutedEventArgs e)
        {

            Captch.Text = Capthacs.Capcha();
        
        }

        private void btnLog_Click(object sender, RoutedEventArgs e)
        {
           
            if (Captch.Text == txtCaptch.Text)
            {
                
                a++;
                
                
                var user = Ent.Context.Users.ToList().
                    Where(p => p.Login == txtLog.Text && p.Password == txtPass.Password).FirstOrDefault();
                if (user != null )
                {
                    User.LName = user.LName;
                    User.Login = user.Login;
                    User.Password = user.Password;
                    User.Phone = user.Phone;
                    User.IdRole = user.IdRole;
                    User.IdGEnder = user.IdGender;

                    if (boxSave.IsChecked == true)
                    {
                        using (StreamWriter sw = new StreamWriter(Paths.Pathsignup))
                        {
                            string log = txtLog.Text;
                            string pas = txtPass.Password;                                                                                                                                                                                                                                       
                            sw.WriteLine(txtLog.Text + "\n" + txtPass.Password);
                            sw.Close();
                        }

                    }
                    WindowMain mainWindowew = new WindowMain();
                    switch (user.IdRole)
                    {
                        case 1:
                            mainWindowew.btnUsers.Visibility = Visibility.Visible;
                          
                            
                            break;
                        case 2:
                            
                            break;
                        case 3:
                            mainWindowew.btnUsers.Visibility = Visibility.Visible;
                            break;

                    }
                   
                    MessageBox.Show("Добро пожаловать");
                    this.Close();
                    mainWindowew.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Неверные данные");                   
                    if (a > 2)
                    {
                        Captch.Text = Capthacs.Capcha();
                        Captch.Visibility = 0;
                        txtCaptch.Visibility = 0;
                        btnCapth.Visibility = 0;
                        imgcapth.Visibility = 0;
                        brdCapth.Visibility = 0;
                    }
                }
            }
            else
            {
                
                MessageBox.Show("Неправильная капча");
            }
           
           
        }

        

        private void txtLog_GotFocus(object sender, RoutedEventArgs e)
        {
            txtLog.Text = "";
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void Captch_GotFocus(object sender, RoutedEventArgs e)
        {
            txtCaptch.Text = "";
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            RegistrWindow registrWindow = new RegistrWindow();
            this.Close();
            registrWindow.Show();




        }
    }
}
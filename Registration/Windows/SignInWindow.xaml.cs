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

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            txtCapth.Text = "";
            if (txtCapth.Text == Captch.Text)
            {
                
                a++;

                
                var user = Ent.Context.Users.ToList().
                    Where(p => p.Login == txtLog.Text && p.Password == txtPass.Password).FirstOrDefault();
                if (user != null)
                {
                    

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
                            mainWindowew.btnUsers.Visibility = 0;
                            break;
                        case 2:
                            
                            break;

                    }ы
                   
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
                        txtCapth.Visibility = 0;
                        btnCapth.Visibility = 0;
                        brdCapth.Visibility = 0;
                    }
                }
            }
            else
            {
                
                MessageBox.Show("Неправильная капча");
            }
           
           
        }
        

    }
}

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
                }
                if (txtName.Text == "")
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
                using (StreamWriter sw = new StreamWriter(@"C:\Users\mrbox\OneDrive\Рабочий стол\signin.txt", true))
                {
                    sw.Write(txtLog.Text + ";" + txtName.Text + ";" + txtNumber.Text + ";" + txtPass.Password + "\n");
                    sw.Close();
                }    
           }
            else
            {
                MessageBox.Show("Неправильная капча");
                Captch.Text = Capthacs.Capcha();
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

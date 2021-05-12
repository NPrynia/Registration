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

namespace Registration.PageMain
{
    /// <summary>
    /// Логика взаимодействия для PageProfile.xaml
    /// </summary>
    public partial class PageProfile : Page
    {
        public PageProfile()
        {
            InitializeComponent();

            txtName.Text = User.LName;
            txtlog.Text = User.Login;
            txtPhone.Text = User.Phone;
            txtpas.Text = User.Password;
            if (User.IdGEnder == 1)
            {
                imgprof.Source = new BitmapImage(new Uri("pack://application:,,,/Windows/img/man.png"));
            }
            if (User.IdGEnder == 2)
            {
                imgprof.Height = 132;
                imgprof.Source = new BitmapImage(new Uri("pack://application:,,,/Windows/img/woman.png"));
            }
        }

       
    }
   
}

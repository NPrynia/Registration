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
using Authorization;


namespace Authorization
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int id;
         string name;
        string pass;
        string phone;
        string login;
        public MainWindow(Person person)
        {
            InitializeComponent();
            txtLog.Text = person.Name;
            txtPas.Text = person.Password;
            txtPhone.Text = person.Phone;
         name = person.Name;
         pass = person.Password;
         phone = person.Phone;
            id = person.Id;
            login = person.Login;



    }

        private void gridTable_Loaded(object sender, RoutedEventArgs e)
        {

            List<MyTable> result = new List<MyTable>(3);
            result.Add(new MyTable(id, name, login, pass, phone));

            gridTable.ItemsSource = result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authorization
{
   public class MyTable
    {
        public MyTable(int Id, string Name, string Login, string Password, string Phone)
        {
            this.Id = Id;
            this.Name = Name;
            this.Login = Login;
            this.Password = Password;
            this.Phone = Phone;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
    }
}

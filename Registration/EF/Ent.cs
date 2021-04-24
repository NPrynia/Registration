using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.EF
{
    public class Ent
    {
        public static RegistrationEntities1 Context { get; } = new RegistrationEntities1();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Registration.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }
        public string MName { get; set; }
        public int IdGender { get; set; }
        public int IdRole { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
    
        public virtual Gender Gender { get; set; }
        public virtual Role Role { get; set; }
    }
}

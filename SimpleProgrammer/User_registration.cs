//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimpleProgrammer
{
    using System;
    using System.Collections.Generic;
    
    public partial class User_registration
    {
        public int ID { get; set; }
        public string FIO { get; set; }
        public string Phone { get; set; }
        public string Hobby { get; set; }
    
        public virtual Users Users { get; set; }
    }
}

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
    
    public partial class Test_results
    {
        public Nullable<int> User { get; set; }
        public Nullable<int> Admin { get; set; }
        public Nullable<int> Test { get; set; }
        public Nullable<int> Result { get; set; }
        public int ID { get; set; }
    
        public virtual Administration Administration { get; set; }
        public virtual Tests Tests { get; set; }
        public virtual Users Users { get; set; }
    }
}
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
    
    public partial class Tests
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tests()
        {
            this.Test_results = new HashSet<Test_results>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Theme { get; set; }
    
        public virtual Themes Themes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Test_results> Test_results { get; set; }
    }
}
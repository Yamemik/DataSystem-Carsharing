//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoDealer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Passport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Passport()
        {
            this.Client = new HashSet<Client>();
        }
    
        public int p_id { get; set; }
        public string ps_series { get; set; }
        public string ps_number { get; set; }
        public string ps_whom { get; set; }
        public System.DateTime ps_when { get; set; }
        public string ps_address { get; set; }
        public string ps_all
        {
            get
            {
                return ps_series + " №" + ps_number;
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Client> Client { get; set; }
    }
}

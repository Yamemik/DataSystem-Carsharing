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
    
    public partial class DriverLicense
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DriverLicense()
        {
            this.Client = new HashSet<Client>();
        }
    
        public int dl_id { get; set; }
        public string dl_series { get; set; }
        public string dl_number { get; set; }
        public System.DateTime dl_date { get; set; }
        public string dl_all
        {
            get
            {
                return dl_series + " №" + dl_number + ", " + dl_date.ToString().Substring(0, 10);
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Client> Client { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CommunicationCompany.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tarif
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tarif()
        {
            this.Client_Tarif = new HashSet<Client_Tarif>();
        }
    
        public int Tarif_id { get; set; }
        public string Tarif_Name { get; set; }
        public int Tarif_Cost { get; set; }
        public string Tarif_Validity { get; set; }
        public int Marketer_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Client_Tarif> Client_Tarif { get; set; }
        public virtual Marketer Marketer { get; set; }
    }
}

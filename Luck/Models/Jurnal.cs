//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Luck.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Jurnal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Jurnal()
        {
            this.Pander = new HashSet<Pander>();
        }
    
        public int Id_jurnal { get; set; }
        public string Baga { get; set; }
        public string Data { get; set; }
        public string Sabakka_katysuy { get; set; }
        public string Jurnal_kosymsha { get; set; }
        public int Id_sabak { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pander> Pander { get; set; }
        public virtual Sabak_kestesi Sabak_kestesi { get; set; }
    }
}

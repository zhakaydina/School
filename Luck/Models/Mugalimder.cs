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
    
    public partial class Mugalimder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mugalimder()
        {
            this.Sabak_kestesi = new HashSet<Sabak_kestesi>();
        }
    
        public int Id_mugalim { get; set; }
        public string Aty { get; set; }
        public string Tegi { get; set; }
        public string Akesinin_aty { get; set; }
        public string Tel_nomeri { get; set; }
        public string Tugan_kuni { get; set; }
        public string Email { get; set; }
        public string Meken_zhaiy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sabak_kestesi> Sabak_kestesi { get; set; }
    }
}

namespace WcfDb
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [DataContract]
    [Table("Clovek")]
    public partial class Clovek
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Clovek()
        {
            Auto = new HashSet<Auto>();
        }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [Required]
        [StringLength(50)]
        public string Jmeno { get; set; }


        [IgnoreDataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Auto> Auto { get; set; }
    }
}

namespace WcfDb
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [DataContract]
    [Table("Auto")]
    public partial class Auto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int Id_Clovek { get; set; }

        [DataMember]
        [Required]
        [StringLength(50)]
        public string Nazev { get; set; }

        public virtual Clovek Clovek { get; set; }
    }
}

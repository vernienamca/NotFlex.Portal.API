using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace NotFlex.ApplicationCore.Entities.Structure
{
    public class Category : BaseEntity<byte>
    {
        [DataMember]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int CreatedBy { get; set; }

        [DataMember]
        public DateTime DateCreated { get; set; }

        [DataMember]
        public int? UpdatedBy { get; set; }

        [DataMember]
        public DateTime? DateUpdated { get; set; }
    }
}

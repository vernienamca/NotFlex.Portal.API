using System;
using System.Runtime.Serialization;

namespace NotFlex.ApplicationCore.Entities.Structure
{
    public class Movie : BaseEntity<byte>
    {
        [DataMember]
        public byte Id { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string GroupName { get; set; }

        [DataMember]
        public DateTime ReleasedDate { get; set; }

        [DataMember]
        public string Director { get; set; }

        [DataMember]
        public string DistributedBy { get; set; }

        [DataMember]
        public string Length { get; set; }

        [DataMember]
        public string PosterImage { get; set; }

        [DataMember]
        public bool IsFeature { get; set; }

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

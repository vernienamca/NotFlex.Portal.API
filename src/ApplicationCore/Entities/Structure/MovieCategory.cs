using System.Runtime.Serialization;

namespace NotFlex.ApplicationCore.Entities.Structure
{
    public class MovieCategory : BaseEntity<byte>
    {

        [DataMember]
        public byte MovieId { get; set; }

        [DataMember]
        public byte CategoryId { get; set; }
    }
}

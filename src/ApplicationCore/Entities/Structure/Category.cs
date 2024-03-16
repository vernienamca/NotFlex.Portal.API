using System.Runtime.Serialization;

namespace NotFlex.ApplicationCore.Entities.Structure
{
    public class Category : BaseEntity<int>
    {
        [DataMember]
        public byte Id { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}

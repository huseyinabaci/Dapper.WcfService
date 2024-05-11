using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Core.Entities
{
    [Serializable]
    [DataContract]
    public class Product
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Barcode { get; set; }
        [DataMember]
        public decimal Rate { get; set; }
        [DataMember]
        public DateTime AddedOn { get; set; }
        [DataMember]
        public DateTime ModifiedOn { get; set; }

    }
}

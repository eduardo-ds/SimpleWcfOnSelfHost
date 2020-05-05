using System;
using System.Runtime.Serialization;

namespace EduardoSelfHost.Contracts
{
    [DataContract]
    public class PesquisaDolar
    {
        [DataMember]
        public DateTime Data { get; set; }

        [DataMember]
        public string Valor { get; set; }
    }
}

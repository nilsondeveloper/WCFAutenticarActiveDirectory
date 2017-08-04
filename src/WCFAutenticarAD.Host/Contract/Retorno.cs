using System.Runtime.Serialization;

namespace WCFAutenticarAD.Host.Contract
{ 
    [DataContract]
    public class Retorno
    {
        [DataMember]
        public bool Autenticado{ get; set; }
        [DataMember]
        public string MensagemErro { get; set; } 
    }
}
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfDb
{
    [ServiceContract]
    public interface IServiceClovek
    {
        [OperationContract]
        ClovekResult GetClovek();
        [OperationContract]
        void InsertClovek(Clovek clovek);
        [OperationContract]
        void UpdateClovek(Clovek clovek);
        [OperationContract]
        void DeleteClovek(int Id);
    }

    [DataContract]
    public class ClovekResult
    {
        [DataMember]
        public List<ClovekContract> Values { get; set; }
    }

    [DataContract]
    public class ClovekContract
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Jmeno { get; set; }
    }
}

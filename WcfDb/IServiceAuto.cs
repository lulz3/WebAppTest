using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfDb
{
    [ServiceContract]
    public interface IServiceAuto
    {
        [OperationContract]
        AutoResult GetAuto();
        [OperationContract]
        void InsertAuto(Auto auto);
        [OperationContract]
        void UpdateAuto(Auto auto);
        [OperationContract]
        void DeleteAuto(int Id);
    }

    [DataContract]
    public class AutoResult
    {
        [DataMember]
        public List<AutoContract> Values { get; set; }
    }

    [DataContract]
    public class AutoContract
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int Id_Clovek { get; set; }

        [DataMember]
        public string Nazev { get; set; }
    }
}

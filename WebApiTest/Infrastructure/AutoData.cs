using System.Linq;
using WebApiTest.ServiceAuto;

namespace WebApiTest.Infrastructure
{
    public interface IAutoData
    {
        AutoResult GetAuto();
        void InsertAuto(Auto auto);
        void UpdateAuto(Auto auto);
        void DeleteAuto(int Id);
    }

    public class AutoData : IAutoData
    {
        private static readonly ServiceAuto.ServiceAutoClient c = new ServiceAuto.ServiceAutoClient();

        public void DeleteAuto(int Id)
        {
            c.DeleteAuto(Id);
        }

        public AutoResult GetAuto()
        {
            return c.GetAuto();
        }

        public void InsertAuto(Auto auto)
        {
            c.InsertAuto(auto);
        }

        public void UpdateAuto(Auto auto)
        {
            c.UpdateAuto(auto);
        }
    }
}
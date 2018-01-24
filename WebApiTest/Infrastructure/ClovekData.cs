using WebApiTest.ServiceClovek;

namespace WebApiTest.Infrastructure
{

    public interface IClovekData
    {
        ClovekResult GetClovek();
        void InsertClovek(Clovek clovek);
        void UpdateClovek(Clovek clovek);
        void DeleteClovek(int Id);
    }

    public class ClovekData : IClovekData
    {
        private static readonly ServiceClovek.ServiceClovekClient c = new ServiceClovek.ServiceClovekClient();

        public ClovekResult GetClovek()
        {
            return c.GetClovek();
        }

        public void DeleteClovek(int Id)
        {
            c.DeleteClovek(Id);
        }

        public void InsertClovek(Clovek clovek)
        {
            c.InsertClovek(clovek);
        }

        public void UpdateClovek(Clovek clovek)
        {
            c.UpdateClovek(clovek);
        }
    }
}
using System.Collections.Generic;
using System.Linq;

namespace WcfDb
{
    public class ServiceClovek : IServiceClovek
    {
        private EntityModel e = new EntityModel();

        public void DeleteClovek(int Id)
        {
            var c = (from per in e.Clovek
                     where per.Id == Id
                     select per).First();
            e.Clovek.Remove(c);
            e.SaveChanges();
        }

        public ClovekResult GetClovek()
        {
            return new ClovekResult
            {
                Values = e.Clovek.Select(
                    c => new ClovekContract
                {
                    Id = c.Id,
                    Jmeno = c.Jmeno
                })
                .ToList()
            };
        }

        public void InsertClovek(Clovek clovek)
        {
            e.Clovek.Add(clovek);
            e.SaveChanges();
        }

        public void UpdateClovek(Clovek clovek)
        {
            var c = (from per in e.Clovek
                     where per.Id == clovek.Id
                     select per).First();

            c.Jmeno = clovek.Jmeno;
            e.SaveChanges();
        }
    }
}

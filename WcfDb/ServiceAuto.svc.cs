using System.Collections.Generic;
using System.Linq;

namespace WcfDb
{
    public class ServiceAuto : IServiceAuto
    {
        private EntityModel e = new EntityModel();

        public void DeleteAuto(int Id)
        {
            var c = (from per in e.Auto
                     where per.Id == Id
                     select per).First();
            e.Auto.Remove(c);
            e.SaveChanges();
        }

        public AutoResult GetAuto()
        {
            return new AutoResult
            {
                Values = e.Auto.Select(
                    c => new AutoContract
                    {
                        Id = c.Id,
                        Id_Clovek = c.Id_Clovek,
                        Nazev = c.Nazev
                    })
                .ToList()
            };
        }

        public void InsertAuto(Auto auto)
        {
            e.Auto.Add(auto);
            e.SaveChanges();
        }

        public void UpdateAuto(Auto auto)
        {
            var c = (from per in e.Auto
                     where per.Id == auto.Id
                     select per).First();

            c.Nazev = auto.Nazev;
            //c.Id_Clovek = auto.Id_Clovek;

            e.SaveChanges();
        }
    }
}

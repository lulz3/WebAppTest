using System;
using System.Web.Http;
using WebApiTest.Infrastructure;
using WebApiTest.ServiceClovek;

namespace WebApiTest.Controllers
{
    public class ClovekController : ApiController
    {
        private readonly IClovekData _clovekData;

        public ClovekController(IClovekData clovekData)
        {
            _clovekData = clovekData;
        }

        [HttpPost]
        public string AddClovek(Clovek clovek)
        {
            try
            {
                _clovekData.InsertClovek(clovek);
                return string.Format("Clovek has been added");
            }
            catch (Exception)
            {
                return string.Format("Error Addeding new Person");
            } 
        }
        [HttpGet]
        public ClovekResult GetClovek()
        {
           return _clovekData.GetClovek();
        }
        [HttpDelete]
        public string DeleteClovek(string id)
        {
            try
            {
                _clovekData.DeleteClovek(Int32.Parse(id));
                return string.Format("Clovek has been deleted with id {0}", id);
            }
            catch (Exception)
            {
                return string.Format("Error Deleting Person");
            }
        }
        [HttpPut]
        public string UpdateClovek(Clovek clovek)
        {
            try
            {
                _clovekData.UpdateClovek(clovek);
                return string.Format("Clovek has been updated");
            }
            catch (Exception)
            {
                return string.Format("Error Updating Person");
            }
        }

    }
}

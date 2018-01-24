using System;
using System.Web.Http;
using WebApiTest.Infrastructure;
using WebApiTest.ServiceAuto;

namespace WebApiTest.Controllers
{
    public class AutoController : ApiController
    {
        
        private readonly IAutoData _autoData;

        public AutoController(IAutoData autoData)
        {
            _autoData = autoData;
        }

        [HttpPost]
        public string AddAuto(Auto auto)
        {
            try
            {
                _autoData.InsertAuto(auto);
                return string.Format("Auto has been added");
            }
            catch (Exception)
            {
                return string.Format("Error Addeding new Car");
            }
        }
        [HttpGet]
        public AutoResult GetAuto()
        {
            return _autoData.GetAuto();
        }
        [HttpDelete]
        public string DeleteAuto(string id)
        {
            try
            {
                _autoData.DeleteAuto(Int32.Parse(id));
                return string.Format("Auto has been deleted with id {0}", id);
            }
            catch (Exception)
            {
                return string.Format("Error Deleting new Car");
            }
        }
        [HttpPut]
        public string UpdateClovek(Auto auto)
        {
            try
            {
                _autoData.UpdateAuto(auto);
                return string.Format("Auto has been updated");
            }
            catch (Exception)
            {
                return string.Format("Error Updating new Car");
            }
        }
        
    }
}

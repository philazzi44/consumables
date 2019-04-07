using System.Collections.Generic;
using System.Web.Http;

namespace Consumables.Api.Controllers
{
    public class AccountsController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return null;
        }

        public string Get(int id)
        {
            return null;
        }

        public void Post([FromBody]string value)
        {
        }

        public void Put(int id, [FromBody]string value)
        {
        }

        public void Delete(int id)
        {
        }
    }
}

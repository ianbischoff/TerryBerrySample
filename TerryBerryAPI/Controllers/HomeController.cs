using System.Threading.Tasks;
using System.Web.Http;
using Autofac.Integration.WebApi;
using TerryBerryAPI.Interfaces;

namespace TerryBerryAPI.Controllers
{
    [AutofacControllerConfiguration]
    public class HomeController : ApiController
    {

        private IService helloWorldService;

        public HomeController(IService hws)
        {
            helloWorldService = hws;
        }

        [AllowAnonymous]
        [Route("api/helloworld")]
        [HttpGet]
        public async Task<IHttpActionResult> HelloWorld()
        {
            var requestedText = await helloWorldService.HelloWorld();
            var result = Json(requestedText);

            return result;
        }
    }
}

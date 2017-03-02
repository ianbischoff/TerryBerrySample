using System.Threading.Tasks;
using TerryBerryAPI.Interfaces;

namespace TerryBerryAPI.Services
{
    public class HelloWorldService : IService
    {
        public async Task<string> HelloWorld()
        {
            var result = await Task.Run(() => { return "Hello World"; });
            return result;
        }
    }
}
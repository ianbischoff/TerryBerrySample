using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerryBerryAPI.Interfaces
{
    public interface IService
    {
        Task<string> HelloWorld();
    }
}

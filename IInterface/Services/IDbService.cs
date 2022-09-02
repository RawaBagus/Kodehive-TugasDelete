using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kodehive.Service.Interface.Services
{
    public interface IDbService
    {
        Task<int> ModifyData(string command, object param);
        Task<List<T>> Get<T>(string command,object param);
        
    }
}

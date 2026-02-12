using EnterpriseMvcApp.Models;
using System.Collections.Generic;

namespace EnterpriseMvcApp.Repositories
{
    public interface IServerRepository
    {
        IEnumerable<ServerMaster> GetActiveServers();
    }
}

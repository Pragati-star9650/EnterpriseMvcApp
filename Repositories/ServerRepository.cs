using EnterpriseMvcApp.Data;
using EnterpriseMvcApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace EnterpriseMvcApp.Repositories
{
    public class ServerRepository : IServerRepository
    {
        private readonly ApplicationDbContext _context;

        public ServerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ServerMaster> GetActiveServers()
        {
            return _context.ServerMasters
                           .Where(s => s.IsActive)
                           .OrderBy(s => s.ServerName)
                           .ToList();
        }
    }
}

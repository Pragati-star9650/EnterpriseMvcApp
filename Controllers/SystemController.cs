using EnterpriseMvcApp.Repositories;
using EnterpriseMvcApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

[ApiController]
[Route("api/system")]
public class SystemController : ControllerBase
{
    private readonly IServerRepository _serverRepository;
    private readonly DatabaseService _databaseService;

    public SystemController(
        IServerRepository serverRepository,
        DatabaseService databaseService)
    {
        _serverRepository = serverRepository;
        _databaseService = databaseService;
    }

    [HttpGet("servers")]
    public IActionResult GetServers()
    {
        var servers = _serverRepository
            .GetActiveServers()
            .Select(s => s.ServerName)
            .ToList();

        return Ok(servers);
    }
    [HttpGet("databases")]
    public IActionResult GetDatabases([FromQuery] string serverName)
    {
        if (string.IsNullOrWhiteSpace(serverName))
            return BadRequest("Server name is required");

        var databases = _databaseService.GetDatabases(serverName);
        return Ok(databases);
    }
}

/*using Microsoft.AspNetCore.Mvc;

namespace EnterpriseMvcApp.Controllers
{
    [ApiController]
    [Route("api/system")]
    public class SystemController : Controller
    {
        [HttpGet("servers")]
        public IActionResult GetServers()
        {
            
            var servers = new[]
            {
                "AYUSHMAN",
                "SQLSERVER01",
                "SQLSERVER02"
            };

            return Ok(servers);
        }

        [HttpGet("databases")]
        public IActionResult GetDatabases(string serverName)
        {
            
            var databases = serverName switch
            {
                "AYUSHMAN" => new[] { "EnterpriseMvcDB", "CRM", "Demo" },
                "SQLSERVER01" => new[] { "SalesDB", "HRDB" },
                "SQLSERVER02" => new[] { "InventoryDB", "FinanceDB" },
                _ => new string[] { }
            };

            return Ok(databases);
        }
    }
}
*/

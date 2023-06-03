using Microsoft.AspNetCore.Mvc;
using Gex.Auth.Handlers;

namespace Auth.Controllers;

[ApiController]
[Route("/api/auth/")]
public class AuthenticationController : ControllerBase
{
    [HttpPost]
    [Route("initsession")]
    public async Task<Guid> InitSession()
    {
        
    }
}

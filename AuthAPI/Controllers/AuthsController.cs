using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

[ApiController]
[Route("api/[controller]")]
public class AuthsController : ControllerBase
{
   IConfiguration _configuration;
   public AuthsController(IConfiguration configuration)
   {
      _configuration = configuration;
   }
   public IActionResult Login(string userName, string password)
   {
      TokenHandler._configuration = _configuration;
      return Ok(userName == "gncy" && password == "12345" ? TokenHandler.CreateAccessToken() : new UnauthorizedResult());
   }
}
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class ProductsController : ControllerBase
{
   public IActionResult Get()
   {
      return Ok(new List<string> {
        "Telefon", "Terlik", "Kalem", "Kağıt", "Ampul", "Kağıt"
      });
   }
}
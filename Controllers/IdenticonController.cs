using Jdenticon;
using Microsoft.AspNetCore.Mvc;

namespace topswagcode.Controllers;

[Route("api/[controller]")]
[ApiController]
public class IdenticonController : Controller
{
    [HttpGet]
    public async Task<IActionResult> Get(string name = "TopSwagCode", int size = 30)
    {
        using (MemoryStream ms = new MemoryStream())
        {
            var icon = Jdenticon.Identicon.FromValue(name, size);

            await icon.SaveAsPngAsync(ms);

            ms.Position = 0;
            return File(ms.ToArray(), "image/png");
        }
    }
}
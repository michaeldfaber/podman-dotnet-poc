using System;
using Microsoft.AspNetCore.Mvc;

namespace podman_dotnet_poc.Controllers;

[ApiController]
[Route("[controller]")]
public class TimeController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return DateTime.Now.ToString();
    }
}

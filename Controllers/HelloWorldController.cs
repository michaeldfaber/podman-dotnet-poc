using System;
using Microsoft.AspNetCore.Mvc;

namespace podman_dotnet_poc.Controllers;

[ApiController]
[Route("/")]
public class HelloWorldController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "Hello World!";
    }
}

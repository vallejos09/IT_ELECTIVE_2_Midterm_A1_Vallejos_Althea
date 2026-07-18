using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult AboutMe()
    {

        ViewData["Greeting"] = "I am Althea, currently pursuing a Bachelor of Science in Information Technology. My studies have introduced me to programming, databases, and system design, but what excites me most is exploring how technology can be applied in practical, everyday solutions. I enjoy learning about user interface design, creating flowcharts, and experimenting with different tools to improve workflows.";
        ViewData["Goal"] = "My career goal is not to become a software developer, but rather to build a path where I can apply my IT knowledge in areas such as system analysis, project management, or technology support.I am passionate about helping people understand and use technology more effectively, and I see myself contributing to projects that improve efficiency and accessibility.Outside of academics, I enjoy creative problem?solving, collaborating with peers, and continuously expanding my skills to prepare for future opportunities in the IT field.";

        return View();
    }
}
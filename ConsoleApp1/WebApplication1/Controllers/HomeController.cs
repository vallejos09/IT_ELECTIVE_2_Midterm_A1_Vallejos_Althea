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

    public IActionResult Skills()
    {
         ViewData["Programming Languages"] = "C#, Java, Python, VB.NET";
         ViewData["Web"] = "HTML, CSS, ASP.NET Core";
         ViewData["Databases"] = "SQL Server, MySQL";
         ViewData["Tools"] = "Visual Studio, Git";

        return View();
    }

public IActionResult Projects()
    {
        ViewData["Project1"] = "The ABC Lending Corporation Loan Calculator Program is a user-friendly application designed to simplify the borrowing process by allowing users to seamlessly apply for loans and instantly view detailed financial computations.";
        ViewData["Tech1"] = "VB.NET Windows Forms Application (GUI)";

        ViewData["Project2"] = "MQ-Check is an intuitive, low-fidelity UI blueprint designed for a modern health clinic's digital check-up system. The platform streamlines the patient intake process by initiating the check-up workflow and providing critical medical emergency disclosures to ensure immediate care for urgent symptoms.";
        ViewData["Tech2"] = "VB.NET Windows Forms Application (GUI)";

        ViewData["Project3"] = "The platform features an organized layout highlighting my credentials, creative galleries, activities, and direct links to social and search platforms.";
        ViewData["Tech3"] = "HTML, CSS";

        return View();
    }

    public IActionResult Contacts()
    {
        ViewData["Email"] = "Email: iamaltheavallejos@email.com";
        ViewData["Mobile"] = "Mobile: 0993-874-7925";
        ViewData["GitHub"] = "GitHub: https://github.com/vallejos09";
        ViewData["LinkedIn"] = "LinkedIn: https://www.linkedin.com/in/althea-vallejos-5267821b7/";

        return View();
    }
}


using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace student_information.app.Controllers;

[Authorize]
public class StudentsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}
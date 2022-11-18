using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using student_information.app.Models.StudentModels;

namespace student_information.app.Controllers;

 public class StudentsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(StudentCreateViewModel model)
    {
        if (ModelState.IsValid)
        {
            return RedirectToAction(nameof(Index));
        }
        return View(model);
    }
}
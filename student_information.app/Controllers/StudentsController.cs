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

    #region Create Action(s)
    /// <summary>
    /// This is a GET http request.
    /// Loads the form without any call to the api/backend services.
    /// </summary>
    /// <returns></returns>
    public IActionResult Create()
    {
        return View();
    }

    /// <summary>
    /// This is a POST http request.
    /// The parameters passed will be sent to the api service
    /// and persist to the database.
    /// Suggestions: No validations yet and no concurrency handling.
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    [HttpPost]
    public IActionResult Create(StudentCreateViewModel model)
    {
        if (ModelState.IsValid)
        {
            return RedirectToAction(nameof(Index));
        }
        return View(model);
    }
    #endregion

    public IActionResult Edit(int id)
    {
        //call a method that will fetch by id
        return View();
    }
}
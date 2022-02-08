using Microsoft.AspNetCore.Mvc;

namespace Demo23_ASP_WebApp.wwwroot.Controller
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return ok(" This is student page")
        }
    }
}

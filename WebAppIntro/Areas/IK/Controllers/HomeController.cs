using Microsoft.AspNetCore.Mvc;

namespace WebAppIntro.Areas.IK.Controllers
{
  [Area("ik")]
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }

    public IActionResult Users()
    {
      return View();
    }
  }
}

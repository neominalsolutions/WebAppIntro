using Microsoft.AspNetCore.Mvc;
using WebAppIntro.Models;

namespace WebAppIntro.Controllers
{
  public class UserController : Controller
  {

    [HttpGet]
    public IActionResult Index()
    {
      var data = new List<User>();
      data.Add(new User { Name = "Ali", SurName = "Tan" });
      data.Add(new User { Name = "Ayşe", SurName = "Can" });

      return View(data);
    }

    // Bu web sayfasının açılması o ekranın tarayıcıda görütüntülenmesi için gerekli olan bir http isteği
    // mvc bir actionresult üstüne açılmayan bir httpverb attribute de http get olarak davranır.
    [HttpGet] // attribute
    public IActionResult Create(int? id, string? name)
    {
      return View();
    }

    // Sayfa açmak ama<çlı değil yani sayfa listeleme amaçlı olmayıp sayfadaki formu web sunucunda göndermek için gerekli olan bir fiil (httpverb)
    [HttpPost]
    public IActionResult Create(User model)
    {

      if (ModelState.IsValid)
      {
        // veri tabanı işlemi yap
      }


      return View();
    }

  }
}

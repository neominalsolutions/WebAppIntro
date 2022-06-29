using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using WebAppIntro.Models;
using WebAppIntro.Models.Settings;
using WebAppIntro.Services;

namespace WebAppIntro.Controllers
{
  public class HomeController : BaseController
  {
    private IConfiguration _configuration;
    private IOptions<EmailSettings> _options;
    // DI ile IOptions<T> tipinde generic olarak options erişiyoruz.


    public HomeController(ILogger<BaseController> logger, IConfiguration configuration, IOptions<EmailSettings> options) : base(logger)
    {
      _configuration = configuration;
      _options = options;
    }

    public override void Validate()
    {
      base.Validate();
    }

    public IActionResult Index()
    {
      string from = _options.Value.From;

      var eService = new EmailService(_configuration);
      eService.Send(_configuration.GetValue<string>("EmailSettings:From"), "test@test.com", "merhaba", "Merhaba");

      ViewBag.Description = "HomePag45";
      //ViewBag.Deneme = "Deneme";
      ViewData["Message"] = "Başarılı";


      return View();
    }

    // url rewrite urun/beyaz-kazak urun/kazak/100050

    public RedirectToActionResult Redirect()
    {
      // kendi view veri taşımak için ise viewbag kullanırız.
      ViewBag.Data1 = "Merhaba1";
      // redirection işlemlerinde kullanılır. 1 web request daha fazla ayakta kalır.
      TempData["Data1"] = "Data1";

    
      return RedirectToAction("Privacy");
    }

    public IActionResult Privacy()
    {
      ViewBag.Data2 = "Merhaba2";


      return View();
    }

    public IActionResult Test()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAppIntro.Controllers
{
  //[Authorize]
  public class BaseController : Controller
  {
    protected readonly ILogger<BaseController> _logger;

    public BaseController(ILogger<BaseController> logger)
    {
      _logger = logger;
    }

    public virtual void Validate()
    {

    }
  }
}

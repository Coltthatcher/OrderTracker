using Microsoft.AspNetCore.Mvc;

namespace OrderTraker.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FB_Login_Net.Core.Pages
{
    // HomeController.cs
    [Authorize]
    public class HomeController : Controller
    {
    
  
    [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
  
    
    }
}

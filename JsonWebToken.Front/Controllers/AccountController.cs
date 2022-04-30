using JsonWebToken.Front.Models;
using Microsoft.AspNetCore.Mvc;

namespace JsonWebToken.Front.Controllers
{
    public class AccountController : Controller
    {
        readonly IHttpClientFactory _httpClientFactory;

        public AccountController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(UserLoginModel model)
        {
            return View();
        }
    }
}

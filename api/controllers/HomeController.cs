

using Microsoft.AspNetCore.Mvc;

namespace capp.movieTalk.api.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "welcome to home index!";
        }
    }
}

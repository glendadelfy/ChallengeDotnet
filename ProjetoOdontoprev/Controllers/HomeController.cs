using Microsoft.AspNetCore.Mvc;
using ProjetoOdontoprev.DTOs;
using ProjetoOdontoprev.Models;
using ProjetoOdontoprev.Repositorys.Implementations;
using ProjetoOdontoprev.Repositorys.Interfaces;
using System.Diagnostics;

namespace ProjetoOdontoprev.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserAuthenticator userAuthenticator;

        public const string SessionName = "_Nome";
        public const string SessionKey = "_isAuthentication";

        public HomeController(ILogger<HomeController> logger, IUserAuthenticator reposiroty)
        {
            userAuthenticator = reposiroty;    
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.SessionName = HttpContext.Session.GetString(SessionName);
            ViewBag.SessionKey = HttpContext.Session.GetInt32(SessionKey);
            return View();
        }
        public async Task<IActionResult> Login(UserLoginDto request)
        {
            try
            {
                var auth = await userAuthenticator.GetUserByEmail(request);
                if (auth == null)
                {
                    return RedirectToAction("Error");
                }

                HttpContext.Session.SetString(SessionName, auth.Email);
                HttpContext.Session.SetInt32(SessionKey, 1);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Error");
            }
        }

        public IActionResult RegisterPage() { return View(); }

        public async Task<IActionResult> Register(UserRegisterDto request)
        {
            try
            {
                var response = await userAuthenticator.CreateDentista(request);
                if (response == null)
                {
                    return RedirectToAction("Error");
                }
                HttpContext.Session.SetString(SessionName, response.Email);
                HttpContext.Session.SetInt32(SessionKey, 1);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Error");
            }
        }

        public IActionResult Privacy()
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

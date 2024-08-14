using AzureADIntegration.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AzureADIntegration.Controllers
{
    [Authorize]
    public class SecurityController : Controller
    {
        public static IConfiguration Configuration { get; set; }
        
        public SecurityController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public ActionResult Index()
        {

            
            return View("~/Views/Security/Protected.cshtml");
        }
    }
}

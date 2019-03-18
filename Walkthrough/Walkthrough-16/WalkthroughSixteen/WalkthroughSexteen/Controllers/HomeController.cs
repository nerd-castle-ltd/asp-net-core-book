using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WalkthroughSixteen.Models;

namespace WalkthroughSixteen.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMyDependency _myDependency;

        public HomeController(IMyDependency myDependency)
        {
            _myDependency = myDependency;
        }
       
        public async Task<IActionResult> Index()
        {
            await _myDependency.WriteMessage("IndexModel.OnGetAsync created this message.");

            return View();
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

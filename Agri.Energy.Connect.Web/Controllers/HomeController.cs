using Agri.Energy.Connect.Web.Repositories;
using Agri.Energy.Connect.Web.Models;
using Agri.Energy.Connect.Web.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Agri.Energy.Connect.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductRepository blogPostRepository;
        // private readonly ITagRepository tagRepository;

        public HomeController(ILogger<HomeController> logger,
            IProductRepository blogPostRepository
            // ITagRepository tagRepository
            )
        {
            _logger = logger;
            this.blogPostRepository = blogPostRepository;
            // this.tagRepository = tagRepository;
        }

        public async Task<IActionResult> Index()
        {
            // getting all blogs
            var blogPosts = await blogPostRepository.GetAllAsync();

            // get all tags
            //var tags = await tagRepository.GetAllAsync();

            var model = new HomeViewModel
            {
                Products = blogPosts,
                //Tags = tags
            };

            return View(model);
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
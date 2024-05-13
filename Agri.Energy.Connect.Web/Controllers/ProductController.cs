using Agri.Energy.Connect.Web.Models.ViewModels;
using Agri.Energy.Connect.Web.Repositories;
using Agri.Energy.Connect.Web.Models.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Agri.Energy.Connect.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly UserManager<IdentityUser> userManager;

        public ProductController(IProductRepository productRepository,
            SignInManager<IdentityUser> signInManager,
            UserManager<IdentityUser> userManager
            )
        {
            this.productRepository = productRepository;
            this.signInManager = signInManager;
            this.userManager = userManager;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            // getting all blogs
            var products = await productRepository.GetAllAsync();

            // get all tags

            var model = new HomeViewModel
            {
                Products = products,
            };

            return View("~/Views/Product/List.cshtml", model);
        }


        [HttpPost]
        public async Task<IActionResult> Index(ProductDetailsViewModel productDetails)
        {
            if (signInManager.IsSignedIn(User))
            {
                var domainModel = new Product
                {
                    Id = productDetails.Id,
                    Category = productDetails.Name,
                    ProductionDate = DateTime.Now
                };

              
                    
            }

            return View(productDetails);
        }
    }
}

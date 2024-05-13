using Agri.Energy.Connect.Web.Models.Domain;
using Agri.Energy.Connect.Web.Models.ViewModels;
 using Agri.Energy.Connect.Web.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace Agri.Energy.Connect.Web.Controllers
 {
     [Authorize(Roles = "Employee")]
    public class AdminProductPostsController : Controller
     {
         private readonly IProductRepository productRepository;

         public AdminProductPostsController( IProductRepository productRepository)
         {
             
             this.productRepository = productRepository;
         }



         [HttpPost]
         public async Task<IActionResult> Add(ProductPostRequest addProductRequest)
        {
             // Map view model to domain model
            var product = new Product
            {
                 Name = addProductRequest.Name,
                 Category = addProductRequest.Category,
                 ProductionDate = addProductRequest.ProductionDate
               
             };

        


            await productRepository.AddAsync(product);

            return View(product);
        }





        [HttpGet]
        public async Task<IActionResult> List()
        {
            // Call the repository 
            var product = await productRepository.GetAllAsync();
          //  return RedirectToAction("List", "AdminUsers");


            return View( product);
        }


        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            // Retrieve the result from the repository 
            var products = await productRepository.GetAsync(id);

            if (products != null)
            {
                // map the domain model into the view model
                var model = new EditProductRequest
                {
                    Name = products.Name,
                    Category = products.Category,
                    ProductionDate = products.ProductionDate
                };

                return View(model);

            }

            // pass data to view
            return View(null);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditProductRequest editProductRequest)
        {
            // map view model back to domain model
            var blogPostDomainModel = new Product
            {
                Name = editProductRequest.Name,
                Category = editProductRequest.Category,
                ProductionDate = editProductRequest.ProductionDate
            };

             // Show error notification
             return RedirectToAction("Edit");
        }

         [HttpPost]
         public async Task<IActionResult> Delete(EditProductRequest editProductRequest)
         {
             // Talk to repository to delete this blog post and tags
             var deletedBlogPost = await productRepository.DeleteAsync(editProductRequest.Id);

             if (deletedBlogPost != null)
             {
                 // Show success notification
                 return RedirectToAction("List");
             }

             // Show error notification
             return RedirectToAction("Edit", new { id = editProductRequest.Id });
        }
     }
 }

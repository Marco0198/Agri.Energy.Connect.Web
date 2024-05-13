using Microsoft.AspNetCore.Mvc.Rendering;

namespace Agri.Energy.Connect.Web.Models.ViewModels
{
    public class EditProductRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime ProductionDate { get; set; }
    }
}
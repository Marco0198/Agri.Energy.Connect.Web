using Agri.Energy.Connect.Web.Models.Domain;

namespace Agri.Energy.Connect.Web.Models.ViewModels
{
    public class ProductDetailsViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Categoty { get; set; }
        public DateTime ProductionDate { get; set; }


    }
}

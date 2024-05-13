namespace Agri.Energy.Connect.Web.Models.Domain
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
   
        public DateTime ProductionDate { get; set; }


    }
}

namespace Agri.Energy.Connect.Web.Repositories
{
    public interface IImageRespository
    {
        Task<string> UploadAsync(IFormFile file);
    }
}

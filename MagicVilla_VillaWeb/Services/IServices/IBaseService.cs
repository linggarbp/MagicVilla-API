using MagicVilla_VillaWeb.Models;

namespace MagicVilla_VillaWeb.Services.IServices
{
    public interface IBaseService
    {
        APIResponse responseModel { get; set; }
        Task<T> SendAsync<T>(APIRequest apiRequest);
    }
}

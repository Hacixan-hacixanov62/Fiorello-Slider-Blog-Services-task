using Fiorello_Slider_Blog_Services_task.Models;

namespace Fiorello_Slider_Blog_Services_task.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllAsync();
    }
}

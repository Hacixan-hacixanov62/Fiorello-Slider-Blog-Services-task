using Fiorello_Slider_Blog_Services_task.Data;
using Fiorello_Slider_Blog_Services_task.Models;
using Fiorello_Slider_Blog_Services_task.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Fiorello_Slider_Blog_Services_task.Services
{
    public class CategoryService : ICategoryService
    {

        private readonly AppDbContext _context;
        public CategoryService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}

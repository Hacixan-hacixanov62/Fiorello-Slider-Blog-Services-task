using Fiorello_Slider_Blog_Services_task.Data;
using Fiorello_Slider_Blog_Services_task.Models;
using Fiorello_Slider_Blog_Services_task.Services.Interfaces;
using Fiorello_Slider_Blog_Services_task.ViewModels.Blog;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Fiorello_Slider_Blog_Services_task.Services
{
    public class BlogService : IBlogService
    {
        private readonly AppDbContext _context;
        public BlogService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<BlogVM>> GetAllAsync(int? take= null)
        {
            IEnumerable<Blog> blogs;
            if ( take is null )
            {
               blogs = await _context.Blogs.ToListAsync();
            }
            else
            {
               blogs = await _context.Blogs.Take((int)take).ToListAsync();
            }

            return blogs.Select(m => new BlogVM { Title = m.Title, Description = m.Description, Image = m.Image, CreateDate = m.Createdate.ToString("MM.dd.yyyy") });
        }


    }
}

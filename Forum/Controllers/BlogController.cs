using System;
using System.Threading.Tasks;
using Forum.DAL.Entities;
using Forum.Models.Blog;
using Forum.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Forum.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly UserManager<User> _userManager;

        public BlogController(IBlogService blogService, UserManager<User> userManager)
        {
            _blogService = blogService;
            _userManager = userManager;
        }


        public IActionResult Index(BlogIndexModel model)
        {
            try
            {
                var models = _blogService.GetAllBlogs(model);
                model.Blogs = models;

                return View(model);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message); 
            }
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]

        public async Task<IActionResult> CreateRecord(BlogCreateModel model)
        {
            try
            {
                User currentUser = await _userManager.GetUserAsync(User);

                _blogService.CreateBlog(model, currentUser.Id);

                return RedirectToAction("Index");
            }
            catch(Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    } 
}


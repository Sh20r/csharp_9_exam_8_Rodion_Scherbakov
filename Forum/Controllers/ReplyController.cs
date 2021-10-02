using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forum.DAL.Entities;
using Forum.Models.Reply;
using Forum.Services.Reply.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Forum.Controllers
{
    public class ReplyController : Controller
    {
        private readonly IReplyService _blogService;
        private readonly UserManager<User> _userManager;

        public ReplyController(IReplyService blogService, UserManager<User> userManager)
        {
            _blogService = blogService;
            _userManager = userManager;
        }


        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult CreateReply(ReplyCreateModel model)
        {

            return View();
        }

        public async Task<IActionResult> CreateRecord(ReplyCreateModel model)
        {
            try
            {
                User currentUser = await _userManager.GetUserAsync(User);

                _blogService.CreateReply(model, currentUser.Id);

                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}

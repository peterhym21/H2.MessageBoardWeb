using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using MessageBoardRepository.Entities;
using MessageBoardRepository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MessageBoardWeb.Pages
{
    public class CreateMessageModel : PageModel
    {
        private readonly ICategoryRepository _categoryRepos;
        private readonly IMessagesRepository _messagesRepository;
        private readonly ILogger<CreateMessageModel> _logger;
        public int CategoryId { get; set; }
        public int UserId { get; set; }
        public List<Messages> MessagesList { get; set; }
        public List<Category> Categorys { get; set; }
        public int messageId { get; set; }

        [BindProperty]
        public string Title { get; set; }

        [BindProperty]
        public string Content { get; set; }

        [BindProperty]
        public string Category { get; set; }

        public CreateMessageModel(ICategoryRepository categoryRepos, IMessagesRepository messagesRepository, ILogger<CreateMessageModel> logger)
        {
            _messagesRepository = messagesRepository;
            _categoryRepos = categoryRepos;
            _logger = logger;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            CategoryId = _categoryRepos.CreateCategory(Category);
            if (UserId == 0)
                messageId = _messagesRepository.CreateMessages(Title, Content, CategoryId, 1);
            else
                messageId = _messagesRepository.CreateMessages(Title, Content, CategoryId, UserId);

            return RedirectToPage("Details/DetaileMessages", new { id = messageId });

        }
    }
}

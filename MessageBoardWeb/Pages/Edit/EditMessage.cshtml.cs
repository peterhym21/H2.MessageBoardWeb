using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessageBoardRepository.Entities;
using MessageBoardRepository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MessageBoardWeb.Pages.Edit
{
    public class EditMessageModel : PageModel
    {
        private readonly ICategoryRepository _categoryRepos;
        private readonly IMessagesRepository _messagesRepository;
        private readonly ILogger<EditMessageModel> _logger;
        public EditMessageModel(ICategoryRepository categoryRepos, IMessagesRepository messagesRepository, ILogger<EditMessageModel> logger)
        {
            _messagesRepository = messagesRepository;
            _categoryRepos = categoryRepos;
            _logger = logger;
        }
        [BindProperty]
        public string Title { get; set; }

        [BindProperty]
        public string Content { get; set; }

        [BindProperty]
        public string Category { get; set; }

        public Messages GetMessages { get; set; }

        public Category GetCategory { get; set; }

        public void OnGet(int id)
        {
            GetMessages = _messagesRepository.GetMessage(id);
            

        }



    }
}

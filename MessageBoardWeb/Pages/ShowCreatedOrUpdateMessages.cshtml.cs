using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessageBoardRepository.Entities;
using MessageBoardRepository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MessageBoardWeb.Pages
{
    public class ShowCreatedOrUpdateMessagesModel : PageModel
    {
        private readonly ICategoryRepository _categoryRepos;
        private readonly IMessagesRepository _messagesRepository;
        private readonly ILogger<ShowCreatedOrUpdateMessagesModel> _logger;

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        public Messages Messages { get; set; }
        public List<Category> Categorys { get; set; }


        public ShowCreatedOrUpdateMessagesModel(ICategoryRepository categoryRepos, IMessagesRepository messagesRepository, ILogger<ShowCreatedOrUpdateMessagesModel> logger)
        {
            _messagesRepository = messagesRepository;
            _categoryRepos = categoryRepos;
            _logger = logger;
        }
        public void OnGet()
        {
            Messages = _messagesRepository.GetMessage(Id);
        }
    }
}

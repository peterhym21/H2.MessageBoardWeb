using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessageBoardRepository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MessageBoardWeb.Pages.Delete
{
    public class DeleteUseresModel : PageModel
    {
        private readonly ICategoryRepository _categoryRepos;
        private readonly IMessagesRepository _messagesRepository;
        private readonly ILogger<DeleteUseresModel> _logger;
        public DeleteUseresModel(ICategoryRepository categoryRepos, IMessagesRepository messagesRepository, ILogger<DeleteUseresModel> logger)
        {
            _messagesRepository = messagesRepository;
            _categoryRepos = categoryRepos;
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}

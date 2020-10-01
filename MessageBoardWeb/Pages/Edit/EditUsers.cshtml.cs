using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessageBoardRepository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MessageBoardWeb.Pages.Edit
{
    public class EditUsersModel : PageModel
    {
        private readonly ICategoryRepository _categoryRepos;
        private readonly IMessagesRepository _messagesRepository;
        private readonly ILogger<EditUsersModel> _logger;
        public EditUsersModel(ICategoryRepository categoryRepos, IMessagesRepository messagesRepository, ILogger<EditUsersModel> logger)
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

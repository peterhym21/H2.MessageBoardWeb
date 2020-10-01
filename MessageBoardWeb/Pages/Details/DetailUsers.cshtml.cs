using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessageBoardRepository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MessageBoardWeb.Pages.Details
{
    public class DetailUsersModel : PageModel
    {
        private readonly ICategoryRepository _categoryRepos;
        private readonly IMessagesRepository _messagesRepository;
        private readonly ILogger<DetailUsersModel> _logger;
        public DetailUsersModel(ICategoryRepository categoryRepos, IMessagesRepository messagesRepository, ILogger<DetailUsersModel> logger)
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

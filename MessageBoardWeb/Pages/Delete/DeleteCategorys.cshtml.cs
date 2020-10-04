using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessageBoardRepository.Entities;
using MessageBoardRepository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MessageBoardWeb.Pages.Delete
{
    public class DeleteCategorysModel : PageModel
    {
        private readonly ICategoryRepository _categoryRepos;
        private readonly IMessagesRepository _messagesRepository;
        private readonly ILogger<DeleteCategorysModel> _logger;
        public DeleteCategorysModel(ICategoryRepository categoryRepos, IMessagesRepository messagesRepository, ILogger<DeleteCategorysModel> logger)
        {
            _messagesRepository = messagesRepository;
            _categoryRepos = categoryRepos;
            _logger = logger;
        }

        public Category GetCategory { get; set; }

        public void OnGet(int id)
        {
            GetCategory = _categoryRepos.ReadOneCategories(id);
        }
        public IActionResult OnPost(int id)
        {
            _categoryRepos.DeleteCategory(id);
            return RedirectToPage("../Categorys");
        }
    }
}

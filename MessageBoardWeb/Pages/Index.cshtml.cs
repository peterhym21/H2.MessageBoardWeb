using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessageBoardRepository.Entities;
using MessageBoardRepository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace MessageBoardWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ICategoryRepository _categoryRepos;
        private readonly IMessagesRepository _messagesRepository;
        private readonly ILogger<IndexModel> _logger;

        public SelectList Categories { get; set; }
        public int SelectedCategoryId { get; set; }
        public List<Messages> MessagesList { get; set; }


        public IndexModel(ICategoryRepository categoryRepos, IMessagesRepository messagesRepository, ILogger<IndexModel> logger)
        {
            _messagesRepository = messagesRepository;
            _categoryRepos = categoryRepos;
            _logger = logger;
        }

        public void OnGet()
        {
            Categories = new SelectList(_categoryRepos.ReadCategories(), "CateogryId", "CategoryName");
        }

        public void OnPost(int SelectedCategoryId) 
        {
            MessagesList = _messagesRepository.ReadMessagesByCategory(SelectedCategoryId);
        }
    }
}

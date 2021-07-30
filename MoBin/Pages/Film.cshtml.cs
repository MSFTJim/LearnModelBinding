using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MoBin.Pages
{
    public class FilmModel : PageModel
    {
        private readonly ILogger<FilmModel> _logger;

        public FilmModel(ILogger<FilmModel> logger)
        {
            _logger = logger;
        }
        [BindProperty]
        public int[] CategoryId { get; set; } = new int[0];


        public void OnGet()
        {

        }

        public void OnPost(int[] categoryId)
        {

            ViewData["categoryId"] = categoryId;

        }
    }
}
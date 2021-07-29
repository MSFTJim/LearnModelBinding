using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MoBin.Pages
{
    public class ModelBindingModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public ModelBindingModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public string Email { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {

            var name = Request.Form["Name"];
            var email = Request.Form["Email"];
            ViewData["confirmation"] = $"{name}, information will be sent to {email}";

        }
    }
}
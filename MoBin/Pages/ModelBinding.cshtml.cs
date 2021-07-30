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
        private readonly ILogger<ModelBindingModel> _logger;

        public ModelBindingModel(ILogger<ModelBindingModel> logger)
        {
            _logger = logger;
        }

        public class Login
        {
            public string Email { get; set; }
            public string Password { get; set; }
        }
        [BindProperty]
        public Login login { get; set; }

        // [BindProperty]
        // public string Name { get; set; }
        // [BindProperty]
        // public string Email { get; set; }

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
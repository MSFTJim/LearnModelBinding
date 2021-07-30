using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MoBin.Pages
{
    public class ContactModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public ContactModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public class Contact
        {
            public int ContactId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }

            public Contact()
            {
                //empty constructor
            }

            public Contact(int _ContactId, string _FirstName, string _LastName , string _Email  )
            {
                ContactId = _ContactId;
                FirstName = _FirstName;
                LastName = _LastName;
                Email = _Email;
            }
        }
        [BindProperty]
        public List<Contact> Contacts { get; set; } = new List<Contact>();


        public void OnGet()
        {

            Contacts.Add(new Contact(1,"f1","l1","e1"));
            Contacts.Add(new Contact(2,"f2","l2","e2"));

        }

        public void OnPost()
        {
            int dog = 1;

            dog++;            

        }
    }
}
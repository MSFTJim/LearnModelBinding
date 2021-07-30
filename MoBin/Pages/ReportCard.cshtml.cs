using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MoBin.Pages
{
    public class ReportCardModel : PageModel
    {
        private readonly ILogger<ReportCardModel> _logger;

        public ReportCardModel(ILogger<ReportCardModel> logger)
        {
            _logger = logger;
        }

        public class SSRSReport
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public bool HasParm { get; set; }
            public bool IsHidden { get; set; }
        }

        public class SelectedReport
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public bool HasParm { get; set; }
            public bool IsHidden { get; set; }
            public bool IsSelected { get; set; }

            public SelectedReport()
            {
                //empty constructor
            }

            public SelectedReport(int _Id, string _Name, bool _HasParm, bool _IsHidden, bool _IsSelected)
            {
                Id = _Id;
                Name = _Name;
                HasParm = _HasParm;
                IsHidden = _IsHidden;
                IsSelected = _IsSelected;
            }
        }
        [BindProperty]
        public List<SelectedReport> SelectedReports { get; set; } = new List<SelectedReport>();
        public int ReportCount = 0;

        public void OnGet()
        {

            List<SSRSReport> ServerReports = new();
            ServerReports.Add(new SSRSReport() { Id = 1, Name = "Cases1Nbr", HasParm = true, IsHidden = false });
            ServerReports.Add(new SSRSReport() { Id = 2, Name = "Cases2Nbr", HasParm = true, IsHidden = true });
            ServerReports.Add(new SSRSReport() { Id = 3, Name = "Cases3", HasParm = false, IsHidden = false });
            ServerReports.Add(new SSRSReport() { Id = 4, Name = "Cases4Nbr", HasParm = true, IsHidden = false });

            ReportCount = ServerReports.Count;

            for (int i = 0; i < ReportCount; i++)
            {
                SelectedReports.Add(new SelectedReport( ServerReports[i].Id,
                                                        ServerReports[i].Name,
                                                        ServerReports[i].HasParm,
                                                        ServerReports[i].IsHidden,
                                                        false ));

            }


            // Contacts.Add(new Contact(1, "f1", "l1", "e1"));
            // Contacts.Add(new Contact(2, "f2", "l2", "e2"));

        }

        public IActionResult OnPost()
        {
            int dog = 1;

            dog++;

            return Redirect("/Index");

        }
    }
}
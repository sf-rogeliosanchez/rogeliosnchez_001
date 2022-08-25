using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WA_NOM035_001.Pages
{
    [Authorize]
    public class ResultsModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public ResultsModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            //User.Identity.Name
            
        }
    }
}

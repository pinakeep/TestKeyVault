using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace TestKeyVault.Pages
{
    public class IndexModel : PageModel
    {
        [ViewData]
        public string ConnectionString { get; set; }

        [ViewData]
        public string TestToken { get; set; }

        private readonly IConfiguration _config;

        public IndexModel(IConfiguration config)
        {
            _config = config;
            ConnectionString = _config.GetValue(typeof(string), "connectionString").ToString();
            TestToken = _config.GetValue(typeof(string), "testToken").ToString();
        }

       public void OnGet()
        {

        }
    }
}

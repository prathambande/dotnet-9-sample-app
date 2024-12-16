using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Runtime.InteropServices;

namespace WA9.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public string DotnetRuntimeVersion { get; private set; } = "";
        public void OnGet()
        {
            DotnetRuntimeVersion = RuntimeInformation.FrameworkDescription;

        }

    }
}

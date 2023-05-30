using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoAppService.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        private readonly IConfiguration configuration;
        public string? Saluto { get; set; }
        public string? Saluto2 { get; set; }

        public PrivacyModel(ILogger<PrivacyModel> logger, IConfiguration configuration)
        {
            _logger = logger;
            this.configuration = configuration;
        }

        public void OnGet()
        {
            Saluto = configuration["Saluto"];
            Saluto2 = configuration["Saluto2"];
           // throw new Exception("Errore gravissimo");
        }
    }
}
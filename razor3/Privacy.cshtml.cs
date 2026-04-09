using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }
        public string Mesaj { get; set; }
        public void OnGet()
        {
            Mesaj = "Merhaba, şu an server zamanı: " + DateTime.Now.ToString();

        }
    }

}

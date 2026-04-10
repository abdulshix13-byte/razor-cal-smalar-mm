using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razor2WebApplication2.Pages
{
    public class OdevModel : PageModel
    {
        [BindProperty]
        public int Yas { get; set; }

        public string Mesaj { get; set; }
        public string HataMesaji { get; set; }

        public void OnGet()
        {
            // Sayfa ilk açıldığında yapılacak işlem yok
        }

        public void OnPost()
        {
            if (Yas < 0)
            {
                HataMesaji = "Hata: Yaş 0'dan küçük olamaz!";
                Mesaj = null;
            }
            else if (Yas >= 18)
            {
                Mesaj = "Reşitsiniz";
                HataMesaji = null;
            }
            else
            {
                Mesaj = "Reşit değilsiniz";
                HataMesaji = null;
            }
        }
    }
}
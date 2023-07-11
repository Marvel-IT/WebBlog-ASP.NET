using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebBlog.Pages
{
    public class DruhaModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string Jmeno { get; set; }
        public void OnGet()
        {
            
        }
    }
}

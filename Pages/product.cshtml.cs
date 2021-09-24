
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreCookieAuthentication.Pages
{
    [Authorize(AuthenticationSchemes = "Cookies")]
    public class productModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}

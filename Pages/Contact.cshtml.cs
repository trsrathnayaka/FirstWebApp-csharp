using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyFirstWebApp.Pages
{
    public class ContactModel : PageModel
    {
        public bool hasData = false;
        public String firstname = "";
        public String lastname = "";
        public String message = "";

        public void OnGet()
        {
        }
        public void OnPost() 
        {
            hasData = true;
            firstname = Request.Form["firstname"];
            lastname = Request.Form["lastname"];
            message = Request.Form["message"];
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyFirstWebApp.Pages
{
    public class ContactModel : PageModel
    {
        public bool hasData = false;
        public string? FirstName = "";
        public string? lastName = "";
        public string? message = "";
        public void OnGet()
        {

        }

        public void OnPost()
        {
            hasData = true;
            FirstName = Request.Form["firstname"];
            lastName = Request.Form["lastname"];
            message = Request.Form["message"];
        }
    }
}

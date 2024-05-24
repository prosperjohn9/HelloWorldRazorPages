using HelloWorldRazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloWorldRazorPages.Pages
{
    public class IndexModel : PageModel
    { 
        [BindProperty] public AppMessage Heading{ get; set; }
        public string SubHeading { get; set; }
        public void OnGet()
        { 
            this.Heading = new AppMessage(); 
            this.Heading.Message = "HelloWorld!"; 
        }
        public void OnPost()
        { 
            this.SubHeading = "Message changed."; 
        }
    }
}

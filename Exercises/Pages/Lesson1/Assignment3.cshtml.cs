using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercises.Pages.Lesson1
{
    public class Assignment3 : PageModel
    {
        public int result { get; set; }

        public void OnGet()
        {

        }

        public void OnPostAdd([FromForm] int input, [FromForm] int tussenStop)
        {
            result = tussenStop + input;
        }
        public void OnPostSubtract([FromForm] int input, [FromForm] int tussenStop)
        {
            result = tussenStop - input;
        }
        public void OnPostMultiply([FromForm] int input, [FromForm] int tussenStop)
        {
            result = tussenStop * input;
        }
        public IActionResult OnPostDivide([FromForm] int input, [FromForm] int tussenStop)
        {
            if (input == 0)
            {
               return BadRequest("Divided by 0 ERROR, NOW GO SUCK YOURSELF") ;
               
            }

            result = tussenStop / input;

            return Page();
        }
    }
}

using System;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercises.Pages.Lesson1
{
    public class Assignment1 : PageModel
    {
        
        //bindproperty oplossing
       // [BindProperty(SupportsGet = true)]
     //   public int scoreHome { get; set; }
        
     //   [BindProperty(SupportsGet = true)]
    //    public int scoreAway { get; set; }

    //request.query oplossing
    /* 
    public string ScoreHome { get; set; }
    public string ScoreAway { get; set; }
    
    public int scoreHome { get; set; }
    public int scoreAway { get; set; }
    */
    
    public int scoreHome { get; set; }
    public int scoreAway { get; set; }
    
    public void OnGet([FromQuery] int ScoreHome, [FromQuery] int ScoreAway)
    {
        /* request.query oplossing
        ScoreHome = Request.Query["ScoreHome"];
        ScoreAway = Request.Query["ScoreAway"];
        
        scoreHome = Convert.ToInt32(ScoreHome);
        scoreAway = Convert.ToInt32(ScoreAway);
        */
       
        scoreAway = ScoreAway;
        scoreHome = ScoreHome;
    }
    }
}

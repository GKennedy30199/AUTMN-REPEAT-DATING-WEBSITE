using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;



namespace WebAssForUna.Pages
{
    public class SignupModel : PageModel
    {
        
      

        [BindProperty]
        public string Firstname { get; set; }

        [BindProperty]
        public string Surname { get; set; }

        [BindProperty]
        public string Gender { get; set; }

        [BindProperty]
        public int Height { get; set; }

        [BindProperty]
        public int Birthday { get; set; }

        [BindProperty]
        public int Ppsn { get; set; }

        [BindProperty]
        public string Status { get; set; }

        [BindProperty]
        public string Interests { get; set; }

        [BindProperty]
        public int Phonenum { get; set; }

        [BindProperty]
        public string Email { get; set; }

        public void OnPost()
        {
           
        }



    }
}

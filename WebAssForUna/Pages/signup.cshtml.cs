using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;



namespace WebAssForUna.Pages
{
    public class signupModel : PageModel
    {
        public void OnGet()
        {

        }
        public void OnPost()
        {

        }

        [BindProperty]
        public string firstname { get; set; }
        [BindProperty]
        public string surname { get; set; }
        [BindProperty]
        public string gender { get; set; }
        [BindProperty]
        public int height { get; set; }
        [BindProperty]
        public int birthday { get; set; }
        [BindProperty]
        public int ppsn { get; set; }
        [BindProperty]
        public string status { get; set; }
        [BindProperty]
        public string interests { get; set; }
        [BindProperty]
        public int phonenum { get; set; }
        [BindProperty]
        public string email { get; set; }
         
        

    }
}

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
        
        public void OnPost()
        {
            var Firstname = Request.Form["Firstname"];
            var Surname = Request.Form["Surname"];
            var Gender = Request.Form["Gender"];
            var Height = Request.Form["Height"];
            var Birthday = Request.Form["Birthday"];
            var Ppsn = Request.Form["Ppsn"];
            var Status = Request.Form["Status"];
            var Interests = Request.Form["Interests"];
            var Phonenum = Request.Form["Phonenum"];
            var Email = Request.Form["Email"];
        }

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
         
        

    }
}

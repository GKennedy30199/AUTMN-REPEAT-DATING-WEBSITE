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
        public string Male { get; set; }

        [BindProperty]
        public string Female { get; set; }

        [BindProperty]
        public string Other { get; set; }

        [BindProperty]
        public int Height { get; set; }

        [BindProperty]
        public int Birthday { get; set; }

        [BindProperty]
        public int Ppsn { get; set; }

        [BindProperty]
        public string Status { get; set; }
        [BindProperty]
        public string Single { get; set; }
        [BindProperty]
        public string Taken { get; set; }
        [BindProperty]
        public string Complicated { get; set; }

        [BindProperty]
        public bool Interests { get; set; }
        [BindProperty]
        public bool OutdoorSports { get; set; }
        [BindProperty]
        public bool WatchingSports { get; set; }
        [BindProperty]
        public bool Food { get; set; }
        [BindProperty]
        public bool Pubs { get; set; }
        [BindProperty]
        public bool Cinema { get; set; }
        [BindProperty]
        public bool Theatre { get; set; }
        [BindProperty]
        public bool Music { get; set; }
        [BindProperty]
        public bool Reading { get; set; }
        [BindProperty]
        public bool Boardgames { get; set; }

        [BindProperty]
        public int Phonenum { get; set; }

        [BindProperty]
        public string Email { get; set; }

        public void OnPost()
        {
           
        }



    }
}

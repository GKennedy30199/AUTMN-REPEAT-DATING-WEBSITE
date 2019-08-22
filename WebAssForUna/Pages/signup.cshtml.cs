using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using WebAssForUna.Models;


namespace WebAssForUna.Pages
{
    public class SignupModel : PageModel
    {
        public string Message { get; set; }
        [BindProperty]
        public Signup Signup { get; set; } = new Signup();
        public void OnGet()
        {
            Signup.Firstname = HttpContext.Session.GetString("FirstName");
            Signup.Surname = HttpContext.Session.GetString("Surname");
            Signup.Gender = HttpContext.Session.GetString("Gender");
            Signup.Male = HttpContext.Session.GetString("Male");
            Signup.Female = HttpContext.Session.GetString("Female");
            Signup.Other = HttpContext.Session.GetString("Other");

            Signup.Ppsn = HttpContext.Session.GetString("Ppsn");

            Signup.Status = HttpContext.Session.GetString("Status");
            Signup.Single = HttpContext.Session.GetString("Single");
            Signup.Taken = HttpContext.Session.GetString("Taken");
            Signup.Complicated = HttpContext.Session.GetString("Complicated");
        }
        [Required]
        [BindProperty]
        public string[] InterestNames { get; set; } = { "Outdoor Sports", "Food", "Pubs", "Cinema", "Theatre", "Music", "Reading", "Gaming", "Watching Sports", "Boardgames" };
        [BindProperty]
        public bool[] InterestsChosen { get; set; } = new bool[10];

        [DataType(DataType.PhoneNumber)]
        [BindProperty]
        public int Phonenum { get; set; }
        [DataType(DataType.EmailAddress)]
        [BindProperty]
        public string Email { get; set; } = "";

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                HttpContext.Session.SetString("Firstname", Signup.Firstname);
                HttpContext.Session.SetString("Surname", Signup.Surname);
                HttpContext.Session.SetString("Gender", Signup.Gender);
                HttpContext.Session.SetString("Male", Signup.Male);
                HttpContext.Session.SetString("Female", Signup.Female);
                HttpContext.Session.SetString("Other", Signup.Other);
                HttpContext.Session.SetString("Ppsn", Signup.Ppsn);
                HttpContext.Session.SetString("Status", Signup.Status);
                HttpContext.Session.SetString("Single", Signup.Single);
                HttpContext.Session.SetString("Taken", Signup.Taken);
                HttpContext.Session.SetString("Complicated", Signup.Complicated);
                return RedirectToPage("Confirm");
            }
            else
            {
                return Page();
            }
        }
    







    }
}


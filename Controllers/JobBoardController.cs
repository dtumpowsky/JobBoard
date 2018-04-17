using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using JobBoard.Models;
using System;

namespace JobBoard.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            List<JobOpening> allJobs = JobOpening.GetAll();
            return View(allJobs);
        }

        [HttpGet("/jobs/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/jobs")]
        public ActionResult Create()
        {
          Contact newContact = new Contact(Request.Form["new-job-name"], Request.Form["new-contact-number"], Request.Form["new-contact-email"]);

          JobOpening newJob = new JobOpening(Request.Form["new-job-opening"], Request.Form["new-description"], Int64.Parse(Request.Form["new-salary"]), newContact);
          newJob.Save();

          List<JobOpening> allJobs = JobOpening.GetAll();
          return View("Index", allJobs);
        }
    }
}

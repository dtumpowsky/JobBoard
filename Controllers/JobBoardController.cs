using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CarDealership.Models;

namespace JobBoard.Controllers
{
    public class CarsController : Controller
    {
        [HttpGet("/jobs")]
        public ActionResult Index()
        {
            List<Car> allJobs = Car.GetAll();
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
          Car newCar = new Car(Request.Form["new-model"], int.Parse(Request.Form["new-mile"]), int.Parse(Request.Form["new-price"]), Request.Form["new-color"]);
          newCar.Save();

          List<Car> allJobs = Car.GetAll();
          return View("Index", allJobs);
        }

        [HttpPost("/jobs/delete")]
        public ActionResult DeleteAll()
        {
            Car.ClearAll();
            return View();
        }
    }
}

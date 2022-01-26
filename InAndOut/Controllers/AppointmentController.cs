using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
            //string todaysDate = DateTime.Now.ToShortDateString();
            //return Ok(todaysDate);
        }

        public IActionResult Details(int id)
        {
            //return View();
            //string todaysDate = DateTime.Now.ToShortDateString();
            return Ok($"You have entered details ID: [{id}]");
        }

        [HttpPost]
        public IActionResult Post([FromHeader] string parentRequestId)
        {
            return Ok($"Got a header with parent request id [{parentRequestId}]");
        }



        // -*-*-*-*-*-*-*-*-*-*-*-*-
        const string BITCHES_KEY = "bitches";
        const string TEACHERS_KEY = "teachers";

        // example of an request
        /*
         https://localhost:44308/Appointment/GetSomeData?values=teachers
         */
        public IActionResult GetSomeData([FromQuery]string values)
        {
            string valuesToLower = values.ToLower();

            if (valuesToLower.Contains(BITCHES_KEY))
            {
                return Ok("You have entered BITCHES side of site");
            }else if (valuesToLower.Contains(TEACHERS_KEY))
            {
                return Ok("You have entered TEACHERS side of site");
            }
            else
            {
                return Ok("You have entered DEFAULT side of site");
            }
        }

       // // doesn't work for some reason
       // [Route("Details/Details2/{id?}")]
       // public IActionResult LongAction(int id)
       // {
       //     //return View();
       //     //string todaysDate = DateTime.Now.ToShortDateString();
       //     return Ok($"LongAction side of site [{id}]");
       // }
    }
}

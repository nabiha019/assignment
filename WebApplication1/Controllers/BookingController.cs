using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingController : Controller
    {
            private readonly BookingDbContextcs _bookingDbContextcs;

            public BookingController(BookingDbContextcs bookingDbContextcs)
            {
                _bookingDbContextcs = bookingDbContextcs;
            }

            [HttpGet]
            public IActionResult GetProduct()
            {
                return Ok();
            }

            [HttpPost]
            public IActionResult Putbooking(InfoData datacheck)
            {
                // Save the product to the database
                _bookingDbContextcs.User_Details.Add(datacheck);
                _bookingDbContextcs.SaveChanges();
                return Ok();
            }
        }
    }


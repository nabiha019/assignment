using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

namespace WebApplication1.Model
{
    [Keyless]
    public class InfoData
    {

        public string FullName { get; set; }
        public string LastName { get; set; }
        public string lococation { get; set; }


    }
}

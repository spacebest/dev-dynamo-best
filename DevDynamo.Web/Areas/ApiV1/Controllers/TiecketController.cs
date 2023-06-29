using DevDynamo.Web.Areas.ApiV1.Models;
using DevDynamo.Web.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DevDynamo.Web.Areas.ApiV1.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly AppDb db;

        public TicketController(AppDb db)
        {
            this.db = db;
        }

        [HttpGet("tickets/{ticket_id}/next-status")]
        public ActionResult<IEnumerable<Dictionary<string, string>>> GetNextStatus(int ticket_id)
        {
            var item = db.Tickets.SingleOrDefault(x => x.Id == ticket_id);

            if (item is null)
            {
                return NotFound(new Dictionary<string, string> { { "Status", "Ticket is not found" } });
            }

            var nextStatusResponse = new Dictionary<string, string>
            {
                { item.Status, item.Description }
            };

            return new List<Dictionary<string, string>> { nextStatusResponse };
        }
    }
}

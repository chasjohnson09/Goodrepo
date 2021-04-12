using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrsServer.Data;
using PrsServer.Models;

namespace PrsServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestsController : ControllerBase
    {
        private readonly PrsDbContext _context;

        public RequestsController(PrsDbContext context)
        {
            _context = context;
        }

        




        // PUT: api/Requests/Approve/5
        [HttpPut("Approve/{id}")]
        public async Task<IActionResult> SetRequestToApprove(int id)
        {
            var request = await _context.Request.FindAsync(id);
            if(request == null)
            {
                return NotFound();
            }
            request.Status = "APPROVED";
            return await PutRequest(request.Id, request);
        }

        // PUT: api/Requests/Reject/5
        [HttpPut("Reject/{id}")]
        public async Task<IActionResult> SetRequestToReject(int id, Request request)
        {
            var requestdb = await _context.Request.FindAsync(id);
            if (requestdb == null)
            {
                return NotFound();
            }
            requestdb.Status = "REJECTED";
            requestdb.RejectionReason = request.RejectionReason;
            return await PutRequest(requestdb.Id, requestdb);
        }




        // GET: api/Requests/review
        [HttpGet("review")]
        public async Task<ActionResult<IEnumerable<Request>>> GetReviewOrders()
        {
            return await _context.Request.Include(r => r.User)
                .Where(r => r.Status == "REVIEW").ToListAsync(); 
        }


        // GET: api/Requests
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Request>>> GetRequest()
        {
            return await _context.Request.Include(r => r.User).ToListAsync();
        }

        // GET: api/Requests/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Request>> GetRequest(int id)
        {
            var request = await _context.Request
                .Include(r => r.User)
                .Include(l => l.Requestlines)
                .ThenInclude(r => r.Product)           
                .SingleOrDefaultAsync(r => r.Id == id);

            if (request == null)
            {
                return NotFound();
            }

            return request;
        }

        // PUT: api/Requests/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRequest(int id, Request request)
        {
            if (id != request.Id)
            {
                return BadRequest();
            }

            _context.Entry(request).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RequestExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Requests
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Request>> PostRequest(Request request)
        {
            _context.Request.Add(request);
         //   request.Status = (request.Total <= 50) ? "APPROVED" : "REVIEW";     // this includes the automatic approve and automatically sets status to review
            await _context.SaveChangesAsync();                                  // if it does not qualify for fast approve

            return CreatedAtAction("GetRequest", new { id = request.Id }, request);
        }

        // DELETE: api/Requests/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Request>> DeleteRequest(int id)
        {
            var request = await _context.Request.FindAsync(id);
            if (request == null)
            {
                return NotFound();
            }

            _context.Request.Remove(request);
            await _context.SaveChangesAsync();

            return request;
        }

        private bool RequestExists(int id)
        {
            return _context.Request.Any(e => e.Id == id);
        }
    }
}

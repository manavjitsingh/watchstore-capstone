using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TheHybridWatchStore.Server.Data.DTOs;
using TheHybridWatchStore.Server.Data.Models;
using TheHybridWatchStore.Server.Models;

namespace TheHybridWatchStore.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WatchesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public WatchesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Watches
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Watch>>> GetWatches()
        //{
        //    var watches = await _context.Watches
        //.Include(w => w.Images)  // Include related images
        //.ToListAsync();

        //    var watchDtos = watches.Select(watch => new WatchDto
        //    {
        //        Id = watch.Id,
        //        Name = watch.Name,
        //        Brand = watch.Brand,
        //        Gender = watch.Gender,
        //        Movement = watch.Movement,
        //        Price = watch.Price,
        //        Description = watch.Description,
        //        Features = watch.Features,
        //        ImagePaths = watch.Images.Select(img => img.ImagePath).ToList()  // Map image paths to the DTO
        //    }).ToList();

        //    return Ok(watchDtos);
        //}
        //public async Task<ActionResult<IEnumerable<WatchDto>>> GetWatches(
        //    int pageNumber = 1,
        //    int pageSize = 10,
        //    string sortBy = "Name",
        //    string sortDirection = "asc")
        //{
        //    var query = _context.Watches.Include(w => w.Images).AsQueryable();

        //    // Apply sorting
        //    switch (sortBy)
        //    {
        //        case "Name":
        //            query = sortDirection == "asc" ? query.OrderBy(w => w.Name) : query.OrderByDescending(w => w.Name);
        //            break;
        //        case "PriceLowToHigh":
        //            query = query.OrderBy(w => w.Price); // Always ascending
        //            break;
        //        case "PriceHighToLow":
        //            query = query.OrderByDescending(w => w.Price); // Always descending
        //            break;
        //        default:
        //            query = sortDirection == "asc" ? query.OrderBy(w => w.Name) : query.OrderByDescending(w => w.Name);
        //            break;
        //    }
        //    var totalItems = await query.CountAsync();
        //    // Apply paging

        //    var watches = await query
        //        .Skip((pageNumber - 1) * pageSize)
        //        .Take(pageSize)
        //        .ToListAsync();

        //    var watchDtos = watches.Select(watch => new WatchDto
        //    {
        //        Id = watch.Id,
        //        Name = watch.Name,
        //        Brand = watch.Brand,
        //        Gender = watch.Gender,
        //        Movement = watch.Movement,
        //        Price = watch.Price,
        //        Description = watch.Description,
        //        Features = watch.Features,
        //        ImagePaths = watch.Images.Select(img => img.ImagePath).ToList()
        //    }).ToList();
        //    //Response.Headers.Add("X-Total-Count", totalItems.ToString());
        //    // return Ok(watchDtos);
        //    return Ok(new { totalItems, watchDtos });
        //}
        public async Task<ActionResult<IEnumerable<WatchDto>>> GetWatches(
    int pageNumber = 1,
    int pageSize = 10,
    string sortBy = "Name",
    string sortDirection = "asc")
        {
            try
            {
                var query = _context.Watches.Include(w => w.Images).AsQueryable();

                // Apply sorting
                switch (sortBy)
                {
                    case "Name":
                        query = sortDirection == "asc" ? query.OrderBy(w => w.Name) : query.OrderByDescending(w => w.Name);
                        break;
                    case "PriceLowToHigh":
                        query = query.OrderBy(w => w.Price); // Always ascending
                        break;
                    case "PriceHighToLow":
                        query = query.OrderByDescending(w => w.Price); // Always descending
                        break;
                    default:
                        query = sortDirection == "asc" ? query.OrderBy(w => w.Name) : query.OrderByDescending(w => w.Name);
                        break;
                }

                var totalItems = await query.CountAsync();

                // Apply paging
                var watches = await query
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();

                var watchDtos = watches.Select(watch => new WatchDto
                {
                    Id = watch.Id,
                    Name = watch.Name,
                    Brand = watch.Brand,
                    Gender = watch.Gender,
                    Movement = watch.Movement,
                    Price = watch.Price,
                    Description = watch.Description,
                    Features = watch.Features,
                    ImagePaths = watch.Images.Select(img => img.ImagePath).ToList()
                }).ToList();

                // Return the result along with the total items count
                return Ok(new { totalItems, watchDtos });
            }
            catch (Exception ex)
            {
                // Log the exception (you can use your logging framework here)
                // Return a 500 Internal Server Error response with the exception message
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("Search")]
        public async Task<IActionResult> Search(string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                return BadRequest("Search query cannot be empty.");
            }

            var watches = await _context.Watches
            .Include(w => w.Images)
            .Where(w => w.Name.Contains(query) || w.Brand.Contains(query))
            .Select(w => new WatchDto
            {
                Id = w.Id,
                Name = w.Name,
                Brand = w.Brand,
                Gender = w.Gender,
                Movement = w.Movement,
                Price = w.Price,
                Description = w.Description,
                Features = w.Features,
                ImagePaths = w.Images.Select(img => img.ImagePath).ToList()
            })
            .ToListAsync();

            return Ok(watches);
        }
        // GET: api/Watches/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Watch>> GetWatch(int id)
        {
            var watch = await _context.Watches
        .Include(w => w.Images)  // Include related images
        .Include(w => w.Specs)    // Include related specs (if needed)
        .FirstOrDefaultAsync(w => w.Id == id);

            if (watch == null)
            {
                return NotFound();
            }

            // Map the Watch entity to a WatchDto
            var watchDto = new WatchDto
            {
                Id = watch.Id,
                Name = watch.Name,
                Brand = watch.Brand,
                Gender = watch.Gender,
                Movement = watch.Movement,
                Price = watch.Price,
                Description = watch.Description,
                Features = watch.Features,
                ImagePaths = watch.Images.Select(img => img.ImagePath).ToList()
            };

            return Ok(watchDto);
        }

        // PUT: api/Watches/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWatch(int id, Watch watch)
        {
            if (id != watch.Id)
            {
                return BadRequest();
            }

            _context.Entry(watch).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WatchExists(id))
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

        // POST: api/Watches
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Watch>> PostWatch(Watch watch)
        {
            _context.Watches.Add(watch);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWatch", new { id = watch.Id }, watch);
        }

        // DELETE: api/Watches/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWatch(int id)
        {
            var watch = await _context.Watches.FindAsync(id);
            if (watch == null)
            {
                return NotFound();
            }

            _context.Watches.Remove(watch);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WatchExists(int id)
        {
            return _context.Watches.Any(e => e.Id == id);
        }
    }
}

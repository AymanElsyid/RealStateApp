using Microsoft.AspNetCore.Mvc;
using RealStateApp.Infrastructure;
using RealStateApp.Model;

namespace RealStateApp.Controllers
{
    [ApiController]
    [Route("api/listings")]
    public class ListingsController : ControllerBase
    {
        private readonly IListingRepository _repository;
        public ListingsController(IListingRepository repository)
        {
            _repository = repository;

        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_repository.GetAll());

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var listing = _repository.GetById(id);
            return listing != null ? Ok(listing) : NotFound();
        }

        [HttpPost]
        public IActionResult Create([FromBody] Listing listing)
        {
            var createdListing = _repository.Create(listing);
            return CreatedAtAction(nameof(GetById), new { id = createdListing.Id }, createdListing);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Listing listing)
        {
            return _repository.Update(id, listing) ? NoContent() : NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return _repository.Delete(id) ? NoContent() : NotFound();
        }
    }
}

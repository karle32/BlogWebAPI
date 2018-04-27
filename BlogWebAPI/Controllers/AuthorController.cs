using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlogWebAPI.Services;
using BlogWebAPI.Domain;
using AutoMapper;
using BlogWebAPI.ViewModels;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlogWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class AuthorController : Controller
    {
        private IAuthorRepository _repository;
        private ILogger<AuthorController> _logger;

        public AuthorController(IAuthorRepository repository, ILogger<AuthorController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var authors = _repository.GetAllAuthors();

                var authorsResult = Mapper.Map<IEnumerable<AuthorViewModel>>(authors);
                return Ok(authorsResult);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get get All Post: {ex}");
            }
            return BadRequest("Failed to retrieve authors");
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var author = _repository.GetAuthorById(id);
                if (author != null)
                {
                    var authorResult = Mapper.Map<AuthorViewModel>(author);
                    return Ok(authorResult);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get get All Post: {ex}");
            }
            return NotFound();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

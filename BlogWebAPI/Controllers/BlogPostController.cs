using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlogWebAPI.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using BlogWebAPI.Services;
using BlogWebAPI.ViewModels;
using AutoMapper;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlogWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class BlogPostController : Controller
    {        
        private ILogger<BlogPostController> _logger;
        private IBlogPostRepository _repository;

        public BlogPostController(IBlogPostRepository repository, ILogger<BlogPostController> logger)
        {            
            _logger = logger;
            _repository = repository;

        }

        // GET: api/blogposts
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {                
                var getPostInfo = _repository.GetAllPosts();
                var blogPosts = Mapper.Map<IEnumerable<BlogPostViewModel>>(getPostInfo);
                return Ok(blogPosts);
                //Ok(getPostInfo);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get get All Post: {ex}");
            }
            return BadRequest("Failed to retrieve posts");
        }

        // GET api/blogpost/5
        //[HttpGet("{id}")]
        //public IActionResult GetById(int id)
        //{
        //    try
        //    {
        //        var item = _repository.GetBlogPostById(id);
        //        if (item != null)
        //        {
        //            var blogPost = Mapper.Map<BlogPostViewModel>(item);
        //            return Ok(blogPost);
        //        }                
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError($"Failed to get get All Post: {ex}");
        //    }

        //    return NotFound();
        //}

        // GET api/blogpost/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var item = _repository.GetBlogPostById(id);
                if (item != null)
                {
                    var posts = Mapper.Map<BlogPostViewModel>(item);
                    return Ok(posts);
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

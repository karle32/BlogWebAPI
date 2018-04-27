using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlogWebAPI.Domain;
using BlogWebAPI.Services;
using Microsoft.Extensions.Logging;
using AutoMapper;
using BlogWebAPI.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlogWebAPI.Controllers
{
    [Route("api/titles")]
    public class CategoryController : Controller
    {        
        private ILogger<CategoryController> _logger;
        private ICategoryRepository _repository;

        public CategoryController(ICategoryRepository repository, ILogger<CategoryController> logger)
        {            
            _logger = logger;
            _repository = repository;
        }

        // GET: api/values
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var getAllCategories = _repository.GetAllCategories();
                var categories = Mapper.Map<IEnumerable<CategoryViewModel>>(getAllCategories);
                return Ok(categories);
            }
            catch (Exception ex)
            {

                _logger.LogError($"Failed to save contact: {ex}");
            }

            return BadRequest("Failed to retrieve categories");
        }

        //[HttpGet("{id}")]
        //public IActionResult GetByName(string name)
        //{
        //    try
        //    {
        //        var item = _repository.GetCategory(name);
        //        if (item != null)
        //        {
        //            var category = Mapper.Map<CategoryWithPostViewModel>(item);
        //            return Ok(item);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError($"Failed to get get All Post: {ex}");
        //    }

        //    return NotFound();
        //}

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlogWebAPI.Domain;
using AutoMapper;
using BlogWebAPI.ViewModels;
using Microsoft.Extensions.Logging;
using BlogWebAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlogWebAPI.Controllers
{
    [Route("api/contacts")]
    public class ContactController : Controller
    {           
        private ILogger<ContactController> _logger;
        private IContactRepository _repository;

        public ContactController(IContactRepository repository , ILogger<ContactController> logger)
        {
            _logger = logger;
            _repository = repository;
        }
        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var contactEntities = _repository.GetAllContacts();
                return Ok(contactEntities);
            }
            catch (Exception ex)
            {

                _logger.LogError($"Failed to save contact: {ex}");
            }
            return BadRequest("Failed to retrieve contacts");
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var contact = _repository.GetContactById(id);
                if (contact != null)
                {
                    return Ok(contact);
                }
            }
            catch (Exception ex)
            {

                _logger.LogError($"Failed to save contact: {ex}");
            }

            return BadRequest("Contact not found"); 

        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]ContactViewModel contact)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var newContact = Mapper.Map<Contact>(contact);
                    //newContact.Created = new DateTime();
                    _repository.AddContact(newContact);
                    _repository.SaveContact();
                    return Created($"api/contacts/{contact.FirstName}", Mapper.Map<ContactViewModel>(newContact));
                }
            }
            catch (Exception ex)
            {

                _logger.LogError($"Failed to save contact: {ex}");
            }

            return BadRequest("Failed to save contact");
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

using Datos;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Negocio.Interfaces;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Convocatoria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        IComments _comments;

        public CommentsController(IComments comments)
        {
            _comments = comments;
        }

        // GET: api/<CommentsController>
        [HttpGet]
        public IEnumerable<Comment> Get()
        {
            return _comments.GetComments();
        }

        // GET api/<CommentsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CommentsController>
        [HttpPost]
        public void Post([FromBody] Comment value)
        {
            _comments.setComment(value);
        }

        // PUT api/<CommentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CommentsController>/5
        [HttpDelete("{id}")]
        public async void Delete(Comment id)
        {
            _comments.DeleteComment(id);

        }
    }
    
}

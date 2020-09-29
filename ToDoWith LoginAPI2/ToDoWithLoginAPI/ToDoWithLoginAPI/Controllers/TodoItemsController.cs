using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoWithLoginAPI.Models;

namespace ToDoWithLoginAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemsController : ControllerBase
    {
        private readonly ToDoWithLoginAPIContext _context;

        public TodoItemsController(ToDoWithLoginAPIContext context)
        {
            _context = context;
        }

        // GET: api/TodoItems
        [HttpGet]
        public IEnumerable<TodoItem> GetTodoItems()
        {
            return _context.TodoItems;
        }

        // GET: api/TodoItems/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTodoItem([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var todoItem = await _context.TodoItems.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return Ok(todoItem);
        }

        // PUT: api/TodoItems/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodoItem([FromRoute] int id, [FromBody] TodoItem todoItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != todoItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(todoItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TodoItemExists(id))
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

        // POST: api/TodoItems
        [HttpPost]
        public async Task<IActionResult> PostTodoItem([FromBody] TodoItem todoItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //context.Database.OpenConnection();
            //try
            //{
            //    context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Employees ON");
            //    context.SaveChanges();
            //    context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Employees OFF");
            //}
            //finally
            //{
            //    context.Database.CloseConnection();
            //}

            try
            {
                _context.TodoItems.Add(todoItem);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                var aaa = "aaa";
            }
            finally
            {
                var bbb = "bbb";
            }


            return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
        }

        // DELETE: api/TodoItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoItem([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var todoItem = await _context.TodoItems.FindAsync(id);
            if (todoItem == null)
            {
                return NotFound();
            }

            _context.TodoItems.Remove(todoItem);
            await _context.SaveChangesAsync();

            return Ok(todoItem);
        }

        private bool TodoItemExists(int id)
        {
            return _context.TodoItems.Any(e => e.Id == id);
        }
    }
}
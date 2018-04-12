using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoAPI.ControllerProviders.Interfaces;
using ToDoAPI.DomainModels;

namespace ToDoAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class TodosController : Controller
    {
        private readonly ITodosControllerProvider _todoProvider;

        public TodosController(ITodosControllerProvider todoProvider)
        {
            _todoProvider = todoProvider;
        }

        [HttpGet]
        public IQueryable<Todo> Get()
        {
            try
            { 
            return _todoProvider.GetAllTodos();
            }
            catch (Exception e)
            {
                return Enumerable.Empty<Todo>().AsQueryable(); ;
            }
        }

        [HttpGet("{id}")]
        public async Task<Todo> Get(int id)
        {
            try
            {
                return await _todoProvider.GetTodoById(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        [HttpPost]
        public async Task<Todo> Creates([FromBody]Todo todo)
        {
            try
            {
           return await _todoProvider.AddTodo(todo);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        [HttpPut("{id}")]
        public async Task<Todo> Put([FromBody]Todo todo)
        {
            try
            {
                await _todoProvider.UpdateTodo(todo);
                return todo;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            try
            {
                await _todoProvider.DeleteTodo(id);
            }
            catch (Exception e)
            {
              return; 
            }
           
        }
    }
}
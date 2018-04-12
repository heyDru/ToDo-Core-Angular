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

        //[HttpGet]
        //public string Test()
        //{
        //    return "Ok";
        //}

        [HttpGet]
        public IQueryable<Todo> Get()
        {
            return _todoProvider.GetAllTodos();
        }

        [HttpGet("{id}")]        public async Task<Todo> Get(int id)
        {
            return await _todoProvider.GetTodoById(id);
        }

        [HttpPost]
        public async Task Creates([FromBody]Todo todo)
        {
             await _todoProvider.AddTodo(todo);
        }

        [HttpPut]
        public async Task Update([FromBody]Todo todo)
        {
            await _todoProvider.UpdateTodo(todo);
        }

        [HttpDelete]
        public async Task Delete(int id)
        {
            await _todoProvider.DeleteTodo(id);
        }
    }
}
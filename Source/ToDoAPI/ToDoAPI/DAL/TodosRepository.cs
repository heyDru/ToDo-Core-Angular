using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDoAPI.DAL.Interfaces;
using ToDoAPI.DomainModels;

namespace ToDoAPI.DAL
{
    public class TodosRepository : ITodosRepository
    {
        private readonly TodoContext _db;

        public TodosRepository(TodoContext db)
        {
            _db = db;
        }

        public IQueryable<Todo> GetAll()
        {
            return _db.Todos.AsNoTracking();
        }

        public async Task<Todo> GetById(int id)
        {
            return await _db.Todos.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> Add(Todo entity)
        {
            await _db.Todos.AddAsync(entity);
           return await _db.SaveChangesAsync();
        }

        public async Task Update(Todo todo)
        {
          var updated =  _db.Todos.Update(todo);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var todo = await GetById(id);
            _db.Todos.Remove(todo);
            await _db.SaveChangesAsync();
        }
    }
}

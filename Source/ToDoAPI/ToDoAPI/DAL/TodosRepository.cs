using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoAPI.DomainModels;

namespace ToDoAPI.DAL
{
    public class TodosRepository:GenericRepository<Todo>
    {
        public TodosRepository(TodoContext dbContext) : base(dbContext)
        {
        }
    }
}

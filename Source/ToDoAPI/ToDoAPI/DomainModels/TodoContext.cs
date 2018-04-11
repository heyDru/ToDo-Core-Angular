using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ToDoAPI.DomainModels
{
    public class TodoContext:DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        { }
    }
}

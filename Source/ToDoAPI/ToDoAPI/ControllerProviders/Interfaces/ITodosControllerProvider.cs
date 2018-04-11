using System.Linq;
using System.Threading.Tasks;
using ToDoAPI.DomainModels;

namespace ToDoAPI.ControllerProviders.Interfaces
{
    public interface ITodosControllerProvider
    {
        IQueryable<Todo> GetAllTodos();
        Task<Todo> GetTodoById(int id);
        Task AddTodo(Todo newTodo);
        Task DeleteTodo(int id);
        Task UpdateTodo(Todo todo);
    }
}
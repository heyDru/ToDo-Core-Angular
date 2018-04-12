using System.Linq;
using System.Threading.Tasks;
using ToDoAPI.DomainModels;

namespace ToDoAPI.DAL.Interfaces
{
    public interface ITodosRepository 
    {
        IQueryable<Todo> GetAll();

        Task<Todo> GetById(int id);

        Task<int> Add(Todo entity);

        Task Update(Todo entity);

        Task Delete(int id);
    }

}

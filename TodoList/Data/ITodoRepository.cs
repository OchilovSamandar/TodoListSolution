using TodoList.Models;

namespace TodoList.Data
{
    public interface ITodoRepository
    {
        Task CreateTodo(Todo todo);

        Task DeleteTodo(Todo todo);

        Task<Todo> GetTodoById(int id);

        Task<IEnumerable<Todo>> GetAllTodo();

        Task UpdateTodo(Todo todo);


    }
}

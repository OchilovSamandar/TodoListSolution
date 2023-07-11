using TodoList.Models;

namespace TodoList.Data
{
    public class TodoRepository : ITodoRepository
    {
        private readonly TodoContext _context;

        public TodoRepository(TodoContext context)
        {
            _context = context;
        }
        public async Task CreateTodo(Todo todo)
        {
            if (todo == null) 
                throw new ArgumentNullException(nameof(todo));
            await _context.Todos.AddAsync(todo);
        }

        public Task DeleteTodo(Todo todo)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Todo>> GetAllTodo()
        {
            throw new NotImplementedException();
        }

        public Task<Todo> GetTodoById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTodo(Todo todo)
        {
            throw new NotImplementedException();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDoLib.Models;

namespace TodoApp
{
    public class TodoController
    {
        private readonly AppDbcontext _context;
        public async Task<IEnumerable<Todo>> GetAll()
        {
            return await _context.Todos.Include(x => x.Category).ToListAsync();
        }
        public async Task<IEnumerable<Todo>> GetByPK(int id)
        {
            return await _context.Todos.Include(x => x.Category).ToListAsync();
        }
        public async Task<Todo> Create(Todo todo)
        {
            if (todo == null)
            {
                throw new Exception("Todo cannot be NULL");
            }
            if (todo.Id != 0)
            {
                throw new Exception("Todo ID must be ZERO");
            }
            await _context.Todos.AddAsync(todo);
            var rowsaffected = await _context.SaveChangesAsync();
            if (rowsaffected != 1)
            {
                throw new Exception("Create FAILED!!!");
            }
            return todo;
        }
    }
}
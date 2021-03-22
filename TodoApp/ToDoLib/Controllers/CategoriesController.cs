using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TodoApp;
using ToDoLib.Models;

namespace ToDoLib.Controllers
{
    public class CategoriesController
    {
        private readonly AppDbcontext _context;
        public async Task<IEnumerable<Category>> GetAll()
        {
            return await _context.Categories.ToListAsync();
        }
        public async Task <IEnumerable<Category>> GetbyPK(int id)
        {
            return await _context.Categories.ToListAsync();
        }
        public async Task Change(Todo todo)
        {
            if(todo == null)
            {
                throw new Exception("Todo cannot be NULL");
            }
            if(todo.Id < 0)
            {
                throw new Exception("Id must be greater than ZERO");
            }
            _context.Entry(todo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var rowsaffected = await _context.SaveChangesAsync();
            if(rowsaffected != 1)
            {
                throw new Exception("Change FAILED!!!");
            }
            return;
        }
    }
}

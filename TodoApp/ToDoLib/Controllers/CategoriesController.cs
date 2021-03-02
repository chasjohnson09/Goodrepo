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
    }
}

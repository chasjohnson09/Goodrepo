using EFCodeFirstSoultion.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstSoultion
{
    class ItemController
    {
        private readonly AppDbContext _context;

        public ItemController()
        {
            _context = new AppDbContext();
        }

        public async Task<IEnumerable<Item>> GetAll()
        {
            return await _context.Item.ToListAsync();
        }

        public async Task<Item> GetbyPK(int id)
        {
            return await _context.Item.FindAsync(id);
        }


        public async Task<Item> Create(Item item)
        {
            if (item == null)
            {
                throw new Exception("Order cannot be NULL");
            }
            if (item.Id != 0)
            {
                throw new Exception("Order ID must be ZERO");
            }
            await _context.Item.AddAsync(item);
            var rowsaffected = await _context.SaveChangesAsync();
            if (rowsaffected != 1)
            {
                throw new Exception("Create FAILED!!!");
            }
            return item;
        }

        public async Task Change(Item item)
        {
            if (item == null)
            {
                throw new Exception("Item cannot be NULL");
            }
            if (item.Id < 0)
            {
                throw new Exception("Item ID must be greater then ZERO");
            }
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var rowsaffected = await _context.SaveChangesAsync();
            if (rowsaffected != 1)
            {
                throw new Exception("Change FAILED!!!");
            }
            return;
        }


        public async Task<Item> Remove(int id)
        {
            var item = await _context.Item.FindAsync(id);
            if (item == null)
            {
                throw new Exception("Order ID cannot be NULL");
            }
            _context.Item.Remove(item);
            var rowsaffected = await _context.SaveChangesAsync();
            if (rowsaffected != 1)
            {
                throw new Exception("Remove Failed");
            }
            return item;
        }
    }
}

using EFCodeFirstSoultion.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstSoultion
{
    public class OrderController
    {
        private readonly AppDbContext _context;

        public OrderController()
        {
            _context = new AppDbContext();
        }

        public async Task<IEnumerable<Order>> GetAll()
        {
            return await _context.Orders.ToListAsync();
        }

        public async Task<Order> GetbyPK(int id)
        {
            return await _context.Orders.FindAsync(id);
        }


        public async Task<Order> Create(Order order)
        {
            if(order == null)
            {
                throw new Exception("Order cannot be NULL");
            }
            if(order.Id != 0)
            {
                throw new Exception("Order ID must be ZERO");
            }
            await _context.Orders.AddAsync(order);
            var rowsaffected = await _context.SaveChangesAsync();
            if(rowsaffected != 1)
            {
                throw new Exception("Create FAILED!!!");
            }
            return order;
        }

        public async Task Change(Order order)
        {
            if(order == null)
            {
                throw new Exception("Order cannot be NULL");
            }
            if(order.Id < 0)
            {
                throw new Exception("Order ID must be greater then ZERO");
            }
            _context.Entry(order).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var rowsaffected = await _context.SaveChangesAsync();
            if(rowsaffected != 1)
            {
                throw new Exception("Change FAILED!!!");
            }
            return;
        }


        public async Task<Order> Remove(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            if(order == null)
            {
                throw new Exception("Order ID cannot be NULL");
            }
            _context.Orders.Remove(order);
            var rowsaffected = await _context.SaveChangesAsync();
            if(rowsaffected != 1)
            {
                throw new Exception("Remove Failed");
            }
            return order;
        }



    }
}

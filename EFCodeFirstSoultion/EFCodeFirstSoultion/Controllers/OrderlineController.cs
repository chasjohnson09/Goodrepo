using EFCodeFirstSoultion.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace EFCodeFirstSoultion
{
    class OrderlineController
    {
        private readonly AppDbContext _context;

        public OrderlineController()
        {
            _context = new AppDbContext();
        }

        public async Task<IEnumerable<Orderline>> GetAll()
        {
            return await _context.Orderlines.ToListAsync();
        }

        public async Task<Orderline> GetbyPK(int id)
        {
            return await _context.Orderlines.FindAsync(id);
        }


        //public async Task<Item> Create(Orderline orderline)
        //{
        //    if (orderline == null)
        //    {
        //        throw new Exception("Order cannot be NULL");
        //    }
        //    if (orderline.Id != 0)
        //    {
        //        throw new Exception("Order ID must be ZERO");
        //    }
        //    await _context.Orderlines.AddAsync(orderline);
        //    var rowsaffected = await _context.SaveChangesAsync();
        //    if (rowsaffected != 1)
        //    {
        //        throw new Exception("Create FAILED!!!");
        //    }
        //    return orderline;
        //}

        public async Task Change(Orderline orderline)
        {
            if (orderline == null)
            {
                throw new Exception("Order cannot be NULL");
            }
            if (orderline.Id < 0)
            {
                throw new Exception("Order ID must be greater then ZERO");
            }
            _context.Entry(orderline).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var rowsaffected = await _context.SaveChangesAsync();
            if (rowsaffected != 1)
            {
                throw new Exception("Change FAILED!!!");
            }
            return;
        }


        public async Task<Orderline> Remove(int id)
        {
            var orderline = await _context.Orders.FindAsync(id);
            if (orderline == null)
            {
                throw new Exception("Orderline ID cannot be NULL");
            }
            _context.Orderlines.Remove(orderline);
            var rowsaffected = await _context.SaveChangesAsync();
            if (rowsaffected != 1)
            {
                throw new Exception("Remove Failed");
            }
            return orderline;
        }
    }
}

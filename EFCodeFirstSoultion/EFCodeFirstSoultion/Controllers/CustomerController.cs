using EFCodeFirstSoultion.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstSoultion
{
    public class CustomerController
    {
        private readonly AppDbContext _context;

        public CustomerController()
        {
            _context = new AppDbContext();
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer> GetbyPK(int id)
        {
            return await _context.Customers.FindAsync(id);
        }

        public async Task<Customer> Create(Customer customer)
        {
            if(customer == null)
            {
                throw new Exception("Customer cannot be NULL");
            }
            if(customer.Id != 0)
            {
                throw new Exception("Customer ID MUST be 0");
            }
            await _context.Customers.AddAsync(customer);
            var rowsaffected = await _context.SaveChangesAsync();
            if(rowsaffected != 1)
            {
                throw new Exception("Create failed!!!");
            }
            return customer;
        }


        public async Task Change(Customer customer)
        {
            if(customer == null)
            {
                throw new Exception("Customer cannot be NULL");
            }
            if(customer.Id < 0)
            {
                throw new Exception("Customer ID must be greater than ZERO");
            }
            _context.Entry(customer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var rowsaffected = await _context.SaveChangesAsync();
            if(rowsaffected != 1)
            {
                throw new Exception("Change failed!!");
            }
            return;
        }


        public async Task<Customer> Remove(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return null;
            }
            _context.Customers.Remove(customer);
            var rowsAffected = await _context.SaveChangesAsync();
            if (rowsAffected != 1)
            {
                throw new Exception("Remove Failed!!");
            }
            return customer;
        }



    }
}

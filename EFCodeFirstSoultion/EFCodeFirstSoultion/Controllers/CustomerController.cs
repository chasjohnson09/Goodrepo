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
        }
    }
}

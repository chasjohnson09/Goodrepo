using EntityFrameworkTutorial.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTutorial
{
    public class MajorController
    {
        public eddbContext _context;


        public async Task<IEnumerable<Major>> GettAll()
        {
            return await _context.Majors.ToListAsync();
        }


        public async Task<Major> GetPK(int id)
        {
            return await _context.Majors.FindAsync(id);
        }


        public async Task<Major> Create(Major major)
        {
            if(major.Id != 0)
            {
                throw new Exception("Major must be ZERO");
            }
            _context.Majors.Add(major);
            var rowsAffected = await _context.SaveChangesAsync();
            if( rowsAffected != 1)
            {
                throw new Exception("Create Failed");
            }
            return major;
        }


        public async Task Change(Major major)
        {
            if(major == null)
            {
                throw new Exception("Must enter a Major ID");
            }
            if(major.Id < 0 )
            {
                throw new Exception("Major Id must be greater than ZERO");
            }
            _context.Entry(major).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var rowsAffected = await _context.SaveChangesAsync();
            if(rowsAffected != 1)
            {
                throw new Exception("Change Failed");
            }
            return;
        }


        public async Task<Major> Remove(int id)
        {
            var major = _context.Majors.Find(id);
            if(major == null)
            {
                return null;
            }
            int count = await _context.Students.Where(s => s.MajorId == major.Id).CountAsync();
            _context.Majors.Remove(major);
            var rowsAffected = _context.SaveChanges();
            if(rowsAffected != 1)
            {
                throw new Exception("Remove Failed");
            }
            return major;
        }


        public MajorController()     // default constructor
        {
            _context = new eddbContext();
        }
    }
}

using EntityFrameworkTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFrameworkTutorial
{
    public class MajorController
    {
        public eddbContext _context;
        public IEnumerable<Major> GettAll()
        {
            return _context.Majors.ToList();
        }
        public Major GetPK(int id)
        {
            return _context.Majors.Find(id);
        }
        public Major Create(Major major)
        {
            if(major.Id != 0)
            {
                throw new Exception("Major must be ZERO");
            }
            _context.Majors.Add(major);
            var rowsAffected = _context.SaveChanges();
            if( rowsAffected != 1)
            {
                throw new Exception("Create Failed");
            }
            return major;

        }
        public void Change(Major major)
        {
            if(major.Id < 0 )
            {
                throw new Exception("Major Id must be greater than ZERO");
            }
            _context.Entry(major).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var rowsAffected = _context.SaveChanges();
            if(rowsAffected != 1)
            {
                throw new Exception("Change Failed");
            }
            return;
        }
        public Major Remove(int id)
        {
            var major = _context.Majors.Find(id);
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

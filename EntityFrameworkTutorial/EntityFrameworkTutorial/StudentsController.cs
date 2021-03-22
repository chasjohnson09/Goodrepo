using EntityFrameworkTutorial.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTutorial
{
    public class StudentsController
    {
        private readonly eddbContext _context;


        public StudentsController()     // default constructor
        {
            _context = new eddbContext();
        }


        public async Task<IEnumerable<Student>> GetAll()    // creating the "GetAll" method   -- "async task" is how async method is started 
        {
             return await _context.Students.ToListAsync(); // students is the collection the method is pulling from --  "await" is there to bridge gap for async
        }                                                   // make sure async is put on the end of the list to make sure it is sent in the correct type


        public async Task<Student> GetbyPK(int id)      // creating the "GetbyPK" method -- async task becuase aysnc is infront of task
        {
            return await _context.Students.FindAsync(id);  // "find" only reads a primary key -- await is returned here -- "find" was changed to "FindAsync"
        }                                                                                                                // for the async method


        public async Task<Student> Create(Student student)
        {
            if(student == null)
            {
                throw new Exception("Student Connot be NULL");
            }
            if(student.Id != 0)
            {
                throw new Exception("Student ID must be 0");
            }
            _context.Students.Add(student);
            var rowsAffected = await _context.SaveChangesAsync();   // make sure to check for async versions of the methods!!!!!
            if(rowsAffected != 1)
            {
                throw new Exception("Create Failed");
            }
            return student;
        }
        

        public async Task Change(Student student)
        {
            if(student == null)
            {
                throw new Exception("Student cannot be null");
            }
            if(student.Id < 0)
            {
                throw new Exception("Student.Id must be greater than zero!");
            }
            _context.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Modified; // this is the cache holder for the data from the database
            var rowsAffected = await _context.SaveChangesAsync();                
            if(rowsAffected != 1)
            {
                throw new Exception("Change failed!");
            }
            return;
            
        } 

        public async Task<Student> Remove(int id)
        {
            var student =await _context.Students.FindAsync(id);
            if(student == null)
            {
                return null;
            }
            _context.Students.Remove(student);
            var rowsAffected = await _context.SaveChangesAsync();
            if(rowsAffected != 1)
            {
                throw new Exception("Remove Failed!!");
            }
            return student;
        }

        

        public IEnumerable<Student> GetSATrange(int lowSAT, int highSAT)        //find the stdents who have a sat score between 1000 1200
        {
            return _context.Students.Where(s => s.Sat >= lowSAT && s.Sat <= highSAT).OrderByDescending(s => s.Sat);

            
        }

        public IEnumerable<Student> GetSATrange2(int lowSAT, int highSAT)
        {

            return (from s in _context.Students
                    where s.Sat >= lowSAT && s.Sat <= highSAT
                    orderby s.Sat descending
                    select s).ToList();
        }


    }
}

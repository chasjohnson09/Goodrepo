using EntityFrameworkTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFrameworkTutorial
{
    public class StudentsController
    {
            

        public IEnumerable<Student> GetAll()    // creating the "GetAll" method
        {
             return _context.Students.ToList(); // students is the collection the method is pulling from 
        }

        public Student GetbyPK(int id)      // creating the "GetbyPK" method
        {
            return _context.Students.Find(id);  // "find" only reads a primary key 
        }

        public Student Create(Student student)
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
            var rowsAffected = _context.SaveChanges();
            if(rowsAffected != 1)
            {
                throw new Exception("Create Failed");
            }
            return student;
        }
        
        public void Change(Student student)
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
            var rowsAffected = _context.SaveChanges();                
            if(rowsAffected != 1)
            {
                throw new Exception("Change failed!");
            }
            return;
            
        } 

        public Student Remove(int id)
        {
            var student = _context.Students.Find(id);
            if(student == null)
            {
                return null;
            }
            _context.Students.Remove(student);
            var rowsAffected = _context.SaveChanges();
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


        public StudentsController()     // default constructor
        {
            _context = new eddbContext();
        }
    }
}

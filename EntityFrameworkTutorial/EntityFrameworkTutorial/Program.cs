using EntityFrameworkTutorial.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkTutorial
{
    class Program
    {
        static async Task Main(string[] args)       // make sure async is declared 
        {

            var sctrl = new StudentsController();   //setting a new instance of the studentcontroller
            var students = await sctrl.GetAll();      // calling the get all method that was created in the studentcontroller class -- await is the end of the asyn method
            foreach (var s in students)
            {
                Console.WriteLine($"{s.Firstname} {s.Lastname}");
            }

            Console.WriteLine($" ");

            var st = await sctrl.GetbyPK(1);          // calling on the "Get by PK" method
            Console.WriteLine($"{st.Firstname} {st.Lastname} GETBYPK");

            Console.WriteLine($" ");


            var sGreg = new Student
            {
                Id = 0,
                Firstname = "sGreg",
                Lastname = "Doud",
                StateCode = "OH",
                Gpa = 2.1m,
                Sat = 805,
                MajorId = 1
            };
            var sGregNew = await sctrl.Create(sGreg);   // await was added so the method will run asynchrounously!!
            Console.WriteLine($"{sGreg.Firstname} {sGreg.Lastname} {sGreg.Id} {sGreg.MajorId}");


            var std = await sctrl.GetbyPK(sGregNew.Id);  // method is async so that is why await is in the method statement
            std.Firstname = "Gregory";

            await sctrl.Change(std);

            var studentdeleted = await sctrl.Remove(std.Id);

            st = await sctrl.GetbyPK(67);       // calling on the "Get by PK" method  --  changed to async becuase the "getbyPK" method got changed to async
            if (st == null)                 // if the id is null 
            {
                Console.WriteLine($"Not found");
            }
            else
            {
                Console.WriteLine($"{st.Firstname} {st.Lastname} {st.Id}"); // if there is an id in the mthod than wriet out the name 

            }

            Console.WriteLine($" ");


        }
        static void Run1() { 
            var _context = new eddbContext();           // setting an instance of the database


            var students = _context.Students.ToList();  // setting the student variable 
            foreach(var s in students)
            {
                Console.WriteLine($"{s.Firstname} {s.Lastname} ");
            }

            Console.WriteLine($" ");

            var _context2 = new eddbContext();                  // easier way to do above 
            foreach (var s in _context2.Students.ToList())      // plugging the context straight into the collection
            {
                Console.WriteLine($"{s.Firstname} {s.Lastname} ");
            }

            Console.WriteLine($" ");

            var _context3 = new eddbContext();                  // easiest way to do above 
            _context3.Students.ToList()
                .ForEach(s => Console.WriteLine($"{s.Firstname} {s.Lastname} "));

            Console.WriteLine($"");

            var majors = from m in _context.Majors      // show all the majors that require a minSAT over 1000
                         where m.MinSat > 1000
                         orderby m.Description
                         select m;
            foreach(var m in majors)
            {
                Console.WriteLine($"{m.Description} || {m.MinSat}");
            }

            Console.WriteLine($"");

            // show all student with their majors 
            var allstudents = (from s in _context.Students      // inner join example
                              join m in _context.Majors         //.DefaultIfEmpty()
                              on s.MajorId equals m.Id
                              orderby s.Lastname
                              select new
                              {
                                  Name = s.Firstname + " " + s.Lastname,
                                  Major = s.MajorId == null ? "Undeclared" : m.Description
                              }).ToList();
            foreach(var s in allstudents)
            {
                Console.WriteLine($"{s.Name} | {s.Major}");
            }

            Console.WriteLine($" ");


            var allstudents2 = (from s in _context.Students     // outter join example of above 
                               join m in _context.Majors        // getting all students including ones without a major
                               on s.MajorId equals m.Id into grp    // grp is a short term holding collection to run the code 
                               from mm in grp.DefaultIfEmpty()      // "mm" is the major 
                               select new
                               {
                                   Name = s.Firstname + " " + s.Lastname,
                                   Major = s.MajorId == null ? "Undeclared" : mm.Description    // if there is a major that is null it will change it to "Undeclared"
                               }).ToList();
            foreach (var s in allstudents2)
            {
                Console.WriteLine($"{s.Name} | {s.Major}");
            }


        }
    }
}

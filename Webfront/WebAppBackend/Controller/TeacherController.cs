using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting;
using System.Web;
using System.Web.UI.WebControls;
using WebAppBackend.Linq;

namespace WebAppBackend.Controller
{
    public class TeacherController
    {
        private static string TeacherID;

        public static List<Teacher> getAllTeacher()
        {
            LINQDataContext dc = new LINQDataContext();
            List<Teacher> teachers = (from c in dc.Teachers where c.Active == true select c).ToList();
            return teachers;
        }
        public string saveTeacher(string id, string name, string email, string phoneno, string position, string city, int age, string startdate, string salary, string gender, string myanmar, string english, string mathematics, string chemistry, string physics, string biology)
        {
            try
            {
                LINQDataContext dc = new LINQDataContext();
                Teacher teacher = new Teacher();
                DateTime parseStartDate;
                if(!DateTime.TryParse(startdate, out parseStartDate))
                {
                    return "Invalid Date Format";
                }
                if(String.IsNullOrEmpty(id) )
                {
                    teacher = new Teacher()
                    {
                        TeacherID = Guid.NewGuid().ToString(),
                        Active = true,
                        CreatedOn = DateTime.Now,
                    };
                    dc.Teachers.InsertOnSubmit(teacher);
                }
                else
                {
                    teacher = (from c in dc.Teachers where c.Active == true && c.TeacherID == id select c).FirstOrDefault();
                    if(teacher == null )
                    {
                        throw new Exception("Not found!");
                    }
                }
                teacher.TeacherName = name;
                teacher.Email = email;
                teacher.PhoneNo = phoneno;
                teacher.Position= position;
                teacher.City= city;
                teacher.Age= age;
                teacher.StartDate = parseStartDate;
                teacher.Gender= gender;
                teacher.Salary = int.Parse(salary);
                teacher.Myanmar = bool.Parse(myanmar);
                teacher.English = bool.Parse(english);
                teacher.Mathematics = bool.Parse(mathematics);
                teacher.Chemistry = bool.Parse(chemistry);
                teacher.Physics = bool.Parse(physics);
                teacher.Biology = bool.Parse(biology);
                teacher.Modified = DateTime.Now;

                dc.SubmitChanges();

                return teacher.TeacherID;

            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public static dynamic getTeacher(string id)
        {
            LINQDataContext dc = new LINQDataContext();
            Teacher teacher = (from c in dc.Teachers where c.TeacherID == id select c).FirstOrDefault();
            if(teacher == null)
            {
                throw new Exception("Not found!");
            }
            return teacher;
        }

        public static string deleteTeacher(string id)
        {
            try
            {
                LINQDataContext dc = new LINQDataContext();
                Teacher teacher = (from c in dc.Teachers where c.TeacherID == id select c).FirstOrDefault();
                if(teacher == null)
                {
                    throw new Exception("Not found!");
                }
                teacher.Active = false;
                teacher.Modified = DateTime.Now;
                dc.SubmitChanges();
                return "teacher.TeacherID";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
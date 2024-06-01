using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebAppBackend.Controller;
using WebAppBackend.Linq;

namespace WebAppBackend.WebService
{
    /// <summary>
    /// Summary description for WebServiceTeacher
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebServiceTeacher : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Teacher> getAllTeacher()
        {
            return TeacherController.getAllTeacher();
        }
        [WebMethod]
        public string saveTeacher(string id, string name, string email, string phoneno, string position, string city, int age, string startdate, string salary, string gender, string myanmar, string english, string mathematics, string chemistry, string physics, string biology)
        {
            TeacherController teacherController = new TeacherController();
            return teacherController.saveTeacher(id, name, email, phoneno, position, city, age, startdate, salary, gender, myanmar, english, mathematics, chemistry, physics, biology);
        }
        [WebMethod]
        public dynamic getTeacher(string id)
        {
            return Controller.TeacherController.getTeacher(id);
        }
        [WebMethod]
        public string deleteTeacher(string id)
        {
            return Controller.TeacherController.deleteTeacher(id);
        }
    }
}

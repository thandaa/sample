using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Webfront
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            RouteTable.Routes.MapPageRoute("home", "home", "~/UserInterface/Home/HomeView/HomeView1.aspx");
            RouteTable.Routes.MapPageRoute("login", "login", "~/UserInterface/Home/LoginView/LoginView.aspx");
            RouteTable.Routes.MapPageRoute("activities", "activities", "~/UserInterface/Home/OurActivitiesView/OurActiviesView.aspx");
            RouteTable.Routes.MapPageRoute("students", "students", "~/UserInterface/StudentView/StudentView.aspx");
            RouteTable.Routes.MapPageRoute("register", "register", "~/UserInterface/RegisterView/RegisterView.aspx");
            RouteTable.Routes.MapPageRoute("dashboard", "dashboard", "~/UserInterface/Dashboard/dashboard.aspx");
            RouteTable.Routes.MapPageRoute("teacher", "teacher", "~/UserInterface/Home/TeachersView/TeacherView.aspx");
            RouteTable.Routes.MapPageRoute("teacherlist", "teacherlist", "~/UserInterface/Dashboard/RegisterTeacher/TeacherList.aspx");
            RouteTable.Routes.MapPageRoute("teacherdetail", "teacherdetail", "~/UserInterface/Dashboard/RegisterTeacher/TeacherDetail.aspx");



        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}
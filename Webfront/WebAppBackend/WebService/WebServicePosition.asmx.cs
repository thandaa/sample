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
    /// Summary description for WebServicePosition
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebServicePosition : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Position> getAllPosition()
        {
            return Controller.PositionController.getAllPosition();
        }

        [WebMethod]
        public string SavePosition(string id , string positionname)
        {
            return Controller.PositionController.SavePosition(id,positionname);
        }

        [WebMethod]
        public string DeletePosition(string id)
        {
            return PositionController.DeletePosition(id);
        }
    }
}

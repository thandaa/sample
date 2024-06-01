using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI.WebControls;
using WebAppBackend.Linq;

namespace WebAppBackend.WebService
{
    /// <summary>
    /// Summary description for WebServiceCity
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebServiceCity : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Table_City> getAllCity()
        {
            return Controller.ConteollerCity.getAllCity();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppBackend.Linq;

namespace WebAppBackend.Controller
{
    public class ConteollerCity
    {
        public static List<Table_City> getAllCity()
        {
            LINQDataContext dc = new LINQDataContext();
            List<Table_City> city = (from c in dc.Table_Cities where c.Active == true select c).ToList();
            return city;
        }
    }
}
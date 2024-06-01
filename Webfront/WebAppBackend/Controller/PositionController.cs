using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI.WebControls;
using WebAppBackend.Linq;

namespace WebAppBackend.Controller
{
    public class PositionController
    {
        public static List<Position> getAllPosition()
        {
            LINQDataContext dc = new LINQDataContext();
            List<Position> positions = (from c in dc.Positions where c.Active== true select c).ToList();
            return positions;
        }

        public static string SavePosition(string id, string positionname)
        {
            try
            {
                LINQDataContext dc = new LINQDataContext();
                Position record = new Position();
                if (string.IsNullOrEmpty(id))
                {
                    record.PositionID = Guid.NewGuid().ToString();
                    record.PositionName = positionname; // Set the position name
                    record.CreatedOn = DateTime.Now;
                    record.Active = true;
                    dc.Positions.InsertOnSubmit(record);
                }
                else
                {
                    record = (from c in dc.Positions where c.Active == true && c.PositionID == id select c).FirstOrDefault();
                    if (record == null)
                    {
                        throw new Exception("Not Found!");
                    }
                    record.PositionName = positionname;
                    record.CreatedOn = DateTime.Now;
                }

                dc.SubmitChanges();
                return "Save Success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public static string DeletePosition(string id)
        {
            try
            {
                using (LINQDataContext dc = new LINQDataContext())
                {
                    Position record = (from c in dc.Positions where c.PositionID.ToString() == id select c).FirstOrDefault();
                    if (record == null)
                    {
                        return "Not Found!";
                    }
                    record.Active = false;
                    record.Modified = DateTime.Now;
                    dc.SubmitChanges();
                    return "Success Delete";
                }
            }
            catch (Exception ex) { 

                return $"Error: {ex.Message}";
            }
        }
    }
}
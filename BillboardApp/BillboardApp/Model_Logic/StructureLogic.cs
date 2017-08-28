using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Web;

namespace BillboardApp.Model_Logic
{
    public class StructureLogic
    {
        public DbGeometry computedLocation(Nullable<double> lon, Nullable<double> lat)
        {
            DbGeometry dbGeometry = null;
            try
            {
                if (lon != null && lat !=null)
                {
                    dbGeometry = DbGeometry.FromText("POINT(" + lon + " " + lat + ")", 4326);
                }
            }
            catch (Exception e)
            {
                
                throw e;
            }            
            return dbGeometry;
        }

    }
}
using BillboardApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BillboardApp.DAL
{
    public class BillboardInitializer : System.Data.Entity.DropCreateDatabaseAlways<BillboardContext>
    {
        protected override void Seed(BillboardContext context)
        {
            //Industry
            /*
            var industrys = new List<Industry>
                {
                    new Industry{Name="Telecommunications"},
                    new Industry{Name="Transport"},
                    new Industry{Name="Manufacturing"},
                    new Industry{Name="Environment & Conservation"},
                    new Industry{Name="Food and Beverage"},
                    new Industry{Name="Agriculture"}
                };
            industrys.ForEach(s => context.Industrys.Add(s));
            context.SaveChanges();

*/
            base.Seed(context);
        }

        public void _ForceSeed(BillboardContext context)
        {
            Seed(context);
        }
    }
}
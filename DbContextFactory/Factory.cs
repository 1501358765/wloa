using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DbContextFactory
{
    public class Factory
    {
        public static DbContext GetDbContext()
        {
            DbContext db = (DbContext)CallContext.GetData("db");
            if (db == null)
            {
                db = new BaseDbContext.BaseDbContext();
                CallContext.SetData("db", db);
            }
            return db;
        }
    }
}

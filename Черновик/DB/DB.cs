using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Черновик
{
    public static class DB
    {
        static DBEntities db;

        public static DBEntities Get()
        {
            if (db == null)
                db = new DBEntities();
            return db;
        }
    }
}

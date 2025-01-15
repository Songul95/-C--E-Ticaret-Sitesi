using Layer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Business
{
    public abstract class IDatabaseIslemleri
    {
        public abstract DbShopEntities Context { get; set; }
        public IDatabaseIslemleri()
        {
            Context = new DbShopEntities();
        }
        public void ConnectDb()
        {
            if (Context != null)
            {
                if (Context.Database.Connection.State == System.Data.ConnectionState.Closed)
                    Context.Database.Connection.Open();
            }
        }
        public void DisconnectDb()
        {
            if (Context != null)
            {
                if (Context.Database.Connection.State == System.Data.ConnectionState.Open)
                    Context.Database.Connection.Close();
            }
        }
    }

}


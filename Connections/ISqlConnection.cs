using System;
using SQLite;
using System.Collections.Generic;

namespace hundredDaysOf.Connections
{
    public class ISqlConnection
    {
        

        public interface IsqlConnection
        {
            SQLiteAsyncConnection connection();
        }

        public ISqlConnection()
        {
            //constructor?
        }
    }
}

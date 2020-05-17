using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Foundation;
using hundredDaysOf;

using SQLite;
using UIKit;
using hundredDaysOf.Connections.ISqlConnection;
using static hundredDaysOf.Connections.ISqlConnection;

[assembly: Dependency(typeof(SQLConnection))]
namespace hundredDaysOf
{
    
      public class SqlConnection : IsqlConnection
        {
            public SQLiteAsyncConnection Connection()
            {
                var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                var path = Path.Combine(documentsPath, "MySQLite.sqldb");

                return new SQLiteAsyncConnection(path);
            }
        }
    }

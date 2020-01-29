using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigration = new DbMigrator(new FileLogger("E:\\Projects\\Learning\\C#Fundamentals\\Extensibility\\log.txt"));
            dbMigration.Migrate();
        }
    }
}
